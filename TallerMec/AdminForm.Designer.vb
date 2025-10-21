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
        Button1 = New Button()
        Label1 = New Label()
        lbCorreo = New Label()
        Label2 = New Label()
        lbRol = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(544, 356)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 23)
        Button1.TabIndex = 0
        Button1.Text = "Cerrar Sesión"
        Button1.UseVisualStyleBackColor = True
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
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbRol)
        Controls.Add(Label2)
        Controls.Add(lbCorreo)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "AdminForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbCorreo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbRol As Label
End Class
