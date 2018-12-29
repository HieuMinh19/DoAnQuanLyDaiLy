Imports QLDaiLyDAL
Imports QLDaiLyDTO
Imports Utility
Public Class ChucVuBUS
    Private cvDAL As ChucVuDAL
    Public Sub New()
        cvDAL = New ChucVuDAL()
    End Sub
    Public Sub New(connectionString As String)
        cvDAL = New ChucVuDAL(connectionString)
    End Sub

    Public Function buildMaCV(ByRef nextMaCV As Integer) As Result
        Return cvDAL.buildMaCV(nextMaCV)
    End Function
    Public Function selectAll(ByRef listloaiCV As List(Of ChucVuDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return cvDAL.selectALL(listloaiCV)
    End Function
End Class

