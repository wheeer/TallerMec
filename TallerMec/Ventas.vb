Public Class Ventas

    Public Sub New()
        InitializeComponent()
        ' Nombre de la ventana
        Me.Text = "Gestión de Siniestros"
        ' centrar la ventana al abrirse
        Me.StartPosition = FormStartPosition.CenterScreen
        ' desactivar maximizar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        ' desactivar maximizar botón
        Me.MaximizeBox = False
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        ' Abrir AdminForm.
        Dim adminMenu As New AdminForm
        adminMenu.Show()
        Close()
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        ' Abrir AdminForm.
        Dim Resumen_Ventas As New Resumen_Ventas
        Resumen_Ventas.Show()
        Close()
    End Sub
End Class