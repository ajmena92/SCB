<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReport
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
        Me.SCSCDataSetReport = New SCSC.SCSCDataSetReport()
        Me.V_TotalesUsuriosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_TotalesUsuriosTableAdapter = New SCSC.SCSCDataSetReportTableAdapters.V_TotalesUsuriosTableAdapter()
        CType(Me.SCSCDataSetReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_TotalesUsuriosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.V_TotalesUsuriosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SCSC.ReportTotales.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(948, 485)
        Me.ReportViewer1.TabIndex = 0
        '
        'SCSCDataSetReport
        '
        Me.SCSCDataSetReport.DataSetName = "SCSCDataSetReport"
        Me.SCSCDataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'V_TotalesUsuriosBindingSource
        '
        Me.V_TotalesUsuriosBindingSource.DataMember = "V_TotalesUsurios"
        Me.V_TotalesUsuriosBindingSource.DataSource = Me.SCSCDataSetReport
        '
        'V_TotalesUsuriosTableAdapter
        '
        Me.V_TotalesUsuriosTableAdapter.ClearBeforeFill = True
        '
        'FrmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 485)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReport"
        Me.Text = "FrmReport"
        CType(Me.SCSCDataSetReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_TotalesUsuriosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents V_TotalesUsuriosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SCSCDataSetReport As SCSC.SCSCDataSetReport
    Friend WithEvents V_TotalesUsuriosTableAdapter As SCSC.SCSCDataSetReportTableAdapters.V_TotalesUsuriosTableAdapter
End Class
