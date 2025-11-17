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
        btVolver = New Button()
        dgvHistorial = New DataGridView()
        btVer = New Button()
        btBuscar = New Button()
        txtId = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
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
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(btVolver)
        GroupBox1.Controls.Add(dgvHistorial)
        GroupBox1.Controls.Add(btVer)
        GroupBox1.Controls.Add(btBuscar)
        GroupBox1.Controls.Add(txtId)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Times New Roman", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(209, 91)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(772, 507)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        GroupBox1.Text = "Historial de Ventas:"
        ' 
        ' btVolver
        ' 
        btVolver.BackColor = Color.Red
        btVolver.ForeColor = Color.White
        btVolver.Location = New Point(654, 467)
        btVolver.Name = "btVolver"
        btVolver.Size = New Size(112, 34)
        btVolver.TabIndex = 5
        btVolver.Text = "Volver"
        btVolver.UseVisualStyleBackColor = False
        ' 
        ' dgvHistorial
        ' 
        dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHistorial.Location = New Point(11, 179)
        dgvHistorial.Name = "dgvHistorial"
        dgvHistorial.RowHeadersWidth = 62
        dgvHistorial.Size = New Size(749, 272)
        dgvHistorial.TabIndex = 4
        ' 
        ' btVer
        ' 
        btVer.BackColor = Color.DarkOrange
        btVer.Location = New Point(615, 119)
        btVer.Name = "btVer"
        btVer.Size = New Size(126, 38)
        btVer.TabIndex = 3
        btVer.Text = "Ver todo🔎"
        btVer.UseVisualStyleBackColor = False
        ' 
        ' btBuscar
        ' 
        btBuscar.BackColor = Color.LawnGreen
        btBuscar.Location = New Point(481, 119)
        btBuscar.Name = "btBuscar"
        btBuscar.Size = New Size(107, 38)
        btBuscar.TabIndex = 2
        btBuscar.Text = "Buscar🔎"
        btBuscar.UseVisualStyleBackColor = False
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(312, 123)
        txtId.Name = "txtId"
        txtId.Size = New Size(135, 33)
        txtId.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(39, 126)
        Label1.Name = "Label1"
        Label1.Size = New Size(275, 25)
        Label1.TabIndex = 0
        Label1.Text = "Introduzca el ID de la venta:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(366, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 25)
        Label2.TabIndex = 6
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(529, 19)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 40)
        Label3.TabIndex = 17
        Label3.Text = "Historial"
        ' 
        ' Resumen_Ventas
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1193, 661)
        Controls.Add(Label3)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Name = "Resumen_Ventas"
        Text = "Resumen_Ventas"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvHistorial, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents btVer As Button
    Friend WithEvents btBuscar As Button
    Friend WithEvents dgvHistorial As DataGridView
    Friend WithEvents btVolver As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
