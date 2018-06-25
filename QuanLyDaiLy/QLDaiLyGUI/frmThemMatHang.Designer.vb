<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemMatHang
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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Mặt Hàng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Mặt Hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Số Lượng Tồn"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(357, 218)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(138, 43)
        Me.btnThem.TabIndex = 3
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtMaMatHang
        '
        Me.txtMaMatHang.Location = New System.Drawing.Point(249, 37)
        Me.txtMaMatHang.Name = "txtMaMatHang"
        Me.txtMaMatHang.Size = New System.Drawing.Size(267, 22)
        Me.txtMaMatHang.TabIndex = 4
        '
        'txtTenMatHang
        '
        Me.txtTenMatHang.Location = New System.Drawing.Point(249, 88)
        Me.txtTenMatHang.Name = "txtTenMatHang"
        Me.txtTenMatHang.Size = New System.Drawing.Size(267, 22)
        Me.txtTenMatHang.TabIndex = 5
        '
        'txtSoLuongTon
        '
        Me.txtSoLuongTon.Location = New System.Drawing.Point(249, 134)
        Me.txtSoLuongTon.Name = "txtSoLuongTon"
        Me.txtSoLuongTon.Size = New System.Drawing.Size(267, 22)
        Me.txtSoLuongTon.TabIndex = 6
        '
        'frmThemMatHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 317)
        Me.Controls.Add(Me.txtSoLuongTon)
        Me.Controls.Add(Me.txtTenMatHang)
        Me.Controls.Add(Me.txtMaMatHang)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmThemMatHang"
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
End Class
