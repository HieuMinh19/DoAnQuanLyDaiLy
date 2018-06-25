Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility

Public Class frmThemQuan
    Private quanBus As QuanBUS


    Private Sub frmThemQuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        quanBus = New QuanBUS()
        ' LoaiDLBUS = New LoaiDLBUS()
        ' quanBus = New QuanBUS()

        'lay ma dai ly
        Dim result As Result
        ' Dim resultQuan As Result
        Dim nextMaQuan As Integer


        result = quanBus.buildMaQuan(nextMaQuan)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động Ma Quan không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaQuan.Text = nextMaQuan
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click


        Dim quan As QuanDTO
        quan = New QuanDTO()

        quan.MaQuan = txtMaQuan.Text
        quan.TenQuan = txtTenQuan.Text



        '3. Insert to DB
        Dim result As Result
        result = quanBus.insert(quan)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Quan thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMaQuan = "1"
            result = quanBus.buildMaQuan(nextMaQuan)

            txtTenQuan.Text = String.Empty
        Else
            MessageBox.Show("Thêm Quan không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If



    End Sub
End Class