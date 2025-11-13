Imports MySql.Data.MySqlClient

Public Class UsuariosForm

    Public Sub New()
        InitializeComponent()
        ' Nombre de la ventana
        Me.Text = "Gestión de Usuarios"
        ' Centrar la ventana al abrirse
        Me.StartPosition = FormStartPosition.CenterScreen
        ' Desactivar maximizar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        ' Desactivar botón maximizar
        Me.MaximizeBox = False
    End Sub
    ' Cargar los roles en el ComboBox al iniciar el formulario
    Private Sub CargarRoles()
        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                Dim query As String = "SELECT DISTINCT Tipo FROM usuarios WHERE Tipo IS NOT NULL;"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cbRol.Items.Clear()
                        While reader.Read()
                            cbRol.Items.Add(reader("Tipo").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los roles: " & ex.Message)
        End Try
    End Sub

    ' Al cargar el formulario
    Private Sub UsuariosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarRoles()
    End Sub

    ' Buscar usuario por RUT
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If String.IsNullOrWhiteSpace(tbRut.Text) Then
            MessageBox.Show("Ingrese el RUT del usuario para buscar.", "Atención")
            Return
        End If

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                Dim query As String = "SELECT * FROM usuarios WHERE Rut = @rut;"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@rut", tbRut.Text)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            tbRut.Text = reader("Rut").ToString()
                            tbCorreo.Text = reader("Correo").ToString()
                            tbContrasena.Text = reader("Contraseña").ToString()
                            cbRol.SelectedItem = reader("Tipo").ToString()
                            MessageBox.Show("Usuario encontrado correctamente.")
                        Else
                            MessageBox.Show("No se encontró el usuario con ese RUT.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al buscar usuario: " & ex.Message)
        End Try
    End Sub

    ' Crear usuario nuevo
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        If String.IsNullOrWhiteSpace(tbRut.Text) OrElse
           String.IsNullOrWhiteSpace(tbContrasena.Text) OrElse
           String.IsNullOrWhiteSpace(tbCorreo.Text) OrElse
           cbRol.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, complete todos los campos.", "Atención")
            Return
        End If

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                Dim query As String = "INSERT INTO usuarios (Rut, Contraseña, Correo, Tipo) VALUES (@rut, @contraseña, @correo, @tipo);"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@rut", tbRut.Text)
                    cmd.Parameters.AddWithValue("@correo", tbCorreo.Text)
                    cmd.Parameters.AddWithValue("@contraseña", tbRut.Text)
                    cmd.Parameters.AddWithValue("@tipo", cbRol.SelectedItem.ToString())
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Usuario creado correctamente.")
            LimpiarCampos()
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Ya existe un usuario con ese RUT.", "Duplicado")
            Else
                MessageBox.Show("Error al crear usuario: " & ex.Message)
            End If
        End Try
    End Sub

    ' Actualizar usuario existente
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If String.IsNullOrWhiteSpace(tbRut.Text) Then
            MessageBox.Show("Debe ingresar un RUT para actualizar.", "Atención")
            Return
        End If

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                Dim query As String = "UPDATE usuarios SET Correo=@correo, Contraseña=@contraseña, Tipo=@tipo WHERE Rut=@rut;"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@correo", tbCorreo.Text)
                    cmd.Parameters.AddWithValue("@contraseña", tbContrasena.Text)
                    cmd.Parameters.AddWithValue("@tipo", cbRol.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@rut", tbRut.Text)

                    Dim filas As Integer = cmd.ExecuteNonQuery()
                    If filas > 0 Then
                        MessageBox.Show("Usuario actualizado correctamente.")
                        LimpiarCampos()
                    Else
                        MessageBox.Show("No se encontró el usuario para actualizar.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar usuario: " & ex.Message)
        End Try
    End Sub

    ' Eliminar usuario
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrWhiteSpace(tbRut.Text) Then
            MessageBox.Show("Ingrese el RUT del usuario que desea eliminar.", "Atención")
            Return
        End If

        Dim confirm As DialogResult = MessageBox.Show($"¿Está seguro que desea eliminar al usuario con RUT {tbRut.Text}?",
                                                      "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm = DialogResult.No Then Return

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                Dim query As String = "DELETE FROM usuarios WHERE Rut=@rut;"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@rut", tbRut.Text)
                    Dim filas As Integer = cmd.ExecuteNonQuery()
                    If filas > 0 Then
                        MessageBox.Show("Usuario eliminado correctamente.")
                        LimpiarCampos()
                    Else
                        MessageBox.Show("No se encontró el usuario para eliminar.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar usuario: " & ex.Message)
        End Try
    End Sub

    ' Volver al menú
    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim adminMenu As New AdminForm()
        adminMenu.Show()
        Me.Close()
    End Sub

    ' Limpiar todos los campos
    Private Sub LimpiarCampos()
        tbRut.Clear()
        tbCorreo.Clear()
        tbContrasena.Clear()
        cbRol.SelectedIndex = -1
    End Sub



End Class
