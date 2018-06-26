<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemPhieuThuTien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMaPhieuThu = New System.Windows.Forms.TextBox()
        Me.txtSoTienThu = New System.Windows.Forms.TextBox()
        Me.cbMaDL = New System.Windows.Forms.ComboBox()
        Me.dtpNgayThuTien = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(324, 128)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(137, 41)
        Me.btnThem.TabIndex = 0
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Phiếu Thu Tiền"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mã Đại Lý"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(403, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ngày Thu Tiền"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(403, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Số Tiền Thu"
        '
        'txtMaPhieuThu
        '
        Me.txtMaPhieuThu.Location = New System.Drawing.Point(158, 19)
        Me.txtMaPhieuThu.Name = "txtMaPhieuThu"
        Me.txtMaPhieuThu.Size = New System.Drawing.Size(230, 22)
        Me.txtMaPhieuThu.TabIndex = 5
        '
        'txtSoTienThu
        '
        Me.txtSoTienThu.Location = New System.Drawing.Point(520, 77)
        Me.txtSoTienThu.Name = "txtSoTienThu"
        Me.txtSoTienThu.Size = New System.Drawing.Size(230, 22)
        Me.txtSoTienThu.TabIndex = 6
        '
        'cbMaDL
        '
        Me.cbMaDL.FormattingEnabled = True
        Me.cbMaDL.Location = New System.Drawing.Point(158, 73)
        Me.cbMaDL.Name = "cbMaDL"
        Me.cbMaDL.Size = New System.Drawing.Size(230, 24)
        Me.cbMaDL.TabIndex = 7
        '
        'dtpNgayThuTien
        '
        Me.dtpNgayThuTien.Location = New System.Drawing.Point(520, 17)
        Me.dtpNgayThuTien.Name = "dtpNgayThuTien"
        Me.dtpNgayThuTien.Size = New System.Drawing.Size(230, 22)
        Me.dtpNgayThuTien.TabIndex = 8
        '
        'frmThemPhieuThuTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 188)
        Me.Controls.Add(Me.dtpNgayThuTien)
        Me.Controls.Add(Me.cbMaDL)
        Me.Controls.Add(Me.txtSoTienThu)
        Me.Controls.Add(Me.txtMaPhieuThu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnThem)
        Me.Name = "frmThemPhieuThuTien"
        Me.Text = "frmThemPhieuThuTien"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnThem As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMaPhieuThu As TextBox
    Friend WithEvents txtSoTienThu As TextBox
    Friend WithEvents cbMaDL As ComboBox
    Friend WithEvents dtpNgayThuTien As DateTimePicker
End Class
