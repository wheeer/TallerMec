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
        btnVolver = New Button()
        Label1 = New Label()
        cmbRepuestos = New ComboBox()
        Label2 = New Label()
        btVer = New Button()
        btEditar = New Button()
        btIngresar = New Button()
        btEliminar = New Button()
        Label3 = New Label()
        txtIngresar = New TextBox()
        lbVer = New Label()
        SuspendLayout()
        ' 
        ' btnVolver
        ' 
        btnVolver.Location = New Point(939, 692)
        btnVolver.Margin = New Padding(4, 5, 4, 5)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(187, 38)
        btnVolver.TabIndex = 2
        btnVolver.Text = "Volver al Menú"
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(504, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 25)
        Label1.TabIndex = 3
        Label1.Text = "Repuestos"
        ' 
        ' cmbRepuestos
        ' 
        cmbRepuestos.FormattingEnabled = True
        cmbRepuestos.Location = New Point(209, 173)
        cmbRepuestos.Name = "cmbRepuestos"
        cmbRepuestos.Size = New Size(182, 33)
        cmbRepuestos.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(191, 25)
        Label2.TabIndex = 5
        Label2.Text = "Seleccione el repuesto:"
        ' 
        ' btVer
        ' 
        btVer.Location = New Point(426, 173)
        btVer.Name = "btVer"
        btVer.Size = New Size(112, 34)
        btVer.TabIndex = 6
        btVer.Text = "Ver"
        btVer.UseVisualStyleBackColor = True
        ' 
        ' btEditar
        ' 
        btEditar.Location = New Point(562, 173)
        btEditar.Name = "btEditar"
        btEditar.Size = New Size(112, 34)
        btEditar.TabIndex = 7
        btEditar.Text = "Editar"
        btEditar.UseVisualStyleBackColor = True
        ' 
        ' btIngresar
        ' 
        btIngresar.Location = New Point(486, 407)
        btIngresar.Name = "btIngresar"
        btIngresar.Size = New Size(112, 34)
        btIngresar.TabIndex = 8
        btIngresar.Text = "Ingresar"
        btIngresar.UseVisualStyleBackColor = True
        ' 
        ' btEliminar
        ' 
        btEliminar.Location = New Point(699, 173)
        btEliminar.Name = "btEliminar"
        btEliminar.Size = New Size(112, 34)
        btEliminar.TabIndex = 9
        btEliminar.Text = "Eliminar"
        btEliminar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(44, 412)
        Label3.Name = "Label3"
        Label3.Size = New Size(228, 25)
        Label3.TabIndex = 10
        Label3.Text = "Ingrese un nuevo repuesto:"
        ' 
        ' txtIngresar
        ' 
        txtIngresar.Location = New Point(291, 412)
        txtIngresar.Name = "txtIngresar"
        txtIngresar.Size = New Size(150, 31)
        txtIngresar.TabIndex = 11
        ' 
        ' lbVer
        ' 
        lbVer.AutoSize = True
        lbVer.Location = New Point(65, 268)
        lbVer.Name = "lbVer"
        lbVer.Size = New Size(63, 25)
        lbVer.TabIndex = 12
        lbVer.Text = "Label4"
        ' 
        ' RepuestosForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 750)
        Controls.Add(lbVer)
        Controls.Add(txtIngresar)
        Controls.Add(Label3)
        Controls.Add(btEliminar)
        Controls.Add(btIngresar)
        Controls.Add(btEditar)
        Controls.Add(btVer)
        Controls.Add(Label2)
        Controls.Add(cmbRepuestos)
        Controls.Add(Label1)
        Controls.Add(btnVolver)
        Margin = New Padding(4, 5, 4, 5)
        Name = "RepuestosForm"
        Text = "RepuestosForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbRepuestos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btVer As Button
    Friend WithEvents btEditar As Button
    Friend WithEvents btIngresar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIngresar As TextBox
    Friend WithEvents lbVer As Label
End Class
