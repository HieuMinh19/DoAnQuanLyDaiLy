Public Class QuanDTO
    Private iMaQuan As Integer
    Private strTenQuan As String
    Private iSoDaiLy As Integer
    Public Sub New()
    End Sub

    Public Sub New(iMaQuan As Integer, strTenQuan As String, iSoDaiLy As Integer)
        Me.iMaQuan = iMaQuan
        Me.strTenQuan = strTenQuan
        Me.iSoDaiLy = iSoDaiLy
    End Sub

    Public Property MaQuan As Integer
        Get
            Return iMaQuan
        End Get
        Set(ByVal value As Integer)
            iMaQuan = value
        End Set
    End Property

    Public Property TenQuan As String
        Get
            Return strTenQuan
        End Get
        Set(ByVal value As String)
            strTenQuan = value
        End Set
    End Property

    Public Property SoDaiLy As Integer
        Get
            Return iSoDaiLy
        End Get
        Set(value As Integer)
            iSoDaiLy = value
        End Set
    End Property
End Class
