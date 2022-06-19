Imports System.Data.SqlClient

Public Class MainForm_Group8_Kiet_13
    Dim con As SqlConnection = New SqlConnection("Data Source=SAMURISEEE;Initial Catalog=TienNuoc;Persist Security Info=True;User ID=sa;Password=cabber123")

    Public Function CallData(dtTable)
        Dim sql As String = "Select * from " + dtTable

        Using cmd As SqlCommand = New SqlCommand(sql, con)
            Using da As New SqlDataAdapter()
                da.SelectCommand = cmd
                Using table As New DataTable()
                    da.Fill(table)
                    Return table
                End Using
            End Using
        End Using
    End Function



    Private Sub BtnAddUser_Click(sender As Object, e As EventArgs) Handles BtnAddUser.Click
        Dim AddNewUser As New AddNewUser_Group8_Kiet_13
        AddNewUser.Show()
    End Sub

    Private Sub MainForm_Group2_Kiet_13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TableKH_13_NgTuanKiet.DataSource = CallData("KhachHang")
        TableHd_Group8_Kiet_13.DataSource = CallData("HoaDonNuoc")


    End Sub

    Private Sub BtnReport_Click(sender As Object, e As EventArgs)
        'Dim report As New Report_TableHoaDonNuoc
        'report.Show()

    End Sub

    Private Sub TableKH_13_NgTuanKiet_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles TableKH_13_NgTuanKiet.CellMouseDoubleClick

        Dim userDetails As New UserDetails_Group8_Kiet_13
        userDetails.Show()
        userDetails.TBMaKH.Text = TableKH_13_NgTuanKiet.CurrentRow.Cells(0).Value
        userDetails.CBLoaiKH.SelectedIndex = TableKH_13_NgTuanKiet.CurrentRow.Cells(1).Value - 1
        userDetails.TBTenKH.Text = TableKH_13_NgTuanKiet.CurrentRow.Cells(2).Value
        userDetails.TBDiaChiKH.Text = TableKH_13_NgTuanKiet.CurrentRow.Cells(3).Value
        userDetails.TBMaSoThue.Text = TableKH_13_NgTuanKiet.CurrentRow.Cells(4).Value
        userDetails.TBNhanKhau.Text = TableKH_13_NgTuanKiet.CurrentRow.Cells(5).Value
        userDetails.OriginID = TableKH_13_NgTuanKiet.CurrentRow.Cells(0).Value
    End Sub

    Private Sub BtnAddInvoice_Click(sender As Object, e As EventArgs) Handles BtnAddInvoice.Click
        Dim addInvoice As New AddNewInvoice_Group8_Kiet_13
        addInvoice.Show()

    End Sub

    Private Sub TableHd_Group8_Kiet_13_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles TableHd_Group8_Kiet_13.CellMouseDoubleClick
        Dim invoiceDetails As New InvoiceDetails_Group8_Kiet_13
        invoiceDetails.Show()
        invoiceDetails.TBMaHoaDon.Text = TableHd_Group8_Kiet_13.CurrentRow.Cells(0).Value
        invoiceDetails.CBMaKH.SelectedValue = TableHd_Group8_Kiet_13.CurrentRow.Cells(1).Value
        invoiceDetails.TBChiSoCu.Text = TableHd_Group8_Kiet_13.CurrentRow.Cells(2).Value
        invoiceDetails.TBChiSoMoi.Text = TableHd_Group8_Kiet_13.CurrentRow.Cells(3).Value
        invoiceDetails.TBSoNuocTieuThu.Text = TableHd_Group8_Kiet_13.CurrentRow.Cells(4).Value
        invoiceDetails.TBGiaChuaThue.Text = TableHd_Group8_Kiet_13.CurrentRow.Cells(5).Value
        invoiceDetails.TBThanhTien.Text = TableHd_Group8_Kiet_13.CurrentRow.Cells(6).Value
        invoiceDetails.DPKngayBatDau.Value = TableHd_Group8_Kiet_13.CurrentRow.Cells(7).Value
        invoiceDetails.DPKngayKetThuc.Value = TableHd_Group8_Kiet_13.CurrentRow.Cells(8).Value
        invoiceDetails.OriginID = TableHd_Group8_Kiet_13.CurrentRow.Cells(0).Value
    End Sub
    Function getDataByQuery(ByVal sql As String)
        Dim cmd As New SqlCommand(sql, con)
        Dim ad As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        ad.Fill(table)
        Return table
    End Function
    Private Sub TBSearchUser_TextChanged(sender As Object, e As EventArgs) Handles TBSearchUser.TextChanged
        If (TBSearchUser.Text <> "") Then
            Try
                con.Open()
                Dim sql As String = "Select * from KhachHang where CONCAT(MaKhachHang,LoaiKhachHang,TenKhachHang,DiaChi,MaSoThue,NhauKhau) like '%" & TBSearchUser.Text & "%'"
                Dim cmd As SqlCommand = New SqlCommand(sql, con)
                Dim ad As New SqlDataAdapter(cmd)
                Dim ds = New DataSet
                ad.Fill(ds, "KhachHang")
                con.Close()
                TableKH_13_NgTuanKiet.DataSource = ds
                TableKH_13_NgTuanKiet.DataMember = "KhachHang"
                TableKH_13_NgTuanKiet.Visible = True
            Catch ex As Exception

            End Try
        Else TableKH_13_NgTuanKiet.DataSource = CallData("KhachHang")
        End If
    End Sub

    Private Sub TBSearchInvoice_TextChanged(sender As Object, e As EventArgs) Handles TBSearchInvoice.TextChanged
        If (TBSearchInvoice.Text <> "") Then
            Try
                con.Open()
                Dim sql As String = "Select * from HoaDonNuoc where CONCAT(MaHoaDon,MaKhachHang,ChiSoCu,ChiSoMoi,SoNuocTieuThu,GiaChuaThue,GiaThanhTien,NgayBatDau,NgayKetThuc) like '%" & TBSearchInvoice.Text & "%'"
                Dim cmd As SqlCommand = New SqlCommand(sql, con)
                Dim ad As New SqlDataAdapter(cmd)
                Dim ds = New DataSet
                ad.Fill(ds, "HoaDonNuoc")
                con.Close()
                TableHd_Group8_Kiet_13.DataSource = ds
                TableHd_Group8_Kiet_13.DataMember = "HoaDonNuoc"
                TableHd_Group8_Kiet_13.Visible = True
            Catch ex As Exception

            End Try
        Else TableHd_Group8_Kiet_13.DataSource = CallData("HoaDonNuoc")
        End If
    End Sub


    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim reportTableHd As New ReportHDNuoc
        reportTableHd.Show()
    End Sub


End Class
