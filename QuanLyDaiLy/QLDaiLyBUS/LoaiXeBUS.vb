Imports QLDaiLyDAL
Imports QLDaiLyDTO
Imports Utility
Imports LoaiXeDTO
Imports LoaiXeDAL

Public Class LoaiXeBUS

    Private loaixeDAL As LoaiXeDAL

    Public Sub New()
        loaixeDAL = New LoaiXeDAL()
    End Sub
    Public Sub New(connectionString As String)
        loaixeDAL = New LoaiXeDAL(connectionString)
    End Sub


    Public Function buildMaLoaiXe(ByRef nextMaXe As Integer) As Result
        Return loaixeDAL.buildMaXe(nextMaXe)
    End Function
    Public Function insert(loaixe As LoaiXeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return loaixeDAL.insert(loaixe)
    End Function
    Public Function selectAll(ByRef listloaixe As List(Of LoaiXeDTO)) As Result

        Return loaixeDAL.selectALL(listloaixe)
    End Function
    Public Function delete(loaixe As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return loaixeDAL.delete(loaixe)
    End Function
    Public Function Update(loaixe As LoaiXeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return loaixeDAL.update(loaixe)
    End Function
    Public Function countsoloaixe(ByRef sdf As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return loaixeDAL.countsoloaixe(sdf)
    End Function
    Public Function selectSoloaixe_thamso(ByRef soloaixetoida As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return loaixeDAL.selectSoloaixe_thamso(soloaixetoida)
    End Function

End Class
