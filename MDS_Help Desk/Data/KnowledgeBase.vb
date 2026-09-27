''' <summary>A row of dbo.MDS_HelpDesk_Knowledge.</summary>
Public Class KnowledgeEntry
    Public Property RecordNo As Integer?
    Public Property Process As String
    Public Property ErrorText As String
    Public Property Workaround As String
    Public Property Entered As Date?
End Class

Public Module KnowledgeBase

    Public Function Processes() As DataTable
        Return Db.Query(Db.MDS,
            "SELECT DISTINCT RTRIM(Process) AS Value, RTRIM(Process) AS Display
             FROM dbo.MDS_HelpDesk_Knowledge
             WHERE Process IS NOT NULL AND RTRIM(Process) <> ''
             ORDER BY Value")
    End Function

    ''' <summary>Entries for a process (optional) whose problem or solution contains the key word (optional).</summary>
    Public Function Search(process As String, keyword As String) As DataTable
        Return Db.Query(Db.MDS,
            "SELECT RecordNo, RTRIM(Process) AS Process, Entered, Error, Workaround
             FROM dbo.MDS_HelpDesk_Knowledge
             WHERE (@process IS NULL OR Process = @process)
               AND (@keyword IS NULL OR Error LIKE '%' + @keyword + '%' OR Workaround LIKE '%' + @keyword + '%')
             ORDER BY Process, RecordNo DESC",
            Db.P("@process", process), Db.P("@keyword", EscapeLike(keyword)))
    End Function

    Public Function Load(recordNo As Integer) As KnowledgeEntry
        Dim dt = Db.Query(Db.MDS,
            "SELECT RecordNo, RTRIM(Process) AS Process, Entered, Error, Workaround
             FROM dbo.MDS_HelpDesk_Knowledge WHERE RecordNo = @id",
            Db.P("@id", recordNo))
        If dt.Rows.Count = 0 Then Return Nothing
        Dim r = dt.Rows(0)
        Return New KnowledgeEntry With {
            .RecordNo = CInt(r("RecordNo")),
            .Process = If(r("Process") Is DBNull.Value, Nothing, r("Process").ToString()),
            .ErrorText = If(r("Error") Is DBNull.Value, Nothing, r("Error").ToString()),
            .Workaround = If(r("Workaround") Is DBNull.Value, Nothing, r("Workaround").ToString()),
            .Entered = If(r("Entered") Is DBNull.Value, CType(Nothing, Date?), CDate(r("Entered")))
        }
    End Function

    ''' <summary>Adds a new entry and returns its record number.</summary>
    Public Function Insert(e As KnowledgeEntry) As Integer
        Return CInt(Db.Scalar(Db.MDS,
            "INSERT INTO dbo.MDS_HelpDesk_Knowledge (Process, Error, Workaround, Entered)
             VALUES (@process, @error, @workaround, @entered);
             SELECT CAST(SCOPE_IDENTITY() AS int);",
            Db.P("@process", e.Process), Db.P("@error", e.ErrorText),
            Db.P("@workaround", e.Workaround), Db.P("@entered", e.Entered)))
    End Function

    Public Sub Update(e As KnowledgeEntry)
        Using cn = Db.Open(Db.MDS),
              cmd = Db.NewCommand(cn,
                "UPDATE dbo.MDS_HelpDesk_Knowledge
                 SET Process = @process, Error = @error, Workaround = @workaround, Entered = @entered
                 WHERE RecordNo = @id",
                Db.P("@process", e.Process), Db.P("@error", e.ErrorText),
                Db.P("@workaround", e.Workaround), Db.P("@entered", e.Entered), Db.P("@id", e.RecordNo))
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ''' <summary>Makes %, _ and [ in a key word match literally.</summary>
    Private Function EscapeLike(value As String) As String
        If String.IsNullOrWhiteSpace(value) Then Return Nothing
        Return value.Trim().Replace("[", "[[]").Replace("%", "[%]").Replace("_", "[_]")
    End Function

End Module
