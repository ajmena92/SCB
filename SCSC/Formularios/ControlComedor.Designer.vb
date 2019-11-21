<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlComedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlComedor))
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
        Me.Imgprocess = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblProcesando = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        PromptLabel = New System.Windows.Forms.Label()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbDatos.SuspendLayout()
        CType(Me.Imgprocess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.BtnSalir.BackColor = System.Drawing.Color.Silver
        Me.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalir.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.Black
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.Location = New System.Drawing.Point(1280, 713)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(70, 38)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "Salir "
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(426, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(531, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sistema de Control de Marcas Comedor"
        '
        'StatusLine
        '
        Me.StatusLine.AutoSize = True
        Me.StatusLine.Location = New System.Drawing.Point(46, 433)
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
        Me.Prompt.Location = New System.Drawing.Point(50, 499)
        Me.Prompt.Name = "Prompt"
        Me.Prompt.ReadOnly = True
        Me.Prompt.Size = New System.Drawing.Size(294, 27)
        Me.Prompt.TabIndex = 16
        Me.Prompt.Visible = False
        '
        'Picture
        '
        Me.Picture.BackColor = System.Drawing.SystemColors.Window
        Me.Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture.Location = New System.Drawing.Point(24, 146)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(263, 219)
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
        Me.GbDatos.Location = New System.Drawing.Point(360, 134)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(775, 252)
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
        Me.TxtTipo.Size = New System.Drawing.Size(597, 40)
        Me.TxtTipo.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(52, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 31)
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
        Me.TxtCedula.Size = New System.Drawing.Size(597, 40)
        Me.TxtCedula.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 31)
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
        Me.TxtTiquetes.Size = New System.Drawing.Size(597, 50)
        Me.TxtTiquetes.TabIndex = 3
        Me.TxtTiquetes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 31)
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
        Me.TxtUsuario.Size = New System.Drawing.Size(597, 40)
        Me.TxtUsuario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 31)
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
        Me.LblFecha.Location = New System.Drawing.Point(14, 26)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(330, 59)
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
        Me.StatusText.Size = New System.Drawing.Size(366, 206)
        Me.StatusText.TabIndex = 18
        Me.StatusText.Visible = False
        '
        'Imgprocess
        '
        Me.Imgprocess.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Imgprocess.BackColor = System.Drawing.Color.Transparent
        Me.Imgprocess.Image = Global.SCSC.My.Resources.Resources.Info
        Me.Imgprocess.Location = New System.Drawing.Point(410, 392)
        Me.Imgprocess.Name = "Imgprocess"
        Me.Imgprocess.Size = New System.Drawing.Size(675, 217)
        Me.Imgprocess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Imgprocess.TabIndex = 24
        Me.Imgprocess.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SCSC.My.Resources.Resources.Ingreso
        Me.PictureBox1.Location = New System.Drawing.Point(1220, 433)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'lblProcesando
        '
        Me.lblProcesando.AutoSize = True
        Me.lblProcesando.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcesando.ForeColor = System.Drawing.Color.Blue
        Me.lblProcesando.Location = New System.Drawing.Point(210, 41)
        Me.lblProcesando.Name = "lblProcesando"
        Me.lblProcesando.Size = New System.Drawing.Size(419, 25)
        Me.lblProcesando.TabIndex = 27
        Me.lblProcesando.Text = "Por favor, coloque su huella digital en el dispositivo"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblProcesando)
        Me.GroupBox1.Location = New System.Drawing.Point(360, 639)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(777, 100)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'ControlComedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 763)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Imgprocess)
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
        Me.Name = "ControlComedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ControlMarcas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        CType(Me.Imgprocess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents Imgprocess As PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblProcesando As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
