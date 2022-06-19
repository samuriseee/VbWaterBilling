Imports System.Data.SqlClient

Public Class UserDetails_Group8_Kiet_13
    Dim con As SqlConnection = New SqlConnection("Data Source=SAMURISEEE;Initial Catalog=TienNuoc;Persist Security Info=True;User ID=sa;Password=cabber123")
    Public OriginID As String
    Private Sub UserDetails_Group2_Kiet_13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBLoaiKH.DataSource = MainForm_Group8_Kiet_13.CallData("LoaiKhachHang")
        CBLoaiKH.ValueMember = "STT"
        CBLoaiKH.DisplayMember = "LoaiKhach"
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim MaKhachHang As String = TBMaKH.Text
        Dim TenKhachHang As String = TBTenKH.Text
        Dim LoaiKhachHang As Integer = CBLoaiKH.SelectedIndex + 1
        Dim DiaChiKhachHang As String = TBDiaChiKH.Text
        Dim MaSoThue As String = TBMaSoThue.Text
        Dim NhanKhau As Integer = TBNhanKhau.Text
        Dim query As String = "Update KhachHang set MaKhachHang = @MaKhachHang,LoaiKhachHang = @LoaiKhachHang,TenKhachHang = @TenKhachHang,DiaChi = @DiaChi,MaSoThue = @MaSoThue,NhauKhau = @NhanKhau where MaKhachHang = @OriginID"
        Using cmd As SqlCommand = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang)
            cmd.Parameters.AddWithValue("@LoaiKhachHang", LoaiKhachHang)
            cmd.Parameters.AddWithValue("@TenKhachHang", TenKhachHang)
            cmd.Parameters.AddWithValue("@DiaChi", DiaChiKhachHang)
            cmd.Parameters.AddWithValue("@MaSoThue", MaSoThue)
            cmd.Parameters.AddWithValue("@NhanKhau", NhanKhau)
            cmd.Parameters.AddWithValue("@OriginID", OriginID)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            TBMaKH.Text = ""
            TBDiaChiKH.Text = ""
            TBTenKH.Text = ""
            TBMaSoThue.Text = ""
            TBNhanKhau.Text = ""
            MainForm_Group8_Kiet_13.TableKH_13_NgTuanKiet.DataSource = MainForm_Group8_Kiet_13.CallData("KhachHang")
            MainForm_Group8_Kiet_13.TableHd_Group8_Kiet_13.DataSource = MainForm_Group8_Kiet_13.CallData("HoaDonNuoc")
            MessageBox.Show("Sửa thành công")
            Me.Close()
        End Using
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim query As String = "Delete from KhachHang where MaKhachHang = @OriginID"
        Using cmd As SqlCommand = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@OriginID", OriginID)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MainForm_Group8_Kiet_13.TableKH_13_NgTuanKiet.DataSource = MainForm_Group8_Kiet_13.CallData("KhachHang")
            MessageBox.Show("Xóa thành công")
            Me.Close()
        End Using
    End Sub


End Class