Public Class ReportHDNuoc
    Private Sub ReportHDNuoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HoaDonNuocDataSet.HoaDonNuoc' table. You can move, or remove it, as needed.
        Me.HoaDonNuocTableAdapter.Fill(Me.HoaDonNuocDataSet.HoaDonNuoc)

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class