﻿Imports System.Configuration

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
        Dim frmthemmathang As frmThemLoaiXe = New frmThemLoaiXe()
        frmthemmathang.MdiParent = Me
        frmthemmathang.Show()

    End Sub

    Private Sub QuảnLíMặtHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíMặtHàngToolStripMenuItem.Click
        Dim frmQLmathang As frmQLLoaiXe = New frmQLLoaiXe()
        frmQLmathang.MdiParent = Me
        frmQLmathang.Show()
    End Sub

    Private Sub ThêmĐơnVịTínhToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Dim frmthemdonvitinh As frmThemDonViTinh = New frmThemDonViTinh()
        frmthemdonvitinh.MdiParent = Me
        frmthemdonvitinh.Show()
    End Sub

    Private Sub QuảnLíĐơnVịTínhToolStripMenuItem_Click(sender As Object, e As EventArgs) 
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

    Private Sub ThêmPhiếuThuTiềnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmPhiếuThuTiềnToolStripMenuItem.Click
        Dim frmthemPhieuThuTien As frmThemPhieuThuTien = New frmThemPhieuThuTien()
        frmthemPhieuThuTien.MdiParent = Me
        frmthemPhieuThuTien.Show()
    End Sub

    Private Sub QuảnLýPhiếuThuTiềnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýPhiếuThuTiềnToolStripMenuItem.Click
        Dim frmQLPhieuThuTien As frmQLPhieuThuTien = New frmQLPhieuThuTien()
        frmQLPhieuThuTien.MdiParent = Me
        frmQLPhieuThuTien.Show()
    End Sub

    'Private Sub BáoCáoDoanhSốToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoDoanhSốToolStripMenuItem.Click
    '    Dim frmthembcDoanhSo As frmThemBCDoanhSo = New frmThemBCDoanhSo()
    '    frmthembcDoanhSo.MdiParent = Me
    '    frmthembcDoanhSo.Show()
    'End Sub

    Private Sub QuảnLýBáoCáoDoanhSốToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýBáoCáoDoanhSốToolStripMenuItem.Click
        Dim frmQLbcDoanhSo As frmQLBCDoanhSo = New frmQLBCDoanhSo()
        frmQLbcDoanhSo.MdiParent = Me
        frmQLbcDoanhSo.Show()
    End Sub

    Private Sub BáoCáoCôngNợToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoCôngNợToolStripMenuItem.Click
        Dim frmThembcCongNo As frmThemBCCongNo = New frmThemBCCongNo()
        frmThembcCongNo.MdiParent = Me
        frmThembcCongNo.Show()
    End Sub

    Private Sub QuảnLýBáoCáoCôngNợToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýBáoCáoCôngNợToolStripMenuItem.Click
        Dim frmQLbcCongNo As frmQLBCCongNo = New frmQLBCCongNo()
        frmQLbcCongNo.MdiParent = Me
        frmQLbcCongNo.Show()
    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub

    Private Sub ThayĐổiQuyĐịnhToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmthamso As frmThamSo = New frmThamSo()
        frmthamso.MdiParent = Me
        frmthamso.Show()
    End Sub

    Private Sub TraCứuĐạiLýToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraCứuĐạiLýToolStripMenuItem1.Click
        Dim frmtracuu As TraCuu = New TraCuu()
        frmtracuu.MdiParent = Me
        frmtracuu.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ThêmNgườiĐạiDiệnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmNgườiĐạiDiệnToolStripMenuItem.Click
        Dim frmThemNguoi As frmThemNDD = New frmThemNDD()
        frmThemNguoi.MdiParent = Me
        frmThemNguoi.Show()
    End Sub

    Private Sub QuảnLýNgườiĐạiDiệnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýNgườiĐạiDiệnToolStripMenuItem.Click
        Dim frmQLChu As frmQLNguoiDaiDien = New frmQLNguoiDaiDien()
        frmQLChu.MdiParent = Me
        frmQLChu.Show()
    End Sub

    Private Sub ThêmNhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmNhânViênToolStripMenuItem.Click
        Dim frmThemNhanVien As frmThemNhanVien = New frmThemNhanVien()
        frmThemNhanVien.MdiParent = Me
        frmThemNhanVien.Show()
    End Sub

    Private Sub QuảnLýNhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýNhânViênToolStripMenuItem.Click
        Dim frmQLNV As frmQLNhanVien = New frmQLNhanVien()
        frmQLNV.MdiParent = Me
        frmQLNV.Show()
    End Sub
End Class
