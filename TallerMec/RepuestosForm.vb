Imports MySql.Data.MySqlClient

Public Class RepuestosForm
    ' Variables de usuario
    Private correoUsuario As String
    Private rolUsuario As String

    ' Variable privada para almacenar el ID del repuesto seleccionado
    Private _repuestoIDSeleccionado As Integer = -1

    Public Sub New()
        InitializeComponent()
        correoUsuario = UsuarioActual.Correo
        rolUsuario = UsuarioActual.Rol
    End Sub

    ' Cargar repuestos al iniciar el formulario
    Private Sub RepuestosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarRepuestos()
    End Sub

    ' Método para cargar el ComboBox con los repuestos
    Private Sub CargarRepuestos()
        Try
            Using conn As MySqlConnection = ObtenerConexion()
                Dim query As String = "SELECT NombreRepuesto FROM repuestos;"
                Dim cmd As New MySqlCommand(query, conn)
                Dim dr As MySqlDataReader = cmd.ExecuteReader()

                cmbRepuestos.Items.Clear()
                While dr.Read()
                    cmbRepuestos.Items.Add(dr("NombreRepuesto").ToString())
                End While

                dr.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los repuestos: " & ex.Message)
        End Try
    End Sub

    ' Al seleccionar un repuesto en el ComboBox, llenar los TextBox
    Private Sub cmbRepuestos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRepuestos.SelectedIndexChanged
        If cmbRepuestos.SelectedIndex = -1 Then Return

        Dim nombreRepuesto As String = cmbRepuestos.SelectedItem.ToString()

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                Dim query As String = "SELECT * FROM repuestos WHERE NombreRepuesto = @nombre"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nombre", nombreRepuesto)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtNombre.Text = reader("NombreRepuesto").ToString()
                            txtStock.Text = reader("CantidadStock").ToString()
                            txtPrecio.Text = reader("PrecioUnitario").ToString()
                            txtProveedor.Text = reader("Proveedor").ToString()
                            ' Guardar el ID internamente para actualizar
                            _repuestoIDSeleccionado = Convert.ToInt32(reader("RepuestoID"))
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos del repuesto: " & ex.Message)
        End Try
    End Sub

    ' Botón Volver
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim adminMenu As New AdminForm()
        adminMenu.Show()
        Me.Close()
    End Sub

    ' Botón Ver
    Private Sub btVer_Click(sender As Object, e As EventArgs) Handles btVer.Click
        If cmbRepuestos.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un repuesto primero.")
            Return
        End If

        Dim nombreRepuesto As String = cmbRepuestos.SelectedItem.ToString()

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                Dim query As String = "SELECT * FROM repuestos WHERE NombreRepuesto = @nombre"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nombre", nombreRepuesto)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim info As String = "RepuestoID: " & reader("RepuestoID").ToString() & vbCrLf &
                                                 "NombreRepuesto: " & reader("NombreRepuesto").ToString() & vbCrLf &
                                                 "CantidadStock: " & reader("CantidadStock").ToString() & vbCrLf &
                                                 "PrecioUnitario: $" & reader("PrecioUnitario").ToString() & vbCrLf &
                                                 "Proveedor: " & reader("Proveedor").ToString()
                            MessageBox.Show(info, "Detalle del Repuesto")
                        Else
                            MessageBox.Show("No se encontró el repuesto.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al leer el repuesto: " & ex.Message)
        End Try
    End Sub

    ' Botón Eliminar
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        If cmbRepuestos.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un repuesto primero.", "Atención")
            Return
        End If

        Dim nombreRepuesto As String = cmbRepuestos.SelectedItem.ToString()

        Dim resultado As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar el repuesto """ & nombreRepuesto & """?",
                                                        "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If resultado = DialogResult.No Then Return

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                Dim query As String = "DELETE FROM repuestos WHERE NombreRepuesto = @nombre"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nombre", nombreRepuesto)
                    Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()
                    If filasAfectadas > 0 Then
                        MessageBox.Show("Repuesto eliminado correctamente.", "Éxito")
                        CargarRepuestos()
                    Else
                        MessageBox.Show("No se encontró el repuesto para eliminar.", "Error")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el repuesto: " & ex.Message, "Error")
        End Try
    End Sub

    ' Botón Ingresar
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btIngresar.Click
        If String.IsNullOrWhiteSpace(txtNombre.Text) OrElse
           String.IsNullOrWhiteSpace(txtStock.Text) OrElse
           String.IsNullOrWhiteSpace(txtPrecio.Text) OrElse
           String.IsNullOrWhiteSpace(txtProveedor.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Atención")
            Return
        End If

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                Dim query As String = "INSERT INTO repuestos (NombreRepuesto, CantidadStock, PrecioUnitario, Proveedor) " &
                                      "VALUES (@nombre, @stock, @precio, @proveedor)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
                    cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text))
                    cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text))
                    cmd.Parameters.AddWithValue("@proveedor", txtProveedor.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Repuesto ingresado correctamente.", "Éxito")
            txtNombre.Clear()
            txtStock.Clear()
            txtPrecio.Clear()
            txtProveedor.Clear()
            CargarRepuestos()
        Catch ex As Exception
            MessageBox.Show("Error al ingresar el repuesto: " & ex.Message, "Error")
        End Try
    End Sub

    ' Botón Editar
    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If _repuestoIDSeleccionado = -1 Then
            MessageBox.Show("Seleccione un repuesto para editar.", "Atención")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtNombre.Text) OrElse
           String.IsNullOrWhiteSpace(txtStock.Text) OrElse
           String.IsNullOrWhiteSpace(txtPrecio.Text) OrElse
           String.IsNullOrWhiteSpace(txtProveedor.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Atención")
            Return
        End If

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                Dim query As String = "UPDATE repuestos SET NombreRepuesto=@nombre, CantidadStock=@stock, PrecioUnitario=@precio, Proveedor=@proveedor WHERE RepuestoID=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
                    cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text))
                    cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text))
                    cmd.Parameters.AddWithValue("@proveedor", txtProveedor.Text)
                    cmd.Parameters.AddWithValue("@id", _repuestoIDSeleccionado)

                    Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()
                    If filasAfectadas > 0 Then
                        MessageBox.Show("Repuesto actualizado correctamente.", "Éxito")
                        CargarRepuestos()
                    Else
                        MessageBox.Show("No se pudo actualizar el repuesto.", "Error")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el repuesto: " & ex.Message, "Error")
        End Try
    End Sub
End Class
