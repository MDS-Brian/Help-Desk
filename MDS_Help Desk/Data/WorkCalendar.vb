''' <summary>
''' Due-date rules from frmHelpDesk_New, using dbo.Calendar (DW = day of week, IsWorkDay).
''' </summary>
Public Module WorkCalendar

    ''' <summary>Day of week from dbo.Calendar (1 = Sunday); falls back to .NET if the date is missing.</summary>
    Public Function DayOfWeekNumber(day As Date) As Integer
        Dim result = Db.Scalar(Db.MDS, "SELECT TOP 1 DW FROM dbo.Calendar WHERE DT = @dt", Db.P("@dt", day.Date))
        If result Is Nothing Then Return CInt(day.DayOfWeek) + 1
        Return CInt(result)
    End Function

    ''' <summary>First work day after the given date.</summary>
    Public Function NextWorkDay(after As Date) As Date
        Dim result = Db.Scalar(Db.MDS,
            "SELECT MIN(DT) FROM dbo.Calendar WHERE DT > @dt AND IsWorkDay = 1",
            Db.P("@dt", after.Date))
        If result Is Nothing Then Return after.Date.AddDays(1)
        Return CDate(result).Date
    End Function

    ''' <summary>Date needed for a priority (txtPriority_LostFocus).</summary>
    Public Function DueDateForPriority(priority As Integer, now As Date) As Date
        Select Case priority
            Case 10
                Return now.AddHours(1)
            Case 20
                If now.TimeOfDay >= New TimeSpan(13, 0, 0) Then
                    Return NextWorkDay(now).AddHours(10)
                End If
                Return now.AddHours(4)
            Case 30
                Return now.AddDays((NextWorkDay(now) - now.Date).TotalDays)
            Case 40
                Return now.AddDays(3)
            Case 50
                Return now.Date.AddDays(7)
            Case 60
                Return now.Date.AddMonths(1)
            Case Else
                Return now.Date.AddMonths(6)
        End Select
    End Function

    ''' <summary>Date needed for a new account setup ticket (Frame79 = 1).</summary>
    Public Function DueDateForNewAccount(today As Date) As Date
        Select Case DayOfWeekNumber(today)
            Case 4 : Return today.Date.AddDays(8)
            Case 5 : Return today.Date.AddDays(7)
            Case 6 : Return today.Date.AddDays(6)
            Case 7 : Return today.Date.AddDays(5)
            Case Else : Return today.Date.AddDays(9)
        End Select
    End Function

    ''' <summary>Date needed for a new user setup ticket (Frame79 = 2).</summary>
    Public Function DueDateForNewUser(today As Date) As Date
        Select Case DayOfWeekNumber(today)
            Case 4 : Return today.Date.AddDays(5)
            Case 5, 6, 7 : Return today.Date.AddDays(4)
            Case Else : Return today.Date.AddDays(3)
        End Select
    End Function

End Module
