''' <summary>The help desk reports, built on <see cref="ReportDocument"/>.</summary>
Public Module HelpDeskReports

    ''' <summary>Open tickets, one block per ticket (rptHelpDesk_Open_Tickets and its variants).</summary>
    Public Function OpenTickets(tickets As DataTable, filterText As String) As ReportDocument
        Dim doc As New ReportDocument("I.T. Open Tickets") With {
            .Subtitle = $"{filterText} — {tickets.Rows.Count} ticket(s)"
        }
        For Each r As DataRow In tickets.Rows
            Dim block = New FieldGridBlock(4, ruleAbove:=doc.Blocks.Count > 0).
                Add("Ticket No.", r("TicketNo")).
                Add("Priority", r("Priority")).
                Add("Account No", r("AccountNo")).
                Add("Software", r("Software")).
                Add("Request Date", r("RequestDate")).
                Add("Request By Date", r("RequestedByDate")).
                Add("Request By", r("RequestBy")).
                Add("Assigned To", r("AssignedTo")).
                Add("Cadence ID", r("CadenceID")).
                Add("Order No", r("OrderNumber"), span:=3).
                Add("Description", r("DescriptionDetail"), span:=4)
            If Not IsBlank(r("Notes")) Then block.Add("Notes", r("Notes"), span:=4)
            block.SpaceAfter = 10
            doc.Blocks.Add(block)
        Next
        If tickets.Rows.Count = 0 Then doc.Blocks.Add(New TextBlock("There are no open tickets that match."))
        Return doc
    End Function

    ''' <summary>A single ticket with a time log to fill in by hand (rptHelpDesk_Individual).</summary>
    Public Function Individual(r As DataRow) As ReportDocument
        Dim doc As New ReportDocument($"Help Desk Ticket {r("TicketNo")}") With {.Subtitle = "Project Detail Report"}
        doc.Blocks.Add(New FieldGridBlock(3).
            Add("Ticket No", r("TicketNo")).
            Add("Account No", r("AccountNo")).
            Add("Priority", r("Priority")).
            Add("Request Date", r("RequestDate")).
            Add("Request By Date", r("RequestedByDate")).
            Add("Request By", r("RequestBy")).
            Add("Assigned To", r("AssignedTo")).
            Add("Software", r("Software")).
            Add("Status", r("Status")).
            Add("Cadence ID", r("CadenceID")).
            Add("Order Nbr", r("OrderNumber")).
            Add("Computer Nbr", r("ComputerNumber")).
            Add("Close Date", r("CloseDate"), span:=3))
        doc.Blocks.Add(New FieldGridBlock(1, ruleAbove:=True).
            Add("Description Detail", r("DescriptionDetail")).
            Add("Notes", r("Notes")))

        doc.Blocks.Add(New TextBlock("Time", heading:=True))
        Dim cols = {New TableColumn("Date", 1), New TableColumn("Start Time", 1), New TableColumn("End Time", 1), New TableColumn("Total", 1)}
        doc.Blocks.Add(TableRowBlock.Header(cols))
        For i = 1 To 8
            doc.Blocks.Add(New TableRowBlock(cols, {"", "", "", ""}, ruled:=True))
        Next
        Return doc
    End Function

    ''' <summary>Open ticket counts by account (rptHelpDeskCounts_Accounts).</summary>
    Public Function CountsByAccount(counts As DataTable, accountNames As IDictionary(Of String, String)) As ReportDocument
        Dim cols = {New TableColumn("Account", 1), New TableColumn("Account Name", 4), New TableColumn("Total Tickets", 1.2!, alignRight:=True)}
        Dim doc As New ReportDocument("Help Desk Ticket Counts By Account Nbr") With {
            .Subtitle = "Open tickets",
            .RepeatHeader = TableRowBlock.Header(cols)
        }
        Dim total = 0
        For Each r As DataRow In counts.Rows
            Dim acct = r("AccountNo").ToString()
            Dim name As String = Nothing
            accountNames.TryGetValue(acct, name)
            doc.Blocks.Add(New TableRowBlock(cols, {acct, name, r("Tickets").ToString()}))
            total += CInt(r("Tickets"))
        Next
        doc.Blocks.Add(New TableRowBlock(cols, {"", "Total", total.ToString()}, isHeader:=True))
        Return doc
    End Function

    ''' <summary>Open ticket counts by priority (rptHelpDeskCounts_Priorities).</summary>
    Public Function CountsByPriority(counts As DataTable) As ReportDocument
        Dim cols = {New TableColumn("Priority", 4), New TableColumn("Total Nbr of Tickets", 1.5!, alignRight:=True)}
        Dim doc As New ReportDocument("Help Desk Ticket Counts By Priority") With {
            .Subtitle = "Open tickets",
            .RepeatHeader = TableRowBlock.Header(cols)
        }
        Dim total = 0
        For Each r As DataRow In counts.Rows
            doc.Blocks.Add(New TableRowBlock(cols, {r("Priority").ToString(), r("Tickets").ToString()}))
            total += CInt(r("Tickets"))
        Next
        doc.Blocks.Add(New TableRowBlock(cols, {"Total", total.ToString()}, isHeader:=True))
        Return doc
    End Function

    ''' <summary>One knowledge base entry (rpt-KnowlegeBase).</summary>
    Public Function KnowledgeBaseEntry(entry As KnowledgeEntry) As ReportDocument
        Dim doc As New ReportDocument("Cadence Knowledge Base Solutions")
        doc.Blocks.Add(New FieldGridBlock(3).
            Add("Record No", entry.RecordNo).
            Add("Date", entry.Entered).
            Add("Process", entry.Process).
            Add("Issue", entry.ErrorText, span:=3).
            Add("Resolution", entry.Workaround, span:=3))
        Return doc
    End Function

    Private Function IsBlank(value As Object) As Boolean
        Return value Is DBNull.Value OrElse String.IsNullOrWhiteSpace(value.ToString())
    End Function

End Module
