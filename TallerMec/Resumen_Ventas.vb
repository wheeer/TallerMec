Imports MySql.Data.MySqlClient

Public Class Resumen_Ventas
    Public Sub New()
        InitializeComponent()
        ' Nombre de la ventana
        Me.Text = "Gestión de Siniestros"
        ' centrar la ventana al abrirse
        Me.StartPosition = FormStartPosition.CenterScreen
        ' desactivar maximizar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        ' desactivar maximizar botón
        Me.MaximizeBox = False
    End Sub

    '===========================
    ' CARGAR HISTORIAL COMPLETO
    '===========================
    Private Sub Resumen_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarDataGridView()
        CargarHistorial()
    End Sub



    '===========================================
    ' CONFIGURAR EL DATAGRIDVIEW (NO CORTA TEXTO)
    '===========================================
    Private Sub ConfigurarDataGridView()
        With dgvHistorial
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells   ' Ajusta columnas según contenido
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells         ' Ajusta filas según contenido
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True            ' Permite saltos de línea
            .ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True ' Encabezados completos
        End With
    End Sub




    '===========================
    ' CARGAR HISTORIAL COMPLETO
    '===========================
    Private Sub CargarHistorial()
        Try
            Using conn As MySqlConnection = ObtenerConexion()
                Dim query As String = "SELECT VentaID, NombreRepuesto, CantidadVendida, Cliente, FechaVenta, Total FROM ventasrepuestos"
                Dim cmd As New MySqlCommand(query, conn)
                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                dgvHistorial.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar historial: " & ex.Message)
        End Try
    End Sub



    '========================================
    ' BOTÓN VER (MUESTRA TODO EL HISTORIAL)
    '========================================
    Private Sub btVer_Click(sender As Object, e As EventArgs) Handles btVer.Click
        CargarHistorial()
    End Sub



    '====================================
    ' BOTÓN BUSCAR POR ID (txtId)
    '====================================
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        If txtId.Text.Trim() = "" Then
            MessageBox.Show("Ingrese un ID de venta para buscar.")
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = ObtenerConexion()
                Dim query As String = "SELECT VentaID, NombreRepuesto, CantidadVendida, Cliente, FechaVenta, Total 
                                       FROM ventasrepuestos 
                                       WHERE VentaID = @id"

                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", txtId.Text.Trim())

                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                If dt.Rows.Count = 0 Then
                    MessageBox.Show("No se encontró ninguna venta con ese ID.")
                End If

                dgvHistorial.DataSource = dt
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al buscar: " & ex.Message)
        End Try
    End Sub



    '===================
    ' BOTÓN VOLVER
    '===================
    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click
        Dim adminVentas As New Ventas()
        adminVentas.Show()
        Me.Close()
    End Sub

End Class
