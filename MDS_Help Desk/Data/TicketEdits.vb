Imports Microsoft.Data.SqlClient

''' <summary>Filters for the Edit Tickets list.</summary>
Public Class TicketFilter
    Public Enum StatusFilter
        All = 0
        Open = 1
        Closed = 2
    End Enum

    Public Enum AssignedFilter
        Any = 0
        Assigned = 1
        NotAssigned = 2
    End Enum

    Public Property Status As StatusFilter = StatusFilter.Open
    Public Property Assigned As AssignedFilter = AssignedFilter.Any
    Public Property AccountNo As String
    Public Property RequestBy As Integer?
    Public Property Priority As Integer?
    ''' <summary>Ticket numbers starting with this text.</summary>
    Public Property TicketStartsWith As String
End Class

''' <summary>An existing ticket as edited on the Edit Tickets form.</summary>
Public Class TicketDetail
    Public Property UniqueKey As Integer
    Public Property ID As Integer
    Public Property RowVersion As Byte()
    Public Property AccountNo As String
    Public Property RequestBy As Integer?
    Public Property AdditionalContact As Integer?
    Public Property Status As Integer?
    Public Property Priority As Integer?
    Public Property Software As Integer?
    Public Property AssignedTo As Integer?
    Public Property AssignedTier As Integer?
    Public Property ResolutionType As Integer?
    Public Property RequestDate As Date?
    Public Property RequestedByDate As Date?
    Public Property CloseDate As Date?
    Public Property AutoCloseDate As Date?
    Public Property CadenceID As String
    Public Property OrderNumber As String
    Public Property ComputerNumber As String
    Public Property Description As String
    Public Property Notes As String
End Class

''' <summary>Raised when someone else saved the ticket after it was loaded.</summary>
Public Class TicketChangedException
    Inherits Exception

    Public Sub New(ticketId As Integer)
        MyBase.New($"Ticket {ticketId} was changed by someone else after you opened it. Reload the ticket and make your changes again.")
    End Sub
End Class

Public Module TicketEdits

    Public Function Search(f As TicketFilter) As DataTable
        Return Db.Query(Db.MDS,
            "SELECT h.ID,
                    RTRIM(u1.UserName) AS RequestedBy,
                    RTRIM(h.AccountNo) AS AccountNo,
                    h.DescriptionDetail AS Description,
                    RTRIM(p.Description) AS Priority,
                    h.RequestDate,
                    h.RequestedByDate AS NeedBy,
                    RTRIM(u2.UserName) AS AssignedTo,
                    h.CloseDate
             FROM dbo.MDS_HelpDesk AS h
             LEFT JOIN dbo.MDS_HelpDesk_Users AS u1 ON u1.ID = h.RequestBy
             LEFT JOIN dbo.MDS_HelpDesk_Users AS u2 ON u2.ID = h.AssignedTo
             LEFT JOIN dbo.MDS_HelpDesk_Categories AS p ON p.ID = h.Priority AND p.Category = 'Priority'
             WHERE (@status = 0 OR (@status = 1 AND h.CloseDate IS NULL) OR (@status = 2 AND h.CloseDate IS NOT NULL))
               AND (@assigned = 0 OR (@assigned = 1 AND h.AssignedTo IS NOT NULL) OR (@assigned = 2 AND h.AssignedTo IS NULL))
               AND (@account IS NULL OR h.AccountNo = @account)
               AND (@requestBy IS NULL OR h.RequestBy = @requestBy)
               AND (@priority IS NULL OR h.Priority = @priority)
               AND (@ticket IS NULL OR CAST(h.ID AS varchar(12)) LIKE @ticket + '%')
             ORDER BY h.ID",
            Db.P("@status", CInt(f.Status)),
            Db.P("@assigned", CInt(f.Assigned)),
            Db.P("@account", f.AccountNo),
            Db.P("@requestBy", f.RequestBy),
            Db.P("@priority", f.Priority),
            Db.P("@ticket", f.TicketStartsWith))
    End Function

    Public Function OpenCount() As Integer
        Return CInt(Db.Scalar(Db.MDS, "SELECT COUNT(*) FROM dbo.MDS_HelpDesk WHERE CloseDate IS NULL"))
    End Function

    ''' <summary>Loads a ticket by ticket number, or Nothing if it does not exist.</summary>
    Public Function Load(ticketId As Integer) As TicketDetail
        Dim dt = Db.Query(Db.MDS,
            "SELECT TOP 1 UniqueKey, ID, [Timestamp], RTRIM(AccountNo) AS AccountNo, RequestBy, AdditionalContact, Status,
                    Priority, Software, AssignedTo, AssignedTier, ResolutionType, RequestDate, RequestedByDate,
                    CloseDate, AutoCloseDate, RTRIM(CadenceID) AS CadenceID, RTRIM(OrderNumber) AS OrderNumber,
                    RTRIM(ComputerNumber) AS ComputerNumber, DescriptionDetail, Notes
             FROM dbo.MDS_HelpDesk WHERE ID = @id",
            Db.P("@id", ticketId))
        If dt.Rows.Count = 0 Then Return Nothing
        Dim r = dt.Rows(0)
        Return New TicketDetail With {
            .UniqueKey = CInt(r("UniqueKey")),
            .ID = CInt(r("ID")),
            .RowVersion = DirectCast(r("Timestamp"), Byte()),
            .AccountNo = AsString(r("AccountNo")),
            .RequestBy = AsInt(r("RequestBy")),
            .AdditionalContact = AsInt(r("AdditionalContact")),
            .Status = AsInt(r("Status")),
            .Priority = AsInt(r("Priority")),
            .Software = AsInt(r("Software")),
            .AssignedTo = AsInt(r("AssignedTo")),
            .AssignedTier = AsInt(r("AssignedTier")),
            .ResolutionType = AsInt(r("ResolutionType")),
            .RequestDate = AsDate(r("RequestDate")),
            .RequestedByDate = AsDate(r("RequestedByDate")),
            .CloseDate = AsDate(r("CloseDate")),
            .AutoCloseDate = AsDate(r("AutoCloseDate")),
            .CadenceID = AsString(r("CadenceID")),
            .OrderNumber = AsString(r("OrderNumber")),
            .ComputerNumber = AsString(r("ComputerNumber")),
            .Description = AsString(r("DescriptionDetail")),
            .Notes = AsString(r("Notes"))
        }
    End Function

    ''' <summary>Saves the editable fields (Update Ticket).</summary>
    Public Sub Save(t As TicketDetail)
        Execute(t, "")
    End Sub

    ''' <summary>Saves the editable fields and closes the ticket (Close Ticket).</summary>
    Public Sub Close(t As TicketDetail)
        Execute(t, ", CloseDate = GETDATE()")
    End Sub

    ''' <summary>Clears the close date and resolution (Re-Open Ticket).</summary>
    Public Sub Reopen(t As TicketDetail)
        Using cn = Db.Open(Db.MDS),
              cmd = Db.NewCommand(cn,
                "UPDATE dbo.MDS_HelpDesk SET CloseDate = NULL, ResolutionType = NULL
                 WHERE UniqueKey = @key AND [Timestamp] = @rv",
                Db.P("@key", t.UniqueKey), RowVersionParam(t))
            If cmd.ExecuteNonQuery() = 0 Then Throw New TicketChangedException(t.ID)
        End Using
    End Sub

    Private Sub Execute(t As TicketDetail, extraSet As String)
        Using cn = Db.Open(Db.MDS),
              cmd = Db.NewCommand(cn,
                "UPDATE dbo.MDS_HelpDesk SET
                    AccountNo = @account, RequestBy = @requestBy, AdditionalContact = @addContact,
                    Status = @status, Priority = @priority, Software = @software, AssignedTo = @assignedTo,
                    AssignedTier = @tier, ResolutionType = @resolution, RequestDate = @requestDate,
                    RequestedByDate = @needBy, AutoCloseDate = @autoClose, CadenceID = @cadence,
                    OrderNumber = @order, ComputerNumber = @computer, DescriptionDetail = @desc, Notes = @notes" &
                 extraSet & "
                 WHERE UniqueKey = @key AND [Timestamp] = @rv",
                Db.P("@account", t.AccountNo),
                Db.P("@requestBy", t.RequestBy),
                Db.P("@addContact", t.AdditionalContact),
                Db.P("@status", t.Status),
                Db.P("@priority", t.Priority),
                Db.P("@software", t.Software),
                Db.P("@assignedTo", t.AssignedTo),
                Db.P("@tier", t.AssignedTier),
                Db.P("@resolution", t.ResolutionType),
                Db.P("@requestDate", t.RequestDate),
                Db.P("@needBy", t.RequestedByDate),
                Db.P("@autoClose", t.AutoCloseDate),
                Db.P("@cadence", t.CadenceID),
                Db.P("@order", t.OrderNumber),
                Db.P("@computer", t.ComputerNumber),
                Db.P("@desc", t.Description),
                Db.P("@notes", t.Notes),
                Db.P("@key", t.UniqueKey),
                RowVersionParam(t))
            If cmd.ExecuteNonQuery() = 0 Then Throw New TicketChangedException(t.ID)
        End Using
    End Sub

    Private Function RowVersionParam(t As TicketDetail) As SqlParameter
        Return New SqlParameter("@rv", SqlDbType.Timestamp) With {.Value = t.RowVersion}
    End Function

    ''' <summary>Order status of a Cadence order, or Nothing.</summary>
    Public Function CadenceOrderStatus(cadenceId As String) As String
        Dim result = Db.Scalar(Db.MDS,
            "SELECT TOP 1 RTRIM(Order_Status) FROM dbo.vw_Cadence_Orders WHERE Order_ID = @id",
            Db.P("@id", cadenceId))
        Return If(result Is Nothing, Nothing, result.ToString())
    End Function

    Private Function AsString(value As Object) As String
        If value Is DBNull.Value Then Return Nothing
        Return value.ToString()
    End Function

    Private Function AsInt(value As Object) As Integer?
        If value Is DBNull.Value Then Return Nothing
        Return Convert.ToInt32(value)
    End Function

    Private Function AsDate(value As Object) As Date?
        If value Is DBNull.Value Then Return Nothing
        Return CDate(value)
    End Function

End Module
