Imports System.IO

Public Class FrmEstudiantes
    Implements DPFP.Capture.EventHandler
    Private Capturer As DPFP.Capture.Capture
    Private Enroller As DPFP.Processing.Enrollment
    'Private Data As AppData
    Public Event OnTemplate(ByVal template)

    Dim ActivaEdicion As Boolean = False
    Dim Cn As New SqlClient.SqlConnection
    Dim Cls As New FuncionesDB
    Private Sub FrmEstudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cls.AbrirConexion(Cn, False)
            Init()
        Catch ex As Exception
            If Cn.State = ConnectionState.Open Then
                Cls.CerrarConexion(Cn)
            End If
            MsgBox("Error al cargar el Formulario: " & ex.Message, MsgBoxStyle.Critical)
            End 'Cierro la aplicacion porque no se pudo abrir la conexion
        End Try
        TxtCedula.Focus()
    End Sub

    Sub LimpiarPantalla()
        'TxtCedula.Clear()
        TxtApe1.Clear()
        TxtApe2.Clear()
        TxtNombre.Clear()
        TxtSexo.Clear()
        TxtTipoUsuario.Clear()
        ChkBeca.Checked = False
        LblCantTiques.Text = "0 Tiquetes"
        TxtCedula.Focus()
        Picture.Image = Nothing
        Try
            StopCapture()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Try
            TxtCedula.Clear()
            Dim Valores(), Llave() As FuncionesDB.Campos
            Valores = Cls.InicializarArray
            Llave = Cls.InicializarArray
            LimpiarSession()
            gSession.Titulo = "Usuarios del Sistema"
            gSession.Valor1 = "Usuario"   '  TABLA utilizada.
            gSession.Valor2 = "IdUsuario" ' ORDER BY
            gSession.Valor3 = "Cedula" ' codigo devuelto a la aplicacion en propiedad gsession.resultado
            gSession.Valor4 = "Cedula,Nombre,PrimerApellido,SegundoApellido" ' Valor presentado al usuario
            gSession.Valor5 = "Nombre" ' campo para el filtro utilizado
            Cls.ArmaValor(Valores, "Cedula", "Cédula")
            Cls.ArmaValor(Valores, "Nombre", "Nombre")
            Cls.ArmaValor(Valores, "PrimerApellido", "1° Apellido")
            Cls.ArmaValor(Valores, "SegundoApellido", "2­­° Apellido")
            'Armado de la llave primaria, 1=1 para todos los registros
            Cls.ArmaValor(Llave, "1", "1")
            gSession.Valores = Valores
            gSession.Llave = Llave
            Dim F As New Busqueda
            F.ShowDialog()
            TxtCedula.Text = (gSession.Resultado(0))
            TxtCedula_Validated(sender, e)
        Catch ex As Exception
            'MsgBox(MSJ.Mensajes.ErrorBusqueda)
        End Try

    End Sub

    Private Sub TxtCedula_Validated(sender As Object, e As EventArgs) Handles TxtCedula.Validated
        TxtCedula.Text = TxtCedula.Text.Trim
        Dim Ds As New DataSet
        Dim Valores(), Llave() As FuncionesDB.Campos
        If Len(TxtCedula.Text) > 0 Then
            Try
                Valores = Cls.InicializarArray
                Llave = Cls.InicializarArray
                Cls.ArmaValor(Llave, "Cedula", TxtCedula.Text)
                Cls.ArmaValor(Valores, "IdUsuario")
                Cls.ArmaValor(Valores, "Nombre")
                Cls.ArmaValor(Valores, "PrimerApellido")
                Cls.ArmaValor(Valores, "SegundoApellido")
                Cls.ArmaValor(Valores, "CantidadTiquetes")
                Cls.ArmaValor(Valores, "CodTipo")
                Cls.ArmaValor(Valores, "Sexo")
                Cls.ArmaValor(Valores, "ActivaBeca")
                Cls.ArmaValor(Valores, "Activo")

                Ds = Cls.Consultar("Usuario", Valores, Llave, Cn)
                If Ds.Tables(0).Rows.Count > 0 Then
                    TxtNombre.Text = Ds.Tables(0).Rows(0)!Nombre
                    TxtApe1.Text = Ds.Tables(0).Rows(0)!PrimerApellido
                    TxtApe2.Text = Ds.Tables(0).Rows(0)!SegundoApellido
                    If (Ds.Tables(0).Rows(0)!Sexo = 1) Then
                        TxtSexo.Text = "MASCULINO"
                    Else

                    End If
                    If (Ds.Tables(0).Rows(0)!CodTipo = 1) Then
                        TxtTipoUsuario.Text = "ESTUDIANTE"
                    Else
                        TxtTipoUsuario.Text = "PROFESOR"
                    End If
                    ChkBeca.Checked = Ds.Tables(0).Rows(0)!ActivaBeca
                    TxtCedula.Tag = Ds.Tables(0).Rows(0)!IdUsuario
                    LblCantTiques.Text = Ds.Tables(0).Rows(0)!CantidadTiquetes & " Tiquetes"
                    ''Lector 
                    StartCapture()
                Else
                    LimpiarPantalla()
                    MsgBox("Usuario no ingresado en el sistema", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            LimpiarPantalla()
        End If
    End Sub

    Private Sub TxtCedula_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCedula.KeyDown
        If e.KeyCode = Keys.Enter Then
            ChkBeca.Focus()
        ElseIf e.KeyCode = Keys.F2 Then
            Buscar.PerformClick()
        ElseIf e.KeyCode = Keys.F8 Then
            BtnGuardar.PerformClick()
        End If
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Dispose()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim Valores(), Llave() As FuncionesDB.Campos
        Try
            If ActivaEdicion Then
                If Enroller.TemplateStatus <> DPFP.Processing.Enrollment.Status.Ready Then
                    MsgBox("Debe Completar las marcas para guardar los datos.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
            Valores = Cls.InicializarArray
            Llave = Cls.InicializarArray
            Cls.ArmaValor(Llave, "IdUsuario", TxtCedula.Tag)
            Cls.ArmaValor(Valores, "ActivaBeca", ChkBeca.Checked)
            Cls.ArmaValor(Valores, "Activo", True)
            If ActivaEdicion Then
                Dim str As New MemoryStream
                Enroller.Template.Serialize(str)
                Dim serializedTemplate As Byte() = str.ToArray()
                Cls.ArmaValor(Valores, "HuellaDactilar", serializedTemplate)
            End If
            Cls.Update("Usuario", Valores, Llave, Cn)
            BtnCancelar_Click(sender, e)
        Catch ex As Exception
            MsgBox("Error al actulizar: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimpiarPantalla()
        TxtCedula.Clear()
        TxtCedula.Focus()
    End Sub

    Protected Sub Init()
        Try
            Capturer = New DPFP.Capture.Capture()                   ' Create a capture operation.

            If (Not Capturer Is Nothing) Then
                Capturer.EventHandler = Me                              ' Subscribe for capturing events.
            Else
                MsgBox("No se puede iniciar la captura de la huella", MsgBoxStyle.Critical)
                SetPrompt("Can't initiate capture operation!")
            End If
            Enroller = New DPFP.Processing.Enrollment()         ' Create an enrollment.            
            UpdateStatus()
        Catch ex As Exception
            MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Protected Sub Process(ByVal Sample As DPFP.Sample)
        DrawPicture(ConvertSampleToBitmap(Sample))

        ' Process the sample and create a feature set for the enrollment purpose.
        Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment)

        ' Check quality of the sample and add to enroller if it's good
        If (Not features Is Nothing) Then
            Try
                MakeReport("The fingerprint feature set was created.")
                Enroller.AddFeatures(features)              ' Add feature set to template.
            Finally
                UpdateStatus()

                ' Check if template has been created.
                Select Case Enroller.TemplateStatus
                    Case DPFP.Processing.Enrollment.Status.Ready        ' Report success and stop capturing
                        RaiseEvent OnTemplate(Enroller.Template)                        
                        SetPrompt("Click Close, and then click Fingerprint Verification.")
                        StopCapture()
                        ActivaEdicion = True
                    Case DPFP.Processing.Enrollment.Status.Failed       ' Report failure and restart capturing
                        Enroller.Clear()
                        StopCapture()
                        RaiseEvent OnTemplate(Nothing)
                        StartCapture()

                End Select
            End Try
        End If
    End Sub

    Protected Sub UpdateStatus()
        ' Show number of samples needed.
        SetStatus(String.Format("Fingerprint samples needed: {0}", Enroller.FeaturesNeeded))
    End Sub



    ''




    Protected Function ConvertSampleToBitmap(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertor As New DPFP.Capture.SampleConversion()    ' Create a sample convertor.
        Dim bitmap As Bitmap = Nothing                          ' TODO: the size doesn't matter
        convertor.ConvertToPicture(Sample, bitmap)              ' TODO: return bitmap as a result
        Return bitmap
    End Function

    Protected Function ExtractFeatures(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()        ' Create a feature extractor
        Dim feedback As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim features As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(Sample, Purpose, feedback, features) ' TODO: return features as a result?
        If (feedback = DPFP.Capture.CaptureFeedback.Good) Then
            Return features
        Else
            Return Nothing
        End If
    End Function

    Protected Sub StartCapture()
        If (Not Capturer Is Nothing) Then
            Try
                Capturer.StartCapture()
                SetPrompt("Using the fingerprint reader, scan your fingerprint.")
            Catch ex As Exception
                SetPrompt("Can't initiate capture!")
            End Try
        End If
    End Sub

    Protected Sub StopCapture()
        If (Not Capturer Is Nothing) Then
            Try
                Capturer.StopCapture()
            Catch ex As Exception
                SetPrompt("Can't terminate capture!")
            End Try
        End If
    End Sub

    Private Sub CaptureForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            If Cn.State = ConnectionState.Open Then
                Cls.CerrarConexion(Cn)
            End If
            StopCapture()
        Catch ex As Exception
            ''Se cierre el formulario            
        End Try
    End Sub

    Sub OnComplete(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        MakeReport("The fingerprint sample was captured.")
        SetPrompt("Scan the same fingerprint again.")
        Process(Sample)
    End Sub

    Sub OnFingerGone(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone
        MakeReport("The finger was removed from the fingerprint reader.")
    End Sub

    Sub OnFingerTouch(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch
        MakeReport("The fingerprint reader was touched.")
    End Sub

    Sub OnReaderConnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect
        MakeReport("The fingerprint reader was connected.")
    End Sub

    Sub OnReaderDisconnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect
        MakeReport("The fingerprint reader was disconnected.")
    End Sub

    Sub OnSampleQuality(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal CaptureFeedback As DPFP.Capture.CaptureFeedback) Implements DPFP.Capture.EventHandler.OnSampleQuality
        If CaptureFeedback = DPFP.Capture.CaptureFeedback.Good Then
            MakeReport("The quality of the fingerprint sample is good.")
        Else
            MakeReport("The quality of the fingerprint sample is poor.")
            MsgBox("Error al capturar la Huella, reintente", MsgBoxStyle.Critical)
        End If
    End Sub

    Protected Sub SetStatus(ByVal status)
        Invoke(New FunctionCall(AddressOf _SetStatus), status)
    End Sub

    Private Sub _SetStatus(ByVal status)
        StatusLine.Text = status
    End Sub

    Protected Sub SetPrompt(ByVal text)
        Invoke(New FunctionCall(AddressOf _SetPrompt), text)
    End Sub

    Private Sub _SetPrompt(ByVal text)
        Prompt.Text = text
    End Sub

    Protected Sub MakeReport(ByVal status)
        Invoke(New FunctionCall(AddressOf _MakeReport), status)
    End Sub

    Private Sub _MakeReport(ByVal status)
        StatusText.AppendText(status + Chr(13) + Chr(10))
    End Sub

    Protected Sub DrawPicture(ByVal bmp)
        Invoke(New FunctionCall(AddressOf _DrawPicture), bmp)
    End Sub

    Private Sub _DrawPicture(ByVal bmp)
        Picture.Image = New Bitmap(bmp, Picture.Size)
    End Sub






    Private Sub Prompt_TextChanged(sender As Object, e As EventArgs) Handles Prompt.TextChanged

    End Sub

    Private Sub LblCantTiques_Click(sender As Object, e As EventArgs) Handles LblCantTiques.Click

    End Sub

    Private Sub StatusLine_Click(sender As Object, e As EventArgs) Handles StatusLine.Click

    End Sub

    Private Sub ChkBeca_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBeca.CheckedChanged

    End Sub


    Private Sub TxtCedula_TextChanged(sender As Object, e As EventArgs) Handles TxtCedula.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TxtApe1_TextChanged(sender As Object, e As EventArgs) Handles TxtApe1.TextChanged

    End Sub
End Class