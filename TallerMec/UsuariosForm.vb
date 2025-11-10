Imports MySql.Data.MySqlClient

Public Class UsuariosForm

    Public Sub New()
        InitializeComponent()
        ' Nombre de la ventana
        Me.Text = "Gestión de Usuarios"
        ' centrar la ventana al abrirse
        Me.StartPosition = FormStartPosition.CenterScreen
        ' desactivar maximizar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        ' desactivar maximizar botón
        Me.MaximizeBox = False
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
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        If String.IsNullOrWhiteSpace(tbRut.Text) OrElse
           String.IsNullOrWhiteSpace(tbCorreo.Text) OrElse
           String.IsNullOrWhiteSpace(tbUsuario.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Atención")
            Return
        End If

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                Dim query As String = "INSERT INTO usuarios (Rut, Correo, Tipo) VALUES (@rut, @correo, @tipo);"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@rut", tbRut.Text)
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
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If String.IsNullOrWhiteSpace(tbRut.Text) Then
            MessageBox.Show("Debe ingresar un RUT para actualizar.", "Atención")
            Return
        End If

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                Dim query As String = "UPDATE usuarios SET Correo=@correo, Tipo=@tipo WHERE Rut=@rut;"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@correo", tbCorreo.Text)
                    cmd.Parameters.AddWithValue("@tipo", tbUsuario.Text)
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
    Private Sub btnEiminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
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
    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Dim adminMenu As New AdminForm()
        adminMenu.Show()
        Me.Close()
    End Sub

    ' Limpiar todos los campos
    Private Sub LimpiarCampos()
        tbrut.Clear()
        tbCorreo.Clear()

    End Sub

    Private Sub UsuariosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class
