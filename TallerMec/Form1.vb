Imports MySql.Data.MySqlClient

Public Class Form1
    Private connectionString As String = "Server=localhost;Database=taller;User ID='root';Password='';"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración del formulario
        Me.Text = "Mechanico Login"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
    End Sub
    Private Sub LimpiarFormulario()
        tbCorreo.Clear()
        tbPwd.Clear()
        tbCorreo.Focus()
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Dim usuario = tbCorreo.Text
        Dim passw = tbPwd.Text

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                '   Consulta para obtener los datos del usuario
                Dim sqlUsuario = "SELECT Contraseña, Correo, Tipo FROM usuarios WHERE Correo=@correo"
                Using cmd As New MySqlCommand(sqlUsuario, conn)
                    cmd.Parameters.AddWithValue("@correo", usuario)
                    Using reader = cmd.ExecuteReader
                        If Not reader.HasRows Then
                            MessageBox.Show("Correo no registrado.")
                            Return
                        End If
                        '   Leer los datos del usuario
                        reader.Read()
                        Dim contraseñaBD = reader("Contraseña").ToString
                        Dim correoBD = reader("Correo").ToString
                        Dim rol = reader("Tipo").ToString
                        '   Verificar la contraseña
                        If passw <> contraseñaBD Then
                            MessageBox.Show("Contraseña incorrecta.")
                            Return
                        End If

                        ' Abrir formulario según rol
                        Select Case rol
                            Case "Administrador"
                                Dim adminForm As New AdminForm(correoBD, rol)
                                adminForm.Show()
                            Case Else
                                MessageBox.Show("Rol no reconocido: " & rol)
                                Return
                        End Select

                        LimpiarFormulario()
                        Hide() ' Ocultar el formulario de inicio de sesión
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error de conexión: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
