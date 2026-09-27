''' <summary>
''' Drop-down lists. Each table has a Value column and a Display column.
''' </summary>
Public Module Lookups

    ''' <summary>Rows from MDS_HelpDesk_Categories for one category (Priority, Software, Status, ...).</summary>
    Public Function Category(name As String, Optional minId As Integer = Integer.MinValue) As DataTable
        Return Db.Query(Db.MDS,
            "SELECT ID AS Value, RTRIM(Description) AS Display
             FROM dbo.MDS_HelpDesk_Categories
             WHERE Category = @cat AND ID >= @minId
             ORDER BY SortOrder, Description",
            Db.P("@cat", name), Db.P("@minId", minId))
    End Function

    ''' <summary>Help desk users; LoginName is used to build email addresses.</summary>
    Public Function HelpDeskUsers() As DataTable
        Return Db.Query(Db.MDS,
            "SELECT ID AS Value, RTRIM(UserName) AS Display, RTRIM(LoginName) AS LoginName
             FROM dbo.MDS_HelpDesk_Users
             ORDER BY UserName")
    End Function

    ''' <summary>WMS users (SEC_Users) for the User ID box.</summary>
    Public Function WmsUsers() As DataTable
        Return Db.Query(Db.DC00MDS,
            "SELECT RTRIM(UserID) AS Value,
                    RTRIM(UserID) + ' - ' + RTRIM(Last_Name) + ' ' + RTRIM(First_Name) AS Display,
                    RTRIM(Last_Name) + ' ' + RTRIM(First_Name) AS FullName
             FROM dbo.SEC_Users
             ORDER BY Last_Name, First_Name")
    End Function

    ''' <summary>Client accounts starting with 1, 8 or 9.</summary>
    Public Function Accounts() As DataTable
        Return Db.Query(Db.DC00MDS,
            "SELECT RTRIM(AccountNumber) AS Value,
                    RTRIM(AccountNumber) + ' - ' + RTRIM(AccountName) AS Display,
                    RTRIM(AccountName) AS AccountName
             FROM dbo.Client
             WHERE AccountNumber LIKE '1%' OR AccountNumber LIKE '8%' OR AccountNumber LIKE '9%'
             ORDER BY AccountName")
    End Function

    ''' <summary>Every client account (the Edit Tickets account list).</summary>
    Public Function AllAccounts() As DataTable
        Return Db.Query(Db.DC00MDS,
            "SELECT DISTINCT RTRIM(AccountNumber) AS Value,
                    RTRIM(AccountNumber) + ' - ' + RTRIM(AccountName) AS Display,
                    RTRIM(AccountName) AS AccountName
             FROM dbo.Client
             ORDER BY Value")
    End Function

    ''' <summary>Account numbers that have at least one ticket.</summary>
    Public Function TicketAccountNumbers() As HashSet(Of String)
        Dim dt = Db.Query(Db.MDS, "SELECT DISTINCT RTRIM(AccountNo) AS AccountNo FROM dbo.MDS_HelpDesk WHERE AccountNo IS NOT NULL")
        Dim result As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
        For Each r As DataRow In dt.Rows
            result.Add(r("AccountNo").ToString())
        Next
        Return result
    End Function

    ''' <summary>
    ''' The accounts (from <see cref="AllAccounts"/>) that have tickets, plus any ticket account
    ''' numbers that are not in the client table.
    ''' </summary>
    Public Function AccountsWithTickets(accounts As DataTable) As DataTable
        Dim used = TicketAccountNumbers()
        Dim result = accounts.Clone()
        For Each r As DataRow In accounts.Rows
            If used.Remove(r("Value").ToString()) Then result.ImportRow(r)
        Next
        For Each acct In used
            result.Rows.Add(acct, acct, "")
        Next
        result.DefaultView.Sort = "Value"
        Return result.DefaultView.ToTable()
    End Function

    ''' <summary>Help desk users who have requested at least one ticket.</summary>
    Public Function TicketRequesters() As DataTable
        Return Db.Query(Db.MDS,
            "SELECT u.ID AS Value, RTRIM(u.UserName) AS Display
             FROM dbo.MDS_HelpDesk_Users AS u
             WHERE EXISTS (SELECT 1 FROM dbo.MDS_HelpDesk AS h WHERE h.RequestBy = u.ID)
             ORDER BY u.UserName")
    End Function

    ''' <summary>Help desk users who can be assigned tickets (UserRole = 1).</summary>
    Public Function AssignableUsers() As DataTable
        Return Db.Query(Db.MDS,
            "SELECT ID AS Value, RTRIM(UserName) AS Display, RTRIM(LoginName) AS LoginName
             FROM dbo.MDS_HelpDesk_Users
             WHERE UserRole = '1'
             ORDER BY UserName")
    End Function

    ''' <summary>Cadence orders for an account updated in the last 3 months.</summary>
    Public Function CadenceOrders(accountNo As String) As DataTable
        Return Db.Query(Db.MDS,
            "SELECT RTRIM(Order_ID) AS Value,
                    RTRIM(Order_ID) + ' - ' + ISNULL(RTRIM(Ship_To_Customer_Name), '') AS Display
             FROM dbo.vw_Cadence_Orders
             WHERE Update_Date > DATEADD(month, -3, CAST(GETDATE() AS date))
               AND Sold_To_Customer_ID = @acct
             ORDER BY RTRIM(Order_ID)",
            Db.P("@acct", accountNo))
    End Function

    ''' <summary>Customer PO reference for a Cadence order ID, or Nothing.</summary>
    Public Function OrderNumberForCadenceId(cadenceId As String) As String
        Dim result = Db.Scalar(Db.DC00MDS,
            "SELECT TOP 1 RTRIM(SoldToCustomerPORef) FROM dbo.OrderHeader WHERE OrderID = @id",
            Db.P("@id", cadenceId))
        Return If(result Is Nothing, Nothing, result.ToString())
    End Function

End Module
