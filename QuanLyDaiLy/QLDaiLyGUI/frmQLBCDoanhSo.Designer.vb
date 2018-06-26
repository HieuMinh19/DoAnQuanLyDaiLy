<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLBCDoanhSo
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
        Me.dgvBaoCaoDoanhSo = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.cbMaDLT = New System.Windows.Forms.ComboBox()
        Me.cbMaDLD = New System.Windows.Forms.ComboBox()
        Me.txtMaBaoCaoDoanhSo = New System.Windows.Forms.TextBox()
        Me.txtSoPhieuXuat = New System.Windows.Forms.TextBox()
        Me.txtTongGiaTri = New System.Windows.Forms.TextBox()
        Me.txtTiLe = New System.Windows.Forms.TextBox()
        CType(Me.dgvBaoCaoDoanhSo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Đại Lý"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã BC Doanh Số"
        '
        'dgvBaoCaoDoanhSo
        '
        Me.dgvBaoCaoDoanhSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBaoCaoDoanhSo.Location = New System.Drawing.Point(16, 54)
        Me.dgvBaoCaoDoanhSo.Name = "dgvBaoCaoDoanhSo"
        Me.dgvBaoCaoDoanhSo.RowTemplate.Height = 24
        Me.dgvBaoCaoDoanhSo.Size = New System.Drawing.Size(581, 195)
        Me.dgvBaoCaoDoanhSo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Số Phiếu Xuất"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Mã Đại Lý"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(335, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tổng Giá Trị"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(335, 326)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tỉ Lệ"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(121, 415)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(113, 47)
        Me.btnCapNhat.TabIndex = 7
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(413, 415)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(113, 47)
        Me.btnXoa.TabIndex = 8
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'cbMaDLT
        '
        Me.cbMaDLT.FormattingEnabled = True
        Me.cbMaDLT.Location = New System.Drawing.Point(158, 13)
        Me.cbMaDLT.Name = "cbMaDLT"
        Me.cbMaDLT.Size = New System.Drawing.Size(183, 24)
        Me.cbMaDLT.TabIndex = 9
        '
        'cbMaDLD
        '
        Me.cbMaDLD.FormattingEnabled = True
        Me.cbMaDLD.Location = New System.Drawing.Point(158, 366)
        Me.cbMaDLD.Name = "cbMaDLD"
        Me.cbMaDLD.Size = New System.Drawing.Size(146, 24)
        Me.cbMaDLD.TabIndex = 10
        '
        'txtMaBaoCaoDoanhSo
        '
        Me.txtMaBaoCaoDoanhSo.Location = New System.Drawing.Point(158, 271)
        Me.txtMaBaoCaoDoanhSo.Name = "txtMaBaoCaoDoanhSo"
        Me.txtMaBaoCaoDoanhSo.Size = New System.Drawing.Size(146, 22)
        Me.txtMaBaoCaoDoanhSo.TabIndex = 11
        '
        'txtSoPhieuXuat
        '
        Me.txtSoPhieuXuat.Location = New System.Drawing.Point(158, 321)
        Me.txtSoPhieuXuat.Name = "txtSoPhieuXuat"
        Me.txtSoPhieuXuat.Size = New System.Drawing.Size(146, 22)
        Me.txtSoPhieuXuat.TabIndex = 12
        '
        'txtTongGiaTri
        '
        Me.txtTongGiaTri.Location = New System.Drawing.Point(451, 271)
        Me.txtTongGiaTri.Name = "txtTongGiaTri"
        Me.txtTongGiaTri.Size = New System.Drawing.Size(146, 22)
        Me.txtTongGiaTri.TabIndex = 13
        '
        'txtTiLe
        '
        Me.txtTiLe.Location = New System.Drawing.Point(451, 321)
        Me.txtTiLe.Name = "txtTiLe"
        Me.txtTiLe.Size = New System.Drawing.Size(146, 22)
        Me.txtTiLe.TabIndex = 14
        '
        'frmQLBCDoanhSo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 485)
        Me.Controls.Add(Me.txtTiLe)
        Me.Controls.Add(Me.txtTongGiaTri)
        Me.Controls.Add(Me.txtSoPhieuXuat)
        Me.Controls.Add(Me.txtMaBaoCaoDoanhSo)
        Me.Controls.Add(Me.cbMaDLD)
        Me.Controls.Add(Me.cbMaDLT)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvBaoCaoDoanhSo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQLBCDoanhSo"
        Me.Text = "frmQLBCDoanhSo"
        CType(Me.dgvBaoCaoDoanhSo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvBaoCaoDoanhSo As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents cbMaDLT As ComboBox
    Friend WithEvents cbMaDLD As ComboBox
    Friend WithEvents txtMaBaoCaoDoanhSo As TextBox
    Friend WithEvents txtSoPhieuXuat As TextBox
    Friend WithEvents txtTongGiaTri As TextBox
    Friend WithEvents txtTiLe As TextBox
End Class
