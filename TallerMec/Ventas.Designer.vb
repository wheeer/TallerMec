<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Dim GroupBox1 As GroupBox
        btnVolver = New Button()
        DataGridView1 = New DataGridView()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Label1 = New Label()
        Label2 = New Label()
        tbId = New TextBox()
        btnBuscar = New Button()
        btnVerTodo = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        tbNombre = New TextBox()
        tbPrecio = New TextBox()
        tbCantidad = New TextBox()
        tbRut = New TextBox()
        tbTotal = New TextBox()
        btnHistorial = New Button()
        btnVender = New Button()
        dtFechaCompra = New DateTimePicker()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        Label10 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        GroupBox1 = New GroupBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnVolver
        ' 
        btnVolver.Location = New Point(657, 459)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(131, 23)
        btnVolver.TabIndex = 3
        btnVolver.Text = "Volver al Menú"
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(172, 91)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(466, 133)
        DataGridView1.TabIndex = 5
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(203, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(384, 25)
        Label1.TabIndex = 6
        Label1.Text = "Busqueda y eleccion de producto solicitado"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(62, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 15)
        Label2.TabIndex = 7
        Label2.Text = "id / Descripción :"
        ' 
        ' tbId
        ' 
        tbId.Location = New Point(172, 57)
        tbId.Name = "tbId"
        tbId.Size = New Size(158, 23)
        tbId.TabIndex = 8
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(352, 57)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(131, 23)
        btnBuscar.TabIndex = 9
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' btnVerTodo
        ' 
        btnVerTodo.Location = New Point(507, 57)
        btnVerTodo.Name = "btnVerTodo"
        btnVerTodo.Size = New Size(131, 23)
        btnVerTodo.TabIndex = 10
        btnVerTodo.Text = "Ver Todo"
        btnVerTodo.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(141, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 15)
        Label3.TabIndex = 11
        Label3.Text = "Ingrese datos Solicitados"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(13, 53)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 15)
        Label4.TabIndex = 12
        Label4.Text = "Nombre :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(13, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 15)
        Label5.TabIndex = 13
        Label5.Text = "Precio :"
        ' 
        ' tbNombre
        ' 
        tbNombre.Location = New Point(112, 50)
        tbNombre.Name = "tbNombre"
        tbNombre.Size = New Size(158, 23)
        tbNombre.TabIndex = 18
        ' 
        ' tbPrecio
        ' 
        tbPrecio.Location = New Point(112, 85)
        tbPrecio.Name = "tbPrecio"
        tbPrecio.Size = New Size(158, 23)
        tbPrecio.TabIndex = 19
        ' 
        ' tbCantidad
        ' 
        tbCantidad.Location = New Point(112, 123)
        tbCantidad.Name = "tbCantidad"
        tbCantidad.Size = New Size(158, 23)
        tbCantidad.TabIndex = 20
        ' 
        ' tbRut
        ' 
        tbRut.Location = New Point(112, 161)
        tbRut.Name = "tbRut"
        tbRut.Size = New Size(158, 23)
        tbRut.TabIndex = 21
        ' 
        ' tbTotal
        ' 
        tbTotal.Location = New Point(112, 225)
        tbTotal.Name = "tbTotal"
        tbTotal.Size = New Size(158, 23)
        tbTotal.TabIndex = 22
        ' 
        ' btnHistorial
        ' 
        btnHistorial.Location = New Point(657, 407)
        btnHistorial.Name = "btnHistorial"
        btnHistorial.Size = New Size(131, 23)
        btnHistorial.TabIndex = 23
        btnHistorial.Text = "Historial"
        btnHistorial.UseVisualStyleBackColor = True
        ' 
        ' btnVender
        ' 
        btnVender.Location = New Point(280, 225)
        btnVender.Name = "btnVender"
        btnVender.Size = New Size(118, 23)
        btnVender.TabIndex = 24
        btnVender.Text = "Vender"
        btnVender.UseVisualStyleBackColor = True
        ' 
        ' dtFechaCompra
        ' 
        dtFechaCompra.Location = New Point(112, 192)
        dtFechaCompra.Name = "dtFechaCompra"
        dtFechaCompra.Size = New Size(212, 23)
        dtFechaCompra.TabIndex = 25
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 510)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Green
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(tbNombre)
        GroupBox1.Controls.Add(dtFechaCompra)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(btnVender)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(tbTotal)
        GroupBox1.Controls.Add(tbRut)
        GroupBox1.Controls.Add(tbCantidad)
        GroupBox1.Controls.Add(tbPrecio)
        GroupBox1.Location = New Point(203, 230)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(408, 263)
        GroupBox1.TabIndex = 27
        GroupBox1.TabStop = False
        GroupBox1.Text = "Ventas"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(15, 126)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 15)
        Label6.TabIndex = 26
        Label6.Text = "Cantidad"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(15, 164)
        Label10.Name = "Label10"
        Label10.Size = New Size(71, 15)
        Label10.TabIndex = 27
        Label10.Text = "Rut Cliente :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(15, 228)
        Label8.Name = "Label8"
        Label8.Size = New Size(87, 15)
        Label8.TabIndex = 29
        Label8.Text = "Total a Pagar :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(15, 198)
        Label7.Name = "Label7"
        Label7.Size = New Size(44, 15)
        Label7.TabIndex = 30
        Label7.Text = "Fecha :"
        ' 
        ' Ventas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 510)
        Controls.Add(GroupBox1)
        Controls.Add(btnHistorial)
        Controls.Add(btnVerTodo)
        Controls.Add(btnBuscar)
        Controls.Add(tbId)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(btnVolver)
        Controls.Add(PictureBox1)
        Name = "Ventas"
        Text = "Ventas"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbId As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnVerTodo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents tbCantidad As TextBox
    Friend WithEvents tbRut As TextBox
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents btnHistorial As Button
    Friend WithEvents btnVender As Button
    Friend WithEvents dtFechaCompra As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
