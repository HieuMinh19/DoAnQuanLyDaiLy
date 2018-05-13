Imports System.Configuration
Imports System.Data.SqlClient
Imports QLDaiLyDTO

Imports Utility


Public Class LoaiDlDAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")

    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function selectALL(ByRef listDaiLy As List(Of LoaiDLDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [MaLoaiDL], [TenLoaiDL]"
        query &= "FROM [LoaiDL]"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listDaiLy.Clear()
                        While reader.Read()
                            listDaiLy.Add(New LoaiDLDTO(reader("MaLoaiDL"), reader("TenLoaiDL")))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả loai không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
