Imports Microsoft.Data.SqlClient

''' <summary>
''' New help desk ticket (frmHelpDesk_New in Access).
''' </summary>
Public Class TicketNewForm

    Private Const Caption As String = "Help Desk"

    ''' <summary>True until Load finishes; InitializeComponent raises CheckedChanged before then.</summary>
    Private _loading As Boolean = True

    Private Sub TicketNewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _loading = True
        Try
            Cursor = Cursors.WaitCursor
            CurrentUser.Check()
            Bind(cboUserID, Lookups.WmsUsers())
            Bind(cboAccount, Lookups.Accounts())
            Bind(cboSoftware, Lookups.Category("Software"))
            Bind(cboPriority, Lookups.Category("Priority", minId:=10))
            Bind(cboRequestedBy, Lookups.HelpDeskUsers())
            Bind(cboAddContact, Lookups.HelpDeskUsers())
        Catch ex As SqlException
            MessageBox.Show("Could not load the help desk lists from SQL Server." & vbCrLf & vbCrLf & ex.Message,
                            Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            BeginInvoke(Sub() Close())
            Return
        Finally
            Cursor = Cursors.Default
            _loading = False
        End Try

        ClearForm(keepUser:=False)
    End Sub

#Region "Help desk type"

    Private Sub optType_CheckedChanged(sender As Object, e As EventArgs) Handles optGeneral.CheckedChanged, optNewAccount.CheckedChanged, optNewUser.CheckedChanged
        Dim opt = DirectCast(sender, RadioButton)
        If _loading OrElse Not opt.Checked Then Return

        If opt Is optNewAccount Then
            SetSoftware(Tickets.SoftwareNewAccount)
            SetPriority(50)
            SetDateNeeded(WorkCalendar.DueDateForNewAccount(Date.Today))
            cboAccount.SelectedValue = Tickets.InternalAccount
            txtDescription.Text = "New Account Setup"
        ElseIf opt Is optNewUser Then
            SetSoftware(Tickets.SoftwareNewUser)
            SetPriority(40)
            SetDateNeeded(WorkCalendar.DueDateForNewUser(Date.Today))
            cboAccount.SelectedValue = Tickets.InternalAccount
            txtDescription.Text = "New User Setup"
        Else
            cboAccount.SelectedIndex = -1
            cboSoftware.SelectedIndex = -1
            txtDescription.Clear()
        End If
        ShowTypeFields()
        cboUserID.Focus()
    End Sub

    ''' <summary>Shows the fields that belong to the selected ticket type.</summary>
    Private Sub ShowTypeFields()
        Dim general = optGeneral.Checked
        pnlNewAccount.Visible = optNewAccount.Checked
        pnlNewUser.Visible = optNewUser.Checked
        For Each c In New Control() {lblCadenceID, cboCadenceID, lblOrderNbr, txtOrderNbr, lblPC_Nbr, txtPC_Nbr}
            c.Visible = general
        Next
    End Sub

    Private Sub cboSoftware_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboSoftware.SelectionChangeCommitted
        Select Case SelectedInt(cboSoftware)
            Case Tickets.SoftwareNewAccount
                optNewAccount.Checked = True
            Case Tickets.SoftwareNewUser
                optNewUser.Checked = True
            Case Tickets.SoftwareHandheld
                cboAccount.SelectedValue = Tickets.InternalAccount
                SetTypeQuietly(optGeneral)
            Case Else
                SetTypeQuietly(optGeneral)
        End Select
    End Sub

    ''' <summary>Changes the type radio without resetting the other fields.</summary>
    Private Sub SetTypeQuietly(opt As RadioButton)
        _loading = True
        opt.Checked = True
        _loading = False
        ShowTypeFields()
    End Sub

#End Region

#Region "Field rules"

    Private Sub cboPriority_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboPriority.SelectionChangeCommitted
        Dim priority = SelectedInt(cboPriority)
        If priority.HasValue Then
            SetDateNeeded(WorkCalendar.DueDateForPriority(priority.Value, Date.Now))
        End If
    End Sub

    Private Sub cboAccount_Leave(sender As Object, e As EventArgs) Handles cboAccount.Leave
        Dim account = SelectedText(cboAccount)
        If account Is Nothing Then Return
        If account = Tickets.InternalAccount Then
            cboCadenceID.DataSource = Nothing
            cboCadenceID.Text = "NA"
            Return
        End If
        Try
            Dim orders = Lookups.CadenceOrders(account)
            Dim typed = cboCadenceID.Text
            cboCadenceID.DisplayMember = "Display"
            cboCadenceID.ValueMember = "Value"
            cboCadenceID.DataSource = orders
            cboCadenceID.SelectedIndex = -1
            cboCadenceID.Text = typed
        Catch ex As SqlException
            MessageBox.Show("Could not load Cadence orders for this account." & vbCrLf & vbCrLf & ex.Message,
                            Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub cboCadenceID_Leave(sender As Object, e As EventArgs) Handles cboCadenceID.Leave
        Dim cadenceId = CadenceIdText()
        If cadenceId Is Nothing OrElse cadenceId = "NA" Then Return
        Try
            Dim orderNumber = Lookups.OrderNumberForCadenceId(cadenceId)
            If orderNumber IsNot Nothing Then txtOrderNbr.Text = orderNumber
        Catch ex As SqlException
            MessageBox.Show("Could not look up the order number." & vbCrLf & vbCrLf & ex.Message,
                            Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub NewAccountFields_Leave(sender As Object, e As EventArgs) Handles txtNewAccountNo.Leave, dtpLaunchDate.Leave
        Dim text = "New Account Setup" & vbCrLf & "Account: " & txtNewAccountNo.Text.Trim()
        If dtpLaunchDate.Checked Then text &= vbCrLf & "Launch Date: " & dtpLaunchDate.Value.ToShortDateString()
        txtDescription.Text = text
    End Sub

    Private Sub NewUserFields_Leave(sender As Object, e As EventArgs) Handles txtNewUserName.Leave, txtNewUserSocial.Leave, txtNewUserPhone.Leave
        txtDescription.Text = "User Name: " & txtNewUserName.Text.Trim() & vbCrLf &
                              "Last 4 Social: " & txtNewUserSocial.Text.Trim() & vbCrLf &
                              "Telephone: " & txtNewUserPhone.Text & vbCrLf & vbCrLf
    End Sub

    Private Sub txtNewUserSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewUserSocial.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then e.Handled = True
    End Sub

#End Region

#Region "Submit / reset / close"

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        Dim ticket = BuildTicket()
        If ticket Is Nothing Then Return

        Dim ticketId As Integer
        Try
            Cursor = Cursors.WaitCursor
            ticketId = Tickets.Create(ticket)
        Catch ex As SqlException
            MessageBox.Show("The ticket was not saved." & vbCrLf & vbCrLf & ex.Message,
                            Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Finally
            Cursor = Cursors.Default
        End Try

        Try
            ShowEmail(ticketId, ticket)
        Catch ex As Exception
            MessageBox.Show($"Ticket {ticketId} was saved, but the Outlook email could not be opened." & vbCrLf & vbCrLf & ex.Message,
                            Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        If MessageBox.Show($"Ticket {ticketId} was saved." & vbCrLf & vbCrLf & "Do you want to add a new Help Desk Ticket?",
                           Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ClearForm(keepUser:=True)
        Else
            Close()
        End If
    End Sub

    ''' <summary>Validates the form (same checks as Access) and returns the ticket, or Nothing.</summary>
    Private Function BuildTicket() As NewTicket
        Dim userId = SelectedText(cboUserID)
        If userId Is Nothing Then Return Invalid(cboUserID, "Please enter the person entering the HD Ticket.")

        Dim account = SelectedText(cboAccount)
        If account Is Nothing Then Return Invalid(cboAccount, "Please select the account.")

        Dim software = SelectedInt(cboSoftware)
        If Not software.HasValue Then Return Invalid(cboSoftware, "Please select the software that you are having a problem with.")

        Dim priority = SelectedInt(cboPriority)
        If Not priority.HasValue Then Return Invalid(cboPriority, "Please set the priority level for this help desk request.")

        Dim requestBy = SelectedInt(cboRequestedBy)
        If Not requestBy.HasValue Then Return Invalid(cboRequestedBy, "Please select the user entering the help desk request.")

        Dim t As New NewTicket With {
            .UserID = userId,
            .AccountNo = account,
            .Software = software.Value,
            .Priority = priority.Value,
            .RequestBy = requestBy.Value,
            .AdditionalContact = SelectedInt(cboAddContact),
            .DateNeeded = If(dtpDateNeeded.Checked, dtpDateNeeded.Value, CType(Nothing, Date?)),
            .Description = NullIfBlank(txtDescription.Text),
            .CadenceID = If(CadenceIdText(), "NA"),
            .OrderNumber = If(NullIfBlank(txtOrderNbr.Text), "NA"),
            .ComputerNumber = NullIfBlank(txtPC_Nbr.Text)
        }

        If software = Tickets.SoftwareNewUser Then
            Dim phone = txtNewUserPhone.Text
            If NullIfBlank(txtNewUserName.Text) Is Nothing OrElse phone.Length = 0 OrElse txtNewUserSocial.TextLength = 0 Then
                Return Invalid(txtNewUserName, "The new user name, last 4 of the social security number and telephone number is required")
            End If
            If txtNewUserSocial.TextLength <> 4 Then
                Return Invalid(txtNewUserSocial, "Please use only the last 4 of the social security number")
            End If
            If phone.Length = 10 Then phone = $"{phone.Substring(0, 3)}-{phone.Substring(3, 3)}-{phone.Substring(6)}"
            t.InitialActions.Add($"User Name: {txtNewUserName.Text.Trim()}   User SS: {txtNewUserSocial.Text}   User Telephone: {phone}")
        ElseIf software = Tickets.SoftwareNewAccount Then
            If NullIfBlank(txtNewAccountNo.Text) Is Nothing OrElse Not dtpLaunchDate.Checked Then
                Return Invalid(txtNewAccountNo, "The new account number and expected launch date is required")
            End If
            t.InitialActions.Add($"New account: {txtNewAccountNo.Text.Trim()}   Launch Date: {dtpLaunchDate.Value.ToShortDateString()}")
            t.AddNewCustomerChecklist = True
        End If

        Return t
    End Function

    Private Function Invalid(focus As Control, message As String) As NewTicket
        MessageBox.Show(message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
        focus.Focus()
        Return Nothing
    End Function

    ''' <summary>Opens the Outlook draft for review, with the same recipients as Access.</summary>
    Private Sub ShowEmail(ticketId As Integer, t As NewTicket)
        Dim subject = $"Help Desk Ticket {ticketId} Priority: {cboPriority.Text} Software: {cboSoftware.Text}"
        Dim body = $"Ticket No: {ticketId}" & vbCrLf &
                   $"Account: {t.AccountNo}" & vbCrLf &
                   $"Priority: {cboPriority.Text}" & vbCrLf &
                   $"Date Needed: {If(t.DateNeeded.HasValue, t.DateNeeded.Value.ToString("g"), "")}" & vbCrLf &
                   $"Cadence ID: {t.CadenceID}" & vbCrLf &
                   $"Order Number: {t.OrderNumber}" & vbCrLf & vbCrLf &
                   "Description:" & vbCrLf & t.Description & vbCrLf & vbCrLf &
                   $"Computer Nbr: {t.ComputerNumber}"

        Dim toAddress = AppConfig.SupportEmail
        Dim cc As String = Nothing
        If optGeneral.Checked AndAlso t.AccountNo <> Tickets.InternalAccount Then
            Dim requestor = SelectedEmail(cboRequestedBy)
            If requestor IsNot Nothing Then toAddress &= "; " & requestor
            cc = SelectedEmail(cboAddContact)
        End If

        OutlookMail.ShowDraft(toAddress, cc, subject, body)
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        ClearForm(keepUser:=False)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    ''' <summary>Clears the entry fields. Requested By always defaults to the logged-in user.</summary>
    Private Sub ClearForm(keepUser As Boolean)
        _loading = True
        If Not keepUser Then
            cboUserID.SelectedIndex = -1
            cboUserID.Text = ""
        End If
        cboAccount.SelectedIndex = -1
        cboSoftware.SelectedIndex = -1
        cboPriority.SelectedIndex = -1
        cboAddContact.SelectedIndex = -1
        If CurrentUser.UserID.HasValue Then
            cboRequestedBy.SelectedValue = CurrentUser.UserID.Value
        ElseIf Not keepUser Then
            cboRequestedBy.SelectedIndex = -1
        End If
        dtpDateNeeded.Checked = False
        cboCadenceID.DataSource = Nothing
        cboCadenceID.Text = ""
        txtOrderNbr.Clear()
        txtPC_Nbr.Clear()
        txtNewAccountNo.Clear()
        dtpLaunchDate.Checked = False
        txtNewUserName.Clear()
        txtNewUserSocial.Clear()
        txtNewUserPhone.Clear()
        txtDescription.Clear()
        optGeneral.Checked = True
        _loading = False
        ShowTypeFields()
        cboUserID.Focus()
    End Sub

#End Region

#Region "Helpers"

    Private Sub SetSoftware(id As Integer)
        cboSoftware.SelectedValue = id
    End Sub

    Private Sub SetPriority(id As Integer)
        cboPriority.SelectedValue = id
    End Sub

    Private Sub SetDateNeeded(value As Date)
        dtpDateNeeded.Value = value
        dtpDateNeeded.Checked = True
    End Sub

    ''' <summary>Cadence ID from the list or as typed, upper case; Nothing if blank.</summary>
    Private Function CadenceIdText() As String
        If cboCadenceID.SelectedIndex >= 0 AndAlso cboCadenceID.SelectedValue IsNot Nothing Then
            Return cboCadenceID.SelectedValue.ToString().Trim().ToUpperInvariant()
        End If
        Dim typed = cboCadenceID.Text.Trim().ToUpperInvariant()
        Return If(typed.Length = 0, Nothing, typed)
    End Function

#End Region

End Class
