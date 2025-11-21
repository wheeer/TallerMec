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
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        btnRut = New Button()
        btnNombre = New Button()
        btnApellidoP = New Button()
        btnApellidoM = New Button()
        btnDirección = New Button()
        btnTelefonoCelular = New Button()
        btnComuna = New Button()
        btnGuardar = New Button()
        btnBuscar = New Button()
        btnEliminar = New Button()
        btnLimpiar = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnVolver
        ' 
        btnVolver.BackColor = SystemColors.WindowFrame
        btnVolver.ForeColor = SystemColors.ControlLightLight
        btnVolver.Location = New Point(220, 345)
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
        GroupBox1.Controls.Add(btnLimpiar)
        GroupBox1.Controls.Add(btnEliminar)
        GroupBox1.Controls.Add(btnBuscar)
        GroupBox1.Controls.Add(btnGuardar)
        GroupBox1.Controls.Add(btnComuna)
        GroupBox1.Controls.Add(btnTelefonoCelular)
        GroupBox1.Controls.Add(btnDirección)
        GroupBox1.Controls.Add(btnApellidoM)
        GroupBox1.Controls.Add(btnApellidoP)
        GroupBox1.Controls.Add(btnNombre)
        GroupBox1.Controls.Add(btnRut)
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
        ' btnRut
        ' 
        btnRut.Location = New Point(106, 13)
        btnRut.Name = "btnRut"
        btnRut.Size = New Size(191, 23)
        btnRut.TabIndex = 7
        btnRut.UseVisualStyleBackColor = True
        ' 
        ' btnNombre
        ' 
        btnNombre.Location = New Point(106, 51)
        btnNombre.Name = "btnNombre"
        btnNombre.Size = New Size(191, 23)
        btnNombre.TabIndex = 8
        btnNombre.UseVisualStyleBackColor = True
        ' 
        ' btnApellidoP
        ' 
        btnApellidoP.Location = New Point(106, 86)
        btnApellidoP.Name = "btnApellidoP"
        btnApellidoP.Size = New Size(191, 23)
        btnApellidoP.TabIndex = 9
        btnApellidoP.UseVisualStyleBackColor = True
        ' 
        ' btnApellidoM
        ' 
        btnApellidoM.Location = New Point(106, 120)
        btnApellidoM.Name = "btnApellidoM"
        btnApellidoM.Size = New Size(191, 23)
        btnApellidoM.TabIndex = 10
        btnApellidoM.UseVisualStyleBackColor = True
        ' 
        ' btnDirección
        ' 
        btnDirección.Location = New Point(106, 157)
        btnDirección.Name = "btnDirección"
        btnDirección.Size = New Size(191, 23)
        btnDirección.TabIndex = 11
        btnDirección.UseVisualStyleBackColor = True
        ' 
        ' btnTelefonoCelular
        ' 
        btnTelefonoCelular.Location = New Point(106, 193)
        btnTelefonoCelular.Name = "btnTelefonoCelular"
        btnTelefonoCelular.Size = New Size(191, 23)
        btnTelefonoCelular.TabIndex = 12
        btnTelefonoCelular.UseVisualStyleBackColor = True
        ' 
        ' btnComuna
        ' 
        btnComuna.Location = New Point(106, 226)
        btnComuna.Name = "btnComuna"
        btnComuna.Size = New Size(191, 23)
        btnComuna.TabIndex = 13
        btnComuna.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = SystemColors.WindowFrame
        btnGuardar.ForeColor = SystemColors.ControlLightLight
        btnGuardar.Location = New Point(44, 287)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(131, 34)
        btnGuardar.TabIndex = 14
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
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
        ' btnEliminar
        ' 
        btnEliminar.BackColor = SystemColors.WindowFrame
        btnEliminar.ForeColor = SystemColors.ControlLightLight
        btnEliminar.Location = New Point(44, 345)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(131, 30)
        btnEliminar.TabIndex = 16
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = SystemColors.WindowFrame
        btnLimpiar.ForeColor = SystemColors.ControlLightLight
        btnLimpiar.Location = New Point(220, 287)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(131, 34)
        btnLimpiar.TabIndex = 17
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' ClientesForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
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
    Friend WithEvents btnComuna As Button
    Friend WithEvents btnTelefonoCelular As Button
    Friend WithEvents btnDirección As Button
    Friend WithEvents btnApellidoM As Button
    Friend WithEvents btnApellidoP As Button
    Friend WithEvents btnNombre As Button
    Friend WithEvents btnRut As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnGuardar As Button
End Class
