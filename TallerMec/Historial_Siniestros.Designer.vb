<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial_Siniestros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Historial_Siniestros))
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        cbEstado = New ComboBox()
        btnVerTodo = New Button()
        btnBuscar = New Button()
        dgvHistorial = New DataGridView()
        tbRut = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnVovler = New Button()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(dgvHistorial, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ActiveCaption
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(cbEstado)
        GroupBox1.Controls.Add(btnVerTodo)
        GroupBox1.Controls.Add(btnBuscar)
        GroupBox1.Controls.Add(dgvHistorial)
        GroupBox1.Controls.Add(tbRut)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(130, 73)
        GroupBox1.Margin = New Padding(2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2)
        GroupBox1.Size = New Size(540, 304)
        GroupBox1.TabIndex = 17
        GroupBox1.TabStop = False
        GroupBox1.Text = "Busqueda de Siniestros"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(294, 64)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 15)
        Label3.TabIndex = 8
        Label3.Text = "Estado :"
        ' 
        ' cbEstado
        ' 
        cbEstado.FormattingEnabled = True
        cbEstado.Location = New Point(349, 61)
        cbEstado.Name = "cbEstado"
        cbEstado.Size = New Size(169, 23)
        cbEstado.TabIndex = 7
        ' 
        ' btnVerTodo
        ' 
        btnVerTodo.Location = New Point(430, 32)
        btnVerTodo.Name = "btnVerTodo"
        btnVerTodo.Size = New Size(88, 23)
        btnVerTodo.TabIndex = 6
        btnVerTodo.Text = "Ver Todo 🔎"
        btnVerTodo.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(349, 32)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(75, 23)
        btnBuscar.TabIndex = 5
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' dgvHistorial
        ' 
        dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHistorial.Location = New Point(8, 107)
        dgvHistorial.Margin = New Padding(2)
        dgvHistorial.Name = "dgvHistorial"
        dgvHistorial.RowHeadersWidth = 62
        dgvHistorial.Size = New Size(524, 163)
        dgvHistorial.TabIndex = 4
        ' 
        ' tbRut
        ' 
        tbRut.Location = New Point(93, 32)
        tbRut.Margin = New Padding(2)
        tbRut.Name = "tbRut"
        tbRut.Size = New Size(251, 23)
        tbRut.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(39, 39)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 15)
        Label1.TabIndex = 0
        Label1.Text = "Cliente :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(333, 29)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(181, 25)
        Label2.TabIndex = 5
        Label2.Text = "Gestión de Clientes."
        ' 
        ' btnVovler
        ' 
        btnVovler.Location = New Point(699, 405)
        btnVovler.Name = "btnVovler"
        btnVovler.Size = New Size(75, 23)
        btnVovler.TabIndex = 7
        btnVovler.Text = "Volver"
        btnVovler.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 450)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' Historial_Siniestros
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnVovler)
        Controls.Add(Label2)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Name = "Historial_Siniestros"
        Text = "Historial_Siniestros"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvHistorial, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnVerTodo As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvHistorial As DataGridView
    Friend WithEvents tbRut As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVovler As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
