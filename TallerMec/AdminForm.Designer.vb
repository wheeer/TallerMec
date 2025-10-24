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
        Button1 = New Button()
        Label1 = New Label()
        lbCorreo = New Label()
        Label2 = New Label()
        lbRol = New Label()
        GroupBox1 = New GroupBox()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        GroupBox2 = New GroupBox()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(822, 641)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(187, 38)
        Button1.TabIndex = 0
        Button1.Text = "Cerrar Sesión"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 43)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 25)
        Label1.TabIndex = 1
        Label1.Text = "Bienvenido :"
        ' 
        ' lbCorreo
        ' 
        lbCorreo.AutoSize = True
        lbCorreo.Location = New Point(161, 43)
        lbCorreo.Margin = New Padding(4, 0, 4, 0)
        lbCorreo.Name = "lbCorreo"
        lbCorreo.Size = New Size(63, 25)
        lbCorreo.TabIndex = 2
        lbCorreo.Text = "Label2"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 102)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 25)
        Label2.TabIndex = 3
        Label2.Text = " Rol"
        ' 
        ' lbRol
        ' 
        lbRol.AutoSize = True
        lbRol.Location = New Point(161, 102)
        lbRol.Margin = New Padding(4, 0, 4, 0)
        lbRol.Name = "lbRol"
        lbRol.Size = New Size(63, 25)
        lbRol.TabIndex = 4
        lbRol.Text = "Label2"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button7)
        GroupBox1.Controls.Add(Button6)
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Location = New Point(10, 162)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(181, 517)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Menú"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(24, 91)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 6
        Button2.Text = "Empleados"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(24, 164)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 34)
        Button3.TabIndex = 7
        Button3.Text = "Usuarios"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(24, 231)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 34)
        Button4.TabIndex = 8
        Button4.Text = "Clientes"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(24, 298)
        Button5.Name = "Button5"
        Button5.Size = New Size(112, 34)
        Button5.TabIndex = 9
        Button5.Text = "Repuestos"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(24, 369)
        Button6.Name = "Button6"
        Button6.Size = New Size(112, 34)
        Button6.TabIndex = 10
        Button6.Text = "Siniestros"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(24, 435)
        Button7.Name = "Button7"
        Button7.Size = New Size(112, 34)
        Button7.TabIndex = 11
        Button7.Text = "Servicios"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(PictureBox1)
        GroupBox2.Location = New Point(252, 173)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(755, 451)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(18, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(707, 407)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(1143, 750)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(lbRol)
        Controls.Add(Label2)
        Controls.Add(lbCorreo)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "AdminForm"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbCorreo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbRol As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
