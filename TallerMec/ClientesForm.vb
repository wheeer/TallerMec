Imports MySql.Data.MySqlClient

Public Class ClientesForm

    Public Property CallerForm As Form

    Public Sub New()
        InitializeComponent()
        Me.Text = "Gestión de Clientes"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
    End Sub

    ' ======================================
    '   BOTÓN VOLVER
    ' ======================================
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        If CallerForm IsNot Nothing Then
            CallerForm.Show()
        Else
            Dim admin As New AdminForm
            admin.Show()
        End If

        Close()
    End Sub

    ' ======================================
    '   GUARDAR CLIENTE
    ' ======================================
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If String.IsNullOrWhiteSpace(tbRut.Text) Or
           String.IsNullOrWhiteSpace(tbNombre.Text) Or
           String.IsNullOrWhiteSpace(tbApellidoP.Text) Or
           String.IsNullOrWhiteSpace(tbApellidoM.Text) Then

            MessageBox.Show("Complete todos los campos obligatorios.", "Atención")
            Return
        End If

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()

                Dim query As String =
                    "INSERT INTO clientes 
                    (Rut, Nombre, ApellidoP, ApellidoM, Direccion, Telefono, Comuna) 
                     VALUES 
                    (@rut, @nombre, @apep, @apem, @dir, @tel, @com)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@rut", tbRut.Text)
                    cmd.Parameters.AddWithValue("@nombre", tbNombre.Text)
                    cmd.Parameters.AddWithValue("@apep", tbApellidoP.Text)
                    cmd.Parameters.AddWithValue("@apem", tbApellidoM.Text)
                    cmd.Parameters.AddWithValue("@dir", tbDireccion.Text)
                    cmd.Parameters.AddWithValue("@tel", tbTelefono.Text)
                    cmd.Parameters.AddWithValue("@com", tbComuna.Text)

                    cmd.ExecuteNonQuery()
                End Using

            End Using

            MessageBox.Show("Cliente guardado correctamente.")
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al guardar cliente: " & ex.Message)
        End Try
    End Sub


    ' ======================================
    '   BUSCAR CLIENTE POR RUT
    ' ======================================
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If String.IsNullOrWhiteSpace(tbRut.Text) Then
            MessageBox.Show("Ingrese un RUT para buscar.", "Atención")
            Return
        End If

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()

                Dim query As String =
                    "SELECT * FROM clientes WHERE Rut = @rut"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@rut", tbRut.Text)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then
                            tbNombre.Text = reader("Nombre").ToString()
                            tbApellidoP.Text = reader("ApellidoP").ToString()
                            tbApellidoM.Text = reader("ApellidoM").ToString()
                            tbDireccion.Text = reader("Direccion").ToString()
                            tbTelefono.Text = reader("Telefono").ToString()
                            tbComuna.Text = reader("Comuna").ToString()
                        Else
                            MessageBox.Show("Cliente no encontrado.")
                        End If

                    End Using

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al buscar cliente: " & ex.Message)
        End Try

    End Sub


    ' ======================================
    '   ELIMINAR CLIENTE
    ' ======================================
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If String.IsNullOrWhiteSpace(tbRut.Text) Then
            MessageBox.Show("Ingrese el RUT del cliente para eliminar.", "Atención")
            Return
        End If

        Dim conf As DialogResult =
            MessageBox.Show("¿Seguro que desea eliminar al cliente con RUT " & tbRut.Text & "?",
                            "Confirmar eliminación",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning)

        If conf = DialogResult.No Then Return

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()

                Dim query As String = "DELETE FROM clientes WHERE Rut = @rut"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@rut", tbRut.Text)

                    Dim filas As Integer = cmd.ExecuteNonQuery()

                    If filas > 0 Then
                        MessageBox.Show("Cliente eliminado correctamente.")
                        LimpiarCampos()
                    Else
                        MessageBox.Show("No se encontró el cliente para eliminar.")
                    End If

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al eliminar cliente: " & ex.Message)
        End Try

    End Sub


    ' ======================================
    '   LIMPIAR CAMPOS
    ' ======================================
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        tbRut.Clear()
        tbNombre.Clear()
        tbApellidoP.Clear()
        tbApellidoM.Clear()
        tbDireccion.Clear()
        tbTelefono.Clear()
        tbComuna.Clear()
    End Sub

    '   ACTUALIZAR CLIENTE
    ' ======================================
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

    If String.IsNullOrWhiteSpace(tbRut.Text) Then
        MessageBox.Show("Debe ingresar el RUT del cliente para actualizar.", "Atención")
        Return
    End If

    If String.IsNullOrWhiteSpace(tbNombre.Text) Or
       String.IsNullOrWhiteSpace(tbApellidoP.Text) Or
       String.IsNullOrWhiteSpace(tbApellidoM.Text) Then

        MessageBox.Show("Los campos Nombre y Apellidos no pueden estar vacíos.", "Atención")
        Return
    End If

    Try
        Using conn As MySqlConnection = ConexionBD.ObtenerConexion()

            Dim query As String =
                "UPDATE clientes SET 
                    Nombre = @nombre,
                    ApellidoP = @apep,
                    ApellidoM = @apem,
                    Direccion = @dir,
                    Telefono = @tel,
                    Comuna = @com
                 WHERE Rut = @rut"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@rut", tbRut.Text)
                cmd.Parameters.AddWithValue("@nombre", tbNombre.Text)
                cmd.Parameters.AddWithValue("@apep", tbApellidoP.Text)
                cmd.Parameters.AddWithValue("@apem", tbApellidoM.Text)
                cmd.Parameters.AddWithValue("@dir", tbDireccion.Text)
                cmd.Parameters.AddWithValue("@tel", tbTelefono.Text)
                cmd.Parameters.AddWithValue("@com", tbComuna.Text)

                Dim filas As Integer = cmd.ExecuteNonQuery()

                If filas > 0 Then
                    MessageBox.Show("Cliente actualizado correctamente.")
                Else
                    MessageBox.Show("No se encontró el cliente para actualizar.")
                End If
            End Using

        End Using

    Catch ex As Exception
        MessageBox.Show("Error al actualizar cliente: " & ex.Message)
    End Try

End Sub

End Class

