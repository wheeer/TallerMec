Public Class AdminForm
    Public Sub New(correo As String, rol As String)
        InitializeComponent()
        lbCorreo.Text = correo
        lbRol.Text = rol
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Mostrar de nuevo el Form1
        Form1.Show()
        ' Cerrar este formulario
        Me.Close()
    End Sub
End Class