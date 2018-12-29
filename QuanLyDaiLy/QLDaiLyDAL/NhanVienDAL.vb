Imports System.Configuration
Imports System.Data.SqlClient
Imports QLDaiLyDTO
Imports Utility

Public Class NhanVienDAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")

    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function builMaNV(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaNV] "
        query &= "FROM [NHANVIEN] "
        query &= "ORDER BY [MaNV] DESC "

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
                            idOnDB = reader("MaNV")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của Nhan Vien không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function insert(nhanvien As NhanVienDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [NHANVIEN] ([MaNV],[HoTen],[CMND],[SoDT],[DiaChi],[MaCV],[MaDL])"
        query &= "VALUES (@MaNhanVien,@HoTen,@CMND,@SoDienThoai,@DiaChi,@MaChucVu,@MaDaiLy)"

        Dim nextID = 0
        Dim result As Result
        result = builMaNV(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        nhanvien.MaNhanVien = nextID
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaNhanVien", nhanvien.MaNhanVien)
                    .Parameters.AddWithValue("@HoTen", nhanvien.HoTenNhanVien)
                    .Parameters.AddWithValue("@CMND", nhanvien.CMND)
                    .Parameters.AddWithValue("@SoDienThoai", nhanvien.SoDienThoai)
                    .Parameters.AddWithValue("@DiaChi", nhanvien.DiaChi)
                    .Parameters.AddWithValue("@MaChucVu", nhanvien.MaChucVu)
                    .Parameters.AddWithValue("@MaDaiLy", nhanvien.MaDaiLy)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm nhân viên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_ByMaDaiLy(maDL As Integer, ByRef listNV As List(Of NhanVienDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaNV],[HoTen],[CMND],[SoDT],[DiaChi],[MaCV],[MaDL]"
        query &= "FROM [NHANVIEN] "
        query &= "WHERE [MaDL] = @MaDL "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDL", maDL)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listNV.Clear()
                        While reader.Read()
                            listNV.Add(New NhanVienDTO(reader("MaNV"), reader("HoTen"), reader("CMND"), reader("SoDT"), reader("DiaChi"), reader("MaCV"), reader("MaDL")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả nhân viên theo đại lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(nv As NhanVienDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [NHANVIEN] SET"
        query &= " [SoDT] = @SoDT "
        query &= " ,[DiaChi] = @DiaChi "
        query &= " ,[MaCV] = @MaCV "
        query &= " ,[MaDL] = @MaDL "
        query &= " WHERE "
        query &= " [MaNV] = @MaNV "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@SoDT", nv.SoDienThoai)
                    .Parameters.AddWithValue("@DiaChi", nv.DiaChi)
                    .Parameters.AddWithValue("@MaCV", nv.MaChucVu)
                    .Parameters.AddWithValue("@MaDL", nv.MaDaiLy)
                    .Parameters.AddWithValue("@MaNV", nv.MaNhanVien)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật nhân viên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function



    Public Function delete(maNhanVien As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [NHANVIEN] "
        query &= " WHERE "
        query &= " [MaNV] = @MaNV "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaNV", maNhanVien)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa nhân viên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function

End Class
