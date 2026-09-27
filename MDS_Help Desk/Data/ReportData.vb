''' <summary>Filters for the open tickets report (Print Tickets).</summary>
Public Class OpenTicketReportFilter
    ''' <summary>Requested on or after this date.</summary>
    Public Property RequestedFrom As Date?
    ''' <summary>Requested before this date.</summary>
    Public Property RequestedBefore As Date?
    Public Property AccountNo As String
    Public Property Priority As Integer?
    Public Property RequestBy As Integer?
    Public Property AssignedTo As Integer?
End Class

Public Module ReportData

    Private Const TicketColumns As String =
        "SELECT h.ID AS TicketNo, RTRIM(p.Description) AS Priority, h.DescriptionDetail, RTRIM(h.AccountNo) AS AccountNo,
                RTRIM(h.CadenceID) AS CadenceID, RTRIM(h.OrderNumber) AS OrderNumber, h.RequestDate, h.RequestedByDate,
                RTRIM(rq.UserName) AS RequestBy, RTRIM(s.Description) AS Software, RTRIM(a.UserName) AS AssignedTo,
                RTRIM(st.Description) AS Status, RTRIM(h.ComputerNumber) AS ComputerNumber, h.CloseDate, h.Notes
         FROM dbo.MDS_HelpDesk AS h
         LEFT JOIN dbo.MDS_HelpDesk_Categories AS p ON p.ID = h.Priority AND p.Category = 'Priority'
         LEFT JOIN dbo.MDS_HelpDesk_Categories AS s ON s.ID = h.Software AND s.Category = 'Software'
         LEFT JOIN dbo.MDS_HelpDesk_Categories AS st ON st.ID = h.Status AND st.Category = 'Status'
         LEFT JOIN dbo.MDS_HelpDesk_Users AS rq ON rq.ID = h.RequestBy
         LEFT JOIN dbo.MDS_HelpDesk_Users AS a ON a.ID = h.AssignedTo "

    Public Function OpenTickets(f As OpenTicketReportFilter) As DataTable
        Return Db.Query(Db.MDS,
            TicketColumns &
            "WHERE h.CloseDate IS NULL
               AND (@from IS NULL OR h.RequestDate >= @from)
               AND (@before IS NULL OR h.RequestDate < @before)
               AND (@account IS NULL OR h.AccountNo = @account)
               AND (@priority IS NULL OR h.Priority = @priority)
               AND (@requestBy IS NULL OR h.RequestBy = @requestBy)
               AND (@assignedTo IS NULL OR h.AssignedTo = @assignedTo)
             ORDER BY h.ID",
            Db.P("@from", f.RequestedFrom),
            Db.P("@before", f.RequestedBefore),
            Db.P("@account", f.AccountNo),
            Db.P("@priority", f.Priority),
            Db.P("@requestBy", f.RequestBy),
            Db.P("@assignedTo", f.AssignedTo))
    End Function

    ''' <summary>One ticket, open or closed, for Quick Print.</summary>
    Public Function Ticket(ticketId As Integer) As DataRow
        Dim dt = Db.Query(Db.MDS, TicketColumns & "WHERE h.ID = @id", Db.P("@id", ticketId))
        Return If(dt.Rows.Count > 0, dt.Rows(0), Nothing)
    End Function

    ''' <summary>Open tickets per account number.</summary>
    Public Function OpenCountsByAccount() As DataTable
        Return Db.Query(Db.MDS,
            "SELECT RTRIM(AccountNo) AS AccountNo, COUNT(*) AS Tickets
             FROM dbo.MDS_HelpDesk
             WHERE CloseDate IS NULL
             GROUP BY RTRIM(AccountNo)
             ORDER BY RTRIM(AccountNo)")
    End Function

    ''' <summary>Open tickets per priority.</summary>
    Public Function OpenCountsByPriority() As DataTable
        Return Db.Query(Db.MDS,
            "SELECT ISNULL(RTRIM(p.Description), '(no priority)') AS Priority, COUNT(*) AS Tickets
             FROM dbo.MDS_HelpDesk AS h
             LEFT JOIN dbo.MDS_HelpDesk_Categories AS p ON p.ID = h.Priority AND p.Category = 'Priority'
             WHERE h.CloseDate IS NULL
             GROUP BY p.ID, p.Description
             ORDER BY p.ID")
    End Function

End Module
