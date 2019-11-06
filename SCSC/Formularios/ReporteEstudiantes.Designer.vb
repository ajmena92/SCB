<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteEstudiantes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteEstudiantes))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCSCDataSet = New SCSC.SCSCDataSetReport()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TransaccionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New SCSC.SCSCDataSetReportTableAdapters.UsuarioTableAdapter()
        Me.TransaccionesTableAdapter = New SCSC.SCSCDataSetReportTableAdapters.TransaccionesTableAdapter()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCSCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransaccionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.SCSCDataSet
        '
        'SCSCDataSet
        '
        Me.SCSCDataSet.DataSetName = "SCSCDataSet"
        Me.SCSCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackgroundImage = CType(resources.GetObject("ReportViewer1.BackgroundImage"), System.Drawing.Image)
        Me.ReportViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        ReportDataSource1.Name = "Reporte"
        ReportDataSource1.Value = Me.UsuarioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SCSC.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(744, 492)
        Me.ReportViewer1.TabIndex = 0
        '
        'TransaccionesBindingSource
        '
        Me.TransaccionesBindingSource.DataMember = "Transacciones"
        Me.TransaccionesBindingSource.DataSource = Me.SCSCDataSet
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'TransaccionesTableAdapter
        '
        Me.TransaccionesTableAdapter.ClearBeforeFill = True
        '
        'ReporteEstudiantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 490)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReporteEstudiantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReporteEstudiantes"
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCSCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransaccionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SCSCDataSet As SCSC.SCSCDataSetReport
    Friend WithEvents UsuarioTableAdapter As SCSC.SCSCDataSetReportTableAdapters.UsuarioTableAdapter
    Friend WithEvents TransaccionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransaccionesTableAdapter As SCSC.SCSCDataSetReportTableAdapters.TransaccionesTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
