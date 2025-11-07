Public Class EmpleadosForm
    Public Sub New()
        InitializeComponent()
        ' Nombre de la ventana
        Me.Text = "Gestión de Empleados"
        ' centrar la ventana al abrirse
        Me.StartPosition = FormStartPosition.CenterScreen
        ' desactivar maximizar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        ' desactivar maximizar botón
        Me.MaximizeBox = False
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        ' Abrir AdminForm.
        Dim adminMenu As New AdminForm()
        adminMenu.Show()
        Me.Close()
    End Sub
End Class