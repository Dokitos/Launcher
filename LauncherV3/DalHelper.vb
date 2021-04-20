Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class DalHelper

    Private Shared Function GetDbConnection() As MySqlConnection
        Try
            Dim conString As String = ConfigurationManager.ConnectionStrings("conexaoMySql").ConnectionString
            Dim connection As MySqlConnection = New MySqlConnection(conString)
            connection.Open()
            Return connection
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ExecuteReader(ByVal sql As String) As IDataReader
        Dim reader As IDataReader = Nothing
        Using connection As MySqlConnection = GetDbConnection()
            Try
                Using command As New MySqlCommand(sql, connection)
                    reader = command.ExecuteReader()
                    Return reader
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Using
    End Function

    Public Shared Function ExecuteDataSet(ByVal sql As String) As DataSet
        Dim ds As DataSet = Nothing
        Using connection As MySqlConnection = GetDbConnection()
            Try
                Using Command As New MySqlCommand(sql, connection)
                    ds = ExecuteDataSet()
                End Using
            Catch ex As Exception
                Throw
            End Try
            Return ds
        End Using
    End Function
    Public Shared Function ExecuteDataSet() As DataSet
        Dim da As MySqlDataAdapter = Nothing
        Dim cmd As IDbCommand = New MySqlCommand()
        Dim ds As DataSet = Nothing
        Try
            da = New MySqlDataAdapter()
            da.SelectCommand = CType(cmd, MySqlCommand)
            ds = New DataSet()
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function

    Public Overloads Shared Function GetDataTable(ByVal sql As String) As DataTable
        Using connection As MySqlConnection = GetDbConnection()
            Using da As New MySqlDataAdapter(sql, connection)
                Dim table As New DataTable
                da.Fill(table)
                Return table
            End Using
        End Using
    End Function

End Class
