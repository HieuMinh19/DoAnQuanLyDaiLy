<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemBCDoanhSo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtMaBaoCaoDoanhSo = New System.Windows.Forms.TextBox()
        Me.txtSoPhieuXuat = New System.Windows.Forms.TextBox()
        Me.txtTongGiaTri = New System.Windows.Forms.TextBox()
        Me.txtTiLe = New System.Windows.Forms.TextBox()
        Me.cbMaDL = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã BC Doanh  Số"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Số Phiếu Xuất"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mã Đại Lý"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(352, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tổng Giá Trị"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(352, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tỉ Lệ"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(250, 169)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(142, 47)
        Me.btnThem.TabIndex = 5
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtMaBaoCaoDoanhSo
        '
        Me.txtMaBaoCaoDoanhSo.Location = New System.Drawing.Point(151, 21)
        Me.txtMaBaoCaoDoanhSo.Name = "txtMaBaoCaoDoanhSo"
        Me.txtMaBaoCaoDoanhSo.Size = New System.Drawing.Size(164, 22)
        Me.txtMaBaoCaoDoanhSo.TabIndex = 6
        '
        'txtSoPhieuXuat
        '
        Me.txtSoPhieuXuat.Location = New System.Drawing.Point(151, 75)
        Me.txtSoPhieuXuat.Name = "txtSoPhieuXuat"
        Me.txtSoPhieuXuat.Size = New System.Drawing.Size(164, 22)
        Me.txtSoPhieuXuat.TabIndex = 7
        '
        'txtTongGiaTri
        '
        Me.txtTongGiaTri.Location = New System.Drawing.Point(459, 24)
        Me.txtTongGiaTri.Name = "txtTongGiaTri"
        Me.txtTongGiaTri.Size = New System.Drawing.Size(164, 22)
        Me.txtTongGiaTri.TabIndex = 8
        '
        'txtTiLe
        '
        Me.txtTiLe.Location = New System.Drawing.Point(459, 73)
        Me.txtTiLe.Name = "txtTiLe"
        Me.txtTiLe.Size = New System.Drawing.Size(164, 22)
        Me.txtTiLe.TabIndex = 9
        '
        'cbMaDL
        '
        Me.cbMaDL.FormattingEnabled = True
        Me.cbMaDL.Location = New System.Drawing.Point(151, 122)
        Me.cbMaDL.Name = "cbMaDL"
        Me.cbMaDL.Size = New System.Drawing.Size(164, 24)
        Me.cbMaDL.TabIndex = 10
        '
        'frmThemBCDoanhSo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 239)
        Me.Controls.Add(Me.cbMaDL)
        Me.Controls.Add(Me.txtTiLe)
        Me.Controls.Add(Me.txtTongGiaTri)
        Me.Controls.Add(Me.txtSoPhieuXuat)
        Me.Controls.Add(Me.txtMaBaoCaoDoanhSo)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmThemBCDoanhSo"
        Me.Text = "frmThemBCDoanhSo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents txtMaBaoCaoDoanhSo As TextBox
    Friend WithEvents txtSoPhieuXuat As TextBox
    Friend WithEvents txtTongGiaTri As TextBox
    Friend WithEvents txtTiLe As TextBox
    Friend WithEvents cbMaDL As ComboBox
End Class
