Public Class Report_NTK
    Public InvoiceID As String
    Private Sub Report_NTK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TienNuocDataSet.HoaDonNuoc' table. You can move, or remove it, as needed.
        Me.HoaDonNuocTableAdapter.Fill(Me.TienNuocDataSet.HoaDonNuoc, InvoiceID)
        'TODO: This line of code loads data into the 'TienNuocDataSet.KhachHang' table. You can move, or remove it, as needed.
        Me.KhachHangTableAdapter.Fill(Me.TienNuocDataSet.KhachHang)
        'TODO: This line of code loads data into the 'TienNuocDataSet.LoaiKhachHang' table. You can move, or remove it, as needed.
        Me.LoaiKhachHangTableAdapter.Fill(Me.TienNuocDataSet.LoaiKhachHang)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class