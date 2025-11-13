Imports MySql.Data.MySqlClient

Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click

    If txtId.Text.Trim() = "" Then
        MessageBox.Show("Ingrese un ID de venta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return
    End If

    Try
        Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
            Dim query As String = "SELECT * FROM ventasrepuestos WHERE VentaID = @id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", txtId.Text.Trim())

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)
            dgvHistorial.DataSource = dt
        End Using

    Catch ex As Exception
        MessageBox.Show("Error al buscar venta: " & ex.Message, "Error")
    End Try

End Sub
