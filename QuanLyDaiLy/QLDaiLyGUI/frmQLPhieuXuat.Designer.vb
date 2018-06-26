<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLPhieuXuat
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
        Me.cbMaDL = New System.Windows.Forms.ComboBox()
        Me.dgvlistPhieuXuat = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaPhieuXuat = New System.Windows.Forms.TextBox()
        Me.cbMaDaiLy = New System.Windows.Forms.ComboBox()
        Me.dtpNgayLapPhieu = New System.Windows.Forms.DateTimePicker()
        Me.txtTongGiaTri = New System.Windows.Forms.TextBox()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        CType(Me.dgvlistPhieuXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Đại Lý"
        '
        'cbMaDL
        '
        Me.cbMaDL.FormattingEnabled = True
        Me.cbMaDL.Location = New System.Drawing.Point(110, 13)
        Me.cbMaDL.Name = "cbMaDL"
        Me.cbMaDL.Size = New System.Drawing.Size(212, 24)
        Me.cbMaDL.TabIndex = 1
        '
        'dgvlistPhieuXuat
        '
        Me.dgvlistPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlistPhieuXuat.Location = New System.Drawing.Point(70, 56)
        Me.dgvlistPhieuXuat.Name = "dgvlistPhieuXuat"
        Me.dgvlistPhieuXuat.RowTemplate.Height = 24
        Me.dgvlistPhieuXuat.Size = New System.Drawing.Size(692, 178)
        Me.dgvlistPhieuXuat.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mã Phiếu Xuất"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(374, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ngày Lập Phiếu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Mã Đại Lý"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(374, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tổng Giá Trị"
        '
        'txtMaPhieuXuat
        '
        Me.txtMaPhieuXuat.Location = New System.Drawing.Point(112, 272)
        Me.txtMaPhieuXuat.Name = "txtMaPhieuXuat"
        Me.txtMaPhieuXuat.Size = New System.Drawing.Size(256, 22)
        Me.txtMaPhieuXuat.TabIndex = 7
        '
        'cbMaDaiLy
        '
        Me.cbMaDaiLy.FormattingEnabled = True
        Me.cbMaDaiLy.Location = New System.Drawing.Point(112, 318)
        Me.cbMaDaiLy.Name = "cbMaDaiLy"
        Me.cbMaDaiLy.Size = New System.Drawing.Size(256, 24)
        Me.cbMaDaiLy.TabIndex = 8
        '
        'dtpNgayLapPhieu
        '
        Me.dtpNgayLapPhieu.Location = New System.Drawing.Point(506, 272)
        Me.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu"
        Me.dtpNgayLapPhieu.Size = New System.Drawing.Size(256, 22)
        Me.dtpNgayLapPhieu.TabIndex = 9
        '
        'txtTongGiaTri
        '
        Me.txtTongGiaTri.Location = New System.Drawing.Point(506, 318)
        Me.txtTongGiaTri.Name = "txtTongGiaTri"
        Me.txtTongGiaTri.Size = New System.Drawing.Size(256, 22)
        Me.txtTongGiaTri.TabIndex = 10
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(157, 392)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(122, 49)
        Me.btnCapNhat.TabIndex = 11
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(480, 392)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(122, 49)
        Me.btnXoa.TabIndex = 12
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'frmQLPhieuXuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 461)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtTongGiaTri)
        Me.Controls.Add(Me.dtpNgayLapPhieu)
        Me.Controls.Add(Me.cbMaDaiLy)
        Me.Controls.Add(Me.txtMaPhieuXuat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvlistPhieuXuat)
        Me.Controls.Add(Me.cbMaDL)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQLPhieuXuat"
        Me.Text = "frmQLPhieuXuat"
        CType(Me.dgvlistPhieuXuat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbMaDL As ComboBox
    Friend WithEvents dgvlistPhieuXuat As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMaPhieuXuat As TextBox
    Friend WithEvents cbMaDaiLy As ComboBox
    Friend WithEvents dtpNgayLapPhieu As DateTimePicker
    Friend WithEvents txtTongGiaTri As TextBox
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
End Class
