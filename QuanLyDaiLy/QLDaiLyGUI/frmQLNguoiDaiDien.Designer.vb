<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLNguoiDaiDien
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.txtTenNDD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaNDD = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDoanhSachQuan = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSoDT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCMND = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvDoanhSachQuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(248, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 26)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Quản Lí người đại diện"
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(349, 318)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(2)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(72, 30)
        Me.btnXoa.TabIndex = 16
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(150, 318)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(72, 30)
        Me.btnCapNhat.TabIndex = 15
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'txtTenNDD
        '
        Me.txtTenNDD.Location = New System.Drawing.Point(481, 137)
        Me.txtTenNDD.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTenNDD.Name = "txtTenNDD"
        Me.txtTenNDD.Size = New System.Drawing.Size(155, 20)
        Me.txtTenNDD.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(371, 137)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Tên người đại diện"
        '
        'txtMaNDD
        '
        Me.txtMaNDD.Enabled = False
        Me.txtMaNDD.Location = New System.Drawing.Point(481, 96)
        Me.txtMaNDD.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaNDD.Name = "txtMaNDD"
        Me.txtMaNDD.Size = New System.Drawing.Size(155, 20)
        Me.txtMaNDD.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(371, 99)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Mã người đại diện"
        '
        'dgvDoanhSachQuan
        '
        Me.dgvDoanhSachQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDoanhSachQuan.Location = New System.Drawing.Point(50, 99)
        Me.dgvDoanhSachQuan.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvDoanhSachQuan.Name = "dgvDoanhSachQuan"
        Me.dgvDoanhSachQuan.RowTemplate.Height = 24
        Me.dgvDoanhSachQuan.Size = New System.Drawing.Size(294, 122)
        Me.dgvDoanhSachQuan.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Doanh Sách Quận"
        '
        'txtSoDT
        '
        Me.txtSoDT.Location = New System.Drawing.Point(481, 177)
        Me.txtSoDT.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSoDT.Name = "txtSoDT"
        Me.txtSoDT.Size = New System.Drawing.Size(155, 20)
        Me.txtSoDT.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(367, 177)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Số điện thoại"
        '
        'TxtCMND
        '
        Me.TxtCMND.Location = New System.Drawing.Point(481, 216)
        Me.TxtCMND.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCMND.Name = "TxtCMND"
        Me.TxtCMND.Size = New System.Drawing.Size(155, 20)
        Me.TxtCMND.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(371, 216)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "CMND"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(481, 254)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(155, 20)
        Me.txtDiaChi.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(371, 257)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Địa chỉ"
        '
        'frmQLNguoiDaiDien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 382)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtCMND)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSoDT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtTenNDD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaNDD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvDoanhSachQuan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQLNguoiDaiDien"
        Me.Text = "frmQLNguoiDaiDien"
        CType(Me.dgvDoanhSachQuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents txtTenNDD As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaNDD As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvDoanhSachQuan As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSoDT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtCMND As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents Label7 As Label
End Class
