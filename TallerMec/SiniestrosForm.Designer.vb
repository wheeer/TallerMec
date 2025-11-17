<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SiniestrosForm
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
        btnHistorial = New Button()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        ComboBox1 = New ComboBox()
        DataGridView1 = New DataGridView()
        Label3 = New Label()
        GroupBox2 = New GroupBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Button3 = New Button()
        Button4 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnVolver
        ' 
        btnVolver.Location = New Point(944, 701)
        btnVolver.Margin = New Padding(4, 5, 4, 5)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(187, 38)
        btnVolver.TabIndex = 2
        btnVolver.Text = "Volver al Menú"
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' btnHistorial
        ' 
        btnHistorial.Location = New Point(12, 699)
        btnHistorial.Margin = New Padding(4, 5, 4, 5)
        btnHistorial.Name = "btnHistorial"
        btnHistorial.Size = New Size(187, 38)
        btnHistorial.TabIndex = 4
        btnHistorial.Text = "Historial Sinistros"
        btnHistorial.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.images_2025_01_02T174228_126
        PictureBox1.Location = New Point(-5, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1150, 752)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(116, 50)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(913, 257)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Busqueda de Siniestros"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Kristen ITC", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(11, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 30)
        Label1.TabIndex = 0
        Label1.Text = "Cliente:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(118, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(185, 18)
        Label2.TabIndex = 1
        Label2.Text = "(Ingrese un rut de Cliente)"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(120, 45)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(222, 31)
        TextBox1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(357, 42)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 3
        Button1.Text = "Buscar🔎"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(479, 42)
        Button2.Name = "Button2"
        Button2.Size = New Size(124, 34)
        Button2.TabIndex = 4
        Button2.Text = "Ver Todo🔎"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(376, 83)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(208, 33)
        ComboBox1.TabIndex = 5
        ComboBox1.Text = "Estado de siniestros"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 123)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(913, 133)
        DataGridView1.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(496, 12)
        Label3.Name = "Label3"
        Label3.Size = New Size(208, 28)
        Label3.TabIndex = 7
        Label3.Text = "Gestión de Siniestros"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(357, 312)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(444, 428)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "Gestión de Siniestros"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 59)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 28)
        Label4.TabIndex = 0
        Label4.Text = "ID:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 226)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 28)
        Label5.TabIndex = 1
        Label5.Text = "Fecha:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 189)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 28)
        Label6.TabIndex = 2
        Label6.Text = "Estado:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 98)
        Label7.Name = "Label7"
        Label7.Size = New Size(77, 28)
        Label7.TabIndex = 3
        Label7.Text = "Detalle:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(6, 259)
        Label8.Name = "Label8"
        Label8.Size = New Size(105, 28)
        Label8.TabIndex = 4
        Label8.Text = "Compañia:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 292)
        Label9.Name = "Label9"
        Label9.Size = New Size(76, 28)
        Label9.TabIndex = 5
        Label9.Text = "Cliente:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(6, 322)
        Label10.Name = "Label10"
        Label10.Size = New Size(79, 28)
        Label10.TabIndex = 6
        Label10.Text = "Seguro:"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(87, 387)
        Button3.Name = "Button3"
        Button3.Size = New Size(123, 34)
        Button3.TabIndex = 7
        Button3.Text = "Guardar✔"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(260, 387)
        Button4.Name = "Button4"
        Button4.Size = New Size(127, 34)
        Button4.TabIndex = 8
        Button4.Text = "Modificar📃"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' SiniestrosForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 750)
        Controls.Add(GroupBox2)
        Controls.Add(Label3)
        Controls.Add(GroupBox1)
        Controls.Add(btnHistorial)
        Controls.Add(btnVolver)
        Controls.Add(PictureBox1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "SiniestrosForm"
        Text = "SiniestrosForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents btnHistorial As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
End Class
