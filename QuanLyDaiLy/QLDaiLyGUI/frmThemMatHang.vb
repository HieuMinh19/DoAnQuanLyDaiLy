Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility

Public Class frmThemMatHang

    Private MatHangBus As MatHangBUS
    Private Sub frmThemMatHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MatHangBus = New MatHangBUS()
        ' LoaiDLBUS = New LoaiDLBUS()
        ' quanBus = New QuanBUS()

        'lay ma dai ly
        Dim result As Result
        ' Dim resultQuan As Result
        Dim nextMaMatHang As Integer


        result = MatHangBus.builMaMatHang(nextMaMatHang)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động  không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaMatHang.Text = nextMaMatHang
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim mathang As MatHangDTO
        mathang = New MatHangDTO()

        mathang.MaMatHang = txtMaMatHang.Text
        mathang.TenMatHang = txtTenMatHang.Text
        mathang.SoLuongTon = txtSoLuongTon.Text

        '3. Insert to DB
        Dim result As Result
        result = MatHangBus.insert(mathang)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm mat hang thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMaMatHang = "1"
            result = MatHangBus.builMaMatHang(nextMaMatHang)

            txtTenMatHang.Text = String.Empty
            txtSoLuongTon.Text = String.Empty
        Else
            MessageBox.Show("Thêm mat hang không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class