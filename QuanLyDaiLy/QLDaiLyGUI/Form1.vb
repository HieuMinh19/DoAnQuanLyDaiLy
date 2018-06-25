Imports System.Configuration

Public Class Form1

    Private ConnectionString As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ConnectionString = ConfigurationManager.AppSettings("ConnectionString")

        MaximizeBox = False
    End Sub

    Private Sub ThemDaiLyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThemDaiLyToolStripMenuItem.Click
        Dim frmdaily As frmThemDaiLy = New frmThemDaiLy()
        frmdaily.MdiParent = Me
        frmdaily.Show()
    End Sub



    Private Sub HồSơĐạiLýToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HồSơĐạiLýToolStripMenuItem.Click

    End Sub

    Private Sub ThamSoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThamSoToolStripMenuItem.Click
        Dim frmthamso As frmThamSo = New frmThamSo()
        frmthamso.MdiParent = Me
        frmthamso.Show()
    End Sub

    Private Sub ThêmQuậnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmQuậnToolStripMenuItem.Click
        Dim frmthemquan As frmThemQuan = New frmThemQuan()
        frmthemquan.MdiParent = Me
        frmthemquan.Show()

    End Sub

    Private Sub ThêmLoạiĐạiLýToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmLoạiĐạiLýToolStripMenuItem.Click
        Dim frmthemloaidl As frmThemLoaiDL = New frmThemLoaiDL()
        frmthemloaidl.MdiParent = Me
        frmthemloaidl.Show()
    End Sub

    Private Sub QuảnLýĐạiLýToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýĐạiLýToolStripMenuItem.Click
        Dim frmQLdaily As frmQLDaiLy = New frmQLDaiLy()
        frmQLdaily.MdiParent = Me
        frmQLdaily.Show()
    End Sub

    Private Sub QuảnLýQuậnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýQuậnToolStripMenuItem.Click
        Dim frmQLquan As frmQLQuan = New frmQLQuan()
        frmQLquan.MdiParent = Me
        frmQLquan.Show()
    End Sub

    Private Sub QuảnLýLoạiĐạiLýToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýLoạiĐạiLýToolStripMenuItem.Click
        Dim frmQLloaiDL As frmQLLoaiDLvb = New frmQLLoaiDLvb()
        frmQLloaiDL.MdiParent = Me
        frmQLloaiDL.Show()
    End Sub

    Private Sub QuanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuanToolStripMenuItem.Click

    End Sub

    Private Sub ThêmMặtHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmMặtHàngToolStripMenuItem.Click
        Dim frmthemmathang As frmThemMatHang = New frmThemMatHang()
        frmthemmathang.MdiParent = Me
        frmthemmathang.Show()

    End Sub

    Private Sub QuảnLíMặtHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíMặtHàngToolStripMenuItem.Click
        Dim frmQLmathang As frmQLMatHang = New frmQLMatHang()
        frmQLmathang.MdiParent = Me
        frmQLmathang.Show()
    End Sub

    Private Sub ThêmĐơnVịTínhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmĐơnVịTínhToolStripMenuItem.Click
        Dim frmthemdonvitinh As frmThemDonViTinh = New frmThemDonViTinh()
        frmthemdonvitinh.MdiParent = Me
        frmthemdonvitinh.Show()
    End Sub

    Private Sub QuảnLíĐơnVịTínhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíĐơnVịTínhToolStripMenuItem.Click
        Dim frmQLdonvitinh As frmQLDonViTinh = New frmQLDonViTinh()
        frmQLdonvitinh.MdiParent = Me
        frmQLdonvitinh.Show()
    End Sub

    Private Sub ThêmPhiếuXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmPhiếuXuấtToolStripMenuItem.Click
        Dim frmthemphieuxuat As frmPhieuXuat = New frmPhieuXuat()
        frmthemphieuxuat.MdiParent = Me
        frmthemphieuxuat.Show()
    End Sub

    Private Sub QuảnLýPhiếuXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýPhiếuXuấtToolStripMenuItem.Click
        Dim frmQLphieuxuat As frmQLPhieuXuat = New frmQLPhieuXuat()
        frmQLphieuxuat.MdiParent = Me
        frmQLphieuxuat.Show()
    End Sub

    Private Sub ThêmChiTiếtPhiếuXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmChiTiếtPhiếuXuấtToolStripMenuItem.Click
        Dim frmthemchitietphieuxuat As frmThemChiTietPhieuXuat = New frmThemChiTietPhieuXuat()
        frmthemchitietphieuxuat.MdiParent = Me
        frmthemchitietphieuxuat.Show()
    End Sub

    Private Sub QuảnLíChiTiếtPhiếuXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíChiTiếtPhiếuXuấtToolStripMenuItem.Click
        Dim frmQLchitietphieuxuat As frmQLChiTietPhieuXuat = New frmQLChiTietPhieuXuat()
        frmQLchitietphieuxuat.MdiParent = Me
        frmQLchitietphieuxuat.Show()
    End Sub
End Class
