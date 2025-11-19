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

    ' ===========================================================
    ' ========== CARGA DE COMBOS ================================
    ' ===========================================================

    ' Filtro superior
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
            MessageBox.Show("Error al cargar estados del filtro: " & ex.Message)
        End Try
    End Sub

    ' Estado del siniestro (COMBO DE ABAJO)
    Private Sub CargarEstadosSiniestro()
        cmbEstado.Items.Clear()
        cmbEstado.Items.AddRange({"Activo", "Pendiente", "Finalizado"})
        cmbEstado.SelectedIndex = 0
    End Sub

    ' Cargar compañías desde TABLA compania
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
            MessageBox.Show("Error al cargar compañías: " & ex.Message)
        End Try
    End Sub

    ' Estado seguro
    Private Sub CargarEstadosSeguro()
        cmbEstadoSeguro.Items.Clear()
        cmbEstadoSeguro.Items.AddRange({"Seguro Vigente", "Seguro Vencido", "En Evaluación"})
        cmbEstadoSeguro.SelectedIndex = 0
    End Sub

    ' ===========================================================
    ' ========== CARGAR HISTORIAL ===============================
    ' ===========================================================

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
            MessageBox.Show("Error historial: " & ex.Message)
        End Try
    End Sub

    ' ===========================================================
    ' ================= FORMULARIO ARRIBA =======================
    ' ===========================================================

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        CargarHistorial(tbRut.Text.Trim(), cbEstado.Text)
    End Sub

    Private Sub btnVerTodo_Click(sender As Object, e As EventArgs) Handles btnVerTodo.Click
        tbRut.Clear()
        cbEstado.SelectedIndex = 0
        CargarHistorial()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim m As New AdminForm()
        m.Show()
        Me.Close()
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        Dim h As New Historial_Siniestros()
        h.Show()
        Me.Close()
    End Sub

    ' ===========================================================
    ' ================== MODO INSERTAR ==========================
    ' ===========================================================

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

    ' ===========================================================
    ' ================== MODO MODIFICAR =========================
    ' ===========================================================

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

    ' ===========================================================
    ' ======================= INSERTAR ==========================
    ' ===========================================================

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
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
                cmd.Parameters.AddWithValue("@cli", txtCliente.Text)
                cmd.Parameters.AddWithValue("@seg", cmbEstadoSeguro.Text)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Siniestro agregado correctamente.")
            LimpiarCampos()
            CargarHistorial()

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        End Try
    End Sub

    ' ===========================================================
    ' ============= CARGAR DATOS AL INGRESAR ID =================
    ' ===========================================================

    Private Sub txtId_LostFocus(sender As Object, e As EventArgs) Handles txtId.LostFocus
        If Not chbModificar.Checked Then Exit Sub
        If txtId.Text.Trim() = "" Then Exit Sub

        Try
            Using conn As MySqlConnection = ObtenerConexion()

                Dim query As String = "SELECT * FROM siniestro WHERE SiniestroID = @id"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", txtId.Text)

                Dim rd As MySqlDataReader = cmd.ExecuteReader()

                If rd.Read() Then
                    cmbEstado.Text = rd("Estado_Siniestro").ToString()
                Else
                    MessageBox.Show("No existe un siniestro con ese ID.")
                End If

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar ID: " & ex.Message)
        End Try
    End Sub

    ' ===========================================================
    ' ======================== UPDATE ===========================
    ' ===========================================================

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtId.Text.Trim() = "" Then
            MessageBox.Show("Ingrese un ID.")
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = ObtenerConexion()

                Dim query As String =
                "UPDATE siniestro SET Estado_Siniestro = @est WHERE SiniestroID = @id"

                Dim cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@est", cmbEstado.Text)
                cmd.Parameters.AddWithValue("@id", txtId.Text)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Estado de siniestro actualizado correctamente.")
            CargarHistorial()

        Catch ex As Exception
            MessageBox.Show("Error al modificar: " & ex.Message)
        End Try
    End Sub

End Class
