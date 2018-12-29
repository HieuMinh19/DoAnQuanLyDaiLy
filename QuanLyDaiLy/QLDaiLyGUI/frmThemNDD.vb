Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility
Public Class frmThemNDD
    Private nddBUS As NguoiDaiDienBUS
    Private Sub btnThemNguoiDaiDien_Click(sender As Object, e As EventArgs) Handles btnThemNguoiDaiDien.Click
        Dim nguoidaidien As NguoiDaiDienDTO
        nguoidaidien = New NguoiDaiDienDTO()

        '1. Mapping data from GUI control
        'hocsinh.MSHS = txtMaSo.Text
        nguoidaidien.TenNguoiDaiDien = txtTenNDD.Text
        nguoidaidien.DiaChi = txtDiaChi.Text
        nguoidaidien.CMND = txtCMND.Text
        nguoidaidien.SoDT = Convert.ToInt32(txtDienThoai.Text)


        '2. Business .....


        '3. Insert to DB
        Dim result As Result

        result = nddBUS.insert(nguoidaidien)
        If (result.FlagResult = True
            ) Then
            MessageBox.Show("Thêm người đại diện thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMaNDD = "1"
            result = nddBUS.buildMaNguoiDaiDien(nextMaNDD)
            'If (result.FlagResult = True) Then
            '    MessageBox.Show("Lấy danh tự động mã Mã Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Me.Close()
            '    Return
            'End If
            txtTenNDD.Text = String.Empty
            txtDiaChi.Text = String.Empty
            txtCMND.Text = String.Empty
            txtDienThoai.Text = String.Empty

        Else
            MessageBox.Show("Thêm người đại diện không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub
    Private Sub txtDienThoai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDienThoai.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub frmThemNDD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nddBUS = New NguoiDaiDienBUS()
        Dim nextMaNDD As Integer

        Dim result As Result
        result = nddBUS.buildMaNguoiDaiDien(nextMaNDD)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã người đại diện không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaNDD.Text = nextMaNDD
    End Sub
End Class