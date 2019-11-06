<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecargasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilitariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeMarcasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDiariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeEstudiantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem, Me.UtilitariosToolStripMenuItem, Me.SeguridadToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(774, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.RecargasToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.UsuariosToolStripMenuItem.Text = "Registro de Usuarios"
        '
        'RecargasToolStripMenuItem
        '
        Me.RecargasToolStripMenuItem.Name = "RecargasToolStripMenuItem"
        Me.RecargasToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RecargasToolStripMenuItem.Text = "Recargas"
        '
        'UtilitariosToolStripMenuItem
        '
        Me.UtilitariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlDeMarcasToolStripMenuItem})
        Me.UtilitariosToolStripMenuItem.Name = "UtilitariosToolStripMenuItem"
        Me.UtilitariosToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.UtilitariosToolStripMenuItem.Text = "Utilitarios"
        '
        'ControlDeMarcasToolStripMenuItem
        '
        Me.ControlDeMarcasToolStripMenuItem.Name = "ControlDeMarcasToolStripMenuItem"
        Me.ControlDeMarcasToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ControlDeMarcasToolStripMenuItem.Text = "Control de Marcas"
        '
        'SeguridadToolStripMenuItem
        '
        Me.SeguridadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeguridadToolStripMenuItem2})
        Me.SeguridadToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop
        Me.SeguridadToolStripMenuItem.Name = "SeguridadToolStripMenuItem"
        Me.SeguridadToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SeguridadToolStripMenuItem.Text = "Seguridad"
        '
        'SeguridadToolStripMenuItem2
        '
        Me.SeguridadToolStripMenuItem2.Name = "SeguridadToolStripMenuItem2"
        Me.SeguridadToolStripMenuItem2.Size = New System.Drawing.Size(127, 22)
        Me.SeguridadToolStripMenuItem2.Text = "Seguridad"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteDiariosToolStripMenuItem, Me.ReporteDeEstudiantesToolStripMenuItem, Me.ContadorToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ReporteDiariosToolStripMenuItem
        '
        Me.ReporteDiariosToolStripMenuItem.Name = "ReporteDiariosToolStripMenuItem"
        Me.ReporteDiariosToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ReporteDiariosToolStripMenuItem.Text = "Reporte Diarios"
        '
        'ReporteDeEstudiantesToolStripMenuItem
        '
        Me.ReporteDeEstudiantesToolStripMenuItem.Name = "ReporteDeEstudiantesToolStripMenuItem"
        Me.ReporteDeEstudiantesToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ReporteDeEstudiantesToolStripMenuItem.Text = "Reporte De Estudiantes"
        '
        'ContadorToolStripMenuItem
        '
        Me.ContadorToolStripMenuItem.Name = "ContadorToolStripMenuItem"
        Me.ContadorToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ContadorToolStripMenuItem.Text = "Contador"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(574, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(325, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 158)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(774, 353)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Control Servicio al Comedor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeguridadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilitariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeguridadToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecargasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlDeMarcasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDiariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeEstudiantesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ContadorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
