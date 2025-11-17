Public Class SiniestrosForm
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
        Dim adminMenu As New AdminForm()
        adminMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        Dim historialSiniestros As New Historial_Siniestros()
        historialSiniestros.Show()
        Me.Close()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub SiniestrosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class