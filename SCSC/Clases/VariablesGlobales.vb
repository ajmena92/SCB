Module VariablesGlobales
    Public Compania As String
    Public Ubicacion As String
    Public TipoFacturaCliente As String    
    Public ImpuestoVentas As Decimal
    Public TipoCambio As Decimal
    Public FechaServer As Date
    Public NumRestaurante As String
    Public Restaurante As String
    Public UsuarioAplicacion As String        
    Public DBUsuario As String
    Public DBClave As String
    Public DBServer As String
    Public DBBase As String
    Public CodVersion As String
    Public CodSistema As String
    Public LlaveIncriptacion As String = "2012_Sic_PossicNet"
    Public CodigoUsuario As String
    Public Supervisor As Boolean = False
    Public Fechaservidor As Date
    Public ModificaDia As Boolean = False
    Public TipoPedido As Integer
    Public FechaCierrePeriodo As Date
    Public CodigoProveedorPedidosAutomatizados As String
    Public A As Integer = 0
    Public CodigoSap As String
    Public TipoPedidoGlobal As Integer
    Public NumLineaGlobal As Integer = 0
    Public TipoCosto As String
    Public ActivaAprovechamiento As Boolean
    Public UnidConvProv As Decimal
    Public UnidConvInv As Decimal
    Public ActivaAsientoCxP As Boolean
    Public CodCuentaDebe As String
    Public CodCuentaIV As String
    Public CodCuentaPagar As String

    ''Conexiones

    Public Conexion1 As String = "Server=97.74.85.68,1433; database=VentasConsolidadas; uid=Cesardgo; pwd=900972548;"
End Module
