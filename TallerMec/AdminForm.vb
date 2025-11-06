Public Class AdminForm

    ' metodo constructor usando el modulo UsuarioActual
    Public Sub New()
        InitializeComponent()
        ' Mostrar correo y rol del usuario actual en etiquetas desde el módulo UsuarioActual.
        lbCorreo.Text = UsuarioActual.Correo
        lbRol.Text = UsuarioActual.Rol
    End Sub
    ' Configuración del formulario al cargar según el rol del usuario
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case UsuarioActual.Rol
            Case "Administrador", "Gerente"
                ' Acceso completo

            Case "Aseguradora", "Vendedor"
                ' Acceso limitado a repuestos y clientes ocultando botones.
                btnRepuestos.Visible = False
                btnUsuarios.Visible = False

            Case "Mecanico"
                ' Acceso limitado a empleados y usuarios ocultando botones.
                btnEmpleados.Visible = False
                btnUsuarios.Visible = False
                btnRepuestos.Visible = True
                btnClientes.Visible = True
                btnSiniestros.Visible = True
                btnServicios.Visible = True

            Case Else
                ' Sin acceso
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
        Me.Close()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        Dim usuariosForm As New UsuariosForm()
        usuariosForm.Show()
        Me.Close()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim clientesForm As New ClientesForm()
        clientesForm.Show()
        Me.Close()
    End Sub

    Private Sub btnRepuestos_Click(sender As Object, e As EventArgs) Handles btnRepuestos.Click
        Dim repuestosForm As New RepuestosForm()
        repuestosForm.Show()
        Me.Close()
    End Sub

    Private Sub btnSiniestros_Click(sender As Object, e As EventArgs) Handles btnSiniestros.Click
        Dim siniestrosForm As New SiniestrosForm()
        siniestrosForm.Show()
        Me.Close()
    End Sub

    Private Sub btnServicios_Click(sender As Object, e As EventArgs) Handles btnServicios.Click
        Dim serviciosForm As New ServiciosForm()
        serviciosForm.Show()
        Me.Close()
    End Sub
End Class