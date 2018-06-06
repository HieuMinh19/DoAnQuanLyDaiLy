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
    Public Function selectAll(ByRef listLoaiDL As List(Of DaiLyDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.selectALL(listLoaiDL)
    End Function

    Public Function selectALL_ByMaLoaiDL(iMaLoaiDL As Integer, ByRef listDL As List(Of DaiLyDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.selectALL_ByMaLoaiDL(iMaLoaiDL, listDL)
    End Function


    Public Function delete(dl As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.delete(dl)
    End Function
    Public Function update(dl As DaiLyDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.update(dl)
    End Function






End Class