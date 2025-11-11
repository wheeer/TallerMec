<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuariosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsuariosForm))
        btnVolver = New Button()
        GroupBox1 = New GroupBox()
        tbContrasena = New TextBox()
        Label5 = New Label()
        cbRol = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        btnActualizar = New Button()
        btnEliminar = New Button()
        btnCrear = New Button()
        tbCorreo = New TextBox()
        tbRut = New TextBox()
        btnBuscar = New Button()
        Label4 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnVolver
        ' 
        btnVolver.Location = New Point(687, 415)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(101, 23)
        btnVolver.TabIndex = 0
        btnVolver.Text = "Volver al Menú"
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.Highlight
        GroupBox1.Controls.Add(tbContrasena)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(cbRol)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(btnActualizar)
        GroupBox1.Controls.Add(btnEliminar)
        GroupBox1.Controls.Add(btnCrear)
        GroupBox1.Controls.Add(tbCorreo)
        GroupBox1.Controls.Add(tbRut)
        GroupBox1.Controls.Add(btnBuscar)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(161, 49)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(512, 284)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Usuarios"
        ' 
        ' tbContrasena
        ' 
        tbContrasena.Location = New Point(160, 81)
        tbContrasena.Name = "tbContrasena"
        tbContrasena.Size = New Size(189, 23)
        tbContrasena.TabIndex = 17
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(50, 82)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 15)
        Label5.TabIndex = 16
        Label5.Text = "Contraseña:"
        ' 
        ' cbRol
        ' 
        cbRol.FormattingEnabled = True
        cbRol.Location = New Point(161, 179)
        cbRol.Name = "cbRol"
        cbRol.Size = New Size(188, 23)
        cbRol.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(68, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 15)
        Label2.TabIndex = 14
        Label2.Text = "Rut:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(175, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 27)
        Label1.TabIndex = 2
        Label1.Text = "Gestion de Usuarios"
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(214, 240)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(75, 23)
        btnActualizar.TabIndex = 13
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(379, 240)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 12
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnCrear
        ' 
        btnCrear.Location = New Point(41, 240)
        btnCrear.Name = "btnCrear"
        btnCrear.Size = New Size(75, 23)
        btnCrear.TabIndex = 10
        btnCrear.Text = "Crear"
        btnCrear.UseVisualStyleBackColor = True
        ' 
        ' tbCorreo
        ' 
        tbCorreo.Location = New Point(160, 129)
        tbCorreo.Name = "tbCorreo"
        tbCorreo.Size = New Size(189, 23)
        tbCorreo.TabIndex = 9
        ' 
        ' tbRut
        ' 
        tbRut.Location = New Point(160, 33)
        tbRut.Name = "tbRut"
        tbRut.Size = New Size(189, 23)
        tbRut.TabIndex = 7
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(379, 32)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(75, 23)
        btnBuscar.TabIndex = 6
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(50, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(29, 15)
        Label4.TabIndex = 5
        Label4.Text = "Rol:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(50, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 15)
        Label3.TabIndex = 4
        Label3.Text = "Correo:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 450)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' UsuariosForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Controls.Add(btnVolver)
        Controls.Add(PictureBox1)
        Name = "UsuariosForm"
        Text = "UsuariosForm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCrear As Button
    Friend WithEvents tbCorreo As TextBox
    Friend WithEvents tbRut As TextBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tbContrasena As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbRol As ComboBox
End Class
