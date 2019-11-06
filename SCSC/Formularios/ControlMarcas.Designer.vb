<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlMarcas
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
        Dim PromptLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlMarcas))
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusLine = New System.Windows.Forms.Label()
        Me.Prompt = New System.Windows.Forms.TextBox()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTiquetes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.StatusText = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        PromptLabel = New System.Windows.Forms.Label()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbDatos.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PromptLabel
        '
        PromptLabel.AutoSize = True
        PromptLabel.Location = New System.Drawing.Point(767, 464)
        PromptLabel.Name = "PromptLabel"
        PromptLabel.Size = New System.Drawing.Size(59, 19)
        PromptLabel.TabIndex = 15
        PromptLabel.Text = "Prompt:"
        PromptLabel.Visible = False
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(776, 518)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(290, 50)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "Salir del Sistema"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(353, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sistema de Control de Marcas"
        '
        'StatusLine
        '
        Me.StatusLine.AutoSize = True
        Me.StatusLine.Location = New System.Drawing.Point(157, 548)
        Me.StatusLine.Name = "StatusLine"
        Me.StatusLine.Size = New System.Drawing.Size(87, 19)
        Me.StatusLine.TabIndex = 19
        Me.StatusLine.Text = "[Status line]"
        Me.StatusLine.Visible = False
        '
        'Prompt
        '
        Me.Prompt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Prompt.Location = New System.Drawing.Point(832, 461)
        Me.Prompt.Name = "Prompt"
        Me.Prompt.ReadOnly = True
        Me.Prompt.Size = New System.Drawing.Size(235, 27)
        Me.Prompt.TabIndex = 16
        Me.Prompt.Visible = False
        '
        'Picture
        '
        Me.Picture.BackColor = System.Drawing.SystemColors.Window
        Me.Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture.Location = New System.Drawing.Point(24, 82)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(309, 283)
        Me.Picture.TabIndex = 14
        Me.Picture.TabStop = False
        '
        'GbDatos
        '
        Me.GbDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbDatos.BackColor = System.Drawing.Color.Transparent
        Me.GbDatos.Controls.Add(Me.TxtTipo)
        Me.GbDatos.Controls.Add(Me.Label5)
        Me.GbDatos.Controls.Add(Me.TxtCedula)
        Me.GbDatos.Controls.Add(Me.Label4)
        Me.GbDatos.Controls.Add(Me.TxtTiquetes)
        Me.GbDatos.Controls.Add(Me.Label3)
        Me.GbDatos.Controls.Add(Me.TxtUsuario)
        Me.GbDatos.Controls.Add(Me.Label2)
        Me.GbDatos.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbDatos.Location = New System.Drawing.Point(360, 165)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(706, 252)
        Me.GbDatos.TabIndex = 20
        Me.GbDatos.TabStop = False
        Me.GbDatos.Text = "Datos de Usuario"
        '
        'TxtTipo
        '
        Me.TxtTipo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTipo.BackColor = System.Drawing.Color.White
        Me.TxtTipo.Location = New System.Drawing.Point(127, 131)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.ReadOnly = True
        Me.TxtTipo.Size = New System.Drawing.Size(395, 40)
        Me.TxtTipo.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(52, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 33)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tipo:"
        '
        'TxtCedula
        '
        Me.TxtCedula.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCedula.BackColor = System.Drawing.Color.White
        Me.TxtCedula.Location = New System.Drawing.Point(127, 39)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.ReadOnly = True
        Me.TxtCedula.Size = New System.Drawing.Size(395, 40)
        Me.TxtCedula.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 33)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cedula:"
        '
        'TxtTiquetes
        '
        Me.TxtTiquetes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTiquetes.BackColor = System.Drawing.Color.White
        Me.TxtTiquetes.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTiquetes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtTiquetes.Location = New System.Drawing.Point(127, 177)
        Me.TxtTiquetes.Name = "TxtTiquetes"
        Me.TxtTiquetes.ReadOnly = True
        Me.TxtTiquetes.Size = New System.Drawing.Size(395, 50)
        Me.TxtTiquetes.TabIndex = 3
        Me.TxtTiquetes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 33)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tiquetes:"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUsuario.BackColor = System.Drawing.Color.White
        Me.TxtUsuario.Location = New System.Drawing.Point(127, 85)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.ReadOnly = True
        Me.TxtUsuario.Size = New System.Drawing.Size(395, 40)
        Me.TxtUsuario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Usuario:"
        '
        'LblFecha
        '
        Me.LblFecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblFecha.BackColor = System.Drawing.Color.Transparent
        Me.LblFecha.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblFecha.Location = New System.Drawing.Point(626, 94)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(215, 59)
        Me.LblFecha.TabIndex = 21
        Me.LblFecha.Text = "Label6"
        '
        'StatusText
        '
        Me.StatusText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusText.BackColor = System.Drawing.SystemColors.Window
        Me.StatusText.Location = New System.Drawing.Point(24, 545)
        Me.StatusText.Multiline = True
        Me.StatusText.Name = "StatusText"
        Me.StatusText.ReadOnly = True
        Me.StatusText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.StatusText.Size = New System.Drawing.Size(83, 24)
        Me.StatusText.TabIndex = 18
        Me.StatusText.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(24, 406)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 133)
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'ControlMarcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1079, 581)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.StatusLine)
        Me.Controls.Add(Me.StatusText)
        Me.Controls.Add(Me.Prompt)
        Me.Controls.Add(PromptLabel)
        Me.Controls.Add(Me.Picture)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ControlMarcas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ControlMarcas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents StatusLine As System.Windows.Forms.Label
    Private WithEvents Prompt As System.Windows.Forms.TextBox
    Private WithEvents Picture As System.Windows.Forms.PictureBox
    Friend WithEvents GbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTiquetes As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Private WithEvents StatusText As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
