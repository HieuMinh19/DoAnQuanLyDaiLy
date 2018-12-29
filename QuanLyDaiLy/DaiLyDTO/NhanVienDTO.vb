Public Class NhanVienDTO
    Private iMaNV As Integer
    Private strHoTen As String
    Private strCMND As String
    Private strDienThoai As String
    Private strDiaChi As String
    Private iMaCV As Integer
    Private iMaDL As Integer


    Public Sub New()

    End Sub
    Public Sub New(iMaNV As Integer, strHoTen As String, strCMND As String, strDienThoai As String, strDiaChi As String, iMaCV As Integer, iMaDL As Integer)
        Me.iMaNV = iMaNV
        Me.strHoTen = strHoTen
        Me.strCMND = strCMND
        Me.strDienThoai = strDienThoai
        Me.strDiaChi = strDiaChi
        Me.iMaCV = iMaCV
        Me.iMaDL = iMaDL
    End Sub
    Public Property MaNhanVien As Integer
        Get
            Return iMaNV
        End Get
        Set(value As Integer)
            iMaNV = value
        End Set
    End Property

    Public Property HoTenNhanVien As String
        Get
            Return strHoTen
        End Get
        Set(value As String)
            strHoTen = value
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

    Public Property SoDienThoai As String
        Get
            Return strDienThoai
        End Get
        Set(value As String)
            strDienThoai = value
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

    Public Property MaChucVu As Integer
        Get
            Return iMaCV
        End Get
        Set(value As Integer)
            iMaCV = value
        End Set
    End Property

    Public Property MaDaiLy As Integer
        Get
            Return iMaDL
        End Get
        Set(value As Integer)
            iMaDL = value
        End Set
    End Property
End Class
