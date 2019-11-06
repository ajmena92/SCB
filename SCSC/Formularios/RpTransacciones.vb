Public Class RpTransacciones

    Private Sub RpTransacciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SCSCDataSet.Transacciones' table. You can move, or remove it, as needed.
        Me.TransaccionesTableAdapter.Fill(Me.SCSCDataSet.Transacciones)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class