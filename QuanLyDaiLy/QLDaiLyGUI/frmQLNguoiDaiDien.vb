Imports System.Configuration
Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility

Public Class frmQLNguoiDaiDien
    Private lNDDBus As NguoiDaiDienBUS
    Private Sub frmQLNguoiDaiDien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lNDDBus = New NguoiDaiDienBUS()
        ' Load LoaiHocSinh list
        loadListNguoiDaiDien()

    End Sub

    Private Sub loadListNguoiDaiDien()
        ' Load LoaiHocSinh list
        Dim listNguoiDaiDien = New List(Of NguoiDaiDienDTO)
        Dim result As Result
        result = lNDDBus.selectAll(listNguoiDaiDien)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDoanhSachQuan.Columns.Clear()
        dgvDoanhSachQuan.DataSource = Nothing

        dgvDoanhSachQuan.AutoGenerateColumns = False
        dgvDoanhSachQuan.AllowUserToAddRows = False
        dgvDoanhSachQuan.DataSource = listNguoiDaiDien

        Dim clMaNguoiDaiDien = New DataGridViewTextBoxColumn()
        clMaNguoiDaiDien.Name = "MaNguoiDaiDien"
        clMaNguoiDaiDien.HeaderText = "Mã người đại diện"
        clMaNguoiDaiDien.DataPropertyName = "MaNguoiDaiDien"
        dgvDoanhSachQuan.Columns.Add(clMaNguoiDaiDien)

        Dim clTenNguoiDaiDien = New DataGridViewTextBoxColumn()
        clTenNguoiDaiDien.Name = "TenNguoiDaiDien"
        clTenNguoiDaiDien.HeaderText = "Tên người đại diện"
        clTenNguoiDaiDien.DataPropertyName = "TenNguoiDaiDien"
        dgvDoanhSachQuan.Columns.Add(clTenNguoiDaiDien)


        Dim clSoDT = New DataGridViewTextBoxColumn()
        clSoDT.Name = "SoDT"
        clSoDT.HeaderText = "Số điện thoại"
        clSoDT.DataPropertyName = "SoDT"
        dgvDoanhSachQuan.Columns.Add(clSoDT)


        Dim clCMND = New DataGridViewTextBoxColumn()
        clCMND.Name = "CMND"
        clCMND.HeaderText = "CMND"
        clCMND.DataPropertyName = "CMND"
        dgvDoanhSachQuan.Columns.Add(clCMND)


        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvDoanhSachQuan.Columns.Add(clDiaChi)
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim currentRowIndex As Integer = dgvDoanhSachQuan.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDoanhSachQuan.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa người đại diện có mã: " + txtMaNDD.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = lNDDBus.delete(Convert.ToInt32(txtMaNDD.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListNguoiDaiDien()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvDoanhSachQuan.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDoanhSachQuan.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim lndd = CType(dgvDoanhSachQuan.Rows(currentRowIndex).DataBoundItem, NguoiDaiDienDTO)
                                    txtMaNDD.Text = lndd.MaNguoiDaiDien
                                    txtTenNDD.Text = lndd.TenNguoiDaiDien
                                    txtSoDT.Text = lndd.SoDT
                                    TxtCMND.Text = lndd.CMND
                                    txtDiaChi.Text = lndd.DiaChi

                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa người đại diện thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa người đại diện không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDoanhSachQuan.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDoanhSachQuan.RowCount) Then
            Try
                Dim lndd As NguoiDaiDienDTO
                lndd = New NguoiDaiDienDTO()

                '1. Mapping data from GUI control
                lndd.MaNguoiDaiDien = Convert.ToInt32(txtMaNDD.Text)
                lndd.TenNguoiDaiDien = txtTenNDD.Text
                lndd.DiaChi = txtDiaChi.Text
                lndd.CMND = TxtCMND.Text
                lndd.SoDT = Convert.ToInt32(txtSoDT.Text)
                '2. Business .....
                'If (lhsBus.isValidName(lhs) = False) Then
                '    MessageBox.Show("Tên Loại học sinh không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    txtTenLoai.Focus()
                '    Return
                'End If

                '3. Insert to DB

                Dim result As Result
                result = lNDDBus.update(lndd)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadListNguoiDaiDien()
                    ' Hightlight the row has been updated on table
                    dgvDoanhSachQuan.Rows(currentRowIndex).Selected = True
                    Try
                        lndd = CType(dgvDoanhSachQuan.Rows(currentRowIndex).DataBoundItem, NguoiDaiDienDTO)
                        txtMaNDD.Text = lndd.MaNguoiDaiDien
                        txtTenNDD.Text = lndd.TenNguoiDaiDien
                        txtSoDT.Text = lndd.SoDT
                        TxtCMND.Text = lndd.CMND
                        txtDiaChi.Text = lndd.DiaChi
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật người đại diện thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật người đại diện không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub dgvDanhSachQuan_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvDoanhSachQuan.SelectionChanged

        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDoanhSachQuan.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDoanhSachQuan.RowCount) Then
            Try
                Dim lndd = CType(dgvDoanhSachQuan.Rows(currentRowIndex).DataBoundItem, NguoiDaiDienDTO)
                txtMaNDD.Text = lndd.MaNguoiDaiDien
                txtTenNDD.Text = lndd.TenNguoiDaiDien
                TxtCMND.Text = lndd.CMND
                txtDiaChi.Text = lndd.DiaChi
                txtSoDT.Text = lndd.SoDT

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub

    Private Sub dgvDoanhSachQuan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDoanhSachQuan.CellContentClick

    End Sub

    Private Sub txtMaNDD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaNDD.KeyPress, txtSoDT.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class