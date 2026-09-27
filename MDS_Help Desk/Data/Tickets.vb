Imports Microsoft.Data.SqlClient

''' <summary>Values entered on the Add Ticket form.</summary>
Public Class NewTicket
    Public Property UserID As String
    Public Property AccountNo As String
    Public Property Description As String
    Public Property Priority As Integer
    Public Property Software As Integer
    Public Property RequestBy As Integer
    Public Property AdditionalContact As Integer?
    Public Property DateNeeded As Date?
    Public Property CadenceID As String
    Public Property OrderNumber As String
    Public Property ComputerNumber As String

    ''' <summary>Extra "To Do" actions created with the ticket.</summary>
    Public Property InitialActions As New List(Of String)
    ''' <summary>Also add the NEWCUST checklist from MDS_HelpDesk_Categories.</summary>
    Public Property AddNewCustomerChecklist As Boolean
End Class

Public Module Tickets

    Public Const SoftwareHandheld As Integer = 10
    Public Const SoftwareNewUser As Integer = 15
    Public Const SoftwareNewAccount As Integer = 16
    Public Const InternalAccount As String = "1000"

    ''' <summary>
    ''' Inserts the ticket and its initial actions in one transaction and returns the ticket number.
    ''' The next number is MAX(ID) + 1, taken under a range lock so two users cannot get the same one.
    ''' </summary>
    Public Function Create(t As NewTicket) As Integer
        Using cn = Db.Open(Db.MDS), tx = cn.BeginTransaction()
            Dim ticketId = CInt(Db.NewCommand(cn, tx,
                "SELECT ISNULL(MAX(ID), 0) + 1 FROM dbo.MDS_HelpDesk WITH (UPDLOCK, HOLDLOCK)").ExecuteScalar())

            Db.NewCommand(cn, tx,
                "INSERT INTO dbo.MDS_HelpDesk
                    (ID, AdditionalContact, AccountNo, DescriptionDetail, Priority, ProjectType, RequestBy, Status,
                     RequestDate, RequestedByDate, CadenceID, Software, UserID, ComputerNumber, OrderNumber)
                 VALUES
                    (@id, @addContact, @account, @desc, @priority, 1, @requestBy, 1,
                     GETDATE(), @dateNeeded, @cadence, @software, @userId, @computer, @order)",
                Db.P("@id", ticketId),
                Db.P("@addContact", t.AdditionalContact),
                Db.P("@account", t.AccountNo),
                Db.P("@desc", t.Description),
                Db.P("@priority", t.Priority),
                Db.P("@requestBy", t.RequestBy),
                Db.P("@dateNeeded", t.DateNeeded),
                Db.P("@cadence", t.CadenceID),
                Db.P("@software", t.Software),
                Db.P("@userId", t.UserID),
                Db.P("@computer", t.ComputerNumber),
                Db.P("@order", t.OrderNumber)).ExecuteNonQuery()

            For Each action In t.InitialActions
                Db.NewCommand(cn, tx,
                    "INSERT INTO dbo.MDS_HelpDesk_Actions (ID, Date, Description, Status)
                     VALUES (@id, CAST(GETDATE() AS date), @desc, 'To Do')",
                    Db.P("@id", ticketId), Db.P("@desc", action)).ExecuteNonQuery()
            Next

            If t.AddNewCustomerChecklist Then
                Db.NewCommand(cn, tx,
                    "INSERT INTO dbo.MDS_HelpDesk_Actions (ID, Date, Description, Status)
                     SELECT @id, CAST(GETDATE() AS date), Description, 'To Do'
                     FROM dbo.MDS_HelpDesk_Categories WHERE Category = 'NEWCUST'",
                    Db.P("@id", ticketId)).ExecuteNonQuery()
            End If

            Db.NewCommand(cn, tx,
                "UPDATE dbo.MDS_HelpDesk_Users SET Update_Date = GETDATE() WHERE ID = @id",
                Db.P("@id", t.RequestBy)).ExecuteNonQuery()

            tx.Commit()
            Return ticketId
        End Using
    End Function

End Module
