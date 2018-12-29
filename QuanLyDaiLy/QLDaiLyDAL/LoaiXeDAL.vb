Imports System.Configuration
Imports System.Data.SqlClient
Imports QLDaiLyDTO
Imports Utility



Public Class LoaiXeDAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")

    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildMaXe(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaXe] "
        query &= "FROM [LOAIXE] "
        query &= "ORDER BY [MaXe] DESC "

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
                            idOnDB = reader("MaXe")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của lOAI XE không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function insert(loaixe As LoaiXeDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [LOAIXE] ([MaXe], [TenXe],[SoLuongTon],[DonGia])"
        query &= "VALUES (@MaXe,@TenXe,@SoLuongTon,@DonGia)"

        Dim nextID = 0
        Dim result As Result
        result = buildMaXe(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        loaixe.MaXe = nextID
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaXe", loaixe.MaXe)
                    .Parameters.AddWithValue("@TenXe", loaixe.TenXe)
                    .Parameters.AddWithValue("@SoLuongTon", loaixe.SoLuongTon)
                    .Parameters.AddWithValue("@DonGia", loaixe.IDonGia1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm loaixe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listloaixe As List(Of LoaiXeDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaXe], [TenXe],[SoLuongTon],[DonGia]"
        query &= "FROM [LOAIXE]"
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
                        listloaixe.Clear()
                        While reader.Read()
                            listloaixe.Add(New LoaiXeDTO(reader("MaXe"), reader("TenXe"), reader("SoLuongTon"), reader("DonGia")))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả loai xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maXe As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [LOAIXE] "
        query &= " WHERE "
        query &= " [MaXe] = @MaXe "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaXe", maXe)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa loai xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(loaixe As LoaiXeDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [LOAIXE] SET"
        query &= " [TenXe] = @TenXe "
        query &= ", [SoLuongTon] = @SoLuongTon "
        query &= ", [DonGia] = @DonGia "
        query &= "WHERE "
        query &= " [MaXe]= @MaXe "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaXe", loaixe.MaXe)
                    .Parameters.AddWithValue("@TenXe", loaixe.TenXe)
                    .Parameters.AddWithValue("@SoLuongTon", loaixe.SoLuongTon)
                    .Parameters.AddWithValue("@DonGia", loaixe.IDonGia1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật loai xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function countsoloaixe(ByRef soloaixe As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT COUNT ([MaXe])"
        query &= "As [SoLuong] "
        query &= "FROM [LOAIXE] "


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim sqlReader As SqlDataReader = comm.ExecuteReader()
                    While sqlReader.Read()
                        soloaixe = sqlReader("SoLuong")
                    End While
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectSoloaixe_thamso(ByRef somathangtoida As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT [SoLoaiXe]"
        query &= "FROM [THAMSO] "
        ' query &= "WHERE [MaDL] = @MaDaiLy "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    '.Parameters.AddWithValue("@MaDaiLy", madl)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        'NoCuaDaiLy.Clear()
                        While reader.Read()
                            somathangtoida = reader("SoLoaiXe")
                            'listPhieuThuTien.Add(New PhieuThuTienDTO(reader("MaPhieuThu"), reader("MaDaiLy"), reader("NgayThuTien"), reader("SoTienThu")))
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
