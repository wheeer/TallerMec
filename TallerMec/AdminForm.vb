Public Class AdminForm
    '   Variables para almacenar correo y rol del usuario actual 
    Private correoUsuario As String
    Private rolUsuario As String

    ' Constructor que recibe correo y rol del usuario actual
    Public Sub New(correo As String, rol As String)
        InitializeComponent()
        correoUsuario = correo
        rolUsuario = rol
        lbCorreo.Text = correoUsuario
        lbRol.Text = rolUsuario
    End Sub

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' control acceso según rol del usuario
        Select Case rolUsuario
            Case "Administrador", "Gerente"
                ' Acceso completo, no se bloquea nada

            Case "Aseguradora", "Vendedor"
                btnRepuestos.Visible = False ' Repuestos
                btnUsuarios.Visible = False ' Usuarios

            Case "Mecanico"
                btnEmpleados.Visible = False ' Empleados
                btnUsuarios.Visible = False ' Usuarios
                btnRepuestos.Visible = True ' Repuestos
                btnClientes.Visible = True  ' Clientes
                btnSiniestros.Visible = True   ' Siniestros
                btnServicios.Visible = True   ' Servicios

            Case Else
                ' Cualquier otro rol: solo puede cerrar sesión
                For Each btn As Button In grbBotones.Controls.OfType(Of Button)()
                    btn.Visible = False
                Next
        End Select
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        ' Mostrar de nuevo el Form1
        Form1.Show()
        ' Cerrar este formulario
        Me.Close()
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        Dim empleadosForm As New EmpleadosForm(correoUsuario, rolUsuario)
        ' Abrir el formulario de Empleados
        empleadosForm.Show()
        ' Ocultar el formulario actual
        Me.Hide()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        Dim UsuariosForm As New UsuariosForm(correoUsuario, rolUsuario)
        ' Abrir el formulario de Usuarios
        UsuariosForm.Show()
        ' Ocultar el formulario actual
        Me.Hide()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim ClientesForm As New ClientesForm(correoUsuario, rolUsuario)
        ' Abrir el formulario de Clientes
        ClientesForm.Show()
        ' Ocultar el formulario actual
        Me.Hide()
    End Sub

    Private Sub btnRepuestos_Click(sender As Object, e As EventArgs) Handles btnRepuestos.Click
        Dim RepuestosForm As New RepuestosForm(correoUsuario, rolUsuario)
        ' Abrir el formulario de Repuestos
        RepuestosForm.Show()
        ' Ocultar el formulario actual
        Me.Hide()
    End Sub

    Private Sub btnSiniestros_Click(sender As Object, e As EventArgs) Handles btnSiniestros.Click
        Dim SiniestrosForm As New SiniestrosForm(correoUsuario, rolUsuario)
        'abrir el formulario de Siniestros
        SiniestrosForm.Show()
        ' Ocultar el formulario actual
        Me.Hide()
    End Sub

    Private Sub btnServicios_Click(sender As Object, e As EventArgs) Handles btnServicios.Click
        Dim ServiciosForm As New ServiciosForm(correoUsuario, rolUsuario)
        ' Abrir el formulario de Servicios
        ServiciosForm.Show()
        ' Ocultar el formulario actual
        Me.Hide()
    End Sub
End Class