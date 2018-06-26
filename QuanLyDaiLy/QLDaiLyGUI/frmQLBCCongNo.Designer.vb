<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLBCCongNo
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
        Me.dgvBaoCaoCongNo = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.txtMaBaoCaoCongNo = New System.Windows.Forms.TextBox()
        Me.txtPhatSinh = New System.Windows.Forms.TextBox()
        Me.txtNoDau = New System.Windows.Forms.TextBox()
        Me.txtNoCuoi = New System.Windows.Forms.TextBox()
        Me.cbMaDLT = New System.Windows.Forms.ComboBox()
        Me.cbMaDLD = New System.Windows.Forms.ComboBox()
        CType(Me.dgvBaoCaoCongNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBaoCaoCongNo
        '
        Me.dgvBaoCaoCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBaoCaoCongNo.Location = New System.Drawing.Point(16, 60)
        Me.dgvBaoCaoCongNo.Name = "dgvBaoCaoCongNo"
        Me.dgvBaoCaoCongNo.RowTemplate.Height = 24
        Me.dgvBaoCaoCongNo.Size = New System.Drawing.Size(677, 205)
        Me.dgvBaoCaoCongNo.TabIndex = 1
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
        Me.Label2.Location = New System.Drawing.Point(13, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mã BC Công Nợ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Phát Sinh"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Mã Đại Lý"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(353, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nợ Đầu"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(353, 341)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Nợ Cuối"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(153, 427)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(112, 43)
        Me.btnCapNhat.TabIndex = 7
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(396, 427)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(112, 43)
        Me.btnXoa.TabIndex = 8
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'txtMaBaoCaoCongNo
        '
        Me.txtMaBaoCaoCongNo.Location = New System.Drawing.Point(127, 284)
        Me.txtMaBaoCaoCongNo.Name = "txtMaBaoCaoCongNo"
        Me.txtMaBaoCaoCongNo.Size = New System.Drawing.Size(200, 22)
        Me.txtMaBaoCaoCongNo.TabIndex = 9
        '
        'txtPhatSinh
        '
        Me.txtPhatSinh.Location = New System.Drawing.Point(127, 336)
        Me.txtPhatSinh.Name = "txtPhatSinh"
        Me.txtPhatSinh.Size = New System.Drawing.Size(200, 22)
        Me.txtPhatSinh.TabIndex = 10
        '
        'txtNoDau
        '
        Me.txtNoDau.Location = New System.Drawing.Point(433, 282)
        Me.txtNoDau.Name = "txtNoDau"
        Me.txtNoDau.Size = New System.Drawing.Size(200, 22)
        Me.txtNoDau.TabIndex = 11
        '
        'txtNoCuoi
        '
        Me.txtNoCuoi.Location = New System.Drawing.Point(433, 336)
        Me.txtNoCuoi.Name = "txtNoCuoi"
        Me.txtNoCuoi.Size = New System.Drawing.Size(200, 22)
        Me.txtNoCuoi.TabIndex = 12
        '
        'cbMaDLT
        '
        Me.cbMaDLT.FormattingEnabled = True
        Me.cbMaDLT.Location = New System.Drawing.Point(127, 10)
        Me.cbMaDLT.Name = "cbMaDLT"
        Me.cbMaDLT.Size = New System.Drawing.Size(163, 24)
        Me.cbMaDLT.TabIndex = 13
        '
        'cbMaDLD
        '
        Me.cbMaDLD.FormattingEnabled = True
        Me.cbMaDLD.Location = New System.Drawing.Point(127, 382)
        Me.cbMaDLD.Name = "cbMaDLD"
        Me.cbMaDLD.Size = New System.Drawing.Size(200, 24)
        Me.cbMaDLD.TabIndex = 14
        '
        'frmQLBCCongNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 512)
        Me.Controls.Add(Me.cbMaDLD)
        Me.Controls.Add(Me.cbMaDLT)
        Me.Controls.Add(Me.txtNoCuoi)
        Me.Controls.Add(Me.txtNoDau)
        Me.Controls.Add(Me.txtPhatSinh)
        Me.Controls.Add(Me.txtMaBaoCaoCongNo)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvBaoCaoCongNo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQLBCCongNo"
        Me.Text = "frmQLBCCongNo"
        CType(Me.dgvBaoCaoCongNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBaoCaoCongNo As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents txtMaBaoCaoCongNo As TextBox
    Friend WithEvents txtPhatSinh As TextBox
    Friend WithEvents txtNoDau As TextBox
    Friend WithEvents txtNoCuoi As TextBox
    Friend WithEvents cbMaDLT As ComboBox
    Friend WithEvents cbMaDLD As ComboBox
End Class
