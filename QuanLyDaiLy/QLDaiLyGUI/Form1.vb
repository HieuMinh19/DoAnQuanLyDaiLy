

Imports System.Configuration



Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'ConnectionString = ConfigurationManager.AppSettings("ConnectionString")

        MaximizeBox = False
    End Sub

    Private Sub ThemDaiLyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThemDaiLyToolStripMenuItem.Click
        Dim frmdaily As frmThemDaiLy = New frmThemDaiLy()
        frmdaily.MdiParent = Me
        frmdaily.Show()
    End Sub



    Private Sub HồSơĐạiLýToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HồSơĐạiLýToolStripMenuItem.Click

    End Sub


End Class
