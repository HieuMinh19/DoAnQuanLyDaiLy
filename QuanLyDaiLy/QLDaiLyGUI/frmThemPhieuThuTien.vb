Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility


Public Class frmThemPhieuThuTien
    Private ptBus As PhieuThuTienBUS
    Private DaiLyBus As DaiLyBUS
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMaDL.SelectedIndexChanged

    End Sub

    Private Sub frmThemPhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ptBus = New PhieuThuTienBUS()
        DaiLyBus = New DaiLyBUS()
        'QuanBUS = New QuanBUS()
        Dim result As Result
        Dim resultDaiLy As Result
        Dim nextMaPhieuThuTien As Integer


        result = ptBus.buildMaPhieuThuTien(nextMaPhieuThuTien)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã phieu xuat không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaPhieuThu.Text = nextMaPhieuThuTien

        'load combobox LoaiDL

        Dim listDaiLy = New List(Of DaiLyDTO)
        result = DaiLyBus.selectAll(listDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh dai ly không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbMaDL.DataSource = New BindingSource(listDaiLy, String.Empty)
        cbMaDL.DisplayMember = "TenDl"
        'cbxMaLoaiDL.ValueMember = "NoDaiLy"
        cbMaDL.ValueMember = "MaDL"


        'load combobox ma quan
        'Dim listQuan = New List(Of QuanDTO)
        'resultDaiLy = QuanBUS.selectAll(listQuan)
        'If (resultQuan.FlagResult = False) Then
        '    MessageBox.Show("Lấy danh loại Quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        '    Return
        'End If

        'cbxMaQuan.DataSource = New BindingSource(listQuan, String.Empty)
        'cbxMaQuan.DisplayMember = "TenQuan"
        'cbxMaQuan.ValueMember = "MaQuan"

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim phieuThu As PhieuThuTienDTO
        phieuThu = New PhieuThuTienDTO()

        '1. Mapping data from GUI control
        'hocsinh.MSHS = txtMaSo.Text
        phieuThu.MaDaiLy = Convert.ToInt32(cbMaDL.SelectedValue)
        phieuThu.NgayThuTien = dtpNgayThuTien.Value

        phieuThu.SoTienThu = txtSoTienThu.Text

        '2. Business .....


        '3. Insert to DB
        Dim result As Result
        result = ptBus.insert(phieuThu)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm phieu xuat thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMaPhieuThuTien = "1"
            result = ptBus.buildMaPhieuThuTien(nextMaPhieuThuTien)
            'If (result.FlagResult = True) Then
            '    MessageBox.Show("Lấy danh tự động mã Mã Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Me.Close()
            '    Return
            'End If




            'txtTenDL.Text = String.Empty
            'txtDiaChi.Text = String.Empty
            'txtEmail.Text = String.Empty
            'txtDienThoai.Text = String.Empty

        Else
            MessageBox.Show("Thêm phieu xuat không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

End Class