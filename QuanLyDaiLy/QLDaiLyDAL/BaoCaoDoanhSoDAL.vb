Imports System.Configuration
Imports System.Data.SqlClient
Imports QLDaiLyDTO
Imports Utility

Public Class BaoCaoDoanhSoDAL
    Private connectionString As String
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    ' lay ma dai ly
    Public Function buildMaBaoCaoDoanhSo(ByRef nextMaBCDoanhSo As Integer) As Result 'ex: 18222229

        Dim msOnDB As Integer
        Dim query As String = String.Empty
        query &= "SELECT IDENT_CURRENT('BAOCAODOANHSO')"


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
                    Return New Result(False, "Lấy tự động Mã số phieu xuat kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        query = String.Empty
        query &= "SELECT * FROM [BAOCAODOANHSO]"

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
                    Return New Result(False, "Lấy tự động Mã số phieu xuat kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        query = String.Empty
        query &= "SELECT * FROM [BAOCAODOANHSO]"
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
                        nextMaBCDoanhSo = 1 + msOnDB

                    Else
                        nextMaBCDoanhSo = 1
                    End If
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số phieu xuat kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        nextMaBCDoanhSo += 0
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(bc As BaoCaoDoanhSoDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [BAOCAODOANHSO] ([MaDaiLy],[SoPhieuXuat],[TongGiaTri],[TiLe])"
        query &= "VALUES (@MaDaiLy,@SoPhieuXuat,@TongGiaTri,@TiLe)"
        'get MSDG
        Dim nextMaBCDoanhSo = "1"
        buildMaBaoCaoDoanhSo(nextMaBCDoanhSo)
        bc.MaBaoCaoDoanhSo = nextMaBCDoanhSo

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    '.Parameters.AddWithValue("@madg", dg.MaDG)
                    .Parameters.AddWithValue("@MaDaiLy", bc.MaDaiLy)
                    .Parameters.AddWithValue("@SoPhieuXuat", bc.SoPhieuXuat)
                    .Parameters.AddWithValue("@TongGiaTri", bc.TongGiaTri)
                    .Parameters.AddWithValue("@TiLe", bc.TiLe)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm phieu xuat không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(bc As BaoCaoDoanhSoDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [BAOCAODOANHSO] SET"
        'query &= " [MaPhieuXuat] = @MaPhieuXuat "
        query &= " [MaDaiLy] = @MaDaiLy "
        query &= " ,[SoPhieuXuat] = @SoPhieuXuat "
        query &= " ,[TongGiaTri] = @TongGiaTri "
        query &= " ,[TiLe] = @TiLe "
        query &= " WHERE "
        query &= " [MaBaoCaoDoanhSo] = @MaBaoCaoDoanhSo "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@MaDaiLy", bc.MaDaiLy)
                    .Parameters.AddWithValue("@SoPhieuXuat", bc.SoPhieuXuat)
                    .Parameters.AddWithValue("@TongGiaTri", bc.TongGiaTri)
                    .Parameters.AddWithValue("@TiLe", bc.TiLe)
                    .Parameters.AddWithValue("@MaBaoCaoDoanhSo", bc.MaBaoCaoDoanhSo)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật phieu xuat không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function delete(maBCDoanhSo As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [BAOCAODOANHSO] "
        query &= " WHERE "
        query &= " [MaBaoCaoDoanhSo] = @MaBaoCaoDoanhSo "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaBaoCaoDoanhSo", maBCDoanhSo)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa phieu xuat không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function



    Public Function selectALL(ByRef listBCDoanhSo As List(Of BaoCaoDoanhSoDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaBaoCaoDoanhSo], [MaDaiLy], [SoPhieuXuat], [TongGiaTri], [TiLe]"
        query &= "FROM [BAOCAODOANHSO]"


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
                        listBCDoanhSo.Clear()
                        While reader.Read()
                            listBCDoanhSo.Add(New BaoCaoDoanhSoDTO(reader("MaBaoCaoDoanhSo"), reader("MaDaiLy"), reader("SoPhieuXuat"), reader("TongGiaTri"), reader("TiLe")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả phieu xuat không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function




    Public Function selectALL_ByMaDaiLy(madl As Integer, ByRef listBCDoanhSo As List(Of BaoCaoDoanhSoDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaBaoCaoDoanhSo], [MaDaiLy], [SoPhieuXuat], [TongGiaTri], [TiLe]"
        query &= "FROM [BAOCAODOANHSO] "
        query &= "WHERE [MaDaiLy] = @MaDaiLy "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDaiLy", madl)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listBCDoanhSo.Clear()
                        While reader.Read()
                            listBCDoanhSo.Add(New BaoCaoDoanhSoDTO(reader("MaBaoCaoDoanhSo"), reader("MaDaiLy"), reader("SoPhieuXuat"), reader("TongGiaTri"), reader("TiLe")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả dai li theo ma dai ly không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

End Class
