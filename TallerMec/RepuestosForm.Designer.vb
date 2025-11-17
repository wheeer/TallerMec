<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepuestosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepuestosForm))
        btnVolver = New Button()
        Label1 = New Label()
        cmbRepuestos = New ComboBox()
        Label2 = New Label()
        btEditar = New Button()
        btIngresar = New Button()
        btEliminar = New Button()
        Label3 = New Label()
        txtNombre = New TextBox()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtStock = New TextBox()
        txtPrecio = New TextBox()
        txtProveedor = New TextBox()
        btLimpiar = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnVolver
        ' 
        btnVolver.BackColor = Color.Yellow
        btnVolver.Location = New Point(943, 698)
        btnVolver.Margin = New Padding(4, 5, 4, 5)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(187, 38)
        btnVolver.TabIndex = 2
        btnVolver.Text = "Volver al Menú"
        btnVolver.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(504, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 25)
        Label1.TabIndex = 3
        Label1.Text = "Repuestos"
        ' 
        ' cmbRepuestos
        ' 
        cmbRepuestos.FormattingEnabled = True
        cmbRepuestos.Location = New Point(178, 187)
        cmbRepuestos.Name = "cmbRepuestos"
        cmbRepuestos.Size = New Size(182, 33)
        cmbRepuestos.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(177, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(191, 25)
        Label2.TabIndex = 5
        Label2.Text = "Seleccione el repuesto:"
        ' 
        ' btEditar
        ' 
        btEditar.BackColor = Color.OrangeRed
        btEditar.ForeColor = Color.White
        btEditar.Location = New Point(503, 600)
        btEditar.Name = "btEditar"
        btEditar.Size = New Size(112, 34)
        btEditar.TabIndex = 7
        btEditar.Text = "Editar"
        btEditar.UseVisualStyleBackColor = False
        ' 
        ' btIngresar
        ' 
        btIngresar.BackColor = Color.LawnGreen
        btIngresar.Location = New Point(355, 600)
        btIngresar.Name = "btIngresar"
        btIngresar.Size = New Size(112, 34)
        btIngresar.TabIndex = 8
        btIngresar.Text = "Ingresar"
        btIngresar.UseVisualStyleBackColor = False
        ' 
        ' btEliminar
        ' 
        btEliminar.BackColor = Color.Red
        btEliminar.ForeColor = SystemColors.ButtonHighlight
        btEliminar.Location = New Point(649, 600)
        btEliminar.Name = "btEliminar"
        btEliminar.Size = New Size(112, 34)
        btEliminar.TabIndex = 9
        btEliminar.Text = "Eliminar"
        btEliminar.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(449, 316)
        Label3.Name = "Label3"
        Label3.Size = New Size(234, 25)
        Label3.TabIndex = 10
        Label3.Text = "Ingrese o edite un repuesto:"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(562, 381)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(150, 31)
        txtNombre.TabIndex = 11
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-1, -8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1161, 761)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(332, 466)
        Label4.Name = "Label4"
        Label4.Size = New Size(212, 25)
        Label4.TabIndex = 14
        Label4.Text = "Ingrese el Precio Unitario:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(303, 423)
        Label5.Name = "Label5"
        Label5.Size = New Size(241, 25)
        Label5.TabIndex = 15
        Label5.Text = "Ingrese la Cantidad de Stock:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(280, 382)
        Label6.Name = "Label6"
        Label6.Size = New Size(264, 25)
        Label6.TabIndex = 16
        Label6.Text = "Ingrese el nombre del repuesto:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(365, 508)
        Label7.Name = "Label7"
        Label7.Size = New Size(179, 25)
        Label7.TabIndex = 17
        Label7.Text = "Ingrese el Proveedor:"
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(561, 421)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(150, 31)
        txtStock.TabIndex = 18
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(560, 463)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(150, 31)
        txtPrecio.TabIndex = 19
        ' 
        ' txtProveedor
        ' 
        txtProveedor.Location = New Point(560, 505)
        txtProveedor.Name = "txtProveedor"
        txtProveedor.Size = New Size(150, 31)
        txtProveedor.TabIndex = 20
        ' 
        ' btLimpiar
        ' 
        btLimpiar.BackColor = Color.Yellow
        btLimpiar.ForeColor = Color.Black
        btLimpiar.Location = New Point(735, 444)
        btLimpiar.Name = "btLimpiar"
        btLimpiar.Size = New Size(131, 34)
        btLimpiar.TabIndex = 21
        btLimpiar.Text = "Limpiar Datos"
        btLimpiar.UseVisualStyleBackColor = False
        ' 
        ' RepuestosForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 750)
        Controls.Add(btLimpiar)
        Controls.Add(txtProveedor)
        Controls.Add(txtPrecio)
        Controls.Add(txtStock)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtNombre)
        Controls.Add(Label3)
        Controls.Add(btEliminar)
        Controls.Add(btIngresar)
        Controls.Add(btEditar)
        Controls.Add(Label2)
        Controls.Add(cmbRepuestos)
        Controls.Add(Label1)
        Controls.Add(btnVolver)
        Controls.Add(PictureBox1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "RepuestosForm"
        Text = "Repuestos"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbRepuestos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btEditar As Button
    Friend WithEvents btIngresar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents btLimpiar As Button
End Class
