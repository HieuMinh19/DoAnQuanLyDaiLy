Imports QLDaiLyDAL
Imports QLDaiLyDTO
Imports Utility

Public Class QuanBUS
    Private quanDAL As QuanDAL
    Public Sub New()
        quanDAL = New QuanDAL()
    End Sub
    Public Sub New(connectionString As String)
        quanDAL = New QuanDAL(connectionString)
    End Sub


    Public Function selectAll(ByRef listquan As List(Of QuanDTO)) As Result

        Return quanDAL.selectALL(listquan)
    End Function
End Class
