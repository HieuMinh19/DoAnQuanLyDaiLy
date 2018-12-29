<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLNhanVien
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxChucVu = New System.Windows.Forms.ComboBox()
        Me.cbxDoiDL = New System.Windows.Forms.ComboBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtSoDienThoai = New System.Windows.Forms.TextBox()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvListNV = New System.Windows.Forms.DataGridView()
        Me.cbxDaiLy = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvListNV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(350, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 26)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Quản Lí nhân viên"
        '
        'cbxChucVu
        '
        Me.cbxChucVu.FormattingEnabled = True
        Me.cbxChucVu.Location = New System.Drawing.Point(340, 289)
        Me.cbxChucVu.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxChucVu.Name = "cbxChucVu"
        Me.cbxChucVu.Size = New System.Drawing.Size(165, 21)
        Me.cbxChucVu.TabIndex = 47
        '
        'cbxDoiDL
        '
        Me.cbxDoiDL.FormattingEnabled = True
        Me.cbxDoiDL.Location = New System.Drawing.Point(109, 284)
        Me.cbxDoiDL.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxDoiDL.Name = "cbxDoiDL"
        Me.cbxDoiDL.Size = New System.Drawing.Size(165, 21)
        Me.cbxDoiDL.TabIndex = 46
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(147, 326)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(524, 20)
        Me.txtDiaChi.TabIndex = 43
        '
        'txtSoDienThoai
        '
        Me.txtSoDienThoai.Location = New System.Drawing.Point(572, 292)
        Me.txtSoDienThoai.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSoDienThoai.Name = "txtSoDienThoai"
        Me.txtSoDienThoai.Size = New System.Drawing.Size(165, 20)
        Me.txtSoDienThoai.TabIndex = 42
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(500, 381)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(2)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(121, 58)
        Me.btnXoa.TabIndex = 39
        Me.btnXoa.Text = "Xóa nhân viên"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(200, 381)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(121, 58)
        Me.btnCapNhat.TabIndex = 38
        Me.btnCapNhat.Text = "Cập Nhật nhân viên"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(509, 285)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Điện Thoại"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 329)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Địa Chỉ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 292)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Tên Đại Lý"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(289, 292)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Chức vụ"
        '
        'dgvListNV
        '
        Me.dgvListNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListNV.Location = New System.Drawing.Point(109, 116)
        Me.dgvListNV.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvListNV.Name = "dgvListNV"
        Me.dgvListNV.RowTemplate.Height = 24
        Me.dgvListNV.Size = New System.Drawing.Size(652, 151)
        Me.dgvListNV.TabIndex = 28
        '
        'cbxDaiLy
        '
        Me.cbxDaiLy.FormattingEnabled = True
        Me.cbxDaiLy.Location = New System.Drawing.Point(109, 76)
        Me.cbxDaiLy.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxDaiLy.Name = "cbxDaiLy"
        Me.cbxDaiLy.Size = New System.Drawing.Size(179, 21)
        Me.cbxDaiLy.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Đại Lý"
        '
        'frmQLNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxChucVu)
        Me.Controls.Add(Me.cbxDoiDL)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtSoDienThoai)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvListNV)
        Me.Controls.Add(Me.cbxDaiLy)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQLNhanVien"
        Me.Text = "frmQLNhanVien"
        CType(Me.dgvListNV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents cbxChucVu As ComboBox
    Friend WithEvents cbxDoiDL As ComboBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtSoDienThoai As TextBox
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvListNV As DataGridView
    Friend WithEvents cbxDaiLy As ComboBox
    Friend WithEvents Label1 As Label
End Class
