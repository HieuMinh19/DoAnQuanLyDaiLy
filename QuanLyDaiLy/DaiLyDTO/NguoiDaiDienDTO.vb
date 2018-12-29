Public Class NguoiDaiDienDTO
    Private iMaNguoiDaiDien As Integer
    Private iSoDT As Integer
    Private strTenNguoiDaiDien As String
    Private strCMND As String
    Private strDiaChi As String
    Public Sub New()
    End Sub

    Public Sub New(iMaNguoiDaiDien As Integer, strTenNguoiDaiDien As String, iSoDT As Integer, strCMND As String, strDiaChi As String)
        Me.iMaNguoiDaiDien = iMaNguoiDaiDien
        Me.iSoDT = iSoDT
        Me.strCMND = strCMND
        Me.strDiaChi = strDiaChi
        Me.strTenNguoiDaiDien = strTenNguoiDaiDien

    End Sub
    Public Property MaNguoiDaiDien As Integer
        Get
            Return iMaNguoiDaiDien
        End Get
        Set(value As Integer)
            iMaNguoiDaiDien = value
        End Set
    End Property

    Public Property SoDT As Integer
        Get
            Return iSoDT
        End Get
        Set(value As Integer)
            iSoDT = value
        End Set
    End Property

    Public Property CMND As String
        Get
            Return strCMND
        End Get
        Set(value As String)
            strCMND = value
        End Set
    End Property

    Public Property DiaChi As String
        Get
            Return strDiaChi
        End Get
        Set(value As String)
            strDiaChi = value
        End Set
    End Property

    Public Property TenNguoiDaiDien As String
        Get
            Return strTenNguoiDaiDien
        End Get
        Set(value As String)
            strTenNguoiDaiDien = value
        End Set
    End Property
End Class
