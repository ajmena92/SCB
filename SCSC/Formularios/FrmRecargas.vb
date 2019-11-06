Public Class FrmRecarga

    Dim Cn As New SqlClient.SqlConnection
    Dim Cls As New FuncionesDB
    Dim Precio As Decimal

    Sub LimpiarPantalla()
        txtCedula.Clear()
        TxtPrimerApellido.Clear()
        TxtSegundoApellido.Clear()
        TxtNombre.Clear()
        TxtRecarga.Clear()
        LblCantTiques.Text = ("0 Tiquetes")
        LblTotal.Text = 0
        txtCedula.Focus()
    End Sub

    Private Sub FrmRecarga_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            If Cn.State = ConnectionState.Open Then
                Cls.CerrarConexion(Cn)
            End If
        Catch ex As Exception
            ''Se cierre el formulario            
        End Try
    End Sub

    Private Sub FrmEstudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cls.AbrirConexion(Cn, False)
        Catch ex As Exception
            If Cn.State = ConnectionState.Open Then
                Cls.CerrarConexion(Cn)
            End If
            MsgBox("Error al cargar el Formulario: " & ex.Message, MsgBoxStyle.Critical)
            End 'Cierro la aplicacion porque no se pudo abrir la conexion
        End Try
        txtCedula.Focus()
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Try
            txtCedula.Clear()
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
            txtCedula.Text = (gSession.Resultado(0))
            TxtCedula_Validated(sender, e)
        Catch ex As Exception
            'MsgBox(MSJ.Mensajes.ErrorBusqueda)
        End Try

    End Sub

    Private Sub TxtCedula_Validated(sender As Object, e As EventArgs) Handles txtCedula.Validated
        txtCedula.Text = txtCedula.Text.Trim
        Dim Ds As New DataSet
        Dim Valores(), Llave() As FuncionesDB.Campos
        If Len(txtCedula.Text) > 0 Then
            Try
                Valores = Cls.InicializarArray
                Llave = Cls.InicializarArray
                Cls.ArmaValor(Llave, "Cedula", txtCedula.Text)
                Cls.ArmaValor(Valores, "IdUsuario")
                Cls.ArmaValor(Valores, "Nombre")
                Cls.ArmaValor(Valores, "PrimerApellido")
                Cls.ArmaValor(Valores, "SegundoApellido")
                Cls.ArmaValor(Valores, "CantidadTiquetes")
                Cls.ArmaValor(Valores, "CodTipo")
                Cls.ArmaValor(Valores, "ActivaBeca")
                Cls.ArmaValor(Valores, "Activo")

                Ds = Cls.Consultar("Usuario", Valores, Llave, Cn)
                If Ds.Tables(0).Rows.Count > 0 Then
                    TxtNombre.Text = Ds.Tables(0).Rows(0)!Nombre
                    TxtPrimerApellido.Text = Ds.Tables(0).Rows(0)!PrimerApellido
                    TxtSegundoApellido.Text = Ds.Tables(0).Rows(0)!SegundoApellido
                    If (Ds.Tables(0).Rows(0)!CodTipo = 1) Then
                        Precio = 300
                    Else
                        Precio = 700
                    End If
                    If Ds.Tables(0).Rows(0)!ActivaBeca Then
                        MsgBox("El usuario ingresado esta becado, no puede realizar recargas", MsgBoxStyle.Critical)
                        LimpiarPantalla()
                        Exit Sub
                    End If
                    txtCedula.Tag = Ds.Tables(0).Rows(0)!IdUsuario
                    LblCantTiques.Text = Ds.Tables(0).Rows(0)!CantidadTiquetes & " Tiquetes"                    
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

    Private Sub TxtCedula_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCedula.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtRecarga.Focus()
        ElseIf e.KeyCode = Keys.F2 Then
            Buscar.PerformClick()
        ElseIf e.KeyCode = Keys.F8 Then
            BtnGuardar.PerformClick()
        End If
    End Sub

    Private Sub TxtRecarga_Validated(sender As Object, e As EventArgs) Handles TxtRecarga.Validated
        Dim Cantidad As Integer = Val(sen(TxtRecarga.Text))
        LblTotal.Text = Cantidad * Precio
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimpiarPantalla()
        txtCedula.Clear()
        txtCedula.Focus()
    End Sub

    Private Sub TxtRecarga_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtRecarga.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnGuardar.Focus()
        End If
    End Sub

    Function Validaciion() As Boolean
        Validaciion = False
        If Len(txtCedula.Text) = 0 Then
            MsgBox("Ingrese el numero de cedula", MsgBoxStyle.Critical)
            txtCedula.Focus()
            Exit Function
        ElseIf Val(TxtRecarga.Text) < 1 Then
            MsgBox("Ingrese la cantidad de tiquetes a ingresar", MsgBoxStyle.Critical)
            TxtRecarga.Focus()
            Exit Function
        Else
            Return True
        End If

    End Function

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Validaciion() Then
            Dim Valores(), Llave() As FuncionesDB.Campos
            Dim Cmd As String
            Try
                'Valores = Cls.InicializarArray
                Llave = Cls.InicializarArray
                Cls.ArmaValor(Llave, "IdUsuario", txtCedula.Tag)
                'Cls.ArmaValor(Valores, "Recarga", Val(sen(TxtRecarga.Text)))                  
                Cmd = "UPDATE Usuario set CantidadTiquetes = CantidadTiquetes + " & Val(sen(TxtRecarga.Text)) & " WHERE IdUsuario = @IdUsuario"
                ''Suma los tiquetes en usuarios
                Cls.AplicaSQL(Cmd, Cn, Llave:=Llave)
                ''Inserta la nueva trasaccion
                Valores = Cls.InicializarArray
                Cls.ArmaValor(Valores, "IdUsuario", txtCedula.Tag)
                Cls.ArmaValor(Valores, "TipoPago", 1)
                Cls.ArmaValor(Valores, "Cantidad", Val(sen(TxtRecarga.Text)))
                
                Cls.Insert("Transacciones", Valores, Cn)
                MsgBox("Recarga realizada con exito.", MsgBoxStyle.Information)
                BtnCancelar_Click(sender, e)
            Catch ex As Exception
                MsgBox("Error al actulizar: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Dispose()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    
    Private Sub TxtRecarga_TextChanged(sender As Object, e As EventArgs) Handles TxtRecarga.TextChanged

    End Sub
End Class
