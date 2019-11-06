Public Class FrmReport

    Private Sub FrmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SCSCDataSetReport.V_TotalesUsurios' table. You can move, or remove it, as needed.
        Me.V_TotalesUsuriosTableAdapter.Fill(Me.SCSCDataSetReport.V_TotalesUsurios)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class