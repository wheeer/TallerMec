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
        Label2 = New Label()
        Label1 = New Label()
        btnActualizar = New Button()
        btnEliminar = New Button()
        btnCrear = New Button()
        tbCorreo = New TextBox()
        tbUsuario = New TextBox()
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
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(btnActualizar)
        GroupBox1.Controls.Add(btnEliminar)
        GroupBox1.Controls.Add(btnCrear)
        GroupBox1.Controls.Add(tbCorreo)
        GroupBox1.Controls.Add(tbUsuario)
        GroupBox1.Controls.Add(tbRut)
        GroupBox1.Controls.Add(btnBuscar)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(161, 76)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(512, 257)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Usuarios"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(30, 33)
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
        btnActualizar.Location = New Point(211, 177)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(75, 23)
        btnActualizar.TabIndex = 13
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(379, 177)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 12
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnCrear
        ' 
        btnCrear.Location = New Point(48, 177)
        btnCrear.Name = "btnCrear"
        btnCrear.Size = New Size(75, 23)
        btnCrear.TabIndex = 10
        btnCrear.Text = "Crear"
        btnCrear.UseVisualStyleBackColor = True
        ' 
        ' tbCorreo
        ' 
        tbCorreo.Location = New Point(160, 72)
        tbCorreo.Name = "tbCorreo"
        tbCorreo.Size = New Size(189, 23)
        tbCorreo.TabIndex = 9
        ' 
        ' tbUsuario
        ' 
        tbUsuario.Location = New Point(160, 112)
        tbUsuario.Name = "tbUsuario"
        tbUsuario.Size = New Size(189, 23)
        tbUsuario.TabIndex = 8
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
        Label4.Location = New Point(30, 115)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 15)
        Label4.TabIndex = 5
        Label4.Text = "Tipo de Usuario:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(30, 75)
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
    Friend WithEvents tbUsuario As TextBox
    Friend WithEvents tbRut As TextBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
