''' <summary>
''' Equipment printouts, grouped by location (rpt_IT_Computers_* in Access, which printed one
''' location per report).
''' </summary>
Public Module InventoryReports

    Public Function Computers(data As DataTable, filterText As String) As ReportDocument
        Dim cols = {
            New TableColumn("Computer", 1.1!), New TableColumn("User", 1.6!), New TableColumn("CMLWIN", 0.8!),
            New TableColumn("Win Ver", 0.8!), New TableColumn("Office Ver", 0.9!), New TableColumn("PS Version", 1),
            New TableColumn("Type", 1.2!), New TableColumn("Sentinel", 0.7!), New TableColumn("IP", 1.2!), New TableColumn("Model", 1.2!)
        }
        Dim doc = Grouped("Computer Inventory", filterText, cols, data, "Whse",
            Function(r) {Cell(r("Computer")), Cell(r("User")), Cell(r("CMLWIN")), Cell(r("Windows")), Cell(r("Office")),
                         If(r("Packstation") Is DBNull.Value, "", CDate(r("Packstation")).ToShortDateString()),
                         Cell(r("Type")), Cell(r("Sentinel")), Cell(r("IP")), Cell(r("Model"))})
        Return doc
    End Function

    Public Function Printers(data As DataTable, filterText As String) As ReportDocument
        Dim cols = {
            New TableColumn("Printer", 1.2!), New TableColumn("Model", 1), New TableColumn("Manufacturer", 1.1!),
            New TableColumn("Type", 0.9!), New TableColumn("IP", 1.2!), New TableColumn("Connected To", 1.2!)
        }
        Return Grouped("Printer Inventory", filterText, cols, data, "Location",
            Function(r) {Cell(r("Printer")), Cell(r("Model")), Cell(r("Manufacturer")), Cell(r("Type")), Cell(r("IP")), Cell(r("Connected To"))})
    End Function

    ''' <summary>A landscape table with a heading each time <paramref name="groupColumn"/> changes.</summary>
    Private Function Grouped(title As String, filterText As String, cols As TableColumn(), data As DataTable,
                             groupColumn As String, rowValues As Func(Of DataRow, String())) As ReportDocument
        Dim doc As New ReportDocument(title) With {
            .Subtitle = $"{filterText} — {data.Rows.Count} item(s)",
            .RepeatHeader = TableRowBlock.Header(cols)
        }
        doc.DefaultPageSettings.Landscape = True

        Dim view As New DataView(data) With {.Sort = groupColumn}
        Dim lastGroup As String = Nothing
        Dim first = True
        For Each rv As DataRowView In view
            Dim group = Cell(rv.Row(groupColumn))
            If first OrElse group <> lastGroup Then
                first = False
                doc.Blocks.Add(New TextBlock(If(group.Length = 0, "(no location)", group), heading:=True) With {.SpaceAfter = 2})
                lastGroup = group
            End If
            doc.Blocks.Add(New TableRowBlock(cols, rowValues(rv.Row)))
        Next
        If data.Rows.Count = 0 Then doc.Blocks.Add(New TextBlock("Nothing matches the current filter."))
        Return doc
    End Function

    Private Function Cell(value As Object) As String
        Return If(value Is DBNull.Value OrElse value Is Nothing, "", value.ToString().Trim())
    End Function

End Module
