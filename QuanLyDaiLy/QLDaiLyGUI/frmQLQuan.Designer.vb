<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLQuan
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
        Me.dgvDoanhSachQuan = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaQuan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenQuan = New System.Windows.Forms.TextBox()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        CType(Me.dgvDoanhSachQuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(181, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Doanh Sách Quận"
        '
        'dgvDoanhSachQuan
        '
        Me.dgvDoanhSachQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDoanhSachQuan.Location = New System.Drawing.Point(71, 95)
        Me.dgvDoanhSachQuan.Name = "dgvDoanhSachQuan"
        Me.dgvDoanhSachQuan.RowTemplate.Height = 24
        Me.dgvDoanhSachQuan.Size = New System.Drawing.Size(392, 150)
        Me.dgvDoanhSachQuan.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(497, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mã Quận"
        '
        'txtMaQuan
        '
        Me.txtMaQuan.Location = New System.Drawing.Point(598, 95)
        Me.txtMaQuan.Name = "txtMaQuan"
        Me.txtMaQuan.Size = New System.Drawing.Size(205, 22)
        Me.txtMaQuan.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(478, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tên Quận"
        '
        'txtTenQuan
        '
        Me.txtTenQuan.Location = New System.Drawing.Point(598, 223)
        Me.txtTenQuan.Name = "txtTenQuan"
        Me.txtTenQuan.Size = New System.Drawing.Size(205, 22)
        Me.txtTenQuan.TabIndex = 5
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(198, 327)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(96, 37)
        Me.btnCapNhat.TabIndex = 6
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(454, 327)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(96, 37)
        Me.btnXoa.TabIndex = 7
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'frmQLQuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 406)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtTenQuan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaQuan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvDoanhSachQuan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQLQuan"
        Me.Text = "frmQLQuan"
        CType(Me.dgvDoanhSachQuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDoanhSachQuan As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaQuan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenQuan As TextBox
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
End Class
