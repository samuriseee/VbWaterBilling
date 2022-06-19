<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportHDNuoc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.HoaDonNuocDataSet = New WaterBilling2.HoaDonNuocDataSet()
        Me.HoaDonNuocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HoaDonNuocTableAdapter = New WaterBilling2.HoaDonNuocDataSetTableAdapters.HoaDonNuocTableAdapter()
        CType(Me.HoaDonNuocDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoaDonNuocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.HoaDonNuocBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WaterBilling2.ReportHoaDonNuoc.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'HoaDonNuocDataSet
        '
        Me.HoaDonNuocDataSet.DataSetName = "HoaDonNuocDataSet"
        Me.HoaDonNuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HoaDonNuocBindingSource
        '
        Me.HoaDonNuocBindingSource.DataMember = "HoaDonNuoc"
        Me.HoaDonNuocBindingSource.DataSource = Me.HoaDonNuocDataSet
        '
        'HoaDonNuocTableAdapter
        '
        Me.HoaDonNuocTableAdapter.ClearBeforeFill = True
        '
        'ReportHDNuoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReportHDNuoc"
        Me.Text = "ReportHDNuoc"
        CType(Me.HoaDonNuocDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoaDonNuocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents HoaDonNuocBindingSource As BindingSource
    Friend WithEvents HoaDonNuocDataSet As HoaDonNuocDataSet
    Friend WithEvents HoaDonNuocTableAdapter As HoaDonNuocDataSetTableAdapters.HoaDonNuocTableAdapter
End Class
