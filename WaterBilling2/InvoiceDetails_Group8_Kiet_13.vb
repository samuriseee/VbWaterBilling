Imports System.Data.SqlClient

Public Class InvoiceDetails_Group8_Kiet_13
    Dim con As SqlConnection = New SqlConnection("Data Source=SAMURISEEE;Initial Catalog=TienNuoc;Persist Security Info=True;User ID=sa;Password=cabber123")
    Public OriginID As String
    Dim LoaiKhachHang As String
    Private Sub InvoiceDetails_Group8_Kiet_13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBMaKH.DataSource = MainForm_Group8_Kiet_13.CallData("KhachHang")
        CBMaKH.ValueMember = "MaKhachHang"
        CBMaKH.DisplayMember = "MaKhachHang"

    End Sub
    Public Function CalWaterPayIncludedTax(input)
        Select Case LoaiKhachHang
            Case 1
                If (input <= 10) Then
                    Return input * 4580
                ElseIf (input > 10 And input <= 31) Then
                    Return (10 * 4580) + ((input - 10) * 5488)
                Else Return (10 * 4580) + (21 * 5488) + ((input - 31) * 6849)
                End If
            Case 2
                Return input * 7564
            Case 3
                Return input * 10759
            Case 4
                Return input * 16302
        End Select

    End Function

    Public Function CalWaterPayWithoutTax(input)
        Select Case LoaiKhachHang
            Case 1
                If (input <= 10) Then
                    Return input * 3809
                ElseIf (input > 10 And input <= 31) Then
                    Return (10 * 3809) + ((input - 10) * 4571)
                Else Return (10 * 3809) + (21 * 4571) + ((input - 31) * 5714)
                End If
            Case 2
                Return input * 6476
            Case 3
                Return input * 8476
            Case 4
                Return input * 12857
        End Select

    End Function

    Private Sub BtnUpdateInvoice_Click(sender As Object, e As EventArgs) Handles BtnUpdateInvoice.Click
        Dim MaHoaDon As String = TBMaHoaDon.Text

        Dim row_v As DataRowView = CBMaKH.SelectedItem
        Dim row As DataRow = row_v.Row
        Dim MaKhachHang As String = row(0).ToString

        Dim ChiSoCu As String = TBChiSoCu.Text
        Dim ChiSoMoi As Integer = TBChiSoMoi.Text
        Dim SoNuocTieuThu As String = TBSoNuocTieuThu.Text
        Dim GiaChuaThue As String = TBGiaChuaThue.Text
        Dim ThanhTien As Integer = TBThanhTien.Text
        Dim NgayBatDau As String = DPKngayBatDau.Value.ToString("yyyyMMdd")
        Dim NgayKetThuc As String = DPKngayKetThuc.Value.ToString("yyyyMMdd")
        Dim query As String = "Update HoaDonNuoc set MaHoaDon = @MaHoaDon, MaKhachHang = @MaKhachHang,ChiSoCu = @ChiSoCu,ChiSoMoi = @ChiSoMoi,SoNuocTieuThu = @SoNuocTieuThu,GiaChuaThue = @GiaChuaThue,GiaThanhTien = @ThanhTien, NgayBatDau = @NgayBatDau,NgayKetThuc = @NgayKetThuc where MaHoaDon = @OriginID"
        Using cmd As SqlCommand = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@MaHoaDon", MaHoaDon)
            cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang)
            cmd.Parameters.AddWithValue("@ChiSoCu", ChiSoCu)
            cmd.Parameters.AddWithValue("@ChiSoMoi", ChiSoMoi)
            cmd.Parameters.AddWithValue("@SoNuocTieuThu", SoNuocTieuThu)
            cmd.Parameters.AddWithValue("@GiaChuaThue", GiaChuaThue)
            cmd.Parameters.AddWithValue("@ThanhTien", ThanhTien)
            cmd.Parameters.AddWithValue("@NgayBatDau", NgayBatDau)
            cmd.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc)
            cmd.Parameters.AddWithValue("@OriginID", OriginID)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            TBMaHoaDon.Text = ""
            TBChiSoCu.Text = ""
            TBChiSoMoi.Text = ""
            TBGiaChuaThue.Text = ""
            TBSoNuocTieuThu.Text = ""
            TBThanhTien.Text = ""

            MainForm_Group8_Kiet_13.TableHd_Group8_Kiet_13.DataSource = MainForm_Group8_Kiet_13.CallData("HoaDonNuoc")
            MessageBox.Show("Sửa thành công")
            Me.Close()
        End Using
    End Sub

    Private Sub CBMaKH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMaKH.SelectedIndexChanged
        Dim row_v As DataRowView = CBMaKH.SelectedItem
        Dim row As DataRow = row_v.Row
        Dim MaKhachHang As String = row(0).ToString
        Dim sql As String = "Select LoaiKhachHang from KhachHang where MaKhachHang = '" & MaKhachHang & "'"
        Dim sqlResult As String
        Using cmd As SqlCommand = New SqlCommand(sql, con)
            con.Open()
            sqlResult = cmd.ExecuteScalar()
            LoaiKhachHang = If((TypeOf sqlResult Is String), CType(sqlResult, String), "(null)")

            con.Close()
        End Using
        TBSoNuocTieuThu.Text = ""
        TBChiSoCu.Text = ""
        TBChiSoMoi.Text = ""
    End Sub

    Private Sub TBChiSoMoi_TextChanged(sender As Object, e As EventArgs) Handles TBChiSoMoi.TextChanged
        If (TBChiSoCu.Text <> "" And TBChiSoMoi.Text <> "") Then
            TBSoNuocTieuThu.Text = CDbl(Val("0" + TBChiSoMoi.Text)) - CDbl(Val("0" + TBChiSoCu.Text))
        End If
    End Sub

    Private Sub TBSoNuocTieuThu_TextChanged(sender As Object, e As EventArgs) Handles TBSoNuocTieuThu.TextChanged
        TBThanhTien.Text = CalWaterPayIncludedTax(CDbl(Val("0" + TBSoNuocTieuThu.Text)))
        TBGiaChuaThue.Text = CalWaterPayWithoutTax(CDbl(Val("0" + TBSoNuocTieuThu.Text)))

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim query As String = "Delete from HoaDonNuoc where MaHoaDon = @OriginID"
        Using cmd As SqlCommand = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@OriginID", OriginID)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MainForm_Group8_Kiet_13.TableHd_Group8_Kiet_13.DataSource = MainForm_Group8_Kiet_13.CallData("HoaDonNuoc")
            MessageBox.Show("Xóa thành công")
            Me.Close()
        End Using
    End Sub

    Private Sub BtnBaoCao_Click_1(sender As Object, e As EventArgs) Handles BtnBaoCao.Click
        Dim report As New Report_NTK
        report.InvoiceID = OriginID
        report.Show()
    End Sub
End Class