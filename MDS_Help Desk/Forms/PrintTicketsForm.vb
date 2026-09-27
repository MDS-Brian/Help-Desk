Imports Microsoft.Data.SqlClient

''' <summary>
''' Print options (frmHelpDesk_PrintAccount in Access): the open tickets report, limited by
''' request date and optionally by account, priority, requester or assignee, plus ticket counts.
''' </summary>
Public Class PrintTicketsForm

    Private Const Caption As String = "Help Desk"

    Private _accounts As DataTable

    Private Sub PrintTicketsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cursor = Cursors.WaitCursor
            _accounts = Lookups.AllAccounts()
            Bind(cboAccount, WithAnyRow(Lookups.AccountsWithTickets(_accounts)))
            Bind(cboPriority, WithAnyRow(Lookups.Category("Priority", minId:=10)))
            Bind(cboRequestBy, WithAnyRow(Lookups.TicketRequesters()))
            Bind(cboAssignedTo, WithAnyRow(Lookups.AssignableUsers()))
        Catch ex As SqlException
            MessageBox.Show("Could not load the help desk lists from SQL Server." & vbCrLf & vbCrLf & ex.Message,
                            Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            BeginInvoke(Sub() Close())
            Return
        Finally
            Cursor = Cursors.Default
        End Try

        For Each cbo In New ComboBox() {cboAccount, cboPriority, cboRequestBy, cboAssignedTo}
            cbo.SelectedIndex = 0
        Next
        dtpStart.Value = Date.Today.AddMonths(-1)
        dtpEnd.Value = Date.Today
    End Sub

    Private Sub Range_CheckedChanged(sender As Object, e As EventArgs) Handles optRangeMonths.CheckedChanged, optRangeDates.CheckedChanged
        nudMonths.Enabled = optRangeMonths.Checked
        dtpStart.Enabled = optRangeDates.Checked
        dtpEnd.Enabled = optRangeDates.Checked
    End Sub

    Private Sub cmdPreviewTickets_Click(sender As Object, e As EventArgs) Handles cmdPreviewTickets.Click
        Dim f As New OpenTicketReportFilter With {
            .AccountNo = SelectedText(cboAccount),
            .Priority = SelectedInt(cboPriority),
            .RequestBy = SelectedInt(cboRequestBy),
            .AssignedTo = SelectedInt(cboAssignedTo)
        }
        Dim parts As New List(Of String)

        Dim tomorrow = Date.Today.AddDays(1)
        If optRange1Week.Checked Then
            f.RequestedFrom = Date.Today.AddDays(-7) : f.RequestedBefore = tomorrow
            parts.Add("Requested in the last week")
        ElseIf optRange2Weeks.Checked Then
            f.RequestedFrom = Date.Today.AddDays(-14) : f.RequestedBefore = tomorrow
            parts.Add("Requested in the last 2 weeks")
        ElseIf optRangeMonths.Checked Then
            f.RequestedFrom = Date.Today.AddMonths(-CInt(nudMonths.Value)) : f.RequestedBefore = tomorrow
            parts.Add($"Requested in the last {nudMonths.Value} month(s)")
        ElseIf optRangeDates.Checked Then
            If dtpEnd.Value.Date < dtpStart.Value.Date Then
                MessageBox.Show("The end date is before the start date.", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpEnd.Focus()
                Return
            End If
            f.RequestedFrom = dtpStart.Value.Date : f.RequestedBefore = dtpEnd.Value.Date.AddDays(1)
            parts.Add($"Requested {dtpStart.Value.ToShortDateString()} to {dtpEnd.Value.ToShortDateString()}")
        Else
            parts.Add("All open tickets")
        End If
        If f.AccountNo IsNot Nothing Then parts.Add("Account " & cboAccount.Text)
        If f.Priority.HasValue Then parts.Add("Priority " & cboPriority.Text)
        If f.RequestBy.HasValue Then parts.Add("Requested by " & cboRequestBy.Text)
        If f.AssignedTo.HasValue Then parts.Add("Assigned to " & cboAssignedTo.Text)

        Dim tickets As DataTable
        Try
            Cursor = Cursors.WaitCursor
            tickets = ReportData.OpenTickets(f)
        Catch ex As SqlException
            MessageBox.Show("Could not load the tickets." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Finally
            Cursor = Cursors.Default
        End Try

        ReportPreview.Show(Me, HelpDeskReports.OpenTickets(tickets, String.Join(" · ", parts)))
    End Sub

    Private Sub cmdPreviewCounts_Click(sender As Object, e As EventArgs) Handles cmdPreviewCounts.Click
        Dim doc As ReportDocument
        Try
            Cursor = Cursors.WaitCursor
            If optCountsAccount.Checked Then
                Dim names As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
                For Each r As DataRow In _accounts.Rows
                    names(r("Value").ToString()) = r("AccountName").ToString()
                Next
                doc = HelpDeskReports.CountsByAccount(ReportData.OpenCountsByAccount(), names)
            Else
                doc = HelpDeskReports.CountsByPriority(ReportData.OpenCountsByPriority())
            End If
        Catch ex As SqlException
            MessageBox.Show("Could not load the ticket counts." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Finally
            Cursor = Cursors.Default
        End Try

        ReportPreview.Show(Me, doc)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

End Class
