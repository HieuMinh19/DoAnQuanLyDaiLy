<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLMatHang
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
        Me.dgvDanhSachMatHang = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMaMatHang = New System.Windows.Forms.TextBox()
        Me.txtSoLuongTon = New System.Windows.Forms.TextBox()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.cbTenMatHang = New System.Windows.Forms.ComboBox()
        CType(Me.dgvDanhSachMatHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Danh Sách Mặt Hàng"
        '
        'dgvDanhSachMatHang
        '
        Me.dgvDanhSachMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachMatHang.Location = New System.Drawing.Point(30, 67)
        Me.dgvDanhSachMatHang.Name = "dgvDanhSachMatHang"
        Me.dgvDanhSachMatHang.RowTemplate.Height = 24
        Me.dgvDanhSachMatHang.Size = New System.Drawing.Size(367, 166)
        Me.dgvDanhSachMatHang.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(441, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mã Mặt Hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(441, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tên Mặt Hàng"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(441, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Số Lượng Tồn"
        '
        'txtMaMatHang
        '
        Me.txtMaMatHang.Location = New System.Drawing.Point(578, 62)
        Me.txtMaMatHang.Name = "txtMaMatHang"
        Me.txtMaMatHang.Size = New System.Drawing.Size(237, 22)
        Me.txtMaMatHang.TabIndex = 5
        '
        'txtSoLuongTon
        '
        Me.txtSoLuongTon.Location = New System.Drawing.Point(578, 180)
        Me.txtSoLuongTon.Name = "txtSoLuongTon"
        Me.txtSoLuongTon.Size = New System.Drawing.Size(237, 22)
        Me.txtSoLuongTon.TabIndex = 7
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(192, 271)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(105, 44)
        Me.btnCapNhat.TabIndex = 8
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(424, 271)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(105, 44)
        Me.btnXoa.TabIndex = 9
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'cbTenMatHang
        '
        Me.cbTenMatHang.FormattingEnabled = True
        Me.cbTenMatHang.Location = New System.Drawing.Point(578, 118)
        Me.cbTenMatHang.Name = "cbTenMatHang"
        Me.cbTenMatHang.Size = New System.Drawing.Size(237, 24)
        Me.cbTenMatHang.TabIndex = 10
        '
        'frmQLMatHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 348)
        Me.Controls.Add(Me.cbTenMatHang)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtSoLuongTon)
        Me.Controls.Add(Me.txtMaMatHang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvDanhSachMatHang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQLMatHang"
        Me.Text = "frmQLMatHang"
        CType(Me.dgvDanhSachMatHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachMatHang As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMaMatHang As TextBox
    Friend WithEvents txtSoLuongTon As TextBox
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents cbTenMatHang As ComboBox
End Class
