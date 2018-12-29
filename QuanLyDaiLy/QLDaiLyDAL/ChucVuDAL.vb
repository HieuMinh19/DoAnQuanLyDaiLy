Imports System.Configuration
Imports System.Data.SqlClient
Imports QLDaiLyDTO
Imports Utility

Public Class ChucVuDAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")

    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    ' lay ma dai ly
    Public Function buildMaCV(ByRef nextMaCV As Integer) As Result 'ex: 18222229

        Dim msOnDB As Integer
        Dim query As String = String.Empty
        query &= "SELECT IDENT_CURRENT('CHUCVU')"


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
                    'Dim msOnDB As String
                    'msOnDB = Nothing

                    If reader.HasRows = True Then
                        While reader.Read()
                            'msOnDB = reader("madg")
                            msOnDB = Convert.ToInt32(reader.GetValue(0))

                        End While
                    End If
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số chức vụ kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        query = String.Empty
        query &= "SELECT * FROM [CHUCVU]"

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
                        While reader.Read()
                            msOnDB = Convert.ToInt32(reader.GetValue(0))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số chức vụ kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        query = String.Empty
        query &= "SELECT * FROM [CHUCVU]"
        'neu has row thi nextMsdg = "SELECT IDENT_CURRENT('DOCGIA')" + 1
        'neu khong co row thì next Msdg = 1;
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
                        nextMaCV = 1 + msOnDB

                    Else
                        nextMaCV = 1
                    End If
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số chức vụ kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        nextMaCV += 0
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listChucVu As List(Of ChucVuDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaCV], [TenCV]"
        query &= "FROM [CHUCVU]"


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
                        listChucVu.Clear()
                        While reader.Read()
                            listChucVu.Add(New ChucVuDTO(reader("MaCV"), reader("TenCV")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả chức vụ không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

End Class

