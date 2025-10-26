Imports MySql.Data.MySqlClient
Module ConexionBD
    ' Cadena de conexión a la base de datos MySQL.
    Private connectionString As String = "Server=localhost;Database=taller;User ID='root';Password='';"

    ' Función para obtener una conexión abierta a la base de datos MySQL.
    Public Function ObtenerConexion() As MySqlConnection
        ' Crear y abrir la conexión a la base de datos.
        Dim conn As New MySqlConnection(connectionString)
        conn.Open()
        Return conn
    End Function
End Module
