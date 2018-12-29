Imports QLDaiLyDAL
Imports QLDaiLyDTO
Imports Utility

Public Class NguoiDaiDienBUS
    Private nguoidaidienDAL As NguoiDaiDienDAL
    Public Sub New()
        nguoidaidienDAL = New NguoiDaiDienDAL()
    End Sub
    Public Sub New(connectionString As String)
        nguoidaidienDAL = New NguoiDaiDienDAL(connectionString)
    End Sub

    Public Function insert(nguoidaidien As NguoiDaiDienDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nguoidaidienDAL.insert(nguoidaidien)
    End Function

    Public Function buildMaNguoiDaiDien(ByRef nextManguoiDaiDien As Integer) As Result
        Return nguoidaidienDAL.buildMaNguoiDaiDien(nextManguoiDaiDien)
    End Function
    Public Function selectAll(ByRef listnguoidaidien As List(Of NguoiDaiDienDTO)) As Result


        Return nguoidaidienDAL.selectALL(listnguoidaidien)
    End Function

    Public Function update(lq As NguoiDaiDienDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nguoidaidienDAL.update(lq)
    End Function
    Public Function delete(manguoidaidien As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nguoidaidienDAL.delete(manguoidaidien)
    End Function



    Public Function selectAll_no(ByRef listnguoidaidien As List(Of NguoiDaiDienDTO)) As Result

        Return nguoidaidienDAL.selectALL_no(listnguoidaidien)
    End Function

End Class
