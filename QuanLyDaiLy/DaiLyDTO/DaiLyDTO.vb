Public Class DaiLyDTO
    Private iMaDL As Integer
    Private strTenDL As String
    Private strDienThoai As String
    Private iMaQuan As Integer
    Private strEmail As String
    Private iMaLoaiDL As Integer
    Private strDiaChi As String
    Private dateNgTiepNhan As DateTime
    Public Sub New()
    End Sub
    Public Sub New(iMaDL As Integer, strTenDL As String, strDienThoai As String, iMaQuan As Integer, strEmail As String, iMaLoaiDL As Integer, strDiaChi As String, dateNgTiepNhan As DateTime)
        Me.iMaDL = iMaDL
        Me.strTenDL = strTenDL
        Me.strDienThoai = strDienThoai
        Me.iMaQuan = iMaQuan
        Me.strEmail = strEmail
        Me.iMaLoaiDL = iMaLoaiDL
        Me.strDiaChi = strDiaChi
        Me.dateNgTiepNhan = dateNgTiepNhan
    End Sub

    Public Property MaDL As Integer
        Get
            Return iMaDL
        End Get
        Set(value As Integer)
            iMaDL = value
        End Set
    End Property

    Public Property TenDL As String
        Get
            Return strTenDL
        End Get
        Set(value As String)
            strTenDL = value
        End Set
    End Property

    Public Property DienThoai As String
        Get
            Return strDienThoai
        End Get
        Set(value As String)
            strDienThoai = value
        End Set
    End Property

    Public Property MaQuan As Integer
        Get
            Return iMaQuan
        End Get
        Set(value As Integer)
            iMaQuan = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return strEmail
        End Get
        Set(value As String)
            strEmail = value
        End Set
    End Property

    Public Property MaLoaiDL As Integer
        Get
            Return iMaLoaiDL
        End Get
        Set(value As Integer)
            iMaLoaiDL = value
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

    Public Property NgTiepNhan As Date
        Get
            Return dateNgTiepNhan
        End Get
        Set(value As Date)
            dateNgTiepNhan = value
        End Set
    End Property
End Class
