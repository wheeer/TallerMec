Imports MySql.Data.MySqlClient

Public Class Form1
    ' Evento Load del formulario inicial.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' nombre de la ventana
        Me.Text = "Mechanico Login"
        ' centrar la ventana al abrirse
        Me.StartPosition = FormStartPosition.CenterScreen
        ' desactivar maximizar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        ' desactivar maximizar botón
        Me.MaximizeBox = False
    End Sub

    ' Limpiar los campos del formulario de inicio de sesión.
    Private Sub LimpiarFormulario()
        tbCorreo.Clear()
        tbPwd.Clear()
        tbCorreo.Focus()
    End Sub

    ' Click del botón de inicio de sesión.
    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        ' Obtener datos de usuario y contraseña de los TextBox.
        Dim usuario = tbCorreo.Text
        Dim passw = tbPwd.Text
        ' conexión a la base de datos usando módulo de conexión.
        Using conn = ConexionBD.ObtenerConexion()
            Try
                ' Consulta SQL para obtener datos del usuario.
                Dim sqlUsuario = "SELECT Contraseña, Correo, Tipo FROM usuarios WHERE Correo=@correo"
                ' Ejecutar consulta
                Using cmd As New MySqlCommand(sqlUsuario, conn)
                    cmd.Parameters.AddWithValue("@correo", usuario)
                    ' Leer resultados
                    Using reader = cmd.ExecuteReader()
                        ' manejar caso de usuario no encontrado en la base de datos.
                        If Not reader.HasRows Then
                            MessageBox.Show("Correo no registrado.")
                            Return
                        End If
                        ' Leer datos del usuario.
                        reader.Read()
                        Dim contraseñaBD = reader("Contraseña").ToString
                        Dim correoBD = reader("Correo").ToString
                        Dim rolBD = reader("Tipo").ToString
                        ' Verificar contraseña ingresada.
                        If passw <> contraseñaBD Then
                            MessageBox.Show("Contraseña incorrecta.")
                            Return
                        End If

                        ' Guardar usuario actual en el módulo UsuarioActual para uso posterior.
                        UsuarioActual.SetUsuario(correoBD, rolBD)

                        ' Abrir AdminForm directamente después de inicio de sesión exitoso.
                        Dim adminForm As New AdminForm()
                        adminForm.Show() ' Mostrar el formulario de administrador
                        Me.Hide() ' Ocultar el formulario de inicio de sesión
                        LimpiarFormulario()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error de conexión: " & ex.Message)
            End Try
        End Using
    End Sub
End Class