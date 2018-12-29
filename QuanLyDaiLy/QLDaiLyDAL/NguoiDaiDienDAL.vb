Imports System.Configuration
Imports System.Data.SqlClient
Imports QLDaiLyDTO
Imports Utility

Public Class NguoiDaiDienDAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")

    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildMaNguoiDaiDien(ByRef nextMaNguoiDaiDien As Integer) As Result 'ex: 18222229   
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaNguoiDaiDien] "
        query &= "FROM [NGUOIDAIDIEN] "
        query &= "ORDER BY [MaNguoiDaiDien] DESC "
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
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("MaNguoiDaiDien")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextMaNguoiDaiDien = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextMaNguoiDaiDien = 1
                    Return New Result(False, "Lấy ID kế tiếp của người đại diện không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(nguoidaidien As NguoiDaiDienDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [NGUOIDAIDIEN] ([MaNguoiDaiDien], [TenNguoiDaiDien], [SoDT],[CMND],[DiaChi])"
        query &= "VALUES (@MaNguoiDaiDien,@TenNguoiDaiDien,@SoDT,@CMND,@DiaChi)"

        Dim nextID = 0
        Dim result As Result
        result = buildMaNguoiDaiDien(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        nguoidaidien.MaNguoiDaiDien = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaNguoiDaiDien", nguoidaidien.MaNguoiDaiDien)
                    .Parameters.AddWithValue("@TenNguoiDaiDien", nguoidaidien.TenNguoiDaiDien)
                    .Parameters.AddWithValue("@SoDT", nguoidaidien.SoDT)
                    .Parameters.AddWithValue("@CMND", nguoidaidien.CMND)
                    .Parameters.AddWithValue("@DiaChi", nguoidaidien.DiaChi)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm người đại diện không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listNguoiDaiDien As List(Of NguoiDaiDienDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [MaNguoiDaiDien], [TenNguoiDaiDien], [SoDT], [CMND],[DiaChi]"
        query &= "FROM [NGUOIDAIDIEN]"


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
                        listNguoiDaiDien.Clear()
                        While reader.Read()
                            listNguoiDaiDien.Add(New NguoiDaiDienDTO(reader("MaNguoiDaiDien"), reader("TenNguoiDaiDien"), reader("SoDT"), reader("CMND"), reader("DiaChi")))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả người đại diện không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(maNguoiDaiDien As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [NGUOIDAIDIEN] "
        query &= " WHERE "
        query &= " [MaNguoiDaiDien] = @MaNguoiDaiDien "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaNguoiDaiDien", maNguoiDaiDien)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa người đại diện không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(lndd As NguoiDaiDienDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [NGUOIDAIDIEN] SET"
        query &= " [TenNguoiDaiDien] = @TenNguoiDaiDien"
        query &= ", [SoDT] = @SoDT"
        query &= ", [CMND] = @CMND"
        query &= ", [DiaChi] = @DiaChi"
        query &= " WHERE "
        query &= " [MaNguoiDaiDien] = @MaNguoiDaiDien "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaNguoiDaiDien", lndd.MaNguoiDaiDien)
                    .Parameters.AddWithValue("@TenNguoiDaiDien", lndd.TenNguoiDaiDien)
                    .Parameters.AddWithValue("@SoDT", lndd.SoDT)
                    .Parameters.AddWithValue("@CMND", lndd.CMND)
                    .Parameters.AddWithValue("@DiaChi", lndd.DiaChi)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật người đại diện không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_no(ByRef listNguoiDaiDien As List(Of NguoiDaiDienDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT DISTINCT [NGUOIDAIDIEN].[MaNguoiDaiDien], [TenNguoiDaiDien],[SoDT],[CMND],[DiaChi]"
        query &= "FROM [NGUOIDAIDIEN], [DAILY]"
        query &= "WHERE [NGUOIDAIDIEN].[MaNguoiDaiDien] = [DAILY].[MaNguoiDaiDien]"

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
                        listNguoiDaiDien.Clear()
                        While reader.Read()
                            listNguoiDaiDien.Add(New NguoiDaiDienDTO(reader("MaNguoiDaiDien"), reader("TenNguoiDaiDien"), reader("SoDT"), reader("CMND"), reader("DiaChi")))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả người đại diện không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

End Class
