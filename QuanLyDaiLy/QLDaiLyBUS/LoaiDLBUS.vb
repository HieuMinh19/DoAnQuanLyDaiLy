Imports QLDaiLyDAL
Imports QLDaiLyDTO
Imports Utility

Public Class LoaiDLBUS
    Private loaidlDAL As LoaiDlDAL
    Public Sub New()
        loaidlDAL = New LoaiDlDAL()
    End Sub
    Public Sub New(connectionString As String)
        loaidlDAL = New LoaiDlDAL(connectionString)
    End Sub


    Public Function selectAll(ByRef listdl As List(Of LoaiDLDTO)) As Result

        Return loaidlDAL.selectALL(listdl)
    End Function
End Class

