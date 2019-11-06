<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RpTransacciones
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SCSCDataSet = New SCSC.SCSCDataSetReport()
        Me.TransaccionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransaccionesTableAdapter = New SCSC.SCSCDataSetReportTableAdapters.TransaccionesTableAdapter()
        CType(Me.SCSCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransaccionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "reporte"
        ReportDataSource1.Value = Me.TransaccionesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SCSC.RptDiario.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(5, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(751, 414)
        Me.ReportViewer1.TabIndex = 0
        '
        'SCSCDataSet
        '
        Me.SCSCDataSet.DataSetName = "SCSCDataSet"
        Me.SCSCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransaccionesBindingSource
        '
        Me.TransaccionesBindingSource.DataMember = "Transacciones"
        Me.TransaccionesBindingSource.DataSource = Me.SCSCDataSet
        '
        'TransaccionesTableAdapter
        '
        Me.TransaccionesTableAdapter.ClearBeforeFill = True
        '
        'RpTransacciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 438)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "RpTransacciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RpTransacciones"
        CType(Me.SCSCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransaccionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TransaccionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SCSCDataSet As SCSC.SCSCDataSetReport
    Friend WithEvents TransaccionesTableAdapter As SCSC.SCSCDataSetReportTableAdapters.TransaccionesTableAdapter
End Class
