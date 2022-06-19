Imports System.Data.SqlClient
Public Class AddNewUser_Group8_Kiet_13
    Dim con As SqlConnection = New SqlConnection("Data Source=SAMURISEEE;Initial Catalog=TienNuoc;Persist Security Info=True;User ID=sa;Password=cabber123")

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim MaKhachHang As String = TBMaKH.Text
        Dim TenKhachHang As String = TBTenKH.Text
        Dim LoaiKhachHang As Integer = CBLoaiKH.SelectedIndex + 1
        Dim DiaChiKhachHang As String = TBDiaChiKH.Text
        Dim MaSoThue As String = TBMaSoThue.Text
        Dim NhanKhau As Integer = TBNhanKhau.Text
        Dim query As String = "Insert into KhachHang Values(@MaKhachHang,@LoaiKhachHang,@TenKhachHang,@DiaChi,@MaSoThue,@NhanKhau)"
        Using cmd As SqlCommand = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang)
            cmd.Parameters.AddWithValue("@LoaiKhachHang", LoaiKhachHang)
            cmd.Parameters.AddWithValue("@TenKhachHang", TenKhachHang)
            cmd.Parameters.AddWithValue("@DiaChi", DiaChiKhachHang)
            cmd.Parameters.AddWithValue("@MaSoThue", MaSoThue)
            cmd.Parameters.AddWithValue("@NhanKhau", NhanKhau)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            TBMaKH.Text = ""
            TBDiaChiKH.Text = ""
            TBTenKH.Text = ""
            TBMaSoThue.Text = ""
            TBNhanKhau.Text = ""
            MainForm_Group8_Kiet_13.TableKH_13_NgTuanKiet.DataSource = MainForm_Group8_Kiet_13.CallData("KhachHang")
            MessageBox.Show("Thêm vào thành công")
            Me.Close()
        End Using
    End Sub

    Private Sub AddNewUser_Group2_Kiet_13_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CBLoaiKH.DataSource = MainForm_Group8_Kiet_13.CallData("LoaiKhachHang")
        CBLoaiKH.ValueMember = "STT"
        CBLoaiKH.DisplayMember = "LoaiKhach"

    End Sub

End Class