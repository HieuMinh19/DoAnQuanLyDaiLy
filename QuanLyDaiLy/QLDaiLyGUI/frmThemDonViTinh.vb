Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility

Public Class frmThemDonViTinh
    Private donvitinhBus As DonViTinhBUS
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click

        Dim donvitinh As DonViTinhDTO
        donvitinh = New DonViTinhDTO()

        donvitinh.MaDonViTinh = txtMaDonViTinh.Text
        donvitinh.TenDonViTinh = txtTenDonViTinh.Text



        '3. Insert to DB
        Dim result As Result
        result = donvitinhBus.insert(donvitinh)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm don vi tinh thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMaDonViTinh = "1"
            result = donvitinhBus.buildMaDonViTinh(nextMaDonViTinh)

            txtTenDonViTinh.Text = String.Empty
        Else
            MessageBox.Show("Thêm don vi tinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If


    End Sub

    Private Sub frmThemDonViTinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        donvitinhBus = New DonViTinhBUS()
        ' LoaiDLBUS = New LoaiDLBUS()
        ' quanBus = New QuanBUS()

        'lay ma dai ly
        Dim result As Result
        ' Dim resultQuan As Result
        Dim nextMaDonViTinh As Integer


        result = donvitinhBus.buildMaDonViTinh(nextMaDonViTinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động Ma don vi tinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaDonViTinh.Text = nextMaDonViTinh
    End Sub
End Class