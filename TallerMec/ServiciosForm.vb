Public Class ServiciosForm
    '   Variables para almacenar correo y rol
    Private correoUsuario As String
    Private rolUsuario As String
    ' Constructor que recibe correo y rol
    Public Sub New(correo As String, rol As String)
        InitializeComponent()
        correoUsuario = correo
        rolUsuario = rol
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim adminMenu As New AdminForm(correoUsuario, rolUsuario)
        adminMenu.Show()
        Me.Close()
    End Sub
End Class