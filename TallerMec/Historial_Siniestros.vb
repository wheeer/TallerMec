Imports MySql.Data.MySqlClient

Public Class Historial_Siniestros

    'Constructor
    Public Sub New()
        InitializeComponent()
        ' Configuración de ventana
        Me.Text = "Gestión de Siniestros"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
    End Sub

    Private Sub Historial_Siniestros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEstados()
        CargarHistorial() ' muestra todo al inicio
        dgvHistorial.ReadOnly = True
        dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    'Cargar estados al combobox
    Private Sub CargarEstados()
        Try
            Using conn As MySqlConnection = ObtenerConexion()
                Dim query As String = "SELECT DISTINCT Estado_Siniestro FROM siniestro WHERE Estado_Siniestro IS NOT NULL;"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cbEstado.Items.Clear()
                        cbEstado.Items.Add("Todos") ' opción general

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

    'Cargar historial
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

                ' Filtro por RUT
                If rut <> "" Then
                    query &= " AND s.Rut = @rut"
                End If

                ' Filtro por estado
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


    'Boton buscar
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim rut As String = tbRut.Text.Trim()
        Dim estado As String = ""

        If cbEstado.SelectedItem IsNot Nothing Then
            estado = cbEstado.SelectedItem.ToString()
        End If

        If rut = "" AndAlso (estado = "" OrElse estado = "Todos") Then
            MessageBox.Show("Ingresa un RUT o selecciona un estado para buscar.", "Atención")
            Return
        End If

        CargarHistorial(rut, estado)
    End Sub

    'Boton ver todo
    Private Sub btnVerTodo_Click(sender As Object, e As EventArgs) Handles btnVerTodo.Click
        tbRut.Clear()
        cbEstado.SelectedIndex = 0
        CargarHistorial()
    End Sub

    ' Boton Volver
    Private Sub btnVovler_Click_1(sender As Object, e As EventArgs) Handles btnVovler.Click
        Dim siniestrosForm As New SiniestrosForm()
        siniestrosForm.Show()
        Me.Close()
    End Sub
End Class
