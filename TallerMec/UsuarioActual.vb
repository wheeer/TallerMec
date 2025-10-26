Module UsuarioActual
    ' Variables para almacenar el correo y rol del usuario actual.
    Public Correo As String
    Public Rol As String
    ' Método para establecer el usuario actual.
    Public Sub SetUsuario(correoUsuario As String, rolUsuario As String)
        Correo = correoUsuario
        Rol = rolUsuario
    End Sub
End Module

