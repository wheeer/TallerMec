Public Class ClientesForm
    Public Property CallerForm As Form
    Public Sub New()
        InitializeComponent()
        ' Nombre de la ventana
        Me.Text = "Gestión de Clientes"
        ' centrar la ventana al abrirse
        Me.StartPosition = FormStartPosition.CenterScreen
        ' desactivar maximizar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        ' desactivar maximizar botón
        Me.MaximizeBox = False
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        If CallerForm IsNot Nothing Then
            ' Volver a la ventana que abrió ClientesForm
            CallerForm.Show
        Else
            ' Comportamiento normal si se abrió desde AdminMenu u otra parte
            Dim admin As New AdminForm
            admin.Show
        End If

        Close
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnApellidoM.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub

    Private Sub ClientesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
