<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Label5 = New Label()
        Panel2 = New Panel()
        Button1 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        btn_inciar_sesion = New Button()
        txt_pass_login = New TextBox()
        txt_user_login = New TextBox()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Yu Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(180, 43)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 35)
        Label5.TabIndex = 6
        Label5.Text = "Login"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(btn_inciar_sesion)
        Panel2.Controls.Add(txt_pass_login)
        Panel2.Controls.Add(txt_user_login)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(63, 81)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(324, 437)
        Panel2.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Gainsboro
        Button1.Location = New Point(116, 400)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 23)
        Button1.TabIndex = 8
        Button1.Text = "Cerrar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Yu Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(24, 226)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 18)
        Label2.TabIndex = 12
        Label2.Text = "password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Yu Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(24, 158)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 18)
        Label1.TabIndex = 11
        Label1.Text = "user"
        ' 
        ' btn_inciar_sesion
        ' 
        btn_inciar_sesion.BackColor = Color.FromArgb(CByte(255), CByte(85), CByte(0))
        btn_inciar_sesion.FlatAppearance.BorderSize = 0
        btn_inciar_sesion.FlatStyle = FlatStyle.Flat
        btn_inciar_sesion.Font = New Font("Yu Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point)
        btn_inciar_sesion.ForeColor = Color.WhiteSmoke
        btn_inciar_sesion.Location = New Point(74, 316)
        btn_inciar_sesion.Name = "btn_inciar_sesion"
        btn_inciar_sesion.Size = New Size(177, 66)
        btn_inciar_sesion.TabIndex = 10
        btn_inciar_sesion.Text = "Iniciar Sesion"
        btn_inciar_sesion.UseVisualStyleBackColor = False
        ' 
        ' txt_pass_login
        ' 
        txt_pass_login.BackColor = SystemColors.Control
        txt_pass_login.ForeColor = SystemColors.Control
        txt_pass_login.Location = New Point(24, 247)
        txt_pass_login.Name = "txt_pass_login"
        txt_pass_login.Size = New Size(277, 23)
        txt_pass_login.TabIndex = 7
        ' 
        ' txt_user_login
        ' 
        txt_user_login.BackColor = SystemColors.Control
        txt_user_login.ForeColor = SystemColors.Control
        txt_user_login.Location = New Point(24, 186)
        txt_user_login.Name = "txt_user_login"
        txt_user_login.Size = New Size(277, 23)
        txt_user_login.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.account
        PictureBox1.Location = New Point(97, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 116)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(85), CByte(0))
        Panel1.Controls.Add(Label5)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(444, 237)
        Panel1.TabIndex = 0
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        ClientSize = New Size(444, 548)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_user_login As TextBox
    Friend WithEvents txt_pass_login As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_inciar_sesion As Button
    Friend WithEvents Button1 As Button
End Class
