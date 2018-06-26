Imports System.Configuration
Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility



Public Class frmQLBCDoanhSo
    Private bcDoanhSoBus As BaoCaoDoanhSoBUS
    Private dlBus As DaiLyBUS
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvBaoCaoDoanhSo.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvBaoCaoDoanhSo.RowCount) Then
            Try
                Dim baocao As BaoCaoDoanhSoDTO
                baocao = New BaoCaoDoanhSoDTO()

                '1. Mapping data from GUI control
                baocao.MaBaoCaoDoanhSo = txtMaBaoCaoDoanhSo.Text
                baocao.MaDaiLy = Convert.ToInt32(cbMaDLD.SelectedValue)
                baocao.TongGiaTri = txtTongGiaTri.Text
                baocao.SoPhieuXuat = txtSoPhieuXuat.Text
                baocao.TiLe = txtTiLe.Text
                '3. Insert to DB
                Dim result As Result
                result = bcDoanhSoBus.update(baocao)
                If (result.FlagResult = True) Then
                    ' Re-Load HocSinh list
                    loadListBaoCaoDoanhSo(cbMaDLT.SelectedValue)
                    ' Hightlight the row has been updated on table
                    dgvBaoCaoDoanhSo.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật phieu xuat thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật phieu xuat không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub frmQLBCDoanhSo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'quanBus = New QuanBUS()
        bcDoanhSoBus = New BaoCaoDoanhSoBUS()
        dlBus = New DaiLyBUS()

        ' Load DaiLy list
        Dim listDaiLy = New List(Of DaiLyDTO)
        Dim result As Result
        result = dlBus.selectAll(listDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbMaDLT.DataSource = New BindingSource(listDaiLy, String.Empty)
        cbMaDLT.DisplayMember = "TenDl"
        cbMaDLT.ValueMember = "MaDL"

        cbMaDLD.DataSource = New BindingSource(listDaiLy, String.Empty)
        cbMaDLD.DisplayMember = "TenDl"
        cbMaDLD.ValueMember = "MaDL"
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        '
        bcDoanhSoBus = New BaoCaoDoanhSoBUS()
        '
        Dim currentRowIndex As Integer = dgvBaoCaoDoanhSo.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvBaoCaoDoanhSo.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa phieu xuat có mã số: " + txtMaBaoCaoDoanhSo.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes ' + txtMaDaiLy.Text
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        'result = dlBus.delete(txtMaDaiLy.Text)
                        result = bcDoanhSoBus.delete((txtMaBaoCaoDoanhSo.Text))
                        'CInt(Int(txtMaDaiLy.Text))
                        If (result.FlagResult = True) Then
                            'Convert.ToInt32(Convert.ToDecimal(txtPrice.Text))
                            ' Re-Load LoaiHocSinh list
                            loadListBaoCaoDoanhSo(cbMaDLT.SelectedValue)

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvBaoCaoDoanhSo.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvBaoCaoDoanhSo.Rows(currentRowIndex).Selected = True
                            End If

                            MessageBox.Show("Xóa phieu xuat thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa phieu xuat không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub cbMaDLT_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles cbMaDLT.SelectedIndexChanged
        Try
            Dim madaily = Convert.ToInt32(cbMaDLT.SelectedValue)
            loadListBaoCaoDoanhSo(madaily)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvlistPhieuXuat_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvBaoCaoDoanhSo.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvBaoCaoDoanhSo.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvBaoCaoDoanhSo.RowCount) Then
            Try
                Dim px = CType(dgvBaoCaoDoanhSo.Rows(currentRowIndex).DataBoundItem, BaoCaoDoanhSoDTO)

                txtMaBaoCaoDoanhSo.Text = px.MaBaoCaoDoanhSo
                cbMaDLD.SelectedIndex = cbMaDLT.SelectedIndex

                txtTongGiaTri.Text = px.TongGiaTri
                txtSoPhieuXuat.Text = px.SoPhieuXuat
                txtTiLe.Text = px.TiLe
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub loadListBaoCaoDoanhSo(maDL As String)
        Dim listBaoCao = New List(Of BaoCaoDoanhSoDTO)
        Dim result As Result

        result = bcDoanhSoBus.selectALL_ByMaDaiLy(maDL, listBaoCao)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phieu  xuat thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        dgvBaoCaoDoanhSo.Columns.Clear()
        dgvBaoCaoDoanhSo.DataSource = Nothing
        dgvBaoCaoDoanhSo.AutoGenerateColumns = False
        dgvBaoCaoDoanhSo.AllowUserToAddRows = False
        dgvBaoCaoDoanhSo.DataSource = listBaoCao

        Dim clMaBaoCaoDoanhSo = New DataGridViewTextBoxColumn()
        clMaBaoCaoDoanhSo.Name = "MaBaoCaoDoanhSo"
        clMaBaoCaoDoanhSo.HeaderText = "Mã BC Doanh Số"
        clMaBaoCaoDoanhSo.DataPropertyName = "MaBaoCaoDoanhSo"
        dgvBaoCaoDoanhSo.Columns.Add(clMaBaoCaoDoanhSo)

        'Dim clLoaiHS = New DataGridView()
        'clLoaiHS.Name = "LoaiHS"
        'clLoaiHS.HeaderText = "Tên Loại"
        'clLoaiHS.DataPropertyName = "LoaiHS"
        'dgvListHS.Columns.Add(clLoaiHS)

        Dim clMaDaiLy = New DataGridViewTextBoxColumn()
        clMaDaiLy.Name = "MaDaiLy"
        clMaDaiLy.HeaderText = "Tên Đại Lý"
        clMaDaiLy.DataPropertyName = "MaDaiLy"
        dgvBaoCaoDoanhSo.Columns.Add(clMaDaiLy)

        Dim clSoPhieuXuat = New DataGridViewTextBoxColumn()
        clSoPhieuXuat.Name = "SoPhieuXuat"
        clSoPhieuXuat.HeaderText = "Số Phiếu Xuất"
        clSoPhieuXuat.DataPropertyName = "SoPhieuXuat"
        dgvBaoCaoDoanhSo.Columns.Add(clSoPhieuXuat)

        Dim clTongGiaTri = New DataGridViewTextBoxColumn()
        clTongGiaTri.Name = "TongGiaTri"
        clTongGiaTri.HeaderText = "Tổng Giá Trị"
        clTongGiaTri.DataPropertyName = "TongGiaTri"
        dgvBaoCaoDoanhSo.Columns.Add(clTongGiaTri)

        Dim clTiLe = New DataGridViewTextBoxColumn()
        clTiLe.Name = "TiLe"
        clTiLe.HeaderText = "Tỉ Lệ"
        clTiLe.DataPropertyName = "TiLe"
        dgvBaoCaoDoanhSo.Columns.Add(clTiLe)
        'dgvListHS.ResumeLayout()

    End Sub
End Class