<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_NTK
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.HoaDonNuocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TienNuocDataSet = New WaterBilling2.TienNuocDataSet()
        Me.KhachHangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoaiKhachHangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HoaDonNuocTableAdapter = New WaterBilling2.TienNuocDataSetTableAdapters.HoaDonNuocTableAdapter()
        Me.KhachHangTableAdapter = New WaterBilling2.TienNuocDataSetTableAdapters.KhachHangTableAdapter()
        Me.LoaiKhachHangTableAdapter = New WaterBilling2.TienNuocDataSetTableAdapters.LoaiKhachHangTableAdapter()
        CType(Me.HoaDonNuocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TienNuocDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KhachHangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoaiKhachHangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.HoaDonNuocBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.KhachHangBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.LoaiKhachHangBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WaterBilling2.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'HoaDonNuocBindingSource
        '
        Me.HoaDonNuocBindingSource.DataMember = "HoaDonNuoc"
        Me.HoaDonNuocBindingSource.DataSource = Me.TienNuocDataSet
        '
        'TienNuocDataSet
        '
        Me.TienNuocDataSet.DataSetName = "TienNuocDataSet"
        Me.TienNuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KhachHangBindingSource
        '
        Me.KhachHangBindingSource.DataMember = "KhachHang"
        Me.KhachHangBindingSource.DataSource = Me.TienNuocDataSet
        '
        'LoaiKhachHangBindingSource
        '
        Me.LoaiKhachHangBindingSource.DataMember = "LoaiKhachHang"
        Me.LoaiKhachHangBindingSource.DataSource = Me.TienNuocDataSet
        '
        'HoaDonNuocTableAdapter
        '
        Me.HoaDonNuocTableAdapter.ClearBeforeFill = True
        '
        'KhachHangTableAdapter
        '
        Me.KhachHangTableAdapter.ClearBeforeFill = True
        '
        'LoaiKhachHangTableAdapter
        '
        Me.LoaiKhachHangTableAdapter.ClearBeforeFill = True
        '
        'Report_NTK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Report_NTK"
        Me.Text = "Report_NTK"
        CType(Me.HoaDonNuocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TienNuocDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KhachHangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoaiKhachHangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HoaDonNuocBindingSource As BindingSource
    Friend WithEvents TienNuocDataSet As TienNuocDataSet
    Friend WithEvents KhachHangBindingSource As BindingSource
    Friend WithEvents LoaiKhachHangBindingSource As BindingSource
    Friend WithEvents HoaDonNuocTableAdapter As TienNuocDataSetTableAdapters.HoaDonNuocTableAdapter
    Friend WithEvents KhachHangTableAdapter As TienNuocDataSetTableAdapters.KhachHangTableAdapter
    Friend WithEvents LoaiKhachHangTableAdapter As TienNuocDataSetTableAdapters.LoaiKhachHangTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
