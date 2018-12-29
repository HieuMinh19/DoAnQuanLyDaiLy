Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility

Public Class frmThemNhanVien
    Private nvBus As NhanVienBUS
    Private cvBus As ChucVuBUS
    Private QuanBUS As QuanBUS
    Private dlBus As DaiLyBUS
    Private dung = 0


    Private Sub BtnThemNhanVien_Click(sender As Object, e As EventArgs) Handles BtnThemNhanVien.Click

        Dim nhanvien As NhanVienDTO
        nhanvien = New NhanVienDTO()

        '1. Mapping data from GUI control
        'hocsinh.MSHS = txtMaSo.Text
        nhanvien.HoTenNhanVien = TxtHoTen.Text
        nhanvien.CMND = TxtCMND.Text
        nhanvien.SoDienThoai = TxtSoDienThoai.Text
        nhanvien.DiaChi = TxtDiaChi.Text
        nhanvien.MaChucVu = Convert.ToInt32(CbxChucVu.SelectedValue)
        nhanvien.MaDaiLy = Convert.ToInt32(CbxDaiLy.SelectedValue)

        '2. Business .....
        'If ((daily.NoCuaDaiLy > 20000 And
        '    daily.MaLoaiDL = 1) Or (daily.NoCuaDaiLy > 50000 And daily.MaLoaiDL = 2)
        '    ) Then
        '    MessageBox.Show("Thêm Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Me.Close()
        '    dung = 1

        'End If


        '3. Insert to DB
        Dim result As Result
        If (dung = 0) Then
            result = nvBus.insert(nhanvien)
            If (result.FlagResult = True
                ) Then
                MessageBox.Show("Thêm nhân viên thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'set MSSH auto
                Dim nextMaNV = "1"
                result = dlBus.buildMaDL(nextMaNV)
                'If (result.FlagResult = True) Then
                '    MessageBox.Show("Lấy danh tự động mã Mã Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    Me.Close()
                '    Return
                'End If
                TxtHoTen.Text = String.Empty
                TxtCMND.Text = String.Empty
                TxtSoDienThoai.Text = String.Empty
                TxtDiaChi.Text = String.Empty

            Else
                MessageBox.Show("Thêm nhân viên không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        End If
        dung = 0

    End Sub

    Private Sub fmrThemNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nvBus = New NhanVienBUS()
        cvBus = New ChucVuBUS()
        dlBus = New DaiLyBUS()

        'lay ma dai ly
        Dim result As Result
        Dim resultQuan As Result


        Dim nextMaNV As Integer


        result = nvBus.builMaNV(nextMaNV)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã nhân viên không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        TxtMaNV.Text = nextMaNV

        'load combobox chuc vu

        Dim listChucVu = New List(Of ChucVuDTO)
        result = cvBus.selectAll(listChucVu)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại chức vụ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        CbxChucVu.DataSource = New BindingSource(listChucVu, String.Empty)
        CbxChucVu.DisplayMember = "TenCV"
        CbxChucVu.ValueMember = "MaCV"


        Dim listDaiLy = New List(Of DaiLyDTO)
        result = dlBus.selectAll(listDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh đại lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        CbxDaiLy.DataSource = New BindingSource(listDaiLy, String.Empty)
        CbxDaiLy.DisplayMember = "TenDL"
        CbxDaiLy.ValueMember = "MaDL"


    End Sub
End Class