Imports QLDaiLyBUS
Imports QLDaiLyDAL
Imports QLDaiLyDTO
Imports Utility

Public Class DaiLyBUS
    Private dlDAL As DaiLyDAL
    Public Sub New()
        dlDAL = New DaiLyDAL()
    End Sub
    Public Sub New(connectionString As String)
        dlDAL = New DaiLyDAL(connectionString)
    End Sub



    Public Function insert(dl As DaiLyDTO) As Result
        '1. verify data here!!
        Return dlDAL.insert(dl)

        'Return New Result(False )
    End Function


    Public Function buildMaDL(ByRef nextMaDL As Integer) As Result
        Return dlDAL.buildMaDL(nextMaDL)
    End Function
End Class