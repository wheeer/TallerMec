<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SiniestrosForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnVolver = New Button()
        btnHistorial = New Button()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        dgvHistorial = New DataGridView()
        cbEstado = New ComboBox()
        btnVerTodo = New Button()
        btnBuscar = New Button()
        tbRut = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        GroupBox2 = New GroupBox()
        chbModificar = New CheckBox()
        chbIngresar = New CheckBox()
        txtDetalle = New TextBox()
        txtSeguro = New TextBox()
        txtCliente = New TextBox()
        txtCompañia = New TextBox()
        txtEstado = New TextBox()
        txtFecha = New TextBox()
        txtId = New TextBox()
        btnModificar = New Button()
        btnGuardar = New Button()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(dgvHistorial, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnVolver
        ' 
        btnVolver.Location = New Point(944, 701)
        btnVolver.Margin = New Padding(4, 5, 4, 5)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(187, 38)
        btnVolver.TabIndex = 2
        btnVolver.Text = "Volver al Menú"
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' btnHistorial
        ' 
        btnHistorial.Location = New Point(12, 699)
        btnHistorial.Margin = New Padding(4, 5, 4, 5)
        btnHistorial.Name = "btnHistorial"
        btnHistorial.Size = New Size(187, 38)
        btnHistorial.TabIndex = 4
        btnHistorial.Text = "Historial Sinistros"
        btnHistorial.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.images_2025_01_02T174228_126
        PictureBox1.Location = New Point(-5, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1150, 752)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvHistorial)
        GroupBox1.Controls.Add(cbEstado)
        GroupBox1.Controls.Add(btnVerTodo)
        GroupBox1.Controls.Add(btnBuscar)
        GroupBox1.Controls.Add(tbRut)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(114, 43)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(913, 257)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Busqueda de Siniestros"
        ' 
        ' dgvHistorial
        ' 
        dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHistorial.Location = New Point(0, 107)
        dgvHistorial.Name = "dgvHistorial"
        dgvHistorial.RowHeadersWidth = 62
        dgvHistorial.Size = New Size(913, 149)
        dgvHistorial.TabIndex = 6
        ' 
        ' cbEstado
        ' 
        cbEstado.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbEstado.FormattingEnabled = True
        cbEstado.Location = New Point(637, 42)
        cbEstado.Name = "cbEstado"
        cbEstado.Size = New Size(208, 33)
        cbEstado.TabIndex = 5
        cbEstado.Text = "Estado de Siniestro"
        ' 
        ' btnVerTodo
        ' 
        btnVerTodo.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnVerTodo.Location = New Point(482, 42)
        btnVerTodo.Name = "btnVerTodo"
        btnVerTodo.Size = New Size(124, 34)
        btnVerTodo.TabIndex = 4
        btnVerTodo.Text = "Ver Todo🔎"
        btnVerTodo.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBuscar.Location = New Point(357, 42)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(112, 34)
        btnBuscar.TabIndex = 3
        btnBuscar.Text = "Buscar🔎"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' tbRut
        ' 
        tbRut.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbRut.Location = New Point(119, 44)
        tbRut.Name = "tbRut"
        tbRut.Size = New Size(222, 31)
        tbRut.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(118, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(185, 18)
        Label2.TabIndex = 1
        Label2.Text = "(Ingrese un rut de Cliente)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Kristen ITC", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(11, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 30)
        Label1.TabIndex = 0
        Label1.Text = "Cliente:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(492, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(208, 28)
        Label3.TabIndex = 7
        Label3.Text = "Gestión de Siniestros"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(chbModificar)
        GroupBox2.Controls.Add(chbIngresar)
        GroupBox2.Controls.Add(txtDetalle)
        GroupBox2.Controls.Add(txtSeguro)
        GroupBox2.Controls.Add(txtCliente)
        GroupBox2.Controls.Add(txtCompañia)
        GroupBox2.Controls.Add(txtEstado)
        GroupBox2.Controls.Add(txtFecha)
        GroupBox2.Controls.Add(txtId)
        GroupBox2.Controls.Add(btnModificar)
        GroupBox2.Controls.Add(btnGuardar)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(319, 303)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(509, 436)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "Gestión de Siniestros"
        ' 
        ' chbModificar
        ' 
        chbModificar.AutoSize = True
        chbModificar.Location = New Point(256, 31)
        chbModificar.Name = "chbModificar"
        chbModificar.Size = New Size(245, 29)
        chbModificar.TabIndex = 17
        chbModificar.Text = "Modificar Estado Siniestro"
        chbModificar.UseVisualStyleBackColor = True
        ' 
        ' chbIngresar
        ' 
        chbIngresar.AutoSize = True
        chbIngresar.Location = New Point(60, 32)
        chbIngresar.Name = "chbIngresar"
        chbIngresar.Size = New Size(183, 29)
        chbIngresar.TabIndex = 16
        chbIngresar.Text = "Ingresar Siniestros"
        chbIngresar.UseVisualStyleBackColor = True
        ' 
        ' txtDetalle
        ' 
        txtDetalle.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDetalle.Location = New Point(101, 125)
        txtDetalle.Name = "txtDetalle"
        txtDetalle.Size = New Size(286, 39)
        txtDetalle.TabIndex = 15
        ' 
        ' txtSeguro
        ' 
        txtSeguro.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSeguro.Location = New Point(101, 348)
        txtSeguro.Name = "txtSeguro"
        txtSeguro.Size = New Size(286, 31)
        txtSeguro.TabIndex = 14
        ' 
        ' txtCliente
        ' 
        txtCliente.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCliente.Location = New Point(101, 308)
        txtCliente.Name = "txtCliente"
        txtCliente.Size = New Size(286, 31)
        txtCliente.TabIndex = 13
        ' 
        ' txtCompañia
        ' 
        txtCompañia.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCompañia.Location = New Point(101, 267)
        txtCompañia.Name = "txtCompañia"
        txtCompañia.Size = New Size(286, 31)
        txtCompañia.TabIndex = 12
        ' 
        ' txtEstado
        ' 
        txtEstado.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEstado.Location = New Point(101, 178)
        txtEstado.Name = "txtEstado"
        txtEstado.Size = New Size(286, 31)
        txtEstado.TabIndex = 11
        ' 
        ' txtFecha
        ' 
        txtFecha.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFecha.Location = New Point(101, 223)
        txtFecha.Name = "txtFecha"
        txtFecha.Size = New Size(136, 31)
        txtFecha.TabIndex = 10
        ' 
        ' txtId
        ' 
        txtId.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtId.Location = New Point(101, 78)
        txtId.Name = "txtId"
        txtId.Size = New Size(109, 31)
        txtId.TabIndex = 9
        ' 
        ' btnModificar
        ' 
        btnModificar.Location = New Point(260, 395)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(127, 34)
        btnModificar.TabIndex = 8
        btnModificar.Text = "Modificar📃"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(87, 395)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(123, 34)
        btnGuardar.TabIndex = 7
        btnGuardar.Text = "Guardar✔"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(6, 350)
        Label10.Name = "Label10"
        Label10.Size = New Size(73, 25)
        Label10.TabIndex = 6
        Label10.Text = "Seguro:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(9, 309)
        Label9.Name = "Label9"
        Label9.Size = New Size(69, 25)
        Label9.TabIndex = 5
        Label9.Text = "Cliente:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(0, 269)
        Label8.Name = "Label8"
        Label8.Size = New Size(97, 25)
        Label8.TabIndex = 4
        Label8.Text = "Compañia:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(9, 132)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 25)
        Label7.TabIndex = 3
        Label7.Text = "Detalle:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(9, 180)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 25)
        Label6.TabIndex = 2
        Label6.Text = "Estado:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(10, 225)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 25)
        Label5.TabIndex = 1
        Label5.Text = "Fecha:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 80)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 25)
        Label4.TabIndex = 0
        Label4.Text = "ID:"
        ' 
        ' SiniestrosForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 750)
        Controls.Add(GroupBox2)
        Controls.Add(Label3)
        Controls.Add(GroupBox1)
        Controls.Add(btnHistorial)
        Controls.Add(btnVolver)
        Controls.Add(PictureBox1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "SiniestrosForm"
        Text = "SiniestrosForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvHistorial, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents btnHistorial As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbRut As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVerTodo As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents dgvHistorial As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents txtSeguro As TextBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtCompañia As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents chbIngresar As CheckBox
    Friend WithEvents chbModificar As CheckBox
End Class
