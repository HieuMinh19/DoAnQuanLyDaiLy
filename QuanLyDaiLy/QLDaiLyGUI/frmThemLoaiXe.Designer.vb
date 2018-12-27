<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemLoaiXe
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
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtMaMatHang = New System.Windows.Forms.TextBox()
        Me.txtTenMatHang = New System.Windows.Forms.TextBox()
        Me.txtSoLuongTon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Xe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Xe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Số Lượng Tồn"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(285, 242)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(139, 43)
        Me.btnThem.TabIndex = 3
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtMaMatHang
        '
        Me.txtMaMatHang.Location = New System.Drawing.Point(249, 90)
        Me.txtMaMatHang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMaMatHang.Name = "txtMaMatHang"
        Me.txtMaMatHang.Size = New System.Drawing.Size(267, 22)
        Me.txtMaMatHang.TabIndex = 4
        '
        'txtTenMatHang
        '
        Me.txtTenMatHang.Location = New System.Drawing.Point(249, 134)
        Me.txtTenMatHang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTenMatHang.Name = "txtTenMatHang"
        Me.txtTenMatHang.Size = New System.Drawing.Size(267, 22)
        Me.txtTenMatHang.TabIndex = 5
        '
        'txtSoLuongTon
        '
        Me.txtSoLuongTon.Location = New System.Drawing.Point(249, 175)
        Me.txtSoLuongTon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSoLuongTon.Name = "txtSoLuongTon"
        Me.txtSoLuongTon.Size = New System.Drawing.Size(267, 22)
        Me.txtSoLuongTon.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(243, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 32)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Thêm loại xe"
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(249, 214)
        Me.txtDonGia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(267, 22)
        Me.txtDonGia.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(104, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Đơn giá"
        '
        'frmThemLoaiXe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 351)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSoLuongTon)
        Me.Controls.Add(Me.txtTenMatHang)
        Me.Controls.Add(Me.txtMaMatHang)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmThemLoaiXe"
        Me.Text = "frmThemMatHang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents txtMaMatHang As TextBox
    Friend WithEvents txtTenMatHang As TextBox
    Friend WithEvents txtSoLuongTon As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents Label5 As Label
End Class
