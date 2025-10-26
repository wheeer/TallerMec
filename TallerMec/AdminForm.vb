Public Class AdminForm
    ' Variables para almacenar el correo y rol del usuario actual
    Private correoUsuario As String
    Private rolUsuario As String

    ' metodo constructor usando el modulo UsuarioActual
    Public Sub New()
        InitializeComponent()
        correoUsuario = UsuarioActual.Correo ' Obtener correo del usuario actual
        rolUsuario = UsuarioActual.Rol ' Obtener rol del usuario actual
        lbCorreo.Text = correoUsuario
        lbRol.Text = rolUsuario
    End Sub

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case rolUsuario
            Case "Administrador", "Gerente"
                ' Acceso completo

            Case "Aseguradora", "Vendedor"
                btnRepuestos.Visible = False
                btnUsuarios.Visible = False

            Case "Mecanico"
                btnEmpleados.Visible = False
                btnUsuarios.Visible = False
                btnRepuestos.Visible = True
                btnClientes.Visible = True
                btnSiniestros.Visible = True
                btnServicios.Visible = True

            Case Else
                For Each btn As Button In grbBotones.Controls.OfType(Of Button)()
                    btn.Visible = False
                Next
        End Select
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        Dim empleadosForm As New EmpleadosForm()
        empleadosForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        Dim usuariosForm As New UsuariosForm()
        usuariosForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim clientesForm As New ClientesForm()
        clientesForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnRepuestos_Click(sender As Object, e As EventArgs) Handles btnRepuestos.Click
        Dim repuestosForm As New RepuestosForm()
        repuestosForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSiniestros_Click(sender As Object, e As EventArgs) Handles btnSiniestros.Click
        Dim siniestrosForm As New SiniestrosForm()
        siniestrosForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnServicios_Click(sender As Object, e As EventArgs) Handles btnServicios.Click
        Dim serviciosForm As New ServiciosForm()
        serviciosForm.Show()
        Me.Hide()
    End Sub
End Class