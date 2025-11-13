<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Resumen_Ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Resumen_Ventas))
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        dgvHistorial = New DataGridView()
        btVer = New Button()
        btBuscar = New Button()
        txtId = New TextBox()
        Label1 = New Label()
        btVolver = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(dgvHistorial, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-4, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1197, 730)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btVolver)
        GroupBox1.Controls.Add(dgvHistorial)
        GroupBox1.Controls.Add(btVer)
        GroupBox1.Controls.Add(btBuscar)
        GroupBox1.Controls.Add(txtId)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(246, 92)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(666, 507)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        GroupBox1.Text = "Historial de Ventas:"
        ' 
        ' dgvHistorial
        ' 
        dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHistorial.Location = New Point(97, 204)
        dgvHistorial.Name = "dgvHistorial"
        dgvHistorial.RowHeadersWidth = 62
        dgvHistorial.Size = New Size(486, 225)
        dgvHistorial.TabIndex = 4
        ' 
        ' btVer
        ' 
        btVer.BackColor = Color.DarkOrange
        btVer.Location = New Point(539, 121)
        btVer.Name = "btVer"
        btVer.Size = New Size(106, 38)
        btVer.TabIndex = 3
        btVer.Text = "Ver todo"
        btVer.UseVisualStyleBackColor = False
        ' 
        ' btBuscar
        ' 
        btBuscar.BackColor = Color.LawnGreen
        btBuscar.Location = New Point(415, 122)
        btBuscar.Name = "btBuscar"
        btBuscar.Size = New Size(101, 38)
        btBuscar.TabIndex = 2
        btBuscar.Text = "Buscar"
        btBuscar.UseVisualStyleBackColor = False
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(256, 126)
        txtId.Name = "txtId"
        txtId.Size = New Size(135, 31)
        txtId.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 126)
        Label1.Name = "Label1"
        Label1.Size = New Size(232, 25)
        Label1.TabIndex = 0
        Label1.Text = "Introduzca el ID de la venta:"
        ' 
        ' btVolver
        ' 
        btVolver.BackColor = Color.Red
        btVolver.ForeColor = Color.White
        btVolver.Location = New Point(533, 451)
        btVolver.Name = "btVolver"
        btVolver.Size = New Size(112, 34)
        btVolver.TabIndex = 5
        btVolver.Text = "Volver"
        btVolver.UseVisualStyleBackColor = False
        ' 
        ' Resumen_Ventas
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1193, 661)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Name = "Resumen_Ventas"
        Text = "Resumen_Ventas"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvHistorial, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents btVer As Button
    Friend WithEvents btBuscar As Button
    Friend WithEvents dgvHistorial As DataGridView
    Friend WithEvents btVolver As Button

End Class
