Imports QLDaiLyBUS
Imports QLDaiLyDAL
Imports QLDaiLyDTO
Imports Utility
Public Class BaoCaoDoanhSoBUS
    Private bcdoanhsoDal As BaoCaoDoanhSoDAL
    Public Sub New()
        bcdoanhsoDal = New BaoCaoDoanhSoDAL()
    End Sub
    Public Sub New(connectionString As String)
        bcdoanhsoDal = New BaoCaoDoanhSoDAL(connectionString)
    End Sub


    Public Function insert(bc As BaoCaoDoanhSoDTO) As Result
        '1. verify data here!!
        Return bcdoanhsoDal.insert(bc)

        'Return New Result(False )
    End Function


    Public Function buildMaBaoCaoDoanhSo(ByRef nextMaBCDoanhSo As Integer) As Result
        Return bcdoanhsoDal.buildMaBaoCaoDoanhSo(nextMaBCDoanhSo)
    End Function
    Public Function selectAll(ByRef listMaDaiLy As List(Of BaoCaoDoanhSoDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bcdoanhsoDal.selectALL(listMaDaiLy)
    End Function

    Public Function selectALL_ByMaDaiLy(madaili As Integer, ByRef listDL As List(Of BaoCaoDoanhSoDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bcdoanhsoDal.selectALL_ByMaDaiLy(madaili, listDL)
    End Function


    Public Function delete(px As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bcdoanhsoDal.delete(px)
    End Function
    Public Function update(bc As BaoCaoDoanhSoDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bcdoanhsoDal.update(bc)
    End Function

End Class
