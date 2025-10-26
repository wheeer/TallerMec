Imports MySql.Data.MySqlClient

Public Class Form1
    '  Cadena de conexión a la base de datos
    Private connectionString As String = "Server=localhost;Database=taller;User ID='root';Password='';"

    ' Evento Load del formulario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración del formulario
        Me.Text = "Mechanico Login"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
    End Sub

    ' metodo para limpiar el formulario
    Private Sub LimpiarFormulario()
        tbCorreo.Clear()
        tbPwd.Clear()
        tbCorreo.Focus()
    End Sub

    ' metodo para abrir el formulario de administrador
    Private Sub AbrirAdminForm(correo As String, rol As String)
        Dim adminForm As New AdminForm(correo, rol)
        adminForm.Show()
        Me.Hide()
    End Sub

    ' Evento Click del botón de inicio de sesión
    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Dim usuario = tbCorreo.Text
        Dim passw = tbPwd.Text

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                '   Consulta para obtener los datos del usuario
                Dim sqlUsuario = "SELECT Contraseña, Correo, Tipo FROM usuarios WHERE Correo=@correo"
                '   Ejecutar la consulta
                Using cmd As New MySqlCommand(sqlUsuario, conn)
                    cmd.Parameters.AddWithValue("@correo", usuario)
                    '   Leer los resultados
                    Using reader = cmd.ExecuteReader
                        '  Verificar si se encontró el usuario
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
                            Case "Administrador", "Gerente", "Aseguradora", "Vendedor", "Mecanico", "Analista"
                                AbrirAdminForm(correoBD, rol)
                            Case Else
                                MessageBox.Show("Rol no reconocido: " & rol)
                                Return
                        End Select
                        LimpiarFormulario()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error de conexión: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
