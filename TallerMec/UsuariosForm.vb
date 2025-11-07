Imports MySql.Data.MySqlClient

Public Class UsuariosForm

    Public Sub New()
        InitializeComponent()
    End Sub

    ' Buscar usuario por RUT
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If String.IsNullOrWhiteSpace(tbrut.Text) Then
            MessageBox.Show("Ingrese el RUT del usuario para buscar.", "Atención")
            Return
        End If

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                Dim query As String = "SELECT * FROM usuarios WHERE Rut = @rut;"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@rut", tbrut.Text)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            tbrut.Text = reader("Rut").ToString()
                            tbCorreo.Text = reader("Correo").ToString()
                            tbUsuario.Text = reader("Tipo").ToString()
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
    Private Sub tbCrear_Click(sender As Object, e As EventArgs) Handles tbCrear.Click
        If String.IsNullOrWhiteSpace(tbrut.Text) OrElse
           String.IsNullOrWhiteSpace(tbCorreo.Text) OrElse
           String.IsNullOrWhiteSpace(tbUsuario.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Atención")
            Return
        End If

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                Dim query As String = "INSERT INTO usuarios (Rut, Nombre, Correo, Tipo) VALUES (@rut, @nombre, @correo, @tipo);"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@rut", tbrut.Text)
                    cmd.Parameters.AddWithValue("@nombre", tbNombre.Text)
                    cmd.Parameters.AddWithValue("@correo", tbCorreo.Text)
                    cmd.Parameters.AddWithValue("@tipo", tbUsuario.Text)
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
    Private Sub tbActualizar_Click(sender As Object, e As EventArgs) Handles tbActualizar.Click
        If String.IsNullOrWhiteSpace(tbrut.Text) Then
            MessageBox.Show("Debe ingresar un RUT para actualizar.", "Atención")
            Return
        End If

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                Dim query As String = "UPDATE usuarios SET Nombre=@nombre, Correo=@correo, Tipo=@tipo WHERE Rut=@rut;"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@correo", tbCorreo.Text)
                    cmd.Parameters.AddWithValue("@tipo", tbUsuario.Text)
                    cmd.Parameters.AddWithValue("@rut", tbrut.Text)

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
    Private Sub tbEliminar_Click(sender As Object, e As EventArgs) Handles tbEliminar.Click
        If String.IsNullOrWhiteSpace(tbrut.Text) Then
            MessageBox.Show("Ingrese el RUT del usuario que desea eliminar.", "Atención")
            Return
        End If

        Dim confirm As DialogResult = MessageBox.Show($"¿Está seguro que desea eliminar al usuario con RUT {tbrut.Text}?",
                                                      "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm = DialogResult.No Then Return

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                Dim query As String = "DELETE FROM usuarios WHERE Rut=@rut;"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@rut", tbrut.Text)
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
    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Dim adminMenu As New AdminForm()
        adminMenu.Show()
        Me.Close()
    End Sub

    ' Limpiar todos los campos
    Private Sub LimpiarCampos()
        tbrut.Clear()
        tbCorreo.Clear()
        tbUsuario.Clear()
    End Sub

End Class
