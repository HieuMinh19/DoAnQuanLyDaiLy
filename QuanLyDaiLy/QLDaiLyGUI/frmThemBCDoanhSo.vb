Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility

Public Class frmThemBCDoanhSo
    Private BCDoanhSoBus As BaoCaoDoanhSoBUS
    Private DaiLyBus As DaiLyBUS
    Private Sub frmThemBCDoanhSo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BCDoanhSoBus = New BaoCaoDoanhSoBUS()
        DaiLyBus = New DaiLyBUS()
        'QuanBUS = New QuanBUS()
        Dim result As Result
        Dim resultDaiLy As Result
        Dim nextMaBCDoanhSo As Integer
        result = BCDoanhSoBus.buildMaBaoCaoDoanhSo(nextMaBCDoanhSo)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã phieu xuat không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaBaoCaoDoanhSo.Text = nextMaBCDoanhSo

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

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim BCDoanhSo As BaoCaoDoanhSoDTO
        BCDoanhSo = New BaoCaoDoanhSoDTO()

        '1. Mapping data from GUI control
        'hocsinh.MSHS = txtMaSo.Text
        BCDoanhSo.MaDaiLy = Convert.ToInt32(cbMaDL.SelectedValue)
        ' phieuxuat.NgayLapPhieu = dtpNgayLapPhieu.Value

        BCDoanhSo.SoPhieuXuat = txtSoPhieuXuat.Text
        BCDoanhSo.TongGiaTri = txtTongGiaTri.Text
        BCDoanhSo.TiLe = txtTiLe.Text
        '2. Business .....


        '3. Insert to DB
        Dim result As Result
        result = BCDoanhSoBus.insert(BCDoanhSo)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm phieu xuat thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMaBCDoanhSo = "1"
            result = BCDoanhSoBus.buildMaBaoCaoDoanhSo(nextMaBCDoanhSo)
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