<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientesForm))
        btnVolver = New Button()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        tbComuna = New TextBox()
        tbTelefono = New TextBox()
        tbDireccion = New TextBox()
        tbApellidoM = New TextBox()
        tbApellidoP = New TextBox()
        tbNombre = New TextBox()
        tbRut = New TextBox()
        btnLimpiar = New Button()
        btnEliminar = New Button()
        btnBuscar = New Button()
        btnGuardar = New Button()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        btnActualizar = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnVolver
        ' 
        btnVolver.BackColor = SystemColors.WindowFrame
        btnVolver.ForeColor = SystemColors.ControlLightLight
        btnVolver.Location = New Point(220, 332)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(131, 30)
        btnVolver.TabIndex = 1
        btnVolver.Text = "Volver"
        btnVolver.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(699, 450)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.HotTrack
        GroupBox1.Controls.Add(btnActualizar)
        GroupBox1.Controls.Add(tbComuna)
        GroupBox1.Controls.Add(tbTelefono)
        GroupBox1.Controls.Add(tbDireccion)
        GroupBox1.Controls.Add(tbApellidoM)
        GroupBox1.Controls.Add(tbApellidoP)
        GroupBox1.Controls.Add(tbNombre)
        GroupBox1.Controls.Add(tbRut)
        GroupBox1.Controls.Add(btnLimpiar)
        GroupBox1.Controls.Add(btnEliminar)
        GroupBox1.Controls.Add(btnBuscar)
        GroupBox1.Controls.Add(btnGuardar)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(btnVolver)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(202, 38)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(401, 412)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        ' 
        ' tbComuna
        ' 
        tbComuna.Location = New Point(110, 226)
        tbComuna.Name = "tbComuna"
        tbComuna.Size = New Size(191, 23)
        tbComuna.TabIndex = 24
        ' 
        ' tbTelefono
        ' 
        tbTelefono.Location = New Point(110, 195)
        tbTelefono.Name = "tbTelefono"
        tbTelefono.Size = New Size(191, 23)
        tbTelefono.TabIndex = 23
        ' 
        ' tbDireccion
        ' 
        tbDireccion.Location = New Point(108, 159)
        tbDireccion.Name = "tbDireccion"
        tbDireccion.Size = New Size(193, 23)
        tbDireccion.TabIndex = 22
        ' 
        ' tbApellidoM
        ' 
        tbApellidoM.Location = New Point(109, 122)
        tbApellidoM.Name = "tbApellidoM"
        tbApellidoM.Size = New Size(192, 23)
        tbApellidoM.TabIndex = 21
        ' 
        ' tbApellidoP
        ' 
        tbApellidoP.Location = New Point(109, 87)
        tbApellidoP.Name = "tbApellidoP"
        tbApellidoP.Size = New Size(192, 23)
        tbApellidoP.TabIndex = 20
        ' 
        ' tbNombre
        ' 
        tbNombre.Location = New Point(108, 51)
        tbNombre.Name = "tbNombre"
        tbNombre.Size = New Size(193, 23)
        tbNombre.TabIndex = 19
        ' 
        ' tbRut
        ' 
        tbRut.Location = New Point(108, 14)
        tbRut.Name = "tbRut"
        tbRut.Size = New Size(193, 23)
        tbRut.TabIndex = 18
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = SystemColors.WindowFrame
        btnLimpiar.ForeColor = SystemColors.ControlLightLight
        btnLimpiar.Location = New Point(220, 276)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(131, 34)
        btnLimpiar.TabIndex = 17
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = SystemColors.WindowFrame
        btnEliminar.ForeColor = SystemColors.ControlLightLight
        btnEliminar.Location = New Point(44, 332)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(131, 30)
        btnEliminar.TabIndex = 16
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = SystemColors.WindowFrame
        btnBuscar.ForeColor = SystemColors.ControlLightLight
        btnBuscar.Location = New Point(316, 7)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(79, 35)
        btnBuscar.TabIndex = 15
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = SystemColors.WindowFrame
        btnGuardar.ForeColor = SystemColors.ControlLightLight
        btnGuardar.Location = New Point(44, 276)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(131, 34)
        btnGuardar.TabIndex = 14
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(27, 228)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 17)
        Label8.TabIndex = 6
        Label8.Text = "Comuna:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(0, 195)
        Label7.Name = "Label7"
        Label7.Size = New Size(110, 17)
        Label7.TabIndex = 5
        Label7.Text = "Teléfono/Celular:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(19, 159)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 17)
        Label6.TabIndex = 4
        Label6.Text = "Dirección:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(16, 122)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 17)
        Label5.TabIndex = 3
        Label5.Text = "Apellido M:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(19, 88)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 17)
        Label4.TabIndex = 2
        Label4.Text = "Apellido P:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(22, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 17)
        Label3.TabIndex = 1
        Label3.Text = "Nombre:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(34, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 17)
        Label1.TabIndex = 0
        Label1.Text = "Rut:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.HotTrack
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Info
        Label2.Location = New Point(293, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(181, 25)
        Label2.TabIndex = 0
        Label2.Text = "Registro de Clientes"
        ' 
        ' btnActualizar
        ' 
        btnActualizar.BackColor = SystemColors.WindowFrame
        btnActualizar.ForeColor = SystemColors.ControlLightLight
        btnActualizar.Location = New Point(128, 370)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(131, 30)
        btnActualizar.TabIndex = 25
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = False
        ' 
        ' ClientesForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(699, 450)
        Controls.Add(Label2)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Name = "ClientesForm"
        Text = "ClientesForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents tbComuna As TextBox
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents tbApellidoM As TextBox
    Friend WithEvents tbApellidoP As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbRut As TextBox
    Friend WithEvents btnActualizar As Button
End Class
