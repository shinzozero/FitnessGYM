<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Socio
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Agregar_Socio))
        Panel1 = New Panel()
        DateTimePicker1 = New DateTimePicker()
        Label10 = New Label()
        CheckedListBox_condicion = New CheckedListBox()
        cbx_conocido = New ComboBox()
        Label9 = New Label()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        PictureBox1 = New PictureBox()
        cbx_genero = New ComboBox()
        Label8 = New Label()
        txt_correo = New TextBox()
        txt_telefono = New TextBox()
        txt_dni = New TextBox()
        txt_apellido = New TextBox()
        txt_direccion = New TextBox()
        txt_nombres = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btn_cancelar = New Button()
        btn_agregar = New Button()
        Btn_Socio = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(10), CByte(10), CByte(10))
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(CheckedListBox_condicion)
        Panel1.Controls.Add(cbx_conocido)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(IconButton1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(cbx_genero)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(txt_correo)
        Panel1.Controls.Add(txt_telefono)
        Panel1.Controls.Add(txt_dni)
        Panel1.Controls.Add(txt_apellido)
        Panel1.Controls.Add(txt_direccion)
        Panel1.Controls.Add(txt_nombres)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btn_cancelar)
        Panel1.Controls.Add(btn_agregar)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 56)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(725, 507)
        Panel1.TabIndex = 0
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(313, 142)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(183, 23)
        DateTimePicker1.TabIndex = 48
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Yu Gothic", 13.5F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = SystemColors.ButtonFace
        Label10.Location = New Point(35, 270)
        Label10.Name = "Label10"
        Label10.Size = New Size(141, 23)
        Label10.TabIndex = 47
        Label10.Text = "Observaciones"
        ' 
        ' CheckedListBox_condicion
        ' 
        CheckedListBox_condicion.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        CheckedListBox_condicion.CheckOnClick = True
        CheckedListBox_condicion.Font = New Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        CheckedListBox_condicion.ForeColor = Color.WhiteSmoke
        CheckedListBox_condicion.FormattingEnabled = True
        CheckedListBox_condicion.Location = New Point(35, 296)
        CheckedListBox_condicion.Name = "CheckedListBox_condicion"
        CheckedListBox_condicion.Size = New Size(250, 96)
        CheckedListBox_condicion.TabIndex = 46
        ' 
        ' cbx_conocido
        ' 
        cbx_conocido.FormattingEnabled = True
        cbx_conocido.Location = New Point(313, 236)
        cbx_conocido.Name = "cbx_conocido"
        cbx_conocido.Size = New Size(183, 23)
        cbx_conocido.TabIndex = 45
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label9.ForeColor = SystemColors.ButtonFace
        Label9.Location = New Point(313, 216)
        Label9.Name = "Label9"
        Label9.Size = New Size(133, 17)
        Label9.TabIndex = 44
        Label9.Text = "Como nos conocio?"
        ' 
        ' IconButton1
        ' 
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.ForeColor = SystemColors.ActiveCaptionText
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.Camera
        IconButton1.IconColor = Color.WhiteSmoke
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 30
        IconButton1.Location = New Point(206, 53)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(37, 35)
        IconButton1.TabIndex = 43
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(35, 53)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(208, 184)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 42
        PictureBox1.TabStop = False
        ' 
        ' cbx_genero
        ' 
        cbx_genero.FormattingEnabled = True
        cbx_genero.Location = New Point(313, 97)
        cbx_genero.Name = "cbx_genero"
        cbx_genero.Size = New Size(183, 23)
        cbx_genero.TabIndex = 41
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ButtonFace
        Label8.Location = New Point(313, 77)
        Label8.Name = "Label8"
        Label8.Size = New Size(55, 17)
        Label8.TabIndex = 40
        Label8.Text = "Genero"
        ' 
        ' txt_correo
        ' 
        txt_correo.Location = New Point(313, 188)
        txt_correo.Name = "txt_correo"
        txt_correo.Size = New Size(183, 23)
        txt_correo.TabIndex = 39
        ' 
        ' txt_telefono
        ' 
        txt_telefono.Location = New Point(513, 142)
        txt_telefono.Name = "txt_telefono"
        txt_telefono.Size = New Size(183, 23)
        txt_telefono.TabIndex = 38
        ' 
        ' txt_dni
        ' 
        txt_dni.Location = New Point(513, 97)
        txt_dni.Name = "txt_dni"
        txt_dni.Size = New Size(183, 23)
        txt_dni.TabIndex = 37
        ' 
        ' txt_apellido
        ' 
        txt_apellido.Location = New Point(513, 53)
        txt_apellido.Name = "txt_apellido"
        txt_apellido.Size = New Size(183, 23)
        txt_apellido.TabIndex = 36
        ' 
        ' txt_direccion
        ' 
        txt_direccion.Location = New Point(513, 188)
        txt_direccion.Name = "txt_direccion"
        txt_direccion.Size = New Size(183, 23)
        txt_direccion.TabIndex = 34
        ' 
        ' txt_nombres
        ' 
        txt_nombres.Location = New Point(313, 53)
        txt_nombres.Name = "txt_nombres"
        txt_nombres.Size = New Size(183, 23)
        txt_nombres.TabIndex = 33
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ButtonFace
        Label7.Location = New Point(513, 77)
        Label7.Name = "Label7"
        Label7.Size = New Size(32, 17)
        Label7.TabIndex = 32
        Label7.Text = "DNI"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ButtonFace
        Label6.Location = New Point(313, 168)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 17)
        Label6.TabIndex = 31
        Label6.Text = "Correo Electronico"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(513, 122)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 17)
        Label5.TabIndex = 30
        Label5.Text = "Telefono"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(313, 122)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 17)
        Label4.TabIndex = 29
        Label4.Text = "Fecha de Nacimiento"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(513, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 17)
        Label3.TabIndex = 28
        Label3.Text = "Direccion"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(513, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 17)
        Label2.TabIndex = 27
        Label2.Text = "Apellido"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(313, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 17)
        Label1.TabIndex = 26
        Label1.Text = "Nombres"
        ' 
        ' btn_cancelar
        ' 
        btn_cancelar.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btn_cancelar.FlatAppearance.BorderSize = 0
        btn_cancelar.FlatStyle = FlatStyle.Flat
        btn_cancelar.ForeColor = Color.Gainsboro
        btn_cancelar.Location = New Point(617, 431)
        btn_cancelar.Name = "btn_cancelar"
        btn_cancelar.Size = New Size(79, 24)
        btn_cancelar.TabIndex = 25
        btn_cancelar.Text = "Cancelar"
        btn_cancelar.UseVisualStyleBackColor = False
        ' 
        ' btn_agregar
        ' 
        btn_agregar.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btn_agregar.FlatAppearance.BorderSize = 0
        btn_agregar.FlatStyle = FlatStyle.Flat
        btn_agregar.ForeColor = Color.Gainsboro
        btn_agregar.Location = New Point(513, 431)
        btn_agregar.Name = "btn_agregar"
        btn_agregar.Size = New Size(79, 24)
        btn_agregar.TabIndex = 24
        btn_agregar.Text = "Siguiente"
        btn_agregar.UseVisualStyleBackColor = False
        ' 
        ' Btn_Socio
        ' 
        Btn_Socio.BackColor = Color.FromArgb(CByte(10), CByte(10), CByte(10))
        Btn_Socio.Dock = DockStyle.Left
        Btn_Socio.FlatAppearance.BorderSize = 0
        Btn_Socio.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(74), CByte(0), CByte(74))
        Btn_Socio.FlatAppearance.MouseOverBackColor = Color.Gray
        Btn_Socio.FlatStyle = FlatStyle.Flat
        Btn_Socio.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Socio.ForeColor = Color.Gainsboro
        Btn_Socio.Location = New Point(0, 0)
        Btn_Socio.Name = "Btn_Socio"
        Btn_Socio.Padding = New Padding(10, 0, 0, 0)
        Btn_Socio.Size = New Size(220, 56)
        Btn_Socio.TabIndex = 3
        Btn_Socio.Text = "Datos"
        Btn_Socio.TextAlign = ContentAlignment.MiddleLeft
        Btn_Socio.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(10), CByte(10), CByte(10))
        Button1.Dock = DockStyle.Left
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(74), CByte(0), CByte(74))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Gainsboro
        Button1.Location = New Point(220, 0)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(10, 0, 0, 0)
        Button1.Size = New Size(220, 56)
        Button1.TabIndex = 4
        Button1.Text = "Suscripcion"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Agregar_Socio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        ClientSize = New Size(725, 563)
        Controls.Add(Button1)
        Controls.Add(Btn_Socio)
        Controls.Add(Panel1)
        MinimumSize = New Size(700, 444)
        Name = "Agregar_Socio"
        Text = "Agregar_Socio"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbx_genero As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents txt_dni As TextBox
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents txt_nombres As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents CheckedListBox_condicion As CheckedListBox
    Friend WithEvents cbx_conocido As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Btn_Socio As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
