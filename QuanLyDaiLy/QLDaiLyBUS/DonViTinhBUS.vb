Imports QLDaiLyDAL
Imports QLDaiLyDTO
Imports Utility

Public Class DonViTinhBUS
    Private donvitinhDAL As DonViTinhDAL
    Public Sub New()
        donvitinhDAL = New DonViTinhDAL()
    End Sub
    Public Sub New(connectionString As String)
        donvitinhDAL = New DonViTinhDAL(connectionString)
    End Sub

    Public Function insert(donvitinh As DonViTinhDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return donvitinhDAL.insert(donvitinh)
    End Function

    Public Function buildMaDonViTinh(ByRef nextMaDonViTinh As Integer) As Result
        Return donvitinhDAL.buildMaDonViTinh(nextMaDonViTinh)
    End Function
    Public Function selectAll(ByRef listdonvitinh As List(Of DonViTinhDTO)) As Result

        Return donvitinhDAL.selectALL(listdonvitinh)
    End Function
    Public Function update(donvitinh As DonViTinhDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return donvitinhDAL.update(donvitinh)
    End Function



    Public Function delete(maquan As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return donvitinhDAL.delete(maquan)
    End Function
End Class
