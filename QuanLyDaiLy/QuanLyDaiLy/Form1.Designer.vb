<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmĐạiLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HồSơĐạiLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmĐạiLýToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.QuảnLýToolStripMenuItem, Me.HồSơĐạiLýToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(599, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmĐạiLýToolStripMenuItem})
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.QuảnLýToolStripMenuItem.Text = "Quản Lý"
        '
        'ThêmĐạiLýToolStripMenuItem
        '
        Me.ThêmĐạiLýToolStripMenuItem.Name = "ThêmĐạiLýToolStripMenuItem"
        Me.ThêmĐạiLýToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ThêmĐạiLýToolStripMenuItem.Text = "Thêm loại đại lý"
        '
        'HồSơĐạiLýToolStripMenuItem
        '
        Me.HồSơĐạiLýToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmĐạiLýToolStripMenuItem1})
        Me.HồSơĐạiLýToolStripMenuItem.Name = "HồSơĐạiLýToolStripMenuItem"
        Me.HồSơĐạiLýToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.HồSơĐạiLýToolStripMenuItem.Text = "Hồ sơ đại lý"
        '
        'ThêmĐạiLýToolStripMenuItem1
        '
        Me.ThêmĐạiLýToolStripMenuItem1.Name = "ThêmĐạiLýToolStripMenuItem1"
        Me.ThêmĐạiLýToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ThêmĐạiLýToolStripMenuItem1.Text = "Thêm đại lý"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 237)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Quản lý đại lý"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThêmĐạiLýToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HồSơĐạiLýToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThêmĐạiLýToolStripMenuItem1 As ToolStripMenuItem
End Class
