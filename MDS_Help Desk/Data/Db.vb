Imports Microsoft.Data.SqlClient

''' <summary>
''' Thin helpers around SqlClient. All SQL goes through parameters.
''' </summary>
Public Module Db

    Public Const MDS As String = "MDS"
    Public Const DC00MDS As String = "DC00MDS"

    Public Function Open(database As String) As SqlConnection
        Dim cn As New SqlConnection(AppConfig.ConnectionString(database))
        cn.Open()
        Return cn
    End Function

    Public Function Query(database As String, sql As String, ParamArray params() As SqlParameter) As DataTable
        Using cn = Open(database), cmd = NewCommand(cn, sql, params)
            Dim dt As New DataTable()
            Using rdr = cmd.ExecuteReader()
                dt.Load(rdr)
            End Using
            Return dt
        End Using
    End Function

    Public Function Scalar(database As String, sql As String, ParamArray params() As SqlParameter) As Object
        Using cn = Open(database), cmd = NewCommand(cn, sql, params)
            Dim result = cmd.ExecuteScalar()
            Return If(result Is DBNull.Value, Nothing, result)
        End Using
    End Function

    Public Function NewCommand(cn As SqlConnection, sql As String, ParamArray params() As SqlParameter) As SqlCommand
        Return NewCommand(cn, Nothing, sql, params)
    End Function

    Public Function NewCommand(cn As SqlConnection, tx As SqlTransaction, sql As String, ParamArray params() As SqlParameter) As SqlCommand
        Dim cmd As New SqlCommand(sql, cn, tx)
        If params IsNot Nothing Then cmd.Parameters.AddRange(params)
        Return cmd
    End Function

    ''' <summary>Creates a parameter, mapping Nothing to DBNull.</summary>
    Public Function P(name As String, value As Object) As SqlParameter
        Return New SqlParameter(name, If(value, DBNull.Value))
    End Function

End Module
