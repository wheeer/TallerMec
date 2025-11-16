<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        btnCerrar = New Button()
        Label1 = New Label()
        lbCorreo = New Label()
        Label2 = New Label()
        lbRol = New Label()
        grbBotones = New GroupBox()
        btnVentas = New Button()
        btnSiniestros = New Button()
        btnRepuestos = New Button()
        btnClientes = New Button()
        btnUsuarios = New Button()
        GroupBox2 = New GroupBox()
        PictureBox1 = New PictureBox()
        grbBotones.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Location = New Point(575, 385)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(131, 23)
        btnCerrar.TabIndex = 0
        btnCerrar.Text = "Cerrar Sesión"
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 15)
        Label1.TabIndex = 1
        Label1.Text = "Bienvenido :"
        ' 
        ' lbCorreo
        ' 
        lbCorreo.AutoSize = True
        lbCorreo.Location = New Point(113, 26)
        lbCorreo.Name = "lbCorreo"
        lbCorreo.Size = New Size(41, 15)
        lbCorreo.TabIndex = 2
        lbCorreo.Text = "Label2"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(27, 15)
        Label2.TabIndex = 3
        Label2.Text = " Rol"
        ' 
        ' lbRol
        ' 
        lbRol.AutoSize = True
        lbRol.Location = New Point(113, 61)
        lbRol.Name = "lbRol"
        lbRol.Size = New Size(41, 15)
        lbRol.TabIndex = 4
        lbRol.Text = "Label2"
        ' 
        ' grbBotones
        ' 
        grbBotones.Controls.Add(btnVentas)
        grbBotones.Controls.Add(btnSiniestros)
        grbBotones.Controls.Add(btnRepuestos)
        grbBotones.Controls.Add(btnClientes)
        grbBotones.Controls.Add(btnUsuarios)
        grbBotones.Location = New Point(7, 97)
        grbBotones.Margin = New Padding(2)
        grbBotones.Name = "grbBotones"
        grbBotones.Padding = New Padding(2)
        grbBotones.Size = New Size(127, 310)
        grbBotones.TabIndex = 5
        grbBotones.TabStop = False
        grbBotones.Text = "Menú"
        ' 
        ' btnVentas
        ' 
        btnVentas.Location = New Point(17, 238)
        btnVentas.Margin = New Padding(2)
        btnVentas.Name = "btnVentas"
        btnVentas.Size = New Size(78, 20)
        btnVentas.TabIndex = 12
        btnVentas.Text = "Ventas"
        btnVentas.UseVisualStyleBackColor = True
        ' 
        ' btnSiniestros
        ' 
        btnSiniestros.Location = New Point(17, 197)
        btnSiniestros.Margin = New Padding(2)
        btnSiniestros.Name = "btnSiniestros"
        btnSiniestros.Size = New Size(78, 20)
        btnSiniestros.TabIndex = 10
        btnSiniestros.Text = "Siniestros"
        btnSiniestros.UseVisualStyleBackColor = True
        ' 
        ' btnRepuestos
        ' 
        btnRepuestos.Location = New Point(17, 155)
        btnRepuestos.Margin = New Padding(2)
        btnRepuestos.Name = "btnRepuestos"
        btnRepuestos.Size = New Size(78, 20)
        btnRepuestos.TabIndex = 9
        btnRepuestos.Text = "Repuestos"
        btnRepuestos.UseVisualStyleBackColor = True
        ' 
        ' btnClientes
        ' 
        btnClientes.Location = New Point(17, 109)
        btnClientes.Margin = New Padding(2)
        btnClientes.Name = "btnClientes"
        btnClientes.Size = New Size(78, 20)
        btnClientes.TabIndex = 8
        btnClientes.Text = "Clientes"
        btnClientes.UseVisualStyleBackColor = True
        ' 
        ' btnUsuarios
        ' 
        btnUsuarios.Location = New Point(17, 67)
        btnUsuarios.Margin = New Padding(2)
        btnUsuarios.Name = "btnUsuarios"
        btnUsuarios.Size = New Size(78, 20)
        btnUsuarios.TabIndex = 7
        btnUsuarios.Text = "Usuarios"
        btnUsuarios.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(PictureBox1)
        GroupBox2.Location = New Point(176, 104)
        GroupBox2.Margin = New Padding(2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(2)
        GroupBox2.Size = New Size(528, 271)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 18)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(495, 244)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(grbBotones)
        Controls.Add(lbRol)
        Controls.Add(Label2)
        Controls.Add(lbCorreo)
        Controls.Add(Label1)
        Controls.Add(btnCerrar)
        Name = "AdminForm"
        grbBotones.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbCorreo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbRol As Label
    Friend WithEvents grbBotones As GroupBox
    Friend WithEvents btnSiniestros As Button
    Friend WithEvents btnRepuestos As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnVentas As Button
End Class
