Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility
Public Class frmQLNhanVien
    Private nvBus As NhanVienBUS
    Private cvBus As ChucVuBUS
    Private dlBus As DaiLyBUS
    Private dung = 0

    Private Sub frmQLNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cvBus = New ChucVuBUS()
        dlBus = New DaiLyBUS()

        nvBus = New NhanVienBUS()

        'lay ma dai ly
        Dim result As Result
        'load combobox chuc vu

        Dim listChucVu = New List(Of ChucVuDTO)
        result = cvBus.selectAll(listChucVu)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại chức vụ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbxChucVu.DataSource = New BindingSource(listChucVu, String.Empty)
        cbxChucVu.DisplayMember = "TenCV"
        cbxChucVu.ValueMember = "MaCV"


        Dim listDaiLy = New List(Of DaiLyDTO)
        result = dlBus.selectAll(listDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh đại lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbxDaiLy.DataSource = New BindingSource(listDaiLy, String.Empty)
        cbxDaiLy.DisplayMember = "TenDL"
        cbxDaiLy.ValueMember = "MaDL"

        cbxDoiDL.DataSource = New BindingSource(listDaiLy, String.Empty)
        cbxDoiDL.DisplayMember = "TenDL"
        cbxDoiDL.ValueMember = "MaDL"
    End Sub

    Private Sub loadListNhanVien(maDL As String)
        Dim listNV = New List(Of NhanVienDTO)
        Dim result As Result

        result = nvBus.selectALL_ByMaDaiLy(maDL, listNV)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách nhân viên không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        dgvListNV.Columns.Clear()
        dgvListNV.DataSource = Nothing

        dgvListNV.AutoGenerateColumns = False
        dgvListNV.AllowUserToAddRows = False
        dgvListNV.DataSource = listNV

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaNV"
        clMa.HeaderText = "Mã Nhân Viên"
        clMa.DataPropertyName = "MaNhanVien"
        dgvListNV.Columns.Add(clMa)

        Dim clTen = New DataGridViewTextBoxColumn()
        clTen.Name = "HoTen"
        clTen.HeaderText = "Tên Nhân Viên"
        clTen.DataPropertyName = "HoTenNhanVien"
        dgvListNV.Columns.Add(clTen)

        Dim clCMND = New DataGridViewTextBoxColumn()
        clCMND.Name = "CMND"
        clCMND.HeaderText = "CMND"
        clCMND.DataPropertyName = "CMND"
        dgvListNV.Columns.Add(clCMND)

        Dim clDienThoai = New DataGridViewTextBoxColumn()
        clDienThoai.Name = "SoDT"
        clDienThoai.HeaderText = "Số Điện Thoại"
        clDienThoai.DataPropertyName = "SoDienThoai"
        dgvListNV.Columns.Add(clDienThoai)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvListNV.Columns.Add(clDiaChi)

        'test
        Dim clMaCV = New DataGridViewTextBoxColumn()
        clMaCV.Name = "MaCV"
        clMaCV.HeaderText = "Mã Chức Vụ"
        clMaCV.DataPropertyName = "MaChucVu"
        dgvListNV.Columns.Add(clMaCV)
        'test
        Dim clMaDL = New DataGridViewTextBoxColumn()
        clMaDL.Name = "MaDL"
        clMaDL.HeaderText = "Mã Đại Lý"
        clMaDL.DataPropertyName = "MaDaiLy"
        dgvListNV.Columns.Add(clMaDL)
        '
    End Sub

    Private Sub cbxDaiLy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDaiLy.SelectedIndexChanged
        Try
            Dim madaily = Convert.ToInt32(cbxDaiLy.SelectedValue)
            loadListNhanVien(madaily)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvListNV_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListNV.SelectionChanged
        Dim currentRowIndex As Integer = dgvListNV.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < dgvListNV.RowCount) Then
            Try
                Dim nv = CType(dgvListNV.Rows(currentRowIndex).DataBoundItem, NhanVienDTO)

                txtSoDienThoai.Text = nv.SoDienThoai
                txtDiaChi.Text = nv.DiaChi
                cbxChucVu.SelectedValue = nv.MaChucVu
                cbxDoiDL.SelectedIndex = cbxDaiLy.SelectedIndex
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListNV.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListNV.RowCount) Then
            Try
                Dim nhanvien As NhanVienDTO
                nhanvien = New NhanVienDTO()
                Dim nv = CType(dgvListNV.Rows(currentRowIndex).DataBoundItem, NhanVienDTO)

                '1. Mapping data from GUI control
                nhanvien.MaNhanVien = nv.MaNhanVien
                nhanvien.SoDienThoai = txtSoDienThoai.Text
                nhanvien.DiaChi = txtDiaChi.Text
                nhanvien.MaChucVu = Convert.ToInt32(cbxChucVu.SelectedValue)
                nhanvien.MaDaiLy = Convert.ToInt32(cbxDoiDL.SelectedValue)

                '3. Insert to DB
                Dim result As Result
                result = nvBus.update(nhanvien)
                If (result.FlagResult = True) Then
                    ' Re-Load HocSinh list
                    loadListNhanVien(cbxDaiLy.SelectedValue)
                    ' Hightlight the row has been updated on table
                    dgvListNV.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật nhân viên thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật nhân viên không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        '
        nvBus = New NhanVienBUS()
        '
        Dim currentRowIndex As Integer = dgvListNV.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListNV.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa ", MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes ' + txtMaDaiLy.Text
                    Try
                        Dim nv = CType(dgvListNV.Rows(currentRowIndex).DataBoundItem, NhanVienDTO)
                        '1. Delete from DB
                        Dim result As Result
                        result = nvBus.delete(nv.MaNhanVien)
                        'CInt(Int(txtMaDaiLy.Text))
                        If (result.FlagResult = True) Then
                            'Convert.ToInt32(Convert.ToDecimal(txtPrice.Text))
                            ' Re-Load LoaiHocSinh list
                            loadListNhanVien(cbxDaiLy.SelectedValue)

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListNV.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListNV.Rows(currentRowIndex).Selected = True
                            End If

                            MessageBox.Show("Xóa nhân viên thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa nhân viên không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End Select


        End If
    End Sub
End Class