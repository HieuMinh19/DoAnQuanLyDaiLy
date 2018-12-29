Imports QLDaiLyDAL
Imports QLDaiLyDTO
Imports Utility
Public Class NhanVienBUS
    Private nhanvienDAL As NhanVienDAL
    Public Sub New()
        nhanvienDAL = New NhanVienDAL()
    End Sub
    Public Sub New(connectionString As String)
        nhanvienDAL = New NhanVienDAL(connectionString)
    End Sub

    Public Function builMaNV(ByRef nextMaNV As Integer) As Result
        Return nhanvienDAL.builMaNV(nextMaNV)

    End Function

    Public Function insert(nv As NhanVienDTO) As Result
        '1. verify data here!!
        Return nhanvienDAL.insert(nv)

        'Return New Result(False )
    End Function
    Public Function selectALL_ByMaDaiLy(maDL As Integer, ByRef listNV As List(Of NhanVienDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nhanvienDAL.selectALL_ByMaDaiLy(maDL, listNV)
    End Function

    Public Function update(nv As NhanVienDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nhanvienDAL.update(nv)
    End Function

    Public Function delete(nv As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nhanvienDAL.delete(nv)
    End Function

End Class
