<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label4 = New Label()
        GroupBox1 = New GroupBox()
        btnInicio = New Button()
        tbPwd = New TextBox()
        tbCorreo = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.DimGray
        Label4.Location = New Point(56, 413)
        Label4.Name = "Label4"
        Label4.Size = New Size(682, 15)
        Label4.TabIndex = 20
        Label4.Text = "© Producto no comercial desarrollado por; Fernanda Lillo, Juan Pablo Hernandez, Walter Hollub. Todos los derechos reservados."
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        GroupBox1.Controls.Add(btnInicio)
        GroupBox1.Controls.Add(tbPwd)
        GroupBox1.Controls.Add(tbCorreo)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.ForeColor = SystemColors.ControlLightLight
        GroupBox1.Location = New Point(185, 61)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(422, 303)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        GroupBox1.Text = "Inicio de sesión"
        ' 
        ' btnInicio
        ' 
        btnInicio.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnInicio.ForeColor = SystemColors.ActiveCaptionText
        btnInicio.Location = New Point(322, 253)
        btnInicio.Name = "btnInicio"
        btnInicio.Size = New Size(85, 23)
        btnInicio.TabIndex = 25
        btnInicio.Text = "Inicio sesión"
        btnInicio.UseVisualStyleBackColor = True
        ' 
        ' tbPwd
        ' 
        tbPwd.Location = New Point(124, 198)
        tbPwd.Name = "tbPwd"
        tbPwd.Size = New Size(283, 23)
        tbPwd.TabIndex = 24
        tbPwd.UseSystemPasswordChar = True
        ' 
        ' tbCorreo
        ' 
        tbCorreo.Location = New Point(124, 125)
        tbCorreo.Name = "tbCorreo"
        tbCorreo.Size = New Size(283, 23)
        tbCorreo.TabIndex = 23
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.LightGray
        Label3.Location = New Point(29, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 15)
        Label3.TabIndex = 22
        Label3.Text = "Contaseña :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.LightGray
        Label2.Location = New Point(29, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 15)
        Label2.TabIndex = 21
        Label2.Text = "Correo :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Viner Hand ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(83, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(324, 44)
        Label1.TabIndex = 20
        Label1.Text = "Bienvenido a Mechanico"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 450)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 22
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Controls.Add(Label4)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnInicio As Button
    Friend WithEvents tbPwd As TextBox
    Friend WithEvents tbCorreo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
