Public Class ChucVuDTO
    Private iMaCV As Integer
    Private strTenCV As String
    Public Sub New()

    End Sub

    Public Sub New(iMaCV As Integer, strTenCV As String)
        Me.iMaCV = iMaCV
        Me.strTenCV = strTenCV
    End Sub

    Public Property MaCV As Integer
        Get
            Return iMaCV
        End Get
        Set(value As Integer)
            iMaCV = value
        End Set
    End Property

    Public Property TenCV As String
        Get
            Return strTenCV
        End Get
        Set(value As String)
            strTenCV = value
        End Set
    End Property
End Class
