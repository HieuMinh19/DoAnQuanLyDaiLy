<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemLoaiDL
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
        Me.txtMaLoaiDL = New System.Windows.Forms.TextBox()
        Me.txtTenLoaiDL = New System.Windows.Forms.TextBox()
        Me.txtNoToiDa = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Loại Đại Lý"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Loại Đại Lý"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nợ Tối Đa"
        '
        'txtMaLoaiDL
        '
        Me.txtMaLoaiDL.Location = New System.Drawing.Point(236, 61)
        Me.txtMaLoaiDL.Name = "txtMaLoaiDL"
        Me.txtMaLoaiDL.Size = New System.Drawing.Size(221, 22)
        Me.txtMaLoaiDL.TabIndex = 3
        '
        'txtTenLoaiDL
        '
        Me.txtTenLoaiDL.Location = New System.Drawing.Point(236, 111)
        Me.txtTenLoaiDL.Name = "txtTenLoaiDL"
        Me.txtTenLoaiDL.Size = New System.Drawing.Size(221, 22)
        Me.txtTenLoaiDL.TabIndex = 4
        '
        'txtNoToiDa
        '
        Me.txtNoToiDa.Location = New System.Drawing.Point(236, 158)
        Me.txtNoToiDa.Name = "txtNoToiDa"
        Me.txtNoToiDa.Size = New System.Drawing.Size(221, 22)
        Me.txtNoToiDa.TabIndex = 5
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(135, 216)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(89, 33)
        Me.btnThem.TabIndex = 6
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'frmThemLoaiDL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 283)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtNoToiDa)
        Me.Controls.Add(Me.txtTenLoaiDL)
        Me.Controls.Add(Me.txtMaLoaiDL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmThemLoaiDL"
        Me.Text = "frmThemLoaiDL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaLoaiDL As TextBox
    Friend WithEvents txtTenLoaiDL As TextBox
    Friend WithEvents txtNoToiDa As TextBox
    Friend WithEvents btnThem As Button
End Class
