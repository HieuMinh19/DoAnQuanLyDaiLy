Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility

Public Class frmThemLoaiXe

    Private LoaiXeBus As LoaiXeBUS
    Private Sub frmThemLoaiXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        LoaiXeBus = New LoaiXeBUS()
        ' LoaiDLBUS = New LoaiDLBUS()
        ' quanBus = New QuanBUS()

        'lay ma dai ly
        Dim result As Result
        ' Dim resultQuan As Result
        Dim nextMaXe As Integer


        result = LoaiXeBus.buildMaLoaiXe(nextMaXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động  không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaMatHang.Text = nextMaXe
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim loaixe As LoaiXeDTO
        loaixe = New LoaiXeDTO()

        loaixe.MaXe = txtMaMatHang.Text
        loaixe.TenXe = txtTenMatHang.Text
        loaixe.SoLuongTon = txtSoLuongTon.Text
        loaixe.IDonGia1 = Convert.ToInt32(txtDonGia.Text)

        Dim countsoloaixe As Integer
        ' Dim resultsodonvitinh As Result
        Dim soloaixetoida As Integer

        LoaiXeBus.countsoloaixe(countsoloaixe)
        LoaiXeBus.selectSoloaixe_thamso(soloaixetoida)
        '3. Insert to DB
        If (1) Then

            Dim result As Result
            result = LoaiXeBus.insert(loaixe)
            If (result.FlagResult = True) Then
                MessageBox.Show("Thêm loại xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'set MSSH auto
                Dim nextMaLoaiXe = "1"
                result = LoaiXeBus.buildMaLoaiXe(nextMaLoaiXe)

                txtTenMatHang.Text = String.Empty
                txtSoLuongTon.Text = String.Empty
            Else
                MessageBox.Show("Thêm loaixe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("số loaixe phải bé hơn số loaixe tối đa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtMaMatHang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaMatHang.KeyPress, txtSoLuongTon.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


End Class
