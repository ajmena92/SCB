<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecarga
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRecarga))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtRecarga = New System.Windows.Forms.TextBox()
        Me.LblCantTiques = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.LblTotal)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtRecarga)
        Me.GroupBox1.Controls.Add(Me.LblCantTiques)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(18, 177)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 152)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Estudiante"
        '
        'LblTotal
        '
        Me.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotal.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblTotal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LblTotal.Location = New System.Drawing.Point(158, 44)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Padding = New System.Windows.Forms.Padding(2)
        Me.LblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblTotal.Size = New System.Drawing.Size(202, 31)
        Me.LblTotal.TabIndex = 54
        Me.LblTotal.Text = " "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(163, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 19)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 19)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Tiquetes a Recargar"
        '
        'TxtRecarga
        '
        Me.TxtRecarga.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtRecarga.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRecarga.Location = New System.Drawing.Point(10, 44)
        Me.TxtRecarga.MaxLength = 14
        Me.TxtRecarga.Name = "TxtRecarga"
        Me.TxtRecarga.Size = New System.Drawing.Size(120, 26)
        Me.TxtRecarga.TabIndex = 51
        '
        'LblCantTiques
        '
        Me.LblCantTiques.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCantTiques.Font = New System.Drawing.Font("Arial", 13.75!, System.Drawing.FontStyle.Bold)
        Me.LblCantTiques.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblCantTiques.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LblCantTiques.Location = New System.Drawing.Point(383, 65)
        Me.LblCantTiques.Name = "LblCantTiques"
        Me.LblCantTiques.Padding = New System.Windows.Forms.Padding(20, 20, 15, 15)
        Me.LblCantTiques.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblCantTiques.Size = New System.Drawing.Size(138, 69)
        Me.LblCantTiques.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(396, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 19)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Total de  Tiquetes"
        '
        'TxtPrimerApellido
        '
        Me.TxtPrimerApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtPrimerApellido.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrimerApellido.Location = New System.Drawing.Point(22, 89)
        Me.TxtPrimerApellido.MaxLength = 14
        Me.TxtPrimerApellido.Name = "TxtPrimerApellido"
        Me.TxtPrimerApellido.ReadOnly = True
        Me.TxtPrimerApellido.Size = New System.Drawing.Size(120, 26)
        Me.TxtPrimerApellido.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 19)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Primer Apellido:"
        '
        'TxtSegundoApellido
        '
        Me.TxtSegundoApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtSegundoApellido.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSegundoApellido.Location = New System.Drawing.Point(158, 89)
        Me.TxtSegundoApellido.MaxLength = 14
        Me.TxtSegundoApellido.Name = "TxtSegundoApellido"
        Me.TxtSegundoApellido.ReadOnly = True
        Me.TxtSegundoApellido.Size = New System.Drawing.Size(120, 26)
        Me.TxtSegundoApellido.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(154, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 19)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Segundo Apellido:"
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtNombre.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(293, 89)
        Me.TxtNombre.MaxLength = 14
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(120, 26)
        Me.TxtNombre.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(289, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 19)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Nombre:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.BtnRegresar)
        Me.Panel4.Controls.Add(Me.BtnCancelar)
        Me.Panel4.Controls.Add(Me.BtnGuardar)
        Me.Panel4.Location = New System.Drawing.Point(392, 346)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(198, 66)
        Me.Panel4.TabIndex = 19
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackgroundImage = Global.SCSC.My.Resources.Resources.Regresar
        Me.BtnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnRegresar.Location = New System.Drawing.Point(129, 2)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(62, 63)
        Me.BtnRegresar.TabIndex = 8
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackgroundImage = Global.SCSC.My.Resources.Resources.Cancelar
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCancelar.Location = New System.Drawing.Point(67, 2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(62, 63)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = Global.SCSC.My.Resources.Resources.Aceptar
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnGuardar.Location = New System.Drawing.Point(5, 2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(62, 63)
        Me.BtnGuardar.TabIndex = 0
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(140, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 29)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Modulo Recargas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtCedula)
        Me.GroupBox2.Controls.Add(Me.Buscar)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtPrimerApellido)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtNombre)
        Me.GroupBox2.Controls.Add(Me.TxtSegundoApellido)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(572, 121)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estudiante"
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtCedula.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(82, 28)
        Me.txtCedula.MaxLength = 14
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(111, 26)
        Me.txtCedula.TabIndex = 39
        '
        'Buscar
        '
        Me.Buscar.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.Buscar.BackColor = System.Drawing.Color.Transparent
        Me.Buscar.BackgroundImage = Global.SCSC.My.Resources.Resources.Buscar_30x30
        Me.Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Buscar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Buscar.FlatAppearance.BorderSize = 0
        Me.Buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buscar.ForeColor = System.Drawing.Color.White
        Me.Buscar.Location = New System.Drawing.Point(199, 27)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(27, 27)
        Me.Buscar.TabIndex = 41
        Me.Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Buscar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Cédula:"
        '
        'FrmRecarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(619, 426)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRecarga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de estudiantes "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Buscar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtPrimerApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtSegundoApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblCantTiques As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtRecarga As System.Windows.Forms.TextBox
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnRegresar As System.Windows.Forms.Button
End Class
