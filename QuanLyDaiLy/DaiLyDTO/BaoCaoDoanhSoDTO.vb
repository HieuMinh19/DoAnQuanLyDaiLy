Public Class BaoCaoDoanhSoDTO
    Private iMaBaoCaoDoanhSo As Integer
    Private iMaDaiLy As Integer
    Private iSoPhieuXuat As Integer
    Private iTongGiaTri As Integer
    Private douTiLe As Double


    Public Sub New()

    End Sub
    Public Sub New(iMaBaoCaoDoanhSo As Integer, iMaDaiLy As Integer, iSoPhieuXuat As Integer, iTongGiaTri As Integer, douTiLe As Double)
        Me.iMaBaoCaoDoanhSo = iMaBaoCaoDoanhSo
        Me.iMaDaiLy = iMaDaiLy
        Me.iSoPhieuXuat = iSoPhieuXuat
        Me.iTongGiaTri = iTongGiaTri
        Me.douTiLe = douTiLe
    End Sub
    Public Property MaBaoCaoDoanhSo As Integer
        Get
            Return iMaBaoCaoDoanhSo
        End Get
        Set(value As Integer)
            iMaBaoCaoDoanhSo = value
        End Set
    End Property

    Public Property MaDaiLy As Integer
        Get
            Return iMaDaiLy
        End Get
        Set(value As Integer)
            iMaDaiLy = value
        End Set
    End Property

    Public Property SoPhieuXuat As Integer
        Get
            Return iSoPhieuXuat
        End Get
        Set(value As Integer)
            iSoPhieuXuat = value
        End Set
    End Property

    Public Property TongGiaTri As Integer
        Get
            Return iTongGiaTri
        End Get
        Set(value As Integer)
            iTongGiaTri = value
        End Set
    End Property

    Public Property TiLe As Double
        Get
            Return douTiLe
        End Get
        Set(value As Double)
            douTiLe = value
        End Set
    End Property
End Class
