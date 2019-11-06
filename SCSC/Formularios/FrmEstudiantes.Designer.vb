<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstudiantes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEstudiantes))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtTipoUsuario = New System.Windows.Forms.TextBox()
        Me.LblCantTiques = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtSexo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtApe1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtApe2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.StatusLine = New System.Windows.Forms.Label()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.ChkBeca = New System.Windows.Forms.CheckBox()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusText = New System.Windows.Forms.TextBox()
        Me.Prompt = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtTipoUsuario)
        Me.GroupBox1.Controls.Add(Me.LblCantTiques)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.TxtSexo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtApe1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtApe2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(18, 258)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(831, 261)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Estudiante"
        '
        'TxtTipoUsuario
        '
        Me.TxtTipoUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtTipoUsuario.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTipoUsuario.Location = New System.Drawing.Point(127, 25)
        Me.TxtTipoUsuario.MaxLength = 14
        Me.TxtTipoUsuario.Name = "TxtTipoUsuario"
        Me.TxtTipoUsuario.ReadOnly = True
        Me.TxtTipoUsuario.Size = New System.Drawing.Size(120, 26)
        Me.TxtTipoUsuario.TabIndex = 51
        '
        'LblCantTiques
        '
        Me.LblCantTiques.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCantTiques.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantTiques.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblCantTiques.Location = New System.Drawing.Point(570, 116)
        Me.LblCantTiques.Name = "LblCantTiques"
        Me.LblCantTiques.Padding = New System.Windows.Forms.Padding(20, 15, 15, 15)
        Me.LblCantTiques.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblCantTiques.Size = New System.Drawing.Size(201, 78)
        Me.LblCantTiques.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(588, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 19)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Cantidad de Tiquetes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 19)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Tipo de Usuario:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.BtnRegresar)
        Me.Panel4.Controls.Add(Me.BtnCancelar)
        Me.Panel4.Controls.Add(Me.BtnGuardar)
        Me.Panel4.Location = New System.Drawing.Point(13, 150)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(225, 66)
        Me.Panel4.TabIndex = 19
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackgroundImage = Global.SCSC.My.Resources.Resources.Regresar
        Me.BtnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnRegresar.Location = New System.Drawing.Point(143, 0)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(63, 63)
        Me.BtnRegresar.TabIndex = 7
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackgroundImage = Global.SCSC.My.Resources.Resources.Cancelar
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCancelar.Location = New System.Drawing.Point(75, 0)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(63, 63)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = Global.SCSC.My.Resources.Resources.Aceptar
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnGuardar.Location = New System.Drawing.Point(7, 0)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(63, 63)
        Me.BtnGuardar.TabIndex = 0
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TxtSexo
        '
        Me.TxtSexo.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtSexo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSexo.Location = New System.Drawing.Point(431, 81)
        Me.TxtSexo.MaxLength = 14
        Me.TxtSexo.Name = "TxtSexo"
        Me.TxtSexo.ReadOnly = True
        Me.TxtSexo.Size = New System.Drawing.Size(120, 26)
        Me.TxtSexo.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(427, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 19)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Sexo:"
        '
        'TxtApe1
        '
        Me.TxtApe1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtApe1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApe1.Location = New System.Drawing.Point(13, 81)
        Me.TxtApe1.MaxLength = 14
        Me.TxtApe1.Name = "TxtApe1"
        Me.TxtApe1.ReadOnly = True
        Me.TxtApe1.Size = New System.Drawing.Size(120, 26)
        Me.TxtApe1.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 19)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Primer Apellido:"
        '
        'TxtApe2
        '
        Me.TxtApe2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtApe2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApe2.Location = New System.Drawing.Point(149, 81)
        Me.TxtApe2.MaxLength = 14
        Me.TxtApe2.Name = "TxtApe2"
        Me.TxtApe2.ReadOnly = True
        Me.TxtApe2.Size = New System.Drawing.Size(120, 26)
        Me.TxtApe2.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(145, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 19)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Segundo Apellido:"
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtNombre.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(284, 81)
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
        Me.Label3.Location = New System.Drawing.Point(280, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 19)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Nombre:"
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
        Me.Label1.Location = New System.Drawing.Point(285, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 29)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Mantenimiento de Estudiantes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.StatusLine)
        Me.GroupBox2.Controls.Add(Me.Picture)
        Me.GroupBox2.Controls.Add(Me.ChkBeca)
        Me.GroupBox2.Controls.Add(Me.TxtCedula)
        Me.GroupBox2.Controls.Add(Me.Buscar)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(831, 171)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estudiante"
        '
        'StatusLine
        '
        Me.StatusLine.AutoSize = True
        Me.StatusLine.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLine.Location = New System.Drawing.Point(257, 128)
        Me.StatusLine.Name = "StatusLine"
        Me.StatusLine.Size = New System.Drawing.Size(87, 19)
        Me.StatusLine.TabIndex = 25
        Me.StatusLine.Text = "[Status line]"
        '
        'Picture
        '
        Me.Picture.BackColor = System.Drawing.SystemColors.Window
        Me.Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture.Location = New System.Drawing.Point(520, 32)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(158, 115)
        Me.Picture.TabIndex = 43
        Me.Picture.TabStop = False
        '
        'ChkBeca
        '
        Me.ChkBeca.AutoSize = True
        Me.ChkBeca.BackColor = System.Drawing.Color.Transparent
        Me.ChkBeca.Location = New System.Drawing.Point(295, 32)
        Me.ChkBeca.Name = "ChkBeca"
        Me.ChkBeca.Size = New System.Drawing.Size(109, 23)
        Me.ChkBeca.TabIndex = 42
        Me.ChkBeca.Text = "Activar Beca"
        Me.ChkBeca.UseVisualStyleBackColor = False
        '
        'TxtCedula
        '
        Me.TxtCedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtCedula.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCedula.Location = New System.Drawing.Point(127, 28)
        Me.TxtCedula.MaxLength = 14
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(111, 26)
        Me.TxtCedula.TabIndex = 39
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
        Me.Buscar.Location = New System.Drawing.Point(237, 28)
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
        Me.Label4.Location = New System.Drawing.Point(63, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Cédula:"
        '
        'StatusText
        '
        Me.StatusText.BackColor = System.Drawing.SystemColors.Window
        Me.StatusText.Location = New System.Drawing.Point(18, 21)
        Me.StatusText.Multiline = True
        Me.StatusText.Name = "StatusText"
        Me.StatusText.ReadOnly = True
        Me.StatusText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.StatusText.Size = New System.Drawing.Size(71, 19)
        Me.StatusText.TabIndex = 23
        Me.StatusText.Visible = False
        '
        'Prompt
        '
        Me.Prompt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Prompt.Location = New System.Drawing.Point(106, 16)
        Me.Prompt.Name = "Prompt"
        Me.Prompt.ReadOnly = True
        Me.Prompt.Size = New System.Drawing.Size(89, 27)
        Me.Prompt.TabIndex = 24
        Me.Prompt.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(668, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'FrmEstudiantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(859, 531)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Prompt)
        Me.Controls.Add(Me.StatusText)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEstudiantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Estudiantes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BtnRegresar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Buscar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ChkBeca As System.Windows.Forms.CheckBox
    Friend WithEvents TxtApe1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtApe2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblCantTiques As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtTipoUsuario As System.Windows.Forms.TextBox
    Private WithEvents Picture As System.Windows.Forms.PictureBox
    Private WithEvents StatusText As System.Windows.Forms.TextBox
    Private WithEvents Prompt As System.Windows.Forms.TextBox
    Friend WithEvents TxtSexo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents StatusLine As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
