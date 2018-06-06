Public Class ChiTietPhieuXuatDTO
    Private iMaChiTietPhieuXuat As Integer
    Private iMaPhieuXuat As Integer
    Private iMaMatHang As Integer
    Private iMaDonViTinh As Integer
    Private iSoLuongTinh As Integer
    Private iDonGia As Integer
    Private iThanhTien As Integer


    Public Sub New()

    End Sub

    Public Sub New(iMaChiTietPhieuXuat As Integer, iMaPhieuXuat As Integer, iMaMatHang As Integer, iMaDonViTinh As Integer, iSoLuongTinh As Integer, iDonGia As Integer, iThanhTien As Integer)
        Me.iMaChiTietPhieuXuat = iMaChiTietPhieuXuat
        Me.iMaPhieuXuat = iMaPhieuXuat
        Me.iMaMatHang = iMaMatHang
        Me.iMaDonViTinh = iMaDonViTinh
        Me.iSoLuongTinh = iSoLuongTinh
        Me.iDonGia = iDonGia
        Me.iThanhTien = iThanhTien
    End Sub

    Public Property MaChiTietPhieuXuat As Integer
        Get
            Return iMaChiTietPhieuXuat
        End Get
        Set(value As Integer)
            iMaChiTietPhieuXuat = value
        End Set
    End Property

    Public Property MaPhieuXuat As Integer
        Get
            Return iMaPhieuXuat
        End Get
        Set(value As Integer)
            iMaPhieuXuat = value
        End Set
    End Property

    Public Property MaMatHang As Integer
        Get
            Return iMaMatHang
        End Get
        Set(value As Integer)
            iMaMatHang = value
        End Set
    End Property

    Public Property MaDonViTinh As Integer
        Get
            Return iMaDonViTinh
        End Get
        Set(value As Integer)
            iMaDonViTinh = value
        End Set
    End Property

    Public Property SoLuongTinh As Integer
        Get
            Return iSoLuongTinh
        End Get
        Set(value As Integer)
            iSoLuongTinh = value
        End Set
    End Property

    Public Property DonGia As Integer
        Get
            Return iDonGia
        End Get
        Set(value As Integer)
            iDonGia = value
        End Set
    End Property

    Public Property ThanhTien As Integer
        Get
            Return iThanhTien
        End Get
        Set(value As Integer)
            iThanhTien = value
        End Set
    End Property
End Class
