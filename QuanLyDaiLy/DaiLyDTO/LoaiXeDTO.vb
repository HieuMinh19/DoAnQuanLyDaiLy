Public Class LoaiXeDTO
    Private iMaXe As Integer
    Private strTenXe As String
    Private iSoLuongTon As Integer
    Private iDonGia As Integer


    Public Sub New()

    End Sub
    Public Sub New(iMaXe As Integer, strTenXe As String, iSoLuongTon As Integer, iDonGia As Integer)
        Me.iMaXe = iMaXe
        Me.strTenXe = strTenXe
        Me.iSoLuongTon = iSoLuongTon
        Me.IDonGia1 = iDonGia

    End Sub
    Public Property MaXe As Integer
        Get
            Return iMaXe
        End Get
        Set(value As Integer)
            iMaXe = value
        End Set
    End Property

    Public Property TenXe As String
        Get
            Return strTenXe
        End Get
        Set(value As String)
            strTenXe = value
        End Set
    End Property

    Public Property SoLuongTon As Integer
        Get
            Return iSoLuongTon
        End Get
        Set(value As Integer)
            iSoLuongTon = value
        End Set
    End Property

    Public Property IDonGia1 As Integer
        Get
            Return iDonGia
        End Get
        Set(value As Integer)
            iDonGia = value
        End Set
    End Property
End Class
