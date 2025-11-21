Imports MySql.Data.MySqlClient

Public Class SiniestrosForm

    Public Sub New()
        InitializeComponent()
        Me.Text = "Gestión de Siniestros"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
    End Sub

    Private Sub SiniestrosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEstadosFiltro()
        CargarEstadosSiniestro()
        CargarCompanias()
        CargarEstadosSeguro()
        CargarHistorial()

        dgvHistorial.ReadOnly = True
        dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    ' 
    '  CARGA DE COMBOS 
    ' 

    Private Sub CargarEstadosFiltro()
        Try
            Using conn As MySqlConnection = ObtenerConexion()
                Dim query As String = "SELECT DISTINCT Estado_Siniestro FROM siniestro WHERE Estado_Siniestro IS NOT NULL"

                Using cmd As New MySqlCommand(query, conn)
                    Using rd As MySqlDataReader = cmd.ExecuteReader()
                        cbEstado.Items.Clear()
                        cbEstado.Items.Add("Todos")
                        While rd.Read()
                            cbEstado.Items.Add(rd("Estado_Siniestro").ToString())
                        End While
                    End Using
                End Using
            End Using

            cbEstado.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Error cargando estados del filtro: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarEstadosSiniestro()
        cmbEstado.Items.Clear()
        cmbEstado.Items.AddRange({"Activo", "Pendiente", "Finalizado"})
        cmbEstado.SelectedIndex = 0
    End Sub

    Private Sub CargarEstadosSeguro()
        cmbEstadoSeguro.Items.Clear()
        cmbEstadoSeguro.Items.AddRange({"Seguro Vigente", "Seguro Vencido", "En Evaluación"})
        cmbEstadoSeguro.SelectedIndex = 0
    End Sub

    Private Sub CargarCompanias()
        Try
            Using conn As MySqlConnection = ObtenerConexion()
                Dim query As String = "SELECT Rut, Descripcion FROM compania"

                Using cmd As New MySqlCommand(query, conn)
                    Using rd As MySqlDataReader = cmd.ExecuteReader()
                        cmbCompañia.Items.Clear()

                        While rd.Read()
                            cmbCompañia.Items.Add(rd("Rut") & " - " & rd("Descripcion"))
                        End While

                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error cargando compañías: " & ex.Message)
        End Try
    End Sub

    ' 
    ' CARGAR HISTORIAL 
    ' 

    Private Sub CargarHistorial(Optional rut As String = "", Optional estado As String = "")
        Try
            Using conn As MySqlConnection = ObtenerConexion()

                Dim query As String =
                "SELECT 
                    s.SiniestroID,
                    s.Rut AS RutCliente,
                    CONCAT(c.Nombre, ' ', c.ApellidoP, ' ', c.ApellidoM) AS Cliente,
                    s.Detalle,
                    s.Estado_Siniestro,
                    s.Estado_Seguro,
                    s.Fecha_Siniestro,
                    co.Descripcion AS Compania_Seguro
                FROM siniestro s
                LEFT JOIN clientes c ON s.Rut = c.Rut
                LEFT JOIN compania co ON s.RutCompania = co.Rut
                WHERE 1=1"

                If rut <> "" Then query &= " AND s.Rut = @rut"
                If estado <> "" AndAlso estado <> "Todos" Then query &= " AND s.Estado_Siniestro = @estado"

                Using da As New MySqlDataAdapter(query, conn)

                    If rut <> "" Then da.SelectCommand.Parameters.AddWithValue("@rut", rut)
                    If estado <> "" AndAlso estado <> "Todos" Then da.SelectCommand.Parameters.AddWithValue("@estado", estado)

                    Dim dt As New DataTable()
                    da.Fill(dt)

                    dgvHistorial.DataSource = dt
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error cargando historial: " & ex.Message)
        End Try
    End Sub

    ' 
    ' BOTONES SUPERIORES 
    ' 

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        CargarHistorial(tbRut.Text.Trim(), cbEstado.Text)
    End Sub

    Private Sub btnVerTodo_Click(sender As Object, e As EventArgs) Handles btnVerTodo.Click
        tbRut.Clear()
        cbEstado.SelectedIndex = 0
        CargarHistorial()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim a As New AdminForm()
        a.Show()
        Me.Close()
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        Dim h As New Historial_Siniestros()
        h.Show()
        Me.Close()
    End Sub

    ' 
    '  MODO INGRESAR 
    ' 

    Private Sub chbIngresar_CheckedChanged(sender As Object, e As EventArgs) Handles chbIngresar.CheckedChanged
        If chbIngresar.Checked Then
            chbModificar.Checked = False
            LimpiarCampos()

            txtId.Enabled = False
            txtDetalle.Enabled = True
            cmbEstado.Enabled = True
            dtpFecha.Enabled = True
            cmbCompañia.Enabled = True
            txtCliente.Enabled = True
            cmbEstadoSeguro.Enabled = True

            btnGuardar.Enabled = True
            btnModificar.Enabled = False
        End If
    End Sub

    ' 
    ' MODO MODIFICAR 
    '

    Private Sub chbModificar_CheckedChanged(sender As Object, e As EventArgs) Handles chbModificar.CheckedChanged
        If chbModificar.Checked Then
            chbIngresar.Checked = False
            LimpiarCampos()

            txtId.Enabled = True
            cmbEstado.Enabled = True

            txtDetalle.Enabled = False
            dtpFecha.Enabled = False
            cmbCompañia.Enabled = False
            txtCliente.Enabled = False
            cmbEstadoSeguro.Enabled = False

            btnGuardar.Enabled = False
            btnModificar.Enabled = True
        End If
    End Sub

    Private Sub LimpiarCampos()
        txtId.Clear()
        txtDetalle.Clear()
        txtCliente.Clear()
        cmbEstado.SelectedIndex = 0
        cmbCompañia.SelectedIndex = -1
        cmbEstadoSeguro.SelectedIndex = 0
    End Sub

    ' 
    '  INSERTAR 
    ' 

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        '
        ' 1. VALIDAR EXISTENCIA CLIENTE
        '
        Dim clienteExiste As Boolean = False

        Try
            Using conn As MySqlConnection = ObtenerConexion()
                Dim q As String = "SELECT COUNT(*) FROM clientes WHERE Rut = @rut"

                Using cmd As New MySqlCommand(q, conn)
                    cmd.Parameters.AddWithValue("@rut", txtCliente.Text.Trim())
                    clienteExiste = Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error validando cliente: " & ex.Message)
            Exit Sub
        End Try

        ' SI NO EXISTE → PREGUNTAR
        If Not clienteExiste Then

            Dim resp = MessageBox.Show(
                "El cliente con RUT " & txtCliente.Text.Trim() &
                " no está registrado." & vbCrLf &
                "¿Desea registrarlo ahora?",
                "Cliente no encontrado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

            If resp = DialogResult.Yes Then

                Dim fCliente As New ClientesForm()

                If fCliente.Controls.ContainsKey("tbRut") Then
                    fCliente.Controls("tbRut").Text = txtCliente.Text.Trim()
                End If

                fCliente.ShowDialog(Me)

                ' Volver a validar
                Try
                    Using conn As MySqlConnection = ObtenerConexion()
                        Dim q2 As String = "SELECT COUNT(*) FROM clientes WHERE Rut = @rut"
                        Using cmd2 As New MySqlCommand(q2, conn)
                            cmd2.Parameters.AddWithValue("@rut", txtCliente.Text.Trim())
                            clienteExiste = Convert.ToInt32(cmd2.ExecuteScalar()) > 0
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error revalidando cliente: " & ex.Message)
                    Exit Sub
                End Try

                If Not clienteExiste Then
                    MessageBox.Show("El cliente no fue registrado. Siniestro cancelado.")
                    Exit Sub
                End If

            Else
                Exit Sub
            End If

        End If

        '
        ' 2. INSERTAR SINIESTRO
        '
        Try
            Using conn As MySqlConnection = ObtenerConexion()

                Dim CompaniaRut As String = cmbCompañia.Text.Split("-"c)(0).Trim()

                Dim query As String =
                "INSERT INTO siniestro 
                (Detalle, Estado_Siniestro, Fecha_Siniestro, RutCompania, Rut, Estado_Seguro)
                VALUES (@det, @est, @fec, @comp, @cli, @seg)"

                Dim cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@det", txtDetalle.Text)
                cmd.Parameters.AddWithValue("@est", cmbEstado.Text)
                cmd.Parameters.AddWithValue("@fec", dtpFecha.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@comp", CompaniaRut)
                cmd.Parameters.AddWithValue("@cli", txtCliente.Text.Trim())
                cmd.Parameters.AddWithValue("@seg", cmbEstadoSeguro.Text)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Siniestro agregado correctamente.")
            LimpiarCampos()
            CargarHistorial()

        Catch ex As Exception
            MessageBox.Show("Error guardando siniestro: " & ex.Message)
        End Try
    End Sub

    ' 
    ' CARGAR DATOS AL INGRESAR ID 
    ' 
    Private Sub txtId_LostFocus(sender As Object, e As EventArgs) Handles txtId.LostFocus
        If Not chbModificar.Checked Then Exit Sub
        If txtId.Text.Trim() = "" Then Exit Sub

        Try
            Using conn As MySqlConnection = ObtenerConexion()

                Dim query As String = "SELECT Estado_Siniestro FROM siniestro WHERE SiniestroID = @id"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", txtId.Text.Trim())

                Dim rd As MySqlDataReader = cmd.ExecuteReader()

                If rd.Read() Then
                    cmbEstado.Text = rd("Estado_Siniestro").ToString()
                Else
                    MessageBox.Show("No existe un siniestro con ese ID.")
                End If

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        End Try
    End Sub

    ' 
    '  UPDATE 
    ' 

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtId.Text.Trim() = "" Then
            MessageBox.Show("Ingrese el ID del siniestro.")
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = ObtenerConexion()

                Dim query As String =
                "UPDATE siniestro SET Estado_Siniestro = @est WHERE SiniestroID = @id"

                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@est", cmbEstado.Text)
                cmd.Parameters.AddWithValue("@id", txtId.Text.Trim())

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Estado actualizado correctamente.")
            CargarHistorial()

        Catch ex As Exception
            MessageBox.Show("Error al modificar: " & ex.Message)
        End Try
    End Sub
End Class
