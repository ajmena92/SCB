Public Class ReporteEstudiantes

    Private Sub ReporteEstudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SCSCDataSet.Transacciones' table. You can move, or remove it, as needed.
        Me.TransaccionesTableAdapter.Fill(Me.SCSCDataSet.Transacciones)
        'TODO: This line of code loads data into the 'SCSCDataSet.Usuario' table. You can move, or remove it, as needed.
        Me.UsuarioTableAdapter.Fill(Me.SCSCDataSet.Usuario)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class