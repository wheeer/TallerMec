Imports MySql.Data.MySqlClient

Public Class RepuestosForm
    ' Variables privadas del formulario
    Private repuestoSeleccionadoID As Integer = -1 ' Guarda el ID del repuesto seleccionado

    ' Constructor
    Public Sub New()
        InitializeComponent()
        ' Nombre de la ventana
        Me.Text = "Gestión de Repuestos"
        ' centrar la ventana al abrirse
        Me.StartPosition = FormStartPosition.CenterScreen
        ' desactivar maximizar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        ' desactivar maximizar botón
        Me.MaximizeBox = False
    End Sub

    ' Cargar datos al iniciar el formulario
    Private Sub RepuestosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarRepuestos()
    End Sub

    ' Carga los nombres de los repuestos al ComboBox
    Private Sub CargarRepuestos()
        Try
            Using conn = ConexionBD.ObtenerConexion()
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

    ' Muestra los detalles del repuesto seleccionado
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
                            repuestoSeleccionadoID = Convert.ToInt32(reader("RepuestoID"))
                            txtNombre.Text = reader("NombreRepuesto").ToString()
                            txtStock.Text = reader("CantidadStock").ToString()
                            txtPrecio.Text = reader("PrecioUnitario").ToString()
                            txtProveedor.Text = reader("Proveedor").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los detalles del repuesto: " & ex.Message)
        End Try
    End Sub

    ' Botón para ingresar o actualizar un repuesto
    Private Sub btIngresar_Click(sender As Object, e As EventArgs) Handles btIngresar.Click
        ' Validar que los campos no estén vacíos
        If String.IsNullOrWhiteSpace(txtNombre.Text) OrElse
           String.IsNullOrWhiteSpace(txtStock.Text) OrElse
           String.IsNullOrWhiteSpace(txtPrecio.Text) OrElse
           String.IsNullOrWhiteSpace(txtProveedor.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Atención")
            Return
        End If

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                ' Verificar si ya existe un repuesto con ese nombre
                Dim queryCheck As String = "SELECT RepuestoID FROM repuestos WHERE NombreRepuesto = @nombre"
                Using cmdCheck As New MySqlCommand(queryCheck, conn)
                    cmdCheck.Parameters.AddWithValue("@nombre", txtNombre.Text)
                    Dim existeID As Object = cmdCheck.ExecuteScalar()

                    If existeID IsNot Nothing Then
                        ' Si existe y es el mismo que el seleccionado → actualizar
                        If repuestoSeleccionadoID = Convert.ToInt32(existeID) Then
                            Dim queryUpdate As String = "UPDATE repuestos SET CantidadStock = @stock, PrecioUnitario = @precio, Proveedor = @proveedor WHERE RepuestoID = @id"
                            Using cmdUpdate As New MySqlCommand(queryUpdate, conn)
                                cmdUpdate.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text))
                                cmdUpdate.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text))
                                cmdUpdate.Parameters.AddWithValue("@proveedor", txtProveedor.Text)
                                cmdUpdate.Parameters.AddWithValue("@id", repuestoSeleccionadoID)
                                cmdUpdate.ExecuteNonQuery()
                            End Using
                            MessageBox.Show("Repuesto actualizado correctamente.", "Éxito")
                        Else
                            ' Si ya existe con otro ID → mensaje de duplicado
                            MessageBox.Show("Ya existe un repuesto con ese nombre.", "Duplicado")
                            Return
                        End If
                    Else
                        ' Si no existe, insertar nuevo
                        Dim queryInsert As String = "INSERT INTO repuestos (NombreRepuesto, CantidadStock, PrecioUnitario, Proveedor) VALUES (@nombre, @stock, @precio, @proveedor)"
                        Using cmdInsert As New MySqlCommand(queryInsert, conn)
                            cmdInsert.Parameters.AddWithValue("@nombre", txtNombre.Text)
                            cmdInsert.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text))
                            cmdInsert.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text))
                            cmdInsert.Parameters.AddWithValue("@proveedor", txtProveedor.Text)
                            cmdInsert.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Repuesto ingresado correctamente.", "Éxito")
                    End If
                End Using
            End Using

            ' Refrescar interfaz
            CargarRepuestos()
            LimpiarCampos()
            repuestoSeleccionadoID = -1

        Catch ex As Exception
            MessageBox.Show("Error al ingresar o actualizar el repuesto: " & ex.Message, "Error")
        End Try
    End Sub

    ' Botón Editar (opcional)
    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If repuestoSeleccionadoID = -1 Then
            MessageBox.Show("Seleccione un repuesto primero.", "Atención")
            Return
        End If

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                Dim query As String = "UPDATE repuestos SET NombreRepuesto = @nombre, CantidadStock = @stock, PrecioUnitario = @precio, Proveedor = @proveedor WHERE RepuestoID = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
                    cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text))
                    cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text))
                    cmd.Parameters.AddWithValue("@proveedor", txtProveedor.Text)
                    cmd.Parameters.AddWithValue("@id", repuestoSeleccionadoID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Repuesto editado correctamente.", "Éxito")
            CargarRepuestos()
            LimpiarCampos()
            repuestoSeleccionadoID = -1
        Catch ex As Exception
            MessageBox.Show("Error al editar el repuesto: " & ex.Message, "Error")
        End Try
    End Sub

    ' Botón Eliminar
    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        If cmbRepuestos.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un repuesto primero.", "Atención")
            Return
        End If

        Dim nombreRepuesto As String = cmbRepuestos.SelectedItem.ToString()
        Dim resultado As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar """ & nombreRepuesto & """?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If resultado = DialogResult.No Then Return

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                Dim query As String = "DELETE FROM repuestos WHERE NombreRepuesto = @nombre"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nombre", nombreRepuesto)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Repuesto eliminado correctamente.", "Éxito")
            CargarRepuestos()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el repuesto: " & ex.Message, "Error")
        End Try
    End Sub

    ' Botón Limpiar pantalla
    Private Sub btLimpiar_Click(sender As Object, e As EventArgs) Handles btLimpiar.Click
        LimpiarCampos()
    End Sub

    ' Limpia los TextBox
    Private Sub LimpiarCampos()
        txtNombre.Clear()
        txtStock.Clear()
        txtPrecio.Clear()
        txtProveedor.Clear()
        cmbRepuestos.SelectedIndex = -1
        repuestoSeleccionadoID = -1
    End Sub

    ' Botón Volver
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim adminMenu As New AdminForm()
        adminMenu.Show()
        Me.Close()
    End Sub
End Class
