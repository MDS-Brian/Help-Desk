Imports Microsoft.Data.SqlClient

''' <summary>
''' Find, edit, close and re-open help desk tickets (frmHelpDesk in Access).
''' </summary>
Public Class TicketEditForm

    Private Const Caption As String = "Help Desk"

    Private _loading As Boolean
    ''' <summary>False until Load finishes; InitializeComponent raises CheckedChanged before then.</summary>
    Private _ready As Boolean
    Private _dirty As Boolean
    Private _current As TicketDetail
    Private _allUsers As DataTable

#Region "Load"

    Private Sub TicketEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _loading = True
        Try
            Cursor = Cursors.WaitCursor
            CurrentUser.Check()

            _allUsers = Lookups.HelpDeskUsers()
            Bind(cboRequestBy, _allUsers.Copy())
            Bind(cboAddContact, _allUsers.Copy())
            Bind(cboAssignedTo, Lookups.AssignableUsers())
            Bind(cboStatus, Lookups.Category("Status"))
            Bind(cboSoftware, Lookups.Category("Software"))
            Bind(cboTier, Lookups.Category("Tier"))
            Bind(cboResolution, Lookups.Category("Resolution"))
            Dim priorities = Lookups.Category("Priority")
            Bind(cboPriority, priorities)
            Bind(cboFilterPriority, priorities.Copy())

            Dim accounts = Lookups.AllAccounts()
            Bind(cboAccount, accounts)
            Bind(cboFilterAccount, Lookups.AccountsWithTickets(accounts))
            Bind(cboFilterUser, Lookups.TicketRequesters())
        Catch ex As SqlException
            MessageBox.Show("Could not load the help desk lists from SQL Server." & vbCrLf & vbCrLf & ex.Message,
                            Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            BeginInvoke(Sub() Close())
            Return
        Finally
            Cursor = Cursors.Default
            _loading = False
        End Try

        TrackChanges(grpTicket)
        _ready = True
        RefreshList()
        txtQuickFind.Focus()
    End Sub

    ''' <summary>Marks the ticket as changed when any field in the ticket panel is edited.</summary>
    Private Sub TrackChanges(parent As Control)
        For Each c As Control In parent.Controls
            If TypeOf c Is TextBox Then
                AddHandler c.TextChanged, AddressOf Field_Changed
            ElseIf TypeOf c Is ComboBox Then
                AddHandler DirectCast(c, ComboBox).SelectedIndexChanged, AddressOf Field_Changed
                AddHandler c.TextChanged, AddressOf Field_Changed
            ElseIf TypeOf c Is DateTimePicker Then
                AddHandler DirectCast(c, DateTimePicker).ValueChanged, AddressOf Field_Changed
            End If
        Next
    End Sub

    Private Sub Field_Changed(sender As Object, e As EventArgs)
        If Not _loading AndAlso _current IsNot Nothing Then _dirty = True
    End Sub

#End Region

#Region "Ticket list"

    Private Sub RefreshList()
        Dim f As New TicketFilter With {
            .Status = If(optOpen.Checked, TicketFilter.StatusFilter.Open,
                      If(optClosed.Checked, TicketFilter.StatusFilter.Closed, TicketFilter.StatusFilter.All)),
            .Assigned = If(optAssigned.Checked, TicketFilter.AssignedFilter.Assigned,
                        If(optNotAssigned.Checked, TicketFilter.AssignedFilter.NotAssigned, TicketFilter.AssignedFilter.Any)),
            .AccountNo = SelectedText(cboFilterAccount),
            .RequestBy = SelectedInt(cboFilterUser),
            .Priority = SelectedInt(cboFilterPriority),
            .TicketStartsWith = NullIfBlank(txtQuickFind.Text)
        }

        Try
            Cursor = Cursors.WaitCursor
            dgvTickets.DataSource = TicketEdits.Search(f)
            FormatGrid()
            lblCount.Text = $"{dgvTickets.Rows.Count} shown · {TicketEdits.OpenCount()} open"
        Catch ex As SqlException
            MessageBox.Show("Could not load the ticket list." & vbCrLf & vbCrLf & ex.Message,
                            Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try

        If _current IsNot Nothing Then SelectGridRow(_current.ID)
    End Sub

    Private Sub FormatGrid()
        SetColumn("ID", "Ticket", 60)
        SetColumn("RequestedBy", "Entered By", 130)
        SetColumn("AccountNo", "Acct", 55)
        SetColumn("Description", "Description", 380)
        SetColumn("Priority", "Priority", 150)
        SetColumn("RequestDate", "Entered", 90, "d")
        SetColumn("NeedBy", "Due", 90, "d")
        SetColumn("AssignedTo", "Assigned To", 110)
        SetColumn("CloseDate", "Close Date", 90, "d")
        dgvTickets.Columns("Description").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub SetColumn(name As String, header As String, width As Integer, Optional format As String = Nothing)
        Dim col = dgvTickets.Columns(name)
        If col Is Nothing Then Return
        col.HeaderText = header
        col.Width = width
        If format IsNot Nothing Then col.DefaultCellStyle.Format = format
    End Sub

    Private Sub SelectGridRow(ticketId As Integer)
        For Each row As DataGridViewRow In dgvTickets.Rows
            If CInt(row.Cells("ID").Value) = ticketId Then
                row.Selected = True
                dgvTickets.CurrentCell = row.Cells("ID")
                Return
            End If
        Next
    End Sub

    Private Sub Filter_Changed(sender As Object, e As EventArgs) Handles optOpen.CheckedChanged, optClosed.CheckedChanged, optAll.CheckedChanged,
                                                                          optAnyAssigned.CheckedChanged, optAssigned.CheckedChanged, optNotAssigned.CheckedChanged
        If Not _ready OrElse _loading OrElse Not DirectCast(sender, RadioButton).Checked Then Return
        RefreshList()
    End Sub

    Private Sub FilterCombo_Changed(sender As Object, e As EventArgs) Handles cboFilterAccount.SelectionChangeCommitted, cboFilterUser.SelectionChangeCommitted, cboFilterPriority.SelectionChangeCommitted
        RefreshList()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        RefreshList()
        ' A full ticket number opens that ticket straight away.
        If dgvTickets.Rows.Count = 1 Then OpenTicket(CInt(dgvTickets.Rows(0).Cells("ID").Value))
    End Sub

    Private Sub cmdClearFilter_Click(sender As Object, e As EventArgs) Handles cmdClearFilter.Click
        ClearFilters()
        RefreshList()
    End Sub

    Private Sub ClearFilters()
        cboFilterAccount.SelectedIndex = -1
        cboFilterUser.SelectedIndex = -1
        cboFilterPriority.SelectedIndex = -1
        txtQuickFind.Clear()
    End Sub

    Private Sub dgvTickets_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTickets.CellDoubleClick
        If e.RowIndex < 0 Then Return
        OpenTicket(CInt(dgvTickets.Rows(e.RowIndex).Cells("ID").Value))
    End Sub

    Private Sub dgvTickets_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvTickets.KeyDown
        If e.KeyCode = Keys.Enter AndAlso dgvTickets.CurrentRow IsNot Nothing Then
            e.Handled = True
            OpenTicket(CInt(dgvTickets.CurrentRow.Cells("ID").Value))
        End If
    End Sub

#End Region

#Region "Ticket details"

    Private Sub OpenTicket(ticketId As Integer)
        If Not ConfirmDiscard() Then Return

        Dim t As TicketDetail
        Try
            t = TicketEdits.Load(ticketId)
        Catch ex As SqlException
            MessageBox.Show("Could not load the ticket." & vbCrLf & vbCrLf & ex.Message,
                            Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        If t Is Nothing Then
            MessageBox.Show($"Ticket {ticketId} was not found.", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        _loading = True
        _current = t
        txtTicketNo.Text = t.ID.ToString()
        SelectValue(cboAccount, t.AccountNo)
        SelectValue(cboRequestBy, t.RequestBy, UserName(t.RequestBy))
        SelectValue(cboAddContact, t.AdditionalContact, UserName(t.AdditionalContact))
        SelectValue(cboAssignedTo, t.AssignedTo, UserName(t.AssignedTo))
        SelectValue(cboStatus, t.Status, $"(status {t.Status})")
        SelectValue(cboPriority, t.Priority, $"(priority {t.Priority})")
        SelectValue(cboSoftware, t.Software, $"(software {t.Software})")
        SelectValue(cboTier, t.AssignedTier, $"(tier {t.AssignedTier})")
        SelectValue(cboResolution, t.ResolutionType, $"(resolution {t.ResolutionType})")

        dtpRequestDate.ShowCheckBox = Not t.RequestDate.HasValue
        SetDate(dtpRequestDate, t.RequestDate)
        SetDate(dtpNeedBy, t.RequestedByDate)
        SetDate(dtpAutoClose, t.AutoCloseDate)
        txtCloseDate.Text = If(t.CloseDate.HasValue, t.CloseDate.Value.ToString("g"), "")

        txtCadenceID.Text = t.CadenceID
        txtOrderNbr.Text = If(t.OrderNumber, LookupOrderNumber(t.CadenceID))
        txtPC_Nbr.Text = t.ComputerNumber
        txtDescription.Text = t.Description
        txtNotes.Text = t.Notes

        cmdCloseTicket.Text = If(t.CloseDate.HasValue, "Re-Open Ticket", "Close Ticket")
        ' Send the assignment email by default only when the ticket is not assigned yet.
        chkNotifyUpdates.Checked = Not t.AssignedTo.HasValue
        grpTicket.Text = $"Ticket {t.ID}"
        grpTicket.Enabled = True
        cmdUpdateTicket.Enabled = True
        cmdCloseTicket.Enabled = True
        _loading = False
        _dirty = False
        cboAccount.Focus()
    End Sub

    Private Sub ClearTicket()
        _loading = True
        _current = Nothing
        For Each c As Control In grpTicket.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            ElseIf TypeOf c Is ComboBox Then
                DirectCast(c, ComboBox).SelectedIndex = -1
                c.Text = ""
            End If
        Next
        dtpRequestDate.ShowCheckBox = False
        dtpNeedBy.Checked = False
        dtpAutoClose.Checked = False
        cmdCloseTicket.Text = "Close Ticket"
        grpTicket.Text = "Ticket (double-click a ticket above to open it)"
        grpTicket.Enabled = False
        cmdUpdateTicket.Enabled = False
        cmdCloseTicket.Enabled = False
        _loading = False
        _dirty = False
    End Sub

    ''' <summary>Builds the ticket from the fields, keeping the key and row version of the loaded ticket.</summary>
    Private Function GatherTicket() As TicketDetail
        Return New TicketDetail With {
            .UniqueKey = _current.UniqueKey,
            .ID = _current.ID,
            .RowVersion = _current.RowVersion,
            .CloseDate = _current.CloseDate,
            .AccountNo = If(SelectedText(cboAccount), NullIfBlank(cboAccount.Text)),
            .RequestBy = SelectedInt(cboRequestBy),
            .AdditionalContact = SelectedInt(cboAddContact),
            .AssignedTo = SelectedInt(cboAssignedTo),
            .Status = SelectedInt(cboStatus),
            .Priority = SelectedInt(cboPriority),
            .Software = SelectedInt(cboSoftware),
            .AssignedTier = SelectedInt(cboTier),
            .ResolutionType = SelectedInt(cboResolution),
            .RequestDate = GetDate(dtpRequestDate),
            .RequestedByDate = GetDate(dtpNeedBy),
            .AutoCloseDate = If(dtpAutoClose.Checked, dtpAutoClose.Value.Date, CType(Nothing, Date?)),
            .CadenceID = NullIfBlank(txtCadenceID.Text),
            .OrderNumber = NullIfBlank(txtOrderNbr.Text),
            .ComputerNumber = NullIfBlank(txtPC_Nbr.Text),
            .Description = NullIfBlank(txtDescription.Text),
            .Notes = NullIfBlank(txtNotes.Text)
        }
    End Function

    Private Sub cboPriority_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboPriority.SelectionChangeCommitted
        Dim priority = SelectedInt(cboPriority)
        Dim requested = GetDate(dtpRequestDate)
        If Not priority.HasValue OrElse Not requested.HasValue Then Return
        Try
            SetDate(dtpNeedBy, DueDateFromRequest(priority.Value, requested.Value))
        Catch ex As SqlException
            ' The due date is a convenience; leave it unchanged if the calendar is unavailable.
        End Try
    End Sub

    ''' <summary>
    ''' Due date for a priority, counted from the request date. Priorities 1-7 are the old
    ''' Access ones (txtPriority_Click); 10 and up use the Add Ticket rules.
    ''' </summary>
    Private Shared Function DueDateFromRequest(priority As Integer, requested As Date) As Date
        Select Case priority
            Case 1 : Return requested.AddHours(1)
            Case 2 : Return requested.AddHours(4)
            Case 3 : Return requested.AddHours(24)
            Case 4 : Return requested.AddDays(3)
            Case 5 : Return requested.AddDays(7)
            Case 6 : Return requested.AddDays(14)
            Case 7 : Return requested.AddMonths(1)
            Case Else : Return WorkCalendar.DueDateForPriority(priority, requested)
        End Select
    End Function

    Private Sub cboAssignedTo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboAssignedTo.SelectionChangeCommitted
        If _current Is Nothing Then Return
        Dim assigned = SelectedInt(cboAssignedTo)
        If assigned.HasValue AndAlso Not Nullable.Equals(assigned, _current.AssignedTo) Then chkNotifyUpdates.Checked = True
    End Sub

    Private Sub dtpAutoClose_ValueChanged(sender As Object, e As EventArgs) Handles dtpAutoClose.ValueChanged
        ' Ticking the box defaults the auto close date to one month out, as in Access.
        If _loading OrElse Not dtpAutoClose.Checked OrElse _current Is Nothing Then Return
        If Not _current.AutoCloseDate.HasValue AndAlso dtpAutoClose.Value.Date = Date.Today Then
            dtpAutoClose.Value = Date.Today.AddMonths(1)
        End If
    End Sub

    Private Sub cmdCadenceStatus_Click(sender As Object, e As EventArgs) Handles cmdCadenceStatus.Click
        Dim cadenceId = NullIfBlank(txtCadenceID.Text)
        If cadenceId Is Nothing OrElse cadenceId = "NA" Then
            MessageBox.Show("Enter a Cadence ID first.", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Try
            Dim status = TicketEdits.CadenceOrderStatus(cadenceId)
            MessageBox.Show(If(status Is Nothing, $"Cadence order {cadenceId} was not found.", $"This order is in a {status} status"),
                            Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As SqlException
            MessageBox.Show("Could not look up the order status." & vbCrLf & vbCrLf & ex.Message,
                            Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

#End Region

#Region "Update / close / re-open"

    Private Sub cmdUpdateTicket_Click(sender As Object, e As EventArgs) Handles cmdUpdateTicket.Click
        If _current Is Nothing Then Return
        Dim t = GatherTicket()
        If Not SaveWith(Sub() TicketEdits.Save(t)) Then Return

        If chkNotifyUpdates.Checked AndAlso t.AssignedTo.HasValue Then
            Dim needBy = If(t.RequestedByDate.HasValue, t.RequestedByDate.Value.ToString("g"), "")
            SendNotice($"Help desk ticket {t.ID} has been assigned",
                       $"Help desk ticket {t.ID} is one step closer to be completed." & vbCrLf & vbCrLf &
                       $"It has been assigned to {cboAssignedTo.Text}." & vbCrLf & vbCrLf &
                       "The assigned person will complete the ticket, or will contact you if more information is required." & vbCrLf & vbCrLf &
                       "Description:" & vbCrLf & t.Description & vbCrLf & vbCrLf &
                       $"Needed By Date: {needBy}")
        End If

        FinishAction(reopenId:=Nothing)
    End Sub

    Private Sub cmdCloseTicket_Click(sender As Object, e As EventArgs) Handles cmdCloseTicket.Click
        If _current Is Nothing Then Return

        If _current.CloseDate.HasValue Then
            If MessageBox.Show($"Do you want to re-open ticket {_current.ID}?", Caption,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            Dim reopen = _current
            If Not SaveWith(Sub() TicketEdits.Reopen(reopen)) Then Return
            FinishAction(reopenId:=reopen.ID)
            Return
        End If

        If MessageBox.Show("Do you want to close the ticket?", Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        If Not SelectedInt(cboAssignedTo).HasValue Then
            MessageBox.Show("The HD ticket has not been assigned to a user yet", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboAssignedTo.Focus()
            Return
        End If
        If Not SelectedInt(cboResolution).HasValue Then
            MessageBox.Show("A resolution is required to complete this ticket", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboResolution.Focus()
            Return
        End If

        Dim t = GatherTicket()
        If Not SaveWith(Sub() TicketEdits.Close(t)) Then Return

        If chkNotifyClose.Checked Then
            SendNotice("Your help desk ticket is complete",
                       $"Help desk ticket {t.ID} has been completed and closed." & vbCrLf & vbCrLf &
                       $"Description: {t.Description}" & vbCrLf & vbCrLf &
                       $"Resolution: {cboResolution.Text}" & vbCrLf & vbCrLf &
                       $"Notes: {t.Notes}")
        End If

        FinishAction(reopenId:=Nothing)
    End Sub

    ''' <summary>Runs a save and reports failures. Returns True when it worked.</summary>
    Private Function SaveWith(action As Action) As Boolean
        Try
            Cursor = Cursors.WaitCursor
            action()
            Return True
        Catch ex As TicketChangedException
            MessageBox.Show(ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As SqlException
            MessageBox.Show("The ticket was not saved." & vbCrLf & vbCrLf & ex.Message,
                            Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
        Return False
    End Function

    ''' <summary>Emails the requester, copying the additional contact and IT support.</summary>
    Private Sub SendNotice(subject As String, body As String)
        Dim requester = SelectedEmail(cboRequestBy)
        Dim cc = New List(Of String)
        Dim contact = SelectedEmail(cboAddContact)
        If contact IsNot Nothing Then cc.Add(contact)
        cc.Add(AppConfig.SupportEmail)
        Try
            DatabaseMail.Send(If(requester, AppConfig.SupportEmail), String.Join(";", cc), subject, body)
        Catch ex As SqlException
            MessageBox.Show("The ticket was saved, but the email could not be sent." & vbCrLf & vbCrLf & ex.Message,
                            Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ''' <summary>After a save: clear the details (or reload a re-opened ticket) and refresh the list.</summary>
    Private Sub FinishAction(reopenId As Integer?)
        _dirty = False
        ClearTicket()
        RefreshList()
        If reopenId.HasValue Then OpenTicket(reopenId.Value)
    End Sub

#End Region

#Region "Quick print"

    ''' <summary>Prints the open ticket, or the ticket highlighted in the list (cmdQuickFind in Access).</summary>
    Private Sub cmdQuickPrint_Click(sender As Object, e As EventArgs) Handles cmdQuickPrint.Click
        Dim ticketId As Integer?
        If _current IsNot Nothing Then
            ticketId = _current.ID
        ElseIf dgvTickets.CurrentRow IsNot Nothing Then
            ticketId = CInt(dgvTickets.CurrentRow.Cells("ID").Value)
        End If
        If Not ticketId.HasValue Then
            MessageBox.Show("You need to highlight a ticket number or open a ticket first", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If _dirty AndAlso MessageBox.Show("This ticket has changes that were not saved. The printout shows the saved version. Print anyway?",
                                          Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

        Try
            Dim row = ReportData.Ticket(ticketId.Value)
            If row Is Nothing Then
                MessageBox.Show($"Ticket {ticketId} was not found.", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            ReportPreview.Show(Me, HelpDeskReports.Individual(row))
        Catch ex As SqlException
            MessageBox.Show("Could not load the ticket." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Reset / close"

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        If Not ConfirmDiscard() Then Return
        _loading = True
        optOpen.Checked = True
        optAnyAssigned.Checked = True
        ClearFilters()
        _loading = False
        ClearTicket()
        RefreshList()
        txtQuickFind.Focus()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub TicketEditForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not ConfirmDiscard() Then e.Cancel = True
    End Sub

    ''' <summary>Asks before throwing away unsaved edits. Returns True if it is OK to continue.</summary>
    Private Function ConfirmDiscard() As Boolean
        If Not _dirty OrElse _current Is Nothing Then Return True
        If MessageBox.Show($"Ticket {_current.ID} has changes that were not saved. Discard them?", Caption,
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            _dirty = False
            Return True
        End If
        Return False
    End Function

#End Region

#Region "Helpers"

    Private Function UserName(id As Integer?) As String
        If Not id.HasValue Then Return Nothing
        Dim rows = _allUsers.Select($"Value = {id.Value}")
        Return If(rows.Length > 0, rows(0)("Display").ToString(), $"(user {id.Value})")
    End Function

    Private Function LookupOrderNumber(cadenceId As String) As String
        If String.IsNullOrWhiteSpace(cadenceId) OrElse cadenceId.Trim() = "NA" Then Return Nothing
        Try
            Return Lookups.OrderNumberForCadenceId(cadenceId.Trim())
        Catch ex As SqlException
            Return Nothing
        End Try
    End Function

    Private Shared Sub SetDate(dtp As DateTimePicker, value As Date?)
        If value.HasValue Then
            dtp.Value = value.Value
            dtp.Checked = True
        Else
            dtp.Value = Date.Now
            dtp.Checked = False
        End If
    End Sub

    Private Shared Function GetDate(dtp As DateTimePicker) As Date?
        If dtp.ShowCheckBox AndAlso Not dtp.Checked Then Return Nothing
        Return dtp.Value
    End Function

#End Region

End Class
