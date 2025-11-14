Imports MySql.Data.MySqlClient
Public Class Ventas

    Private StockActual As Integer = 0
    Public Sub New()
        InitializeComponent()
        ' Nombre de la ventana
        Me.Text = "Ventas"
        ' centrar la ventana al abrirse
        Me.StartPosition = FormStartPosition.CenterScreen
        ' desactivar maximizar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        ' desactivar maximizar botón
        Me.MaximizeBox = False
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        ' Abrir AdminForm.
        Dim adminMenu As New AdminForm
        adminMenu.Show()
        Close()
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        ' Abrir AdminForm.
        Dim Resumen_Ventas As New Resumen_Ventas
        Resumen_Ventas.Show()
        Close()
    End Sub

    Private Sub btnVerTodo_Click(sender As Object, e As EventArgs) Handles btnVerTodo.Click
        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                Dim query As String = "SELECT * FROM repuestos"
                Dim da As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable
                da.Fill(dt)
                DataGridView1.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar repuestos: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If tbId.Text.Trim() = "" Then
            MessageBox.Show("Ingrese ID o Nombre del repuesto.")
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()

                Dim query As String =
                    "SELECT * FROM repuestos 
                 WHERE RepuestoID LIKE @bus OR NombreRepuesto LIKE @bus;"

                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@bus", "%" & tbId.Text & "%")

                    Dim dt As New DataTable()
                    da.Fill(dt)

                    If dt.Rows.Count > 0 Then
                        DataGridView1.DataSource = dt

                        ' llenar los textbox con el primer resultado
                        tbNombre.Text = dt.Rows(0)("NombreRepuesto").ToString()
                        tbPrecio.Text = dt.Rows(0)("PrecioUnitario").ToString()
                        tbCantidad.Text = ""
                        tbTotal.Text = ""

                        StockActual = CInt(dt.Rows(0)("CantidadStock"))

                    Else
                        MessageBox.Show("No se encontró el repuesto.")
                    End If
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al buscar: " & ex.Message)
        End Try
    End Sub
    Private Sub tbCantidad_TextChanged(sender As Object, e As EventArgs) Handles tbCantidad.TextChanged
        If tbCantidad.Text.Trim() = "" Or tbPrecio.Text.Trim() = "" Then Exit Sub

        Dim cant As Integer
        If Integer.TryParse(tbCantidad.Text, cant) Then
            tbTotal.Text = (cant * Decimal.Parse(tbPrecio.Text)).ToString()
        End If
    End Sub
    Private Function HayStock() As Boolean
        If tbCantidad.Text.Trim() = "" Then Return False

        Dim cant As Integer = Integer.Parse(tbCantidad.Text)

        If cant > StockActual Then
            MessageBox.Show("No hay stock suficiente.", "Error")
            Return False
        End If

        Return True
    End Function

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        ' Validar campos obligatorios
        If tbNombre.Text.Trim() = "" Or tbPrecio.Text.Trim() = "" Or
           tbCantidad.Text.Trim() = "" Or tbRut.Text.Trim() = "" Then

            MessageBox.Show("Complete todos los campos antes de vender.")
            Exit Sub
        End If

        ' Validar cantidad y stock
        If Not HayStock() Then Exit Sub

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                Dim trans = conn.BeginTransaction()

                Try
                    ' ---- 1. INSERTAR LA VENTA ----
                    Dim insertVenta As String =
                        "INSERT INTO ventasrepuestos (NombreRepuesto, CantidadVendida, Cliente, FechaVenta, Total)
                     VALUES (@nom, @cant, @cli, @fecha, @total)"

                    Using cmd As New MySqlCommand(insertVenta, conn, trans)
                        cmd.Parameters.AddWithValue("@nom", tbNombre.Text)
                        cmd.Parameters.AddWithValue("@cant", Integer.Parse(tbCantidad.Text))
                        cmd.Parameters.AddWithValue("@cli", tbRut.Text)
                        cmd.Parameters.AddWithValue("@fecha", dtFechaCompra.Value.Date)

                        cmd.Parameters.AddWithValue("@total", Decimal.Parse(tbTotal.Text))
                        cmd.ExecuteNonQuery()
                    End Using


                    ' ---- 2. DESCONTAR STOCK ----
                    Dim updateStock As String =
                        "UPDATE repuestos SET CantidadStock = CantidadStock - @cant 
                     WHERE NombreRepuesto = @nom"

                    Using cmd2 As New MySqlCommand(updateStock, conn, trans)
                        cmd2.Parameters.AddWithValue("@cant", Integer.Parse(tbCantidad.Text))
                        cmd2.Parameters.AddWithValue("@nom", tbNombre.Text)
                        cmd2.ExecuteNonQuery()
                    End Using


                    ' Confirmar transacción
                    trans.Commit()

                    MessageBox.Show("Venta registrada exitosamente.")

                    ' Limpiar campos
                    tbCantidad.Clear()
                    tbTotal.Clear()

                    ' Actualizar listado
                    btnVerTodo_Click(Nothing, Nothing)

                Catch ex As Exception
                    trans.Rollback()
                    MessageBox.Show("Error en la venta: " & ex.Message)
                End Try
            End Using

        Catch ex As Exception
            MessageBox.Show("Error general: " & ex.Message)
        End Try
    End Sub
End Class