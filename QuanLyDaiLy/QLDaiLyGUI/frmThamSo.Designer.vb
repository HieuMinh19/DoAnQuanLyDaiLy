<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmThamSo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSoDaiLyToiDa = New System.Windows.Forms.TextBox()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Số Đại Lý Tối Đa"
        '
        'txtSoDaiLyToiDa
        '
        Me.txtSoDaiLyToiDa.Location = New System.Drawing.Point(219, 67)
        Me.txtSoDaiLyToiDa.Name = "txtSoDaiLyToiDa"
        Me.txtSoDaiLyToiDa.Size = New System.Drawing.Size(153, 22)
        Me.txtSoDaiLyToiDa.TabIndex = 1
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(195, 151)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(94, 35)
        Me.btnCapNhat.TabIndex = 2
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'frmThamSo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 334)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtSoDaiLyToiDa)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmThamSo"
        Me.Text = "frmThamSo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSoDaiLyToiDa As TextBox
    Friend WithEvents btnCapNhat As Button
End Class
