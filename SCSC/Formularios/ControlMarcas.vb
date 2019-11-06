Imports System.IO

Public Class ControlMarcas
    Implements DPFP.Capture.EventHandler

    Private Capturer As DPFP.Capture.Capture
    Private Template As DPFP.Template

    Private Verificator As DPFP.Verification.Verification

    Dim Cls As New FuncionesDB
    Dim Cn As New SqlClient.SqlConnection
    Dim Ds As New DataSet

    Public Sub Verify(ByVal template As DPFP.Template)
        Me.Template = template
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Protected Overridable Sub Init()
        Try
            Capturer = New DPFP.Capture.Capture()                   ' Create a capture operation.
            If (Not Capturer Is Nothing) Then
                Capturer.EventHandler = Me                              ' Subscribe for capturing events.
            Else
                SetPrompt("Can't initiate capture operation!")
            End If
        Catch ex As Exception
            MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Text = "Fingerprint Verification"
        Verificator = New DPFP.Verification.Verification()
        UpdateStatus(0)
    End Sub

    Protected Sub Process(ByVal Sample As DPFP.Sample)        
        DrawPicture(ConvertSampleToBitmap(Sample))
        Dim Verifico As Boolean = False
        Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification)

        Dim byteTemplate As Byte()
        Dim memStreamTemplate As MemoryStream
        ' Check quality of the sample and start verification if it's good
        If Not features Is Nothing Then
            ' Compare the feature set with our template          
            For Each Row As DataRow In Ds.Tables(0).Rows
                If Not (IsDBNull(Row!HuellaDactilar)) Then
                    byteTemplate = Row!HuellaDactilar
                    memStreamTemplate = New MemoryStream(byteTemplate)

                    Me.Template = New DPFP.Template
                    Me.Template.DeSerialize(memStreamTemplate)

                    Dim result As DPFP.Verification.Verification.Result = New DPFP.Verification.Verification.Result()
                    Verificator.Verify(features, Template, result)
                    UpdateStatus(result.FARAchieved)
                    If result.Verified Then
                        ProcesarMarca(Row)
                        MakeReport("The fingerprint was VERIFIED." & Row!IdUsuario)
                        Verifico = True

                        Exit For
                    End If
                End If
            Next
            If Not Verifico Then
                MsgBox("Fallo vericación vuelva a intentar", MsgBoxStyle.Critical)
                MakeReport("The fingerprint wan NOT VERIFIED.")
                LimpiarPantalla()
            End If
        End If
    End Sub
    Protected Sub UpdateStatus(ByVal FAR As Integer)
        ' Show "False accept rate" value
        SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR))
    End Sub

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
        Me.Dispose()
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

    Private Sub ControlMarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cls.AbrirConexion(Cn, False)
            Ds = Cls.ConsultarTSQL("Usuario", "SELECT IdUsuario,ActivaBeca,HuellaDactilar,Nombre,PrimerApellido,SegundoApellido,CodTipo,Cedula FROM Usuario WHERE Activo = 1", Cn:=Cn)
            Init()
            StartCapture()
            LblFecha.Text = FechaServer
        Catch ex As Exception
            If Cn.State = ConnectionState.Open Then
                Cls.CerrarConexion(Cn)
            End If
            MsgBox("Error al cargar el Formulario: " & ex.Message, MsgBoxStyle.Critical)
            End 'Cierro la aplicacion porque no se pudo abrir la conexion
        End Try
    End Sub

    Protected Sub ProcesarMarca(ByVal Usuario As DataRow)
        Invoke(New FunctionCall(AddressOf _ProcesarMarca), Usuario)
    End Sub

    Sub _ProcesarMarca(ByVal Usuario As DataRow)
        Try
            Dim cmd As String
            Dim CantTiquetes As Integer = 0
            Dim Valores() As FuncionesDB.Campos
            TxtCedula.Text = Usuario!Cedula
            TxtUsuario.Text = Usuario!Nombre & " " & Usuario!PrimerApellido & " " & Usuario!SegundoApellido
            If (Usuario!CodTipo = 1) Then
                TxtTipo.Text = "ESTUDIANTE"
            Else
                TxtTipo.Text = "PROFESOR"
            End If

            Valores = Cls.InicializarArray
            Cls.ArmaValor(Valores, "IdUsuario", Usuario!IdUsuario)
            If (Usuario!ActivaBeca) Then
                TxtTiquetes.Text = " Usuario Becado"
            Else
                Dim Data As New DataSet
                Data = Cls.ConsultarTSQL("Usuario", "SELECT CantidadTiquetes FROM Usuario WHERE IdUsuario = @IdUsuario", Valores, Cn)
                If Data.Tables(0).Rows(0)!CantidadTiquetes < 1 Then
                    MsgBox("No Tiene tiquetes disponibles para pasar al comedor", MsgBoxStyle.Critical)

                    LimpiarPantalla()
                    Exit Sub
                Else
                    CantTiquetes = Data.Tables(0).Rows(0)!CantidadTiquetes - 1
                    cmd = "UPDATE Usuario set CantidadTiquetes = CantidadTiquetes - " & 1 & " WHERE IdUsuario = @IdUsuario"
                    ''Suma los tiquetes en usuarios
                    Cls.AplicaSQL(cmd, Cn, Llave:=Valores)

                End If
                TxtTiquetes.Text = CantTiquetes & " Tiquetes"
            End If
            Cls.ArmaValor(Valores, "TipoPago", 2)
            Cls.ArmaValor(Valores, "Cantidad", 1)
            Cls.Insert("Transacciones", Valores, Cn)
        Catch ex As Exception
            LimpiarPantalla()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub LimpiarPantalla()
        TxtCedula.Clear()
        TxtTipo.Clear()
        TxtTiquetes.Clear()
        TxtUsuario.Clear()
        Picture.Image = Nothing
    End Sub

 

    Private Sub TxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuario.TextChanged

    End Sub

    Private Sub TxtTipo_TextChanged(sender As Object, e As EventArgs) Handles TxtTipo.TextChanged

    End Sub

  
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TxtCedula_TextChanged(sender As Object, e As EventArgs) Handles TxtCedula.TextChanged

    End Sub
End Class