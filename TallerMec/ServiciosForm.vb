Public Class ServiciosForm
    Private correoUsuario As String
    Private rolUsuario As String

    ' Constructor usando el módulo UsuarioActual.
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        ' Abrir AdminForm.
        Dim adminMenu As New AdminForm()
        adminMenu.Show()
        Me.Close()
    End Sub
End Class