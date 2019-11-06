Public Module CodigoGeneral
    Public gCodCompania As Integer
    'Enum Test
    '    Condimentos = 1
    '    Salsas = 2
    '    Otros = 3
    'End Enum
    'este parametro ayuda a localizar la configuracion en el archivo app.config
    ' si compañia = 01, equivale parametro de conexion con nombre "Conexion01"

    Public Sub LimpiarSession()
        Dim cls As New FuncionesDB
        gSession.Titulo = ""
        gSession.Valor1 = ""
        gSession.Valor2 = ""
        gSession.Valor3 = ""
        gSession.Valor4 = ""
        gSession.Valor5 = ""
        gSession.Valor6 = ""
        gSession.Valor8 = ""
        gSession.Valor9 = ""
        gSession.Valor10 = ""
        gSession.Valor11 = ""
        gSession.Valor12 = ""
        gSession.Valor13 = ""
        gSession.Valor14 = ""
        gSession.Valor15 = ""
        gSession.Valor16 = ""
        gSession.Valor17 = ""
        gSession.Valor18 = ""
        gSession.TipoReporte = ""
        gSession.Reporte = ""
        gSession.Imprimir = False
        gSession.Reporte = ""
        gSession.DiasPromedio = ""
        gSession.Valores = cls.InicializarArray
        gSession.Llave = cls.InicializarArray
        ReDim gSession.Resultado(-1)
        gSession.ResultadoDset = Nothing
    End Sub

    Public Structure stSession
        Dim Titulo As String
        Dim Valor1 As String
        Dim Valor2 As String
        Dim Valor3 As String 'mas de 1 campo se pasa separado por comas "," ej (Codigo, Fecha)
        Dim Valor4 As String
        Dim Valor5 As String
        Dim Valor6 As String
        Dim Valor7 As String
        Dim Valor8 As String
        Dim Valor9 As String
        Dim Valor10 As String
        Dim Valor11 As String
        Dim Valor12 As String
        Dim Valor13 As String
        Dim Valor14 As String
        Dim Valor15 As String
        Dim Valor16 As String
        Dim Valor17 As String
        Dim Valor18 As String
        Dim TipoReporte As String
        Dim Imprimir As Boolean
        Dim Reporte As String
        Dim Fecha1 As Date
        Dim Fecha2 As Date
        Dim Valores() As FuncionesDB.Campos
        Dim Llave() As FuncionesDB.Campos
        Dim Resultado() As String     ' array dinamico, se pueden devolver 1 o n valores.
        Dim ResultadoDset As DataSet
        Dim Usuario As String
        Dim TrueFalse As Boolean
        Dim NumDias As String
        Dim DiasAdicionales As String
        Dim Variacion As String
        Dim DiasPromedio As String
    End Structure

    Public gSession As stSession

    Public Function KeyAscii(ByVal UserKeyArgument As KeyPressEventArgs) As Short
        KeyAscii = Asc(UserKeyArgument.KeyChar)
    End Function

    ' ************************************************
    ' ** Creado por Cesardgo (cesardgo@hotmail.com) **
    ' ** Fecha: 1-marzo-2011                **********
    ' ************************************************

    ''' <summary>
    ''' Recupera la configuración especificada en el archivo app.config
    ''' </summary>
    ''' <param name="NombreConfiguracion">Nombre del parámetro a buscar en el archivo app.config</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetAppConfig(Optional ByVal NombreConfiguracion As String = "Conexion") As String
        Dim strConn As String       
        Dim configurationAppSettings As New System.Configuration.AppSettingsReader
        strConn = CStr(configurationAppSettings.GetValue(NombreConfiguracion, GetType(String)))
        Return strConn
    End Function

    ' <summary>
    ' Busca dentro de la cadena de conexion, los parametros indicados tales como:
    '    Base Datos, servidor, usuario, etc. Resive como parametro adicional, una segunda descripcion
    '    para el valor buscado en la cadena de conexion, Ej: las bases de datos pueden definirse en el archivo 
    '    de configuracion como: DataBase=xxxxx o Initial Catalog=xxxxx, 
    ' </summary>
    ' <param name="pBuscar">Valor principal a buscar </param>
    ' <param name="pBuscarAuxiliar">Valor Secundario a buscar, en caso de que el primero No se encuentre. </param>
    ' <returns>Devuelve el valor encontrado con los parametros de busqueda indicados. </returns>
    ' <remarks></remarks>
    'Function ObtenerUsuarioBaseDatos(ByVal pBuscar As String, Optional ByVal pBuscarAuxiliar As String = ".") As String
    '    Dim Usr As String = ""
    '    Dim CadenaConexion As String = GetAppConfig("Conexion")
    '    Dim Resultado As String = ""

    '    pBuscar = pBuscar & "="
    '    pBuscarAuxiliar = pBuscarAuxiliar & "="

    '    Dim Pos As Integer = InStr(CadenaConexion.ToLower, pBuscar.ToLower)
    '    Dim PosFin As Integer = 0

    '    If Pos > 0 Then
    '        PosFin = InStr(Pos, CadenaConexion.ToLower, ";")
    '        ' Usuario/cadena encontrada.
    '        Resultado = Mid(CadenaConexion, Pos + Len(pBuscar), PosFin - Pos - Len(pBuscar))
    '    Else
    '        ' No se encuentra datode busqueda "parametro pbuscar, se utiliza pbuacarAuxiliar"
    '        Pos = InStr(CadenaConexion.ToLower, pBuscarAuxiliar.ToLower)

    '        If Pos > 0 Then
    '            PosFin = InStr(Pos, CadenaConexion.ToLower, ";")
    '            ' Usuario encontrado.
    '            Resultado = Mid(CadenaConexion, Pos + Len(pBuscarAuxiliar), PosFin - Pos - Len(pBuscarAuxiliar))

    '        Else
    '            ' No se encuentra usuario, buscar "usr", buscar Trusted_Connection.
    '            Pos = InStr(CadenaConexion.ToLower, "trusted")

    '            If Pos > 0 Then
    '                Resultado = "Conexion de Confianza"
    '            Else
    '                ' usuario es el ultimo parametro
    '                Resultado = "No hay parámetro de busqueda definido." ' esto no deberia suceder nunca.
    '            End If
    '        End If
    '    End If

    '    Resultado = Resultado.Replace(";", "")
    '    Return Resultado
    'End Function

    Function ObtenerValorParametroConexion(ByVal pBuscar As String, Optional ByVal pBuscarAux As String = ".") As String

        Dim CadenaConexion As String = GetAppConfig("Conexion")
        Dim Resultado As String = ""

        pBuscar = pBuscar & "="

        Dim Pos As Integer = InStr(CadenaConexion.ToLower, pBuscar.ToLower) + Len(pBuscar)
        Dim PosFin As Integer = InStr(Pos, CadenaConexion.ToLower, ";")

        If Pos > 0 Then
            ' Usuario/cadena encontrada.
            Resultado = Mid(CadenaConexion, Pos, PosFin - Pos)
        Else
            Pos = InStr(CadenaConexion.ToLower, pBuscarAux.ToLower) + Len(pBuscarAux)
            PosFin = InStr(Pos, CadenaConexion.ToLower, ";")
        End If

        Return Resultado
    End Function

    Sub SeleccionaComboItem(ByRef Combo As ComboBox, ByVal Valor As String)
        Try
            Dim Texto As String = ""
            For I As Integer = 0 To Combo.Items.Count - 1
                Texto = Combo.Items(I).ToString
                If InStr(Texto, Valor) > 0 Then
                    ' COINCIDENCIA DE TEXTO 
                    Combo.SelectedIndex = I
                    Exit For
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function SoloNumerosFN(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            ' no acepta los caracteres
            SoloNumerosFN = 0
        Else
            ' aceptando solo numeros y lo que contenga la propiedad pPermitirCaracteres
            SoloNumerosFN = Keyascii ' permitido

        End If
        Select Case Keyascii ' permite teclas de borrado
            Case 8
                SoloNumerosFN = Keyascii
            Case 13
                SoloNumerosFN = Keyascii
        End Select
    End Function

    'Private Sub UpdateSortField(ByRef myReportDocument As ReportDocument, ByVal tableName As String, ByVal fieldName As String)
    '    Dim myDatabaseFieldDefinition As DatabaseFieldDefinition

    '    myDatabaseFieldDefinition = myReportDocument.Database.Tables.Item(tableName).Fields.Item(fieldName)

    '    Dim mySortField As SortField = myReportDocument.DataDefinition.SortFields.Item(1)

    '    If (mySortField.SortType = SortFieldType.RecordSortField) Then
    '        mySortField.Field = myDatabaseFieldDefinition
    '        mySortField.SortDirection = SortDirection.AscendingOrder
    '    End If
    'End Sub

    Function SCM(ByVal valor As String) As String
        Return "'" & valor & "'"
    End Function

    Public Function ArmaFechaReporte(ByRef Campo As String, ByRef FechaInicial As Date, ByRef FechaFinal As Date) As String
        'ArmaFechaReporte = Campo & ">=date(" & VB6.Format(FechaInicial, "yyyy,mm,dd") & ") and " & Campo & "<=date(" & VB6.Format(FechaFinal, "yyyy,mm,dd") & ")"
        ArmaFechaReporte = Campo & ">=date(" & FechaInicial.Year & "," & FechaInicial.Month & "," & FechaInicial.Day & ") and " & _
            Campo & "<=date(" & FechaFinal.Year & "," & FechaFinal.Month & "," & FechaFinal.Day & ")"
    End Function

    Public Function FechaSistema() As Date
        Dim Cn As New SqlClient.SqlConnection(GetAppConfig("Conexion"))
        Dim Cls As New FuncionesDB
        Dim Valores(), Llave() As FuncionesDB.Campos
        Dim Dr As SqlClient.SqlDataReader
        Dim Resultado As Date

        Valores = Cls.InicializarArray
        Llave = Cls.InicializarArray

        Cls.ArmaValor(Valores, "FechaCierre")
        Cls.ArmaValor(Llave, "1", 1)

        Cls.AbrirConexion(Cn, False)

        Dr = Cls.ConsultarDataReader(Cn, "Parametros", Valores, Llave)

        If Dr.Read Then
            Resultado = Dr!FechaCierre
        Else
            Dr.Close()
            Cls.CerrarConexion(Cn)

            Throw New Exception("No existe FechaCierre en Tabla PARAMETROS.")
        End If


        Dr.Close()
        Cls.CerrarConexion(Cn)

        Return Resultado

    End Function
    Function sen(ByVal Valor As String) As String
        Dim largo As Integer = 0
        Dim a As Integer = 0
        'Super Evaluador Numérico
        Dim pto As Short
        If Len(Valor) Then
            'Le Quita el Signo de Colones
            If InStr(Valor, "¢") Then
                a = InStr(Valor, "¢")
                If a = 1 Then
                    Valor = Mid(Valor, 2)
                Else
                    Valor = Mid(Valor, 1, a - 1) & Mid(Valor, a + 1)
                End If
            End If

            largo = Len(Valor)
            Do While 1 < 2
                pto = InStr(Valor, ",")
                'Elimina las Comas
                If pto > 0 Then
                    Valor = Mid(Valor, 1, pto - 1) & Mid(Valor, pto + 1, largo)
                Else
                    Exit Do
                End If
            Loop
            sen = Valor
        Else
            sen = "0"
        End If
    End Function


    Sub Cargacajeros(ByRef Combo As ComboBox)

        Try
            Dim Cn As New SqlClient.SqlConnection(GetAppConfig("Conexion"))
            Dim Dr As SqlClient.SqlDataReader
            Dim Cls As New FuncionesDB
            Dim Valores(), Llave() As FuncionesDB.Campos
            Valores = Cls.InicializarArray
            Llave = Cls.InicializarArray

            Cls.AbrirConexion(Cn, False)

            Cls.ArmaValor(Valores, "CodCajero")
            Cls.ArmaValor(Valores, "NomCajero")
            Cls.ArmaValor(Llave, "1", 1)

            Dr = Cls.ConsultarDataReader(Cn, "Cajeros", Valores, Llave)

            Do While Dr.Read
                'Combo.Items.Add(Dr("CodCajero") + " " + Dr("NomCajero"))
                Combo.Items.Add(New LBItem(Dr("CodCajero"), Dr("NomCajero")))
            Loop

            Dr.Close()
            Cls.CerrarConexion(Cn)


            If Combo.Items.Count <> 0 Then
                Combo.SelectedIndex = -1
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub Cargacaja(ByRef Combo As ComboBox)

        Try
            Dim Cn As New SqlClient.SqlConnection(GetAppConfig("Conexion"))
            Dim Dr As SqlClient.SqlDataReader
            Dim Cls As New FuncionesDB
            Dim Valores(), Llave() As FuncionesDB.Campos
            Valores = Cls.InicializarArray
            Llave = Cls.InicializarArray

            Cls.AbrirConexion(Cn, False)

            Cls.ArmaValor(Valores, "Codcaja")
            Cls.ArmaValor(Valores, "NomCaja")
            Cls.ArmaValor(Llave, "1", 1)

            Dr = Cls.ConsultarDataReader(Cn, "Cajas", Valores, Llave)

            Do While Dr.Read
                'Combo.Items.Add(Dr("CodCaja") + " " + Dr("NomCaja"))
                Combo.Items.Add(New LBItem(Dr("CodCaja"), Dr("NomCaja")))
            Loop

            Dr.Close()
            Cls.CerrarConexion(Cn)

            If Combo.Items.Count <> 0 Then
                Combo.SelectedIndex = -1

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub CargaSupervisores(ByRef Combo As ComboBox)

        Try
            Dim Cn As New SqlClient.SqlConnection(GetAppConfig("Conexion"))
            Dim Dr As SqlClient.SqlDataReader
            Dim Cls As New FuncionesDB
            Dim Valores(), Llave() As FuncionesDB.Campos
            Valores = Cls.InicializarArray
            Llave = Cls.InicializarArray

            Cls.AbrirConexion(Cn, False)

            Cls.ArmaValor(Valores, "CodSupervisor")
            Cls.ArmaValor(Valores, "NomSupervisor")
            Cls.ArmaValor(Llave, "1", 1)

            Dr = Cls.ConsultarDataReader(Cn, "Supervisores", Valores, Llave)

            Do While Dr.Read
                'Combo.Items.Add(Dr("CodCajero") + " " + Dr("NomCajero"))
                Combo.Items.Add(New LBItem(Dr("CodSupervisor"), Dr("NomSupervisor")))
            Loop

            Dr.Close()
            Cls.CerrarConexion(Cn)


            If Combo.Items.Count <> 0 Then
                Combo.SelectedIndex = -1
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub CargaSaloneros(ByRef Combo As ComboBox)

        Try
            Dim Cn As New SqlClient.SqlConnection(GetAppConfig("Conexion"))
            Dim Dr As SqlClient.SqlDataReader
            Dim Cls As New FuncionesDB
            Dim Valores(), Llave() As FuncionesDB.Campos
            Valores = Cls.InicializarArray
            Llave = Cls.InicializarArray

            Cls.AbrirConexion(Cn, False)

            Cls.ArmaValor(Valores, "CodSalonero")
            Cls.ArmaValor(Valores, "NomSalonero")
            Cls.ArmaValor(Llave, "1", 1)

            Dr = Cls.ConsultarDataReader(Cn, "Saloneros", Valores, Llave)

            Do While Dr.Read
                Combo.Items.Add(New LBItem(Dr("CodSalonero"), Dr("NomSalonero")))
            Loop

            Dr.Close()
            Cls.CerrarConexion(Cn)


            If Combo.Items.Count <> 0 Then
                Combo.SelectedIndex = -1
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub CargaClasificacion(ByRef Combo As ComboBox)

        Try
            Dim Cn As New SqlClient.SqlConnection(GetAppConfig("Conexion"))
            Dim Dr As SqlClient.SqlDataReader
            Dim Cls As New FuncionesDB
            Dim Valores(), Llave() As FuncionesDB.Campos
            Valores = Cls.InicializarArray
            Llave = Cls.InicializarArray

            Cls.AbrirConexion(Cn, False)

            Cls.ArmaValor(Valores, "CodCla")
            Cls.ArmaValor(Valores, "NomCla")
            Cls.ArmaValor(Llave, "1", 1)

            Dr = Cls.ConsultarDataReader(Cn, "ClasificacionProducto", Valores, Llave)

            Do While Dr.Read
                Combo.Items.Add(New LBItem(Dr("CodCla"), Dr("NomCla")))
            Loop

            Dr.Close()
            Cls.CerrarConexion(Cn)


            If Combo.Items.Count <> 0 Then
                Combo.SelectedIndex = -1
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub Cargatarjeta(ByRef Combo As ComboBox)

        Try
            Dim Cn As New SqlClient.SqlConnection(GetAppConfig("Conexion"))
            Dim Dr As SqlClient.SqlDataReader
            Dim Cls As New FuncionesDB
            Dim Valores(), Llave() As FuncionesDB.Campos
            Valores = Cls.InicializarArray
            Llave = Cls.InicializarArray
            Cls.AbrirConexion(Cn, False)
            Cls.ArmaValor(Valores, "CodTar")
            Cls.ArmaValor(Valores, "NomTar")
            Cls.ArmaValor(Llave, "1", 1)
            Dr = Cls.ConsultarDataReader(Cn, "tarjetas", Valores, Llave)
            Do While Dr.Read
                Combo.Items.Add(New LBItem(Dr("CodTar"), Dr("NomTar")))
            Loop
            Dr.Close()
            Cls.CerrarConexion(Cn)
            If Combo.Items.Count <> 0 Then
                Combo.SelectedIndex = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Sub CargaTipoMovimientos(ByRef Combo As ComboBox, Optional Usuario As String = "")
        Try
            Dim Cn As New SqlClient.SqlConnection(GetAppConfig("Conexion"))
            Dim Dr As SqlClient.SqlDataReader
            Dim Cls As New FuncionesDB
            Dim Valores(), Llave() As FuncionesDB.Campos
            Valores = Cls.InicializarArray
            Llave = Cls.InicializarArray
            Cls.AbrirConexion(Cn, False)
            Cls.ArmaValor(Valores, "CodMov")
            Cls.ArmaValor(Valores, "NomMov")
            Cls.ArmaValor(Llave, "Modifica", 1)
            Dr = Cls.ConsultarDataReader(Cn, "TiposMovimientos", Valores, Llave)
            Combo.Items.Add("00  Inventario Final")
            Do While Dr.Read
                If Dr!CodMov = "20" Or Dr!CodMov = "21" Then
                    If Supervisor Then
                        Combo.Items.Add(New LBItem(Dr("CodMov"), Dr("NomMov")))
                    End If
                ElseIf Dr!CodMov <> "50" Then
                    Combo.Items.Add(New LBItem(Dr("CodMov"), Dr("NomMov")))

                End If
                'Combo.Items.Add(Dr("CodCajero") + " " + Dr("NomCajero"))
            Loop
            Dr.Close()
            Cls.CerrarConexion(Cn)
            If Combo.Items.Count <> 0 Then
                Combo.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Function ArmaFechaQueryHora(ByVal Campo As String, ByVal FechaInicial As Date, ByVal FechaFinal As Date)
        ArmaFechaQueryHora = Campo & ">=CONVERT(DATETIME," & SCM(Format(FechaInicial, "yyyy/MM/dd HH:mm:ss")) & " , 102) And " & Campo & "<=CONVERT(DATETIME," & SCM(Format(FechaFinal, "yyyy/MM/dd") & " 23:59:59") & ", 102)"
    End Function
    Function ArmaFechaQuery(ByVal Campo As String, ByVal FechaInicial As Date, ByVal FechaFinal As Date)
        ArmaFechaQuery = Campo & ">=CONVERT(DATETIME," & SCM(Format(FechaInicial, "yyyy/MM/dd")) & " , 102) And " & Campo & "<=CONVERT(DATETIME," & SCM(Format(FechaFinal, "yyyy/MM/dd")) & ", 102)"
    End Function
    Function ConvertDate(ByVal Campo As String, ByVal signo As String, ByVal Fecha As Date)
        ConvertDate = Campo & signo & "CONVERT(DATETIME," & SCM(Format(Fecha, "yyyy/MM/dd")) & " , 102)"
    End Function
    Function CalculaVentas(FecIni As Date, FecFin As Date) ' funcion para possic reportes calcula total ventas
        Dim A
        Dim Cls As New FuncionesDB
        Dim Result As String
        Dim criterio As String
        Dim cmd As String
        Dim Vtas As Decimal
        Dim Datos As DataSet
        CalculaVentas = 0
        Try
            'Consolidado
            If NumRestaurante = "99" Then
                A = CalculaVentasConsolidado(FecIni, FecFin)
                CalculaVentas = A
                Exit Function
            End If
            'Arma el Criterio de la Consulta
            criterio = "EncVtas.Anulada=" & 0
            If IsDate(FecIni) And IsDate(FecFin) Then
                Dim Final As Date
                Final = DateAdd("d", 1, FecFin)
                Result = ArmaFechaQuery("EncVtas.FecFactura", FecIni, Final)
                criterio = criterio + " and " + Result
            End If

            'Ejecuta el Query
            cmd = "SELECT SUM(SubTotal-Descuento) AS Ventas"
            cmd = cmd + " From EncVtas"
            'cmd = "SelecT DISTINCT Sum([DetVtas].[UniVen]*([DetVtas].[PreVta]*(100-[PorDescto])/100)) AS Ventas"
            'cmd = cmd + " FROM EncVtas INNER JOIN DetVtas ON EncVtas.NumFactura = DetVtas.NumFactura    "
            'cmd = cmd + " Where " + criterio
            cmd = cmd + " where " + criterio
            Datos = Cls.ConsultarTSQL("Vtas", cmd)
            If IsDBNull(Datos.Tables(0).Rows(0)!Ventas) Or Datos.Tables(0).Rows.Count = 0 Then
                Vtas = 0
            Else
                Vtas = Val(Datos.Tables(0).Rows(0)!Ventas)
            End If
            'If CalculoVentasTouch Then
            '    CalculaVentas = Vtas
            'Else
            If (Vtas > 0) Then
                'CalculaVentas = Vtas / ImpuestoVentas
                CalculaVentas = Vtas
            Else
                CalculaVentas = Vtas
            End If
            'End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return (0)
        End Try
    End Function

    Function CalculaVentasConsolidado(FecIni As Date, FecFin As Date) ' funcion para possic reportes
        Dim Cls As New FuncionesDB
        Dim criterio As String
        Dim cmd As String
        Dim Datos As DataSet
        Dim VtasC As Decimal
        CalculaVentasConsolidado = 0
        'Ejecuta el Query
        cmd = "SelecT DISTINCTROW Sum(MontoVentas) AS VentasC"
        cmd = cmd + " FROM VentasConsolidadas"
        criterio = ArmaFechaQuery("Fecha", FecIni, FecFin)
        cmd = cmd + " Where " + criterio
        Datos = Cls.ConsultarTSQL("VtasC", cmd)
        If IsDBNull(Datos.Tables(0).Rows(0)!Ventas) Or Datos.Tables(0).Rows.Count = 0 Then
            VtasC = 0
        Else
            VtasC = Val(Datos.Tables(0).Rows(0)(0))
        End If
        CalculaVentasConsolidado = VtasC
    End Function
End Module