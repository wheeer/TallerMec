Imports MySql.Data.MySqlClient

Public Class SiniestrosForm
    Public Property CallerForm As Form
    Public Sub New()
        InitializeComponent()
        Me.Text = "Gestión de Siniestros"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
    End Sub

    Private Sub SiniestrosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEstados()
        CargarHistorial()
        dgvHistorial.ReadOnly = True
        dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        CargarEstadosFormulario() ' Cargar estados en el combo inferior
    End Sub

    '====================== COMBO SUPERIOR ======================

    Private Sub CargarEstados()
        Try
            Using conn As MySqlConnection = ObtenerConexion()
                Dim query As String = "SELECT DISTINCT Estado_Siniestro FROM siniestro WHERE Estado_Siniestro IS NOT NULL;"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cbEstado.Items.Clear()
                        cbEstado.Items.Add("Todos")

                        While reader.Read()
                            cbEstado.Items.Add(reader("Estado_Siniestro").ToString())
                        End While
                    End Using
                End Using
            End Using

            cbEstado.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Error al cargar estados: " & ex.Message)
        End Try
    End Sub

    '====================== COMBO INFERIOR ======================

    Private Sub CargarEstadosFormulario()
        Try
            Using conn As MySqlConnection = ObtenerConexion()
                Dim query As String = "SELECT DISTINCT Estado_Siniestro FROM siniestro WHERE Estado_Siniestro IS NOT NULL;"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbEstado.Items.Clear()

                        While reader.Read()
                            cmbEstado.Items.Add(reader("Estado_Siniestro").ToString())
                        End While
                    End Using
                End Using
            End Using

            If cmbEstado.Items.Count > 0 Then cmbEstado.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Error al cargar estados en el formulario: " & ex.Message)
        End Try
    End Sub

    '====================== CARGAR HISTORIAL ======================

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
                    WHERE 1 = 1"

                If rut <> "" Then
                    query &= " AND s.Rut = @rut"
                End If

                If estado <> "" AndAlso estado <> "Todos" Then
                    query &= " AND s.Estado_Siniestro = @estado"
                End If

                Using da As New MySqlDataAdapter(query, conn)
                    If rut <> "" Then
                        da.SelectCommand.Parameters.AddWithValue("@rut", rut)
                    End If

                    If estado <> "" AndAlso estado <> "Todos" Then
                        da.SelectCommand.Parameters.AddWithValue("@estado", estado)
                    End If

                    Dim dt As New DataTable()
                    da.Fill(dt)
                    dgvHistorial.DataSource = dt
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar historial: " & ex.Message)
        End Try
    End Sub

    '====================== BOTONES SUPERIORES ======================

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim rut As String = tbRut.Text.Trim()
        Dim estado As String = ""

        If cbEstado.SelectedItem IsNot Nothing Then
            estado = cbEstado.SelectedItem.ToString()
        End If

        If rut = "" AndAlso (estado = "" OrElse estado = "Todos") Then
            MessageBox.Show("Ingresa un RUT o selecciona un estado para buscar.")
            Return
        End If

        CargarHistorial(rut, estado)
    End Sub

    Private Sub btnVerTodo_Click(sender As Object, e As EventArgs) Handles btnVerTodo.Click
        tbRut.Clear()
        cbEstado.SelectedIndex = 0
        CargarHistorial()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        If CallerForm IsNot Nothing Then
            ' Volver a la ventana que llamó
            CallerForm.Show()
        Else
            ' Comportamiento normal: volver al Admin
            Dim adminMenu As New AdminForm()
            adminMenu.Show()
        End If

        Me.Close()
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        Dim historialSiniestros As New Historial_Siniestros()
        historialSiniestros.Show()
        Me.Close()
    End Sub

    '====================== SECCIÓN INGRESAR / MODIFICAR ======================

    Private Sub chbIngresar_CheckedChanged(sender As Object, e As EventArgs) Handles chbIngresar.CheckedChanged
        If chbIngresar.Checked Then
            chbModificar.Checked = False
            LimpiarCampos()
            HabilitarCampos(True)
            txtId.Enabled = False
            btnGuardar.Enabled = True
            btnModificar.Enabled = False
        End If
    End Sub

    Private Sub chbModificar_CheckedChanged(sender As Object, e As EventArgs) Handles chbModificar.CheckedChanged
        If chbModificar.Checked Then
            chbIngresar.Checked = False
            LimpiarCampos()
            HabilitarCampos(False)
            txtId.Enabled = True
            cmbEstado.Enabled = True
            btnGuardar.Enabled = False
            btnModificar.Enabled = True
        End If
    End Sub

    Private Sub HabilitarCampos(valor As Boolean)
        txtDetalle.Enabled = valor
        cmbEstado.Enabled = valor
        txtFecha.Enabled = valor
        txtCompañia.Enabled = valor
        txtCliente.Enabled = valor
        txtSeguro.Enabled = valor
    End Sub

    Private Sub LimpiarCampos()
        txtId.Clear()
        txtDetalle.Clear()
        txtFecha.Clear()
        txtCompañia.Clear()
        txtCliente.Clear()
        txtSeguro.Clear()
        If cmbEstado.Items.Count > 0 Then cmbEstado.SelectedIndex = 0
    End Sub

    '====================== GUARDAR (INSERT) ======================

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Using conn As MySqlConnection = ObtenerConexion()
                Dim query As String =
                    "INSERT INTO siniestro (Detalle, Estado_Siniestro, Fecha_Siniestro, RutCompania, Rut, Estado_Seguro)
                 VALUES (@det, @est, @fec, @comp, @cli, @seg)"

                Dim cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@det", txtDetalle.Text)
                cmd.Parameters.AddWithValue("@est", cmbEstado.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@fec", txtFecha.Text)
                cmd.Parameters.AddWithValue("@comp", txtCompañia.Text)
                cmd.Parameters.AddWithValue("@cli", txtCliente.Text)
                cmd.Parameters.AddWithValue("@seg", txtSeguro.Text)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Siniestro ingresado correctamente.")
            LimpiarCampos()
            CargarHistorial()

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        End Try
    End Sub

    '====================== CARGA DE DATOS AL INGRESAR ID ======================

    Private Sub txtId_LostFocus(sender As Object, e As EventArgs) Handles txtId.LostFocus
        If Not chbModificar.Checked Then Exit Sub
        If txtId.Text.Trim() = "" Then Exit Sub

        Try
            Using conn As MySqlConnection = ObtenerConexion()
                Dim query As String = "SELECT * FROM siniestro WHERE SiniestroID = @id"
                Dim cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@id", txtId.Text.Trim())

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    txtDetalle.Text = reader("Detalle").ToString()
                    txtFecha.Text = reader("Fecha_Siniestro").ToString()
                    txtCompañia.Text = reader("RutCompania").ToString()
                    txtCliente.Text = reader("Rut").ToString()
                    txtSeguro.Text = reader("Estado_Seguro").ToString()

                    Dim estadoActual As String = reader("Estado_Siniestro").ToString()

                    If cmbEstado.Items.Contains(estadoActual) Then
                        cmbEstado.SelectedItem = estadoActual
                    End If
                Else
                    MessageBox.Show("No existe un siniestro con ese ID.")
                End If

                reader.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        End Try
    End Sub

    '====================== MODIFICAR (UPDATE) ======================

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtId.Text.Trim() = "" Then
            MessageBox.Show("Ingrese el ID para modificar.")
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = ObtenerConexion()
                Dim query As String =
                    "UPDATE siniestro SET Estado_Siniestro = @est WHERE SiniestroID = @id"

                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@est", cmbEstado.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@id", txtId.Text)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Estado actualizado correctamente.")
            CargarHistorial()

        Catch ex As Exception
            MessageBox.Show("Error al modificar: " & ex.Message)
        End Try
    End Sub

End Class
