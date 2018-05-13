Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility

Public Class frmThemDaiLy
    Private dlBus As DaiLyBUS
    'Private lhsBus As LoaiHocSinhBUS

    Private Sub btnThemDaiLy_Click(sender As Object, e As EventArgs) Handles btnThemDaiLy.Click

        Dim daily As DaiLyDTO
        daily = New DaiLyDTO()

        '1. Mapping data from GUI control
        'hocsinh.MSHS = txtMaSo.Text
        daily.TenDL = txtTenDL.Text
        daily.DiaChi = txtDiaChi.Text
        daily.Email = txtEmail.Text
        daily.DienThoai = txtDienThoai.Text
        daily.NgTiepNhan = dtpNgTiepNhan.Value
        daily.MaQuan = Convert.ToInt32(cbMaQuan.SelectedValue)
        daily.MaLoaiDL = Convert.ToInt32(cbMaLoaiDL.SelectedValue)

        'hocsinh.LoaiHS = Convert.ToInt32(cbLoaiHS.SELECTedValue)

        '2. Business .....


        '3. Insert to DB
        Dim result As Result
        result = dlBus.insert(daily)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Đại Lý thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMaDL = "1"
            result = dlBus.buildMaDL(nextMaDL)
            If (result.FlagResult = True) Then
                MessageBox.Show("Lấy danh tự động mã Mã Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            'txtMaSo.Text = nextMshs
            txtTenDL.Text = String.Empty
            txtDiaChi.Text = String.Empty



        Else
            MessageBox.Show("Thêm Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub frmThemDaiLy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dlBus = New DaiLyBUS()
        Dim result As Result



        Dim nextMaDL As Integer
        result = dlBus.buildMaDL(nextMaDL)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaDL.Text = nextMaDL




    End Sub
End Class