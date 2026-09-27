''' <summary>A row of dbo.MDS_HelpDesk_Computers.</summary>
Public Class ComputerRecord
    Public Property Computer As String
    Public Property UserName As String
    Public Property CmlWin As String
    Public Property WinVersion As String
    Public Property OfficeVersion As String
    Public Property PackstationVersion As Date?
    Public Property Type As String
    Public Property Sentinel As String
    Public Property IpAddress As String
    Public Property Warehouse As String
    Public Property ModelNbr As String
    Public Property Vpn As String
    Public Property WritebackUps As String
    Public Property WritebackUsps As String
    Public Property WritebackFedex As String
    Public Property Notes As String
End Class

''' <summary>A row of dbo.MDS_IT_Printers.</summary>
Public Class PrinterRecord
    Public Property PrinterID As String
    Public Property ModelNo As String
    Public Property IpAddress As String
    Public Property ConnectedTo As String
    Public Property Location As String
    Public Property Type As String
    Public Property Manufacturer As String
    Public Property Notes As String
End Class

''' <summary>Data for the IT Admin screens.</summary>
Public Module ItAdmin

#Region "Computers (frmMDS_IT_Computers)"

    Public Function Computers(type As String, warehouse As String) As DataTable
        Return Db.Query(Db.MDS,
            "SELECT RTRIM(Computer) AS Computer, RTRIM(User_Name) AS [User], RTRIM(CMLWIN) AS CMLWIN,
                    RTRIM(Win_Version) AS Windows, RTRIM(Office_Version) AS Office, PS_Version AS Packstation,
                    RTRIM(Type) AS Type, RTRIM(Sentinel) AS Sentinel, RTRIM(IP_Address) AS IP,
                    RTRIM(Warehouse) AS Whse, RTRIM(VPN) AS VPN, RTRIM(ModelNbr) AS Model, RTRIM(HasNotes) AS Notes
             FROM dbo.MDS_HelpDesk_Computers
             WHERE (@type IS NULL OR Type = @type) AND (@whse IS NULL OR Warehouse = @whse)
             ORDER BY Whse, Computer",
            Db.P("@type", type), Db.P("@whse", warehouse))
    End Function

    Public Function ComputerTypes() As DataTable
        Return Distinct("MDS_HelpDesk_Computers", "Type")
    End Function

    Public Function ComputerWarehouses() As DataTable
        Return Distinct("MDS_HelpDesk_Computers", "Warehouse")
    End Function

    Public Function LoadComputer(computer As String) As ComputerRecord
        Dim dt = Db.Query(Db.MDS, "SELECT * FROM dbo.MDS_HelpDesk_Computers WHERE Computer = @id", Db.P("@id", computer))
        If dt.Rows.Count = 0 Then Return Nothing
        Dim r = dt.Rows(0)
        Return New ComputerRecord With {
            .Computer = Text(r("Computer")),
            .UserName = Text(r("User_Name")),
            .CmlWin = Text(r("CMLWIN")),
            .WinVersion = Text(r("Win_Version")),
            .OfficeVersion = Text(r("Office_Version")),
            .PackstationVersion = If(r("PS_Version") Is DBNull.Value, CType(Nothing, Date?), CDate(r("PS_Version"))),
            .Type = Text(r("Type")),
            .Sentinel = Text(r("Sentinel")),
            .IpAddress = Text(r("IP_Address")),
            .Warehouse = Text(r("Warehouse")),
            .ModelNbr = Text(r("ModelNbr")),
            .Vpn = Text(r("VPN")),
            .WritebackUps = Text(r("Writeback_UPS")),
            .WritebackUsps = Text(r("Writeback_USPS")),
            .WritebackFedex = Text(r("Writeback_Fedex")),
            .Notes = Text(r("Notes"))
        }
    End Function

    ''' <summary>Adds the computer, or updates it if <paramref name="isNew"/> is False.</summary>
    Public Sub SaveComputer(c As ComputerRecord, isNew As Boolean)
        Dim sql = If(isNew,
            "INSERT INTO dbo.MDS_HelpDesk_Computers
                (Computer, User_Name, CMLWIN, Win_Version, Office_Version, PS_Version, Type, Sentinel, IP_Address,
                 Warehouse, ModelNbr, VPN, Writeback_UPS, Writeback_USPS, Writeback_Fedex, Notes, HasNotes)
             VALUES (@id, @user, @cml, @win, @office, @ps, @type, @sentinel, @ip,
                     @whse, @model, @vpn, @ups, @usps, @fedex, @notes, @hasNotes)",
            "UPDATE dbo.MDS_HelpDesk_Computers SET
                User_Name = @user, CMLWIN = @cml, Win_Version = @win, Office_Version = @office, PS_Version = @ps,
                Type = @type, Sentinel = @sentinel, IP_Address = @ip, Warehouse = @whse, ModelNbr = @model, VPN = @vpn,
                Writeback_UPS = @ups, Writeback_USPS = @usps, Writeback_Fedex = @fedex, Notes = @notes, HasNotes = @hasNotes
             WHERE Computer = @id")
        Execute(sql,
            Db.P("@id", c.Computer), Db.P("@user", c.UserName), Db.P("@cml", c.CmlWin), Db.P("@win", c.WinVersion),
            Db.P("@office", c.OfficeVersion), Db.P("@ps", c.PackstationVersion), Db.P("@type", c.Type),
            Db.P("@sentinel", c.Sentinel), Db.P("@ip", c.IpAddress), Db.P("@whse", c.Warehouse), Db.P("@model", c.ModelNbr),
            Db.P("@vpn", c.Vpn), Db.P("@ups", c.WritebackUps), Db.P("@usps", c.WritebackUsps), Db.P("@fedex", c.WritebackFedex),
            Db.P("@notes", c.Notes), Db.P("@hasNotes", HasNotes(c.Notes)))
    End Sub

    Public Sub DeleteComputer(computer As String)
        Execute("DELETE FROM dbo.MDS_HelpDesk_Computers WHERE Computer = @id", Db.P("@id", computer))
    End Sub

#End Region

#Region "Printers (frmMDS_IT_Printers)"

    Public Function Printers(type As String, location As String) As DataTable
        Return Db.Query(Db.MDS,
            "SELECT RTRIM(PrinterID) AS Printer, RTRIM(Model_No) AS Model, RTRIM(IP_Address) AS IP,
                    RTRIM(Connected_To) AS [Connected To], RTRIM(Location) AS Location, RTRIM(Type) AS Type,
                    RTRIM(Manufacturer) AS Manufacturer, RTRIM(HasNotes) AS Notes
             FROM dbo.MDS_IT_Printers
             WHERE (@type IS NULL OR Type = @type) AND (@location IS NULL OR Location = @location)
             ORDER BY Location, PrinterID",
            Db.P("@type", type), Db.P("@location", location))
    End Function

    Public Function PrinterTypes() As DataTable
        Return Distinct("MDS_IT_Printers", "Type")
    End Function

    Public Function PrinterLocations() As DataTable
        Return Distinct("MDS_IT_Printers", "Location")
    End Function

    Public Function LoadPrinter(printerId As String) As PrinterRecord
        Dim dt = Db.Query(Db.MDS, "SELECT * FROM dbo.MDS_IT_Printers WHERE PrinterID = @id", Db.P("@id", printerId))
        If dt.Rows.Count = 0 Then Return Nothing
        Dim r = dt.Rows(0)
        Return New PrinterRecord With {
            .PrinterID = Text(r("PrinterID")),
            .ModelNo = Text(r("Model_No")),
            .IpAddress = Text(r("IP_Address")),
            .ConnectedTo = Text(r("Connected_To")),
            .Location = Text(r("Location")),
            .Type = Text(r("Type")),
            .Manufacturer = Text(r("Manufacturer")),
            .Notes = Text(r("Notes"))
        }
    End Function

    Public Sub SavePrinter(p As PrinterRecord, isNew As Boolean)
        Dim sql = If(isNew,
            "INSERT INTO dbo.MDS_IT_Printers (PrinterID, Model_No, IP_Address, Connected_To, Location, Type, Manufacturer, Notes, HasNotes)
             VALUES (@id, @model, @ip, @connected, @location, @type, @maker, @notes, @hasNotes)",
            "UPDATE dbo.MDS_IT_Printers SET
                Model_No = @model, IP_Address = @ip, Connected_To = @connected, Location = @location,
                Type = @type, Manufacturer = @maker, Notes = @notes, HasNotes = @hasNotes
             WHERE PrinterID = @id")
        Execute(sql,
            Db.P("@id", p.PrinterID), Db.P("@model", p.ModelNo), Db.P("@ip", p.IpAddress), Db.P("@connected", p.ConnectedTo),
            Db.P("@location", p.Location), Db.P("@type", p.Type), Db.P("@maker", p.Manufacturer),
            Db.P("@notes", p.Notes), Db.P("@hasNotes", HasNotes(p.Notes)))
    End Sub

    Public Sub DeletePrinter(printerId As String)
        Execute("DELETE FROM dbo.MDS_IT_Printers WHERE PrinterID = @id", Db.P("@id", printerId))
    End Sub

#End Region

#Region "Categories (frmHelpDesk_Categories)"

    ''' <summary>The ticket column that stores the ID for each category, for the in-use check.</summary>
    Private ReadOnly TicketColumnFor As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase) From {
        {"Priority", "Priority"}, {"Status", "Status"}, {"Software", "Software"},
        {"Resolution", "ResolutionType"}, {"Tier", "AssignedTier"}, {"ProjectTyp", "ProjectType"}
    }

    Public Function CategoryNames() As DataTable
        Return Db.Query(Db.MDS,
            "SELECT DISTINCT RTRIM(Category) AS Value, RTRIM(Category) AS Display
             FROM dbo.MDS_HelpDesk_Categories ORDER BY Value")
    End Function

    Public Function CategoryEntries(category As String) As DataTable
        Return Db.Query(Db.MDS,
            "SELECT ID, RTRIM(Description) AS Description, SortOrder
             FROM dbo.MDS_HelpDesk_Categories WHERE Category = @cat ORDER BY ID",
            Db.P("@cat", category))
    End Function

    Public Sub AddCategoryEntry(category As String, id As Integer, description As String, sortOrder As Integer?)
        Execute("INSERT INTO dbo.MDS_HelpDesk_Categories (ID, Category, Description, SortOrder) VALUES (@id, @cat, @desc, ISNULL(@sort, 1))",
                Db.P("@id", id), Db.P("@cat", category), Db.P("@desc", description), Db.P("@sort", sortOrder))
    End Sub

    Public Sub UpdateCategoryEntry(category As String, id As Integer, description As String, sortOrder As Integer?)
        Execute("UPDATE dbo.MDS_HelpDesk_Categories SET Description = @desc, SortOrder = ISNULL(@sort, 1) WHERE Category = @cat AND ID = @id",
                Db.P("@id", id), Db.P("@cat", category), Db.P("@desc", description), Db.P("@sort", sortOrder))
    End Sub

    Public Sub DeleteCategoryEntry(category As String, id As Integer)
        Execute("DELETE FROM dbo.MDS_HelpDesk_Categories WHERE Category = @cat AND ID = @id",
                Db.P("@id", id), Db.P("@cat", category))
    End Sub

    ''' <summary>Number of tickets (open or closed) that use a category entry; 0 for categories tickets do not use.</summary>
    Public Function TicketsUsingCategory(category As String, id As Integer) As Integer
        Dim column As String = Nothing
        If Not TicketColumnFor.TryGetValue(category, column) Then Return 0
        Return CInt(Db.Scalar(Db.MDS, $"SELECT COUNT(*) FROM dbo.MDS_HelpDesk WHERE [{column}] = @id", Db.P("@id", id)))
    End Function

#End Region

#Region "Cadence unit IDs (frmHelpDesk_Unit_ID)"

    Public Function Warehouses() As DataTable
        Return Db.Query(Db.MDS,
            "SELECT RTRIM(Warehouse) AS Value, RTRIM(Warehouse_Description) AS Display
             FROM dbo.MDS_Warehouse ORDER BY Warehouse_Description")
    End Function

    Public Function UnitIds(warehouse As String) As DataTable
        Return Db.Query(Db.MDS,
            "SELECT Unit_ID AS [Unit ID], RTRIM(Warehouse) AS Warehouse, RTRIM(Assigned_To) AS [Assigned To]
             FROM dbo.MDS_HelpDesk_Unit_ID
             WHERE @whse IS NULL OR Warehouse = @whse
             ORDER BY Unit_ID",
            Db.P("@whse", warehouse))
    End Function

#End Region

#Region "Orders in COMP (frmHelpDesk_OrdersInComp)"

    Public Function OrdersInComp() As DataTable
        Return Db.Query(Db.MDS, "SELECT RTRIM(Field1) AS [Cadence ID] FROM dbo.MDS_HelpDesk_OrdersInComp ORDER BY Field1")
    End Function

    ''' <summary>Adds Cadence IDs that are not already in the list. Returns how many were added.</summary>
    Public Function AddOrdersInComp(cadenceIds As IEnumerable(Of String)) As Integer
        Dim added = 0
        Using cn = Db.Open(Db.MDS), tx = cn.BeginTransaction()
            For Each id In cadenceIds
                added += Db.NewCommand(cn, tx,
                    "INSERT INTO dbo.MDS_HelpDesk_OrdersInComp (Field1)
                     SELECT @id WHERE NOT EXISTS (SELECT 1 FROM dbo.MDS_HelpDesk_OrdersInComp WHERE Field1 = @id)",
                    Db.P("@id", id)).ExecuteNonQuery()
            Next
            tx.Commit()
        End Using
        Return added
    End Function

    Public Sub RemoveOrderInComp(cadenceId As String)
        Execute("DELETE FROM dbo.MDS_HelpDesk_OrdersInComp WHERE Field1 = @id", Db.P("@id", cadenceId))
    End Sub

    Public Sub ClearOrdersInComp()
        Execute("DELETE FROM dbo.MDS_HelpDesk_OrdersInComp")
    End Sub

#End Region

#Region "Helpers"

    ''' <summary>Distinct non-blank values of a column, as a Value / Display lookup.</summary>
    Private Function Distinct(table As String, column As String) As DataTable
        Return Db.Query(Db.MDS,
            $"SELECT DISTINCT RTRIM([{column}]) AS Value, RTRIM([{column}]) AS Display
              FROM dbo.[{table}] WHERE [{column}] IS NOT NULL AND RTRIM([{column}]) <> '' ORDER BY Value")
    End Function

    Private Sub Execute(sql As String, ParamArray params() As Microsoft.Data.SqlClient.SqlParameter)
        Using cn = Db.Open(Db.MDS), cmd = Db.NewCommand(cn, sql, params)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ''' <summary>"Y" when there are notes, as the Access forms set HasNotes.</summary>
    Private Function HasNotes(notes As String) As String
        Return If(String.IsNullOrWhiteSpace(notes), Nothing, "Y")
    End Function

    Private Function Text(value As Object) As String
        If value Is DBNull.Value Then Return Nothing
        Dim s = value.ToString().Trim()
        Return If(s.Length = 0, Nothing, s)
    End Function

#End Region

End Module
