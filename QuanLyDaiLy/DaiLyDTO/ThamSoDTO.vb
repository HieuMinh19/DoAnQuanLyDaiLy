Public Class ThamSoDTO
    Private iID As Integer
    Private iSoDaiLyToiDa As Integer

    Public Sub New()
        ID = 0
        iSoDaiLyToiDa = 0
    End Sub

    Public Sub New(id As Integer, iSoDaiLyToiDa As Integer)
        Me.iID = id
        Me.iSoDaiLyToiDa = iSoDaiLyToiDa
    End Sub

    Public Property ID As Integer
        Get
            Return iID
        End Get
        Set(value As Integer)
            iID = value
        End Set
    End Property
    Public Property SoDaiLyToiDa As Integer
        Get
            Return iSoDaiLyToiDa
        End Get
        Set(value As Integer)
            iSoDaiLyToiDa = value
        End Set
    End Property

End Class
