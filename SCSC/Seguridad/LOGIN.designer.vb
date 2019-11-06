<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Login
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnAbrir = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ChkOpen = New System.Windows.Forms.CheckBox()
        Me.ClavePaso = New System.Windows.Forms.TextBox()
        Me.CodUsuario = New System.Windows.Forms.TextBox()
        Me.fecha = New System.Windows.Forms.Label()
        Me.NombreUsuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAbrir
        '
        Me.BtnAbrir.Image = Global.SCSC.My.Resources.Resources.Aceptar
        Me.BtnAbrir.Location = New System.Drawing.Point(279, 204)
        Me.BtnAbrir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAbrir.Name = "BtnAbrir"
        Me.BtnAbrir.Size = New System.Drawing.Size(62, 50)
        Me.BtnAbrir.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.BtnAbrir, "Abrir")
        Me.BtnAbrir.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Image = Global.SCSC.My.Resources.Resources.Regresar
        Me.Salir.Location = New System.Drawing.Point(344, 204)
        Me.Salir.Margin = New System.Windows.Forms.Padding(4)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(62, 50)
        Me.Salir.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.Salir, "Salir")
        Me.Salir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.ChkOpen)
        Me.GroupBox1.Controls.Add(Me.ClavePaso)
        Me.GroupBox1.Controls.Add(Me.CodUsuario)
        Me.GroupBox1.Controls.Add(Me.fecha)
        Me.GroupBox1.Controls.Add(Me.NombreUsuario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(13, 53)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(393, 133)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(341, 17)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'ChkOpen
        '
        Me.ChkOpen.AutoSize = True
        Me.ChkOpen.Location = New System.Drawing.Point(277, 105)
        Me.ChkOpen.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkOpen.Name = "ChkOpen"
        Me.ChkOpen.Size = New System.Drawing.Size(108, 20)
        Me.ChkOpen.TabIndex = 22
        Me.ChkOpen.Text = "Force Open"
        Me.ChkOpen.UseVisualStyleBackColor = True
        Me.ChkOpen.Visible = False
        '
        'ClavePaso
        '
        Me.ClavePaso.AcceptsReturn = True
        Me.ClavePaso.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClavePaso.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ClavePaso.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClavePaso.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ClavePaso.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ClavePaso.Location = New System.Drawing.Point(116, 98)
        Me.ClavePaso.Margin = New System.Windows.Forms.Padding(4)
        Me.ClavePaso.MaxLength = 0
        Me.ClavePaso.Name = "ClavePaso"
        Me.ClavePaso.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ClavePaso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ClavePaso.Size = New System.Drawing.Size(111, 27)
        Me.ClavePaso.TabIndex = 13
        '
        'CodUsuario
        '
        Me.CodUsuario.AcceptsReturn = True
        Me.CodUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.CodUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CodUsuario.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodUsuario.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CodUsuario.Location = New System.Drawing.Point(116, 63)
        Me.CodUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.CodUsuario.MaxLength = 5
        Me.CodUsuario.Name = "CodUsuario"
        Me.CodUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CodUsuario.Size = New System.Drawing.Size(70, 27)
        Me.CodUsuario.TabIndex = 12
        '
        'fecha
        '
        Me.fecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.fecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fecha.Cursor = System.Windows.Forms.Cursors.Default
        Me.fecha.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.ForeColor = System.Drawing.Color.Red
        Me.fecha.Location = New System.Drawing.Point(116, 17)
        Me.fecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.fecha.Name = "fecha"
        Me.fecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fecha.Size = New System.Drawing.Size(217, 37)
        Me.fecha.TabIndex = 19
        Me.fecha.Text = "20/06/2013"
        Me.fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NombreUsuario
        '
        Me.NombreUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.NombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NombreUsuario.Cursor = System.Windows.Forms.Cursors.Default
        Me.NombreUsuario.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreUsuario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NombreUsuario.Location = New System.Drawing.Point(194, 63)
        Me.NombreUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NombreUsuario.Name = "NombreUsuario"
        Me.NombreUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NombreUsuario.Size = New System.Drawing.Size(191, 27)
        Me.NombreUsuario.TabIndex = 20
        Me.NombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(106, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Fecha Sistema:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(3, 101)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(104, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Clave de Paso:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(1, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(109, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "No. de Usuario:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(89, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 29)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Control de Seguridad"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Cursor = System.Windows.Forms.Cursors.Default
        Me.Version.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.ForeColor = System.Drawing.Color.Black
        Me.Version.Location = New System.Drawing.Point(3, 251)
        Me.Version.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Version.Name = "Version"
        Me.Version.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Version.Size = New System.Drawing.Size(117, 15)
        Me.Version.TabIndex = 36
        Me.Version.Text = "Version del Sistema "
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(401, 276)
        Me.ControlBox = False
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnAbrir)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(143, 113)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Seguridad "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub

    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAbrir As System.Windows.Forms.Button
    Public WithEvents ClavePaso As System.Windows.Forms.TextBox
    Public WithEvents CodUsuario As System.Windows.Forms.TextBox
    Public WithEvents fecha As System.Windows.Forms.Label
    Friend WithEvents Salir As System.Windows.Forms.Button
    Public WithEvents NombreUsuario As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChkOpen As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox    
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Version As System.Windows.Forms.Label
#End Region
End Class