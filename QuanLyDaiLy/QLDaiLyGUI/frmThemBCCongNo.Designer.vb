﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemBCCongNo
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
        Me.txtMaBaoCaoCongNo = New System.Windows.Forms.TextBox()
        Me.txtPhatSinh = New System.Windows.Forms.TextBox()
        Me.txtNoDau = New System.Windows.Forms.TextBox()
        Me.txtNoCuoi = New System.Windows.Forms.TextBox()
        Me.cbMaDL = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Báo Cáo Công Nợ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Phát Sinh"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mã Đại Lý"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(351, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nợ Đầu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(351, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nợ Cuối"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(226, 168)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(115, 44)
        Me.btnThem.TabIndex = 5
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtMaBaoCaoCongNo
        '
        Me.txtMaBaoCaoCongNo.Location = New System.Drawing.Point(164, 27)
        Me.txtMaBaoCaoCongNo.Name = "txtMaBaoCaoCongNo"
        Me.txtMaBaoCaoCongNo.Size = New System.Drawing.Size(177, 22)
        Me.txtMaBaoCaoCongNo.TabIndex = 6
        '
        'txtPhatSinh
        '
        Me.txtPhatSinh.Location = New System.Drawing.Point(164, 71)
        Me.txtPhatSinh.Name = "txtPhatSinh"
        Me.txtPhatSinh.Size = New System.Drawing.Size(177, 22)
        Me.txtPhatSinh.TabIndex = 7
        '
        'txtNoDau
        '
        Me.txtNoDau.Location = New System.Drawing.Point(426, 22)
        Me.txtNoDau.Name = "txtNoDau"
        Me.txtNoDau.Size = New System.Drawing.Size(177, 22)
        Me.txtNoDau.TabIndex = 8
        '
        'txtNoCuoi
        '
        Me.txtNoCuoi.Location = New System.Drawing.Point(426, 71)
        Me.txtNoCuoi.Name = "txtNoCuoi"
        Me.txtNoCuoi.Size = New System.Drawing.Size(177, 22)
        Me.txtNoCuoi.TabIndex = 9
        '
        'cbMaDL
        '
        Me.cbMaDL.FormattingEnabled = True
        Me.cbMaDL.Location = New System.Drawing.Point(164, 113)
        Me.cbMaDL.Name = "cbMaDL"
        Me.cbMaDL.Size = New System.Drawing.Size(177, 24)
        Me.cbMaDL.TabIndex = 10
        '
        'frmThemBCCongNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 237)
        Me.Controls.Add(Me.cbMaDL)
        Me.Controls.Add(Me.txtNoCuoi)
        Me.Controls.Add(Me.txtNoDau)
        Me.Controls.Add(Me.txtPhatSinh)
        Me.Controls.Add(Me.txtMaBaoCaoCongNo)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmThemBCCongNo"
        Me.Text = "frmThemBCCongNo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents txtMaBaoCaoCongNo As TextBox
    Friend WithEvents txtPhatSinh As TextBox
    Friend WithEvents txtNoDau As TextBox
    Friend WithEvents txtNoCuoi As TextBox
    Friend WithEvents cbMaDL As ComboBox
End Class