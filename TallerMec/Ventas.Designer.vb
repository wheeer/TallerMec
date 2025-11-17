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
        Dim GroupBox1 As GroupBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Label7 = New Label()
        Label8 = New Label()
        Label10 = New Label()
        Label6 = New Label()
        tbNombre = New TextBox()
        dtFechaCompra = New DateTimePicker()
        Label3 = New Label()
        btnVender = New Button()
        Label4 = New Label()
        Label5 = New Label()
        tbTotal = New TextBox()
        tbRut = New TextBox()
        tbCantidad = New TextBox()
        tbPrecio = New TextBox()
        btnVolver = New Button()
        DataGridView1 = New DataGridView()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Label1 = New Label()
        Label2 = New Label()
        tbId = New TextBox()
        btnBuscar = New Button()
        btnVerTodo = New Button()
        btnHistorial = New Button()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        GroupBox1.Location = New Point(290, 383)
        GroupBox1.Margin = New Padding(4, 5, 4, 5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 5, 4, 5)
        GroupBox1.Size = New Size(583, 438)
        GroupBox1.TabIndex = 27
        GroupBox1.TabStop = False
        GroupBox1.Text = "Ventas"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(21, 330)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(67, 25)
        Label7.TabIndex = 30
        Label7.Text = "Fecha :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(21, 380)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(130, 25)
        Label8.TabIndex = 29
        Label8.Text = "Total a Pagar :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(21, 273)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(108, 25)
        Label10.TabIndex = 27
        Label10.Text = "Rut Cliente :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(21, 210)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 25)
        Label6.TabIndex = 26
        Label6.Text = "Cantidad"
        ' 
        ' tbNombre
        ' 
        tbNombre.Location = New Point(160, 83)
        tbNombre.Margin = New Padding(4, 5, 4, 5)
        tbNombre.Name = "tbNombre"
        tbNombre.Size = New Size(224, 31)
        tbNombre.TabIndex = 18
        ' 
        ' dtFechaCompra
        ' 
        dtFechaCompra.Location = New Point(160, 320)
        dtFechaCompra.Margin = New Padding(4, 5, 4, 5)
        dtFechaCompra.Name = "dtFechaCompra"
        dtFechaCompra.Size = New Size(301, 31)
        dtFechaCompra.TabIndex = 25
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(201, 32)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(210, 25)
        Label3.TabIndex = 11
        Label3.Text = "Ingrese datos Solicitados"
        ' 
        ' btnVender
        ' 
        btnVender.Location = New Point(400, 375)
        btnVender.Margin = New Padding(4, 5, 4, 5)
        btnVender.Name = "btnVender"
        btnVender.Size = New Size(169, 38)
        btnVender.TabIndex = 24
        btnVender.Text = "Vender"
        btnVender.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(19, 88)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 25)
        Label4.TabIndex = 12
        Label4.Text = "Nombre :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(19, 147)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 25)
        Label5.TabIndex = 13
        Label5.Text = "Precio :"
        ' 
        ' tbTotal
        ' 
        tbTotal.Location = New Point(160, 375)
        tbTotal.Margin = New Padding(4, 5, 4, 5)
        tbTotal.Name = "tbTotal"
        tbTotal.Size = New Size(224, 31)
        tbTotal.TabIndex = 22
        ' 
        ' tbRut
        ' 
        tbRut.Location = New Point(160, 268)
        tbRut.Margin = New Padding(4, 5, 4, 5)
        tbRut.Name = "tbRut"
        tbRut.Size = New Size(224, 31)
        tbRut.TabIndex = 21
        ' 
        ' tbCantidad
        ' 
        tbCantidad.Location = New Point(160, 205)
        tbCantidad.Margin = New Padding(4, 5, 4, 5)
        tbCantidad.Name = "tbCantidad"
        tbCantidad.Size = New Size(224, 31)
        tbCantidad.TabIndex = 20
        ' 
        ' tbPrecio
        ' 
        tbPrecio.Location = New Point(160, 142)
        tbPrecio.Margin = New Padding(4, 5, 4, 5)
        tbPrecio.Name = "tbPrecio"
        tbPrecio.Size = New Size(224, 31)
        tbPrecio.TabIndex = 19
        ' 
        ' btnVolver
        ' 
        btnVolver.Location = New Point(939, 765)
        btnVolver.Margin = New Padding(4, 5, 4, 5)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(187, 38)
        btnVolver.TabIndex = 3
        btnVolver.Text = "Volver al Menú"
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(246, 152)
        DataGridView1.Margin = New Padding(4, 5, 4, 5)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(666, 222)
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
        Label1.Location = New Point(290, 32)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(573, 40)
        Label1.TabIndex = 6
        Label1.Text = "Busqueda y eleccion de producto solicitado"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(89, 108)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 25)
        Label2.TabIndex = 7
        Label2.Text = "id / Descripción :"
        ' 
        ' tbId
        ' 
        tbId.Location = New Point(246, 95)
        tbId.Margin = New Padding(4, 5, 4, 5)
        tbId.Name = "tbId"
        tbId.Size = New Size(224, 31)
        tbId.TabIndex = 8
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(503, 95)
        btnBuscar.Margin = New Padding(4, 5, 4, 5)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(187, 38)
        btnBuscar.TabIndex = 9
        btnBuscar.Text = "Buscar🔎"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' btnVerTodo
        ' 
        btnVerTodo.Location = New Point(724, 95)
        btnVerTodo.Margin = New Padding(4, 5, 4, 5)
        btnVerTodo.Name = "btnVerTodo"
        btnVerTodo.Size = New Size(187, 38)
        btnVerTodo.TabIndex = 10
        btnVerTodo.Text = "Ver Todo🔎"
        btnVerTodo.UseVisualStyleBackColor = True
        ' 
        ' btnHistorial
        ' 
        btnHistorial.Location = New Point(939, 678)
        btnHistorial.Margin = New Padding(4, 5, 4, 5)
        btnHistorial.Name = "btnHistorial"
        btnHistorial.Size = New Size(187, 38)
        btnHistorial.TabIndex = 23
        btnHistorial.Text = "Historial Ventas"
        btnHistorial.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1143, 850)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' Ventas
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 850)
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
        Margin = New Padding(4, 5, 4, 5)
        Name = "Ventas"
        Text = "Ventas"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
