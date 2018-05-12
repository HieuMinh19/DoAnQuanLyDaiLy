Public Class LoaiDLDTO
    Private iMaLoaiDL As Integer
    Private strTenLoaiDL As String
    Public Sub New()
    End Sub

    Public Sub New(iMaLoaiDL As Integer, strTenLoaiDL As String)
        Me.iMaLoaiDL = iMaLoaiDL
        Me.strTenLoaiDL = strTenLoaiDL
    End Sub

    Public Property MaLoaiDL As Integer
        Get
            Return iMaLoaiDL
        End Get
        Set(value As Integer)
            iMaLoaiDL = value
        End Set
    End Property

    Public Property TenLoaiDL As String
        Get
            Return strTenLoaiDL
        End Get
        Set(value As String)
            strTenLoaiDL = value
        End Set
    End Property
End Class