Public Class FrmPrincipal

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.ShowDialog()
    End Sub

    Private Sub RecargasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecargasToolStripMenuItem.Click

        FrmRecarga.ShowDialog()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        FrmEstudiantes.ShowDialog()
    End Sub

    Private Sub ControlDeMarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlDeMarcasToolStripMenuItem.Click
        ControlMarcas.ShowDialog()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        FrmAyuda.Show()

    End Sub

    Private Sub TiposDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReporteDeEstudiantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeEstudiantesToolStripMenuItem.Click
        'ReporteEstudiantes.Show()
    End Sub

    Private Sub ReporteDiariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDiariosToolStripMenuItem.Click
        'RpTransacciones.Show()
    End Sub

    
    Private Sub ContadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContadorToolStripMenuItem.Click
        'FrmReport.Show()

    End Sub
End Class