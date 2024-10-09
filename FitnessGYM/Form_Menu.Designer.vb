<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form_Menu))
        Panel_Superior = New FlowLayoutPanel()
        PictureBox2 = New PictureBox()
        PictureBox4 = New PictureBox()
        Panel_Menu = New Panel()
        pnl_socli = New Panel()
        PictureBox3 = New PictureBox()
        pnl_busqueda = New Panel()
        Label1 = New Label()
        txt_bus_cliente = New TextBox()
        PictureBox5 = New PictureBox()
        Button1 = New Button()
        btn_buscar = New Button()
        Panel_pln_lateral = New Panel()
        PictureBox1 = New PictureBox()
        Btn_Socio = New Button()
        Pnl_submenu_socios = New Panel()
        btn_lista_socio = New Button()
        btn_agregar_socio = New Button()
        Btn_Actividades = New Button()
        Pnl_Sub_menu_Actividades = New Panel()
        Button2 = New Button()
        btn_sub = New Button()
        btn_ejercicio = New Button()
        Btn_Informe = New Button()
        Pnl_Sub_menu_Informe = New Panel()
        btn_caja = New Button()
        Button6 = New Button()
        Panel_Lateral = New Panel()
        pnl_mas = New Panel()
        btn_mas = New Button()
        Panel_Superior.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel_Menu.SuspendLayout()
        pnl_socli.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        pnl_busqueda.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel_pln_lateral.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Pnl_submenu_socios.SuspendLayout()
        Pnl_Sub_menu_Actividades.SuspendLayout()
        Pnl_Sub_menu_Informe.SuspendLayout()
        Panel_Lateral.SuspendLayout()
        pnl_mas.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel_Superior
        ' 
        Panel_Superior.BackColor = Color.FromArgb(CByte(10), CByte(10), CByte(10))
        Panel_Superior.Controls.Add(PictureBox2)
        Panel_Superior.Controls.Add(PictureBox4)
        Panel_Superior.Location = New Point(0, 0)
        Panel_Superior.Name = "Panel_Superior"
        Panel_Superior.Size = New Size(983, 42)
        Panel_Superior.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(217, 39)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(226, 3)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(36, 33)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' Panel_Menu
        ' 
        Panel_Menu.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        Panel_Menu.Controls.Add(pnl_socli)
        Panel_Menu.Dock = DockStyle.Fill
        Panel_Menu.Location = New Point(220, 0)
        Panel_Menu.Name = "Panel_Menu"
        Panel_Menu.Size = New Size(763, 597)
        Panel_Menu.TabIndex = 2
        ' 
        ' pnl_socli
        ' 
        pnl_socli.Anchor = AnchorStyles.None
        pnl_socli.Controls.Add(PictureBox3)
        pnl_socli.Location = New Point(140, 141)
        pnl_socli.Name = "pnl_socli"
        pnl_socli.Size = New Size(498, 328)
        pnl_socli.TabIndex = 1
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(84, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(355, 325)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' pnl_busqueda
        ' 
        pnl_busqueda.BackColor = Color.FromArgb(CByte(10), CByte(10), CByte(10))
        pnl_busqueda.Controls.Add(Label1)
        pnl_busqueda.Controls.Add(txt_bus_cliente)
        pnl_busqueda.Controls.Add(PictureBox5)
        pnl_busqueda.Controls.Add(Button1)
        pnl_busqueda.Controls.Add(btn_buscar)
        pnl_busqueda.Dock = DockStyle.Top
        pnl_busqueda.ForeColor = SystemColors.Control
        pnl_busqueda.Location = New Point(220, 0)
        pnl_busqueda.Name = "pnl_busqueda"
        pnl_busqueda.Size = New Size(763, 100)
        pnl_busqueda.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(185, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 17)
        Label1.TabIndex = 5
        Label1.Text = "DNI"
        ' 
        ' txt_bus_cliente
        ' 
        txt_bus_cliente.Anchor = AnchorStyles.None
        txt_bus_cliente.BackColor = Color.Gray
        txt_bus_cliente.BorderStyle = BorderStyle.FixedSingle
        txt_bus_cliente.ForeColor = SystemColors.Window
        txt_bus_cliente.Location = New Point(223, 34)
        txt_bus_cliente.Name = "txt_bus_cliente"
        txt_bus_cliente.Size = New Size(230, 23)
        txt_bus_cliente.TabIndex = 4
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(699, 6)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(52, 50)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 3
        PictureBox5.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Gainsboro
        Button1.Location = New Point(665, 62)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 23)
        Button1.TabIndex = 2
        Button1.Text = "Cerrar Sesion"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btn_buscar
        ' 
        btn_buscar.Anchor = AnchorStyles.None
        btn_buscar.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btn_buscar.FlatAppearance.BorderSize = 0
        btn_buscar.FlatStyle = FlatStyle.Flat
        btn_buscar.ForeColor = Color.Gainsboro
        btn_buscar.Location = New Point(459, 33)
        btn_buscar.Name = "btn_buscar"
        btn_buscar.Size = New Size(79, 24)
        btn_buscar.TabIndex = 0
        btn_buscar.Text = "Buscar"
        btn_buscar.UseVisualStyleBackColor = False
        ' 
        ' Panel_pln_lateral
        ' 
        Panel_pln_lateral.Controls.Add(PictureBox1)
        Panel_pln_lateral.Dock = DockStyle.Top
        Panel_pln_lateral.Location = New Point(0, 0)
        Panel_pln_lateral.Name = "Panel_pln_lateral"
        Panel_pln_lateral.Size = New Size(220, 100)
        Panel_pln_lateral.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-24, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(275, 69)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Btn_Socio
        ' 
        Btn_Socio.Dock = DockStyle.Top
        Btn_Socio.FlatAppearance.BorderSize = 0
        Btn_Socio.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(74), CByte(0), CByte(74))
        Btn_Socio.FlatStyle = FlatStyle.Flat
        Btn_Socio.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Socio.ForeColor = Color.Gainsboro
        Btn_Socio.Location = New Point(0, 100)
        Btn_Socio.Name = "Btn_Socio"
        Btn_Socio.Padding = New Padding(10, 0, 0, 0)
        Btn_Socio.Size = New Size(220, 47)
        Btn_Socio.TabIndex = 2
        Btn_Socio.Text = "Socios"
        Btn_Socio.TextAlign = ContentAlignment.MiddleLeft
        Btn_Socio.UseVisualStyleBackColor = True
        ' 
        ' Pnl_submenu_socios
        ' 
        Pnl_submenu_socios.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        Pnl_submenu_socios.Controls.Add(btn_lista_socio)
        Pnl_submenu_socios.Controls.Add(btn_agregar_socio)
        Pnl_submenu_socios.Dock = DockStyle.Top
        Pnl_submenu_socios.Location = New Point(0, 147)
        Pnl_submenu_socios.Name = "Pnl_submenu_socios"
        Pnl_submenu_socios.Size = New Size(220, 70)
        Pnl_submenu_socios.TabIndex = 0
        ' 
        ' btn_lista_socio
        ' 
        btn_lista_socio.Dock = DockStyle.Top
        btn_lista_socio.FlatAppearance.BorderSize = 0
        btn_lista_socio.FlatStyle = FlatStyle.Flat
        btn_lista_socio.ForeColor = Color.Gainsboro
        btn_lista_socio.Location = New Point(0, 30)
        btn_lista_socio.Name = "btn_lista_socio"
        btn_lista_socio.Padding = New Padding(35, 0, 0, 0)
        btn_lista_socio.Size = New Size(220, 30)
        btn_lista_socio.TabIndex = 1
        btn_lista_socio.Text = "Lista de Socio"
        btn_lista_socio.TextAlign = ContentAlignment.MiddleLeft
        btn_lista_socio.UseVisualStyleBackColor = True
        ' 
        ' btn_agregar_socio
        ' 
        btn_agregar_socio.Dock = DockStyle.Top
        btn_agregar_socio.FlatAppearance.BorderSize = 0
        btn_agregar_socio.FlatStyle = FlatStyle.Flat
        btn_agregar_socio.ForeColor = Color.Gainsboro
        btn_agregar_socio.Location = New Point(0, 0)
        btn_agregar_socio.Name = "btn_agregar_socio"
        btn_agregar_socio.Padding = New Padding(35, 0, 0, 0)
        btn_agregar_socio.Size = New Size(220, 30)
        btn_agregar_socio.TabIndex = 0
        btn_agregar_socio.Text = "Agregar Socio"
        btn_agregar_socio.TextAlign = ContentAlignment.MiddleLeft
        btn_agregar_socio.UseVisualStyleBackColor = True
        ' 
        ' Btn_Actividades
        ' 
        Btn_Actividades.Dock = DockStyle.Top
        Btn_Actividades.FlatAppearance.BorderSize = 0
        Btn_Actividades.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(74), CByte(0), CByte(74))
        Btn_Actividades.FlatStyle = FlatStyle.Flat
        Btn_Actividades.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Actividades.ForeColor = Color.Gainsboro
        Btn_Actividades.Location = New Point(0, 217)
        Btn_Actividades.Name = "Btn_Actividades"
        Btn_Actividades.Padding = New Padding(10, 0, 0, 0)
        Btn_Actividades.Size = New Size(220, 45)
        Btn_Actividades.TabIndex = 3
        Btn_Actividades.Text = "Actividades"
        Btn_Actividades.TextAlign = ContentAlignment.MiddleLeft
        Btn_Actividades.UseVisualStyleBackColor = True
        ' 
        ' Pnl_Sub_menu_Actividades
        ' 
        Pnl_Sub_menu_Actividades.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        Pnl_Sub_menu_Actividades.Controls.Add(Button2)
        Pnl_Sub_menu_Actividades.Controls.Add(btn_sub)
        Pnl_Sub_menu_Actividades.Controls.Add(btn_ejercicio)
        Pnl_Sub_menu_Actividades.Dock = DockStyle.Top
        Pnl_Sub_menu_Actividades.Location = New Point(0, 262)
        Pnl_Sub_menu_Actividades.Name = "Pnl_Sub_menu_Actividades"
        Pnl_Sub_menu_Actividades.Size = New Size(220, 106)
        Pnl_Sub_menu_Actividades.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.Dock = DockStyle.Top
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Gainsboro
        Button2.Location = New Point(0, 60)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(35, 0, 0, 0)
        Button2.Size = New Size(220, 30)
        Button2.TabIndex = 3
        Button2.Text = "Gestion Suscripcion y Rutinas"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btn_sub
        ' 
        btn_sub.Dock = DockStyle.Top
        btn_sub.FlatAppearance.BorderSize = 0
        btn_sub.FlatStyle = FlatStyle.Flat
        btn_sub.ForeColor = Color.Gainsboro
        btn_sub.Location = New Point(0, 30)
        btn_sub.Name = "btn_sub"
        btn_sub.Padding = New Padding(35, 0, 0, 0)
        btn_sub.Size = New Size(220, 30)
        btn_sub.TabIndex = 2
        btn_sub.Text = "Suscripciones"
        btn_sub.TextAlign = ContentAlignment.MiddleLeft
        btn_sub.UseVisualStyleBackColor = True
        ' 
        ' btn_ejercicio
        ' 
        btn_ejercicio.Dock = DockStyle.Top
        btn_ejercicio.FlatAppearance.BorderSize = 0
        btn_ejercicio.FlatStyle = FlatStyle.Flat
        btn_ejercicio.ForeColor = Color.Gainsboro
        btn_ejercicio.Location = New Point(0, 0)
        btn_ejercicio.Name = "btn_ejercicio"
        btn_ejercicio.Padding = New Padding(35, 0, 0, 0)
        btn_ejercicio.Size = New Size(220, 30)
        btn_ejercicio.TabIndex = 1
        btn_ejercicio.Text = "Ejercicios"
        btn_ejercicio.TextAlign = ContentAlignment.MiddleLeft
        btn_ejercicio.UseVisualStyleBackColor = True
        ' 
        ' Btn_Informe
        ' 
        Btn_Informe.Dock = DockStyle.Top
        Btn_Informe.FlatAppearance.BorderSize = 0
        Btn_Informe.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(74), CByte(0), CByte(74))
        Btn_Informe.FlatStyle = FlatStyle.Flat
        Btn_Informe.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Informe.ForeColor = Color.Gainsboro
        Btn_Informe.Location = New Point(0, 368)
        Btn_Informe.Name = "Btn_Informe"
        Btn_Informe.Padding = New Padding(10, 0, 0, 0)
        Btn_Informe.Size = New Size(220, 45)
        Btn_Informe.TabIndex = 6
        Btn_Informe.Text = "Informe"
        Btn_Informe.TextAlign = ContentAlignment.MiddleLeft
        Btn_Informe.UseVisualStyleBackColor = True
        ' 
        ' Pnl_Sub_menu_Informe
        ' 
        Pnl_Sub_menu_Informe.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        Pnl_Sub_menu_Informe.Controls.Add(btn_caja)
        Pnl_Sub_menu_Informe.Dock = DockStyle.Top
        Pnl_Sub_menu_Informe.Location = New Point(0, 413)
        Pnl_Sub_menu_Informe.Name = "Pnl_Sub_menu_Informe"
        Pnl_Sub_menu_Informe.Size = New Size(220, 44)
        Pnl_Sub_menu_Informe.TabIndex = 7
        ' 
        ' btn_caja
        ' 
        btn_caja.Dock = DockStyle.Top
        btn_caja.FlatAppearance.BorderSize = 0
        btn_caja.FlatStyle = FlatStyle.Flat
        btn_caja.ForeColor = Color.Gainsboro
        btn_caja.Location = New Point(0, 0)
        btn_caja.Name = "btn_caja"
        btn_caja.Padding = New Padding(35, 0, 0, 0)
        btn_caja.Size = New Size(220, 30)
        btn_caja.TabIndex = 1
        btn_caja.Text = "Ultimos Movimientos"
        btn_caja.TextAlign = ContentAlignment.MiddleLeft
        btn_caja.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Dock = DockStyle.Top
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(74), CByte(0), CByte(74))
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.ForeColor = Color.Gainsboro
        Button6.Location = New Point(0, 457)
        Button6.Name = "Button6"
        Button6.Padding = New Padding(10, 0, 0, 0)
        Button6.Size = New Size(220, 45)
        Button6.TabIndex = 8
        Button6.Text = "Más"
        Button6.TextAlign = ContentAlignment.MiddleLeft
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Panel_Lateral
        ' 
        Panel_Lateral.AutoScroll = True
        Panel_Lateral.BackColor = Color.FromArgb(CByte(10), CByte(10), CByte(10))
        Panel_Lateral.Controls.Add(pnl_mas)
        Panel_Lateral.Controls.Add(Button6)
        Panel_Lateral.Controls.Add(Pnl_Sub_menu_Informe)
        Panel_Lateral.Controls.Add(Btn_Informe)
        Panel_Lateral.Controls.Add(Pnl_Sub_menu_Actividades)
        Panel_Lateral.Controls.Add(Btn_Actividades)
        Panel_Lateral.Controls.Add(Pnl_submenu_socios)
        Panel_Lateral.Controls.Add(Btn_Socio)
        Panel_Lateral.Controls.Add(Panel_pln_lateral)
        Panel_Lateral.Dock = DockStyle.Left
        Panel_Lateral.Location = New Point(0, 0)
        Panel_Lateral.Name = "Panel_Lateral"
        Panel_Lateral.Size = New Size(220, 597)
        Panel_Lateral.TabIndex = 1
        ' 
        ' pnl_mas
        ' 
        pnl_mas.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        pnl_mas.Controls.Add(btn_mas)
        pnl_mas.Dock = DockStyle.Top
        pnl_mas.Location = New Point(0, 502)
        pnl_mas.Name = "pnl_mas"
        pnl_mas.Size = New Size(220, 44)
        pnl_mas.TabIndex = 9
        ' 
        ' btn_mas
        ' 
        btn_mas.Dock = DockStyle.Top
        btn_mas.FlatAppearance.BorderSize = 0
        btn_mas.FlatStyle = FlatStyle.Flat
        btn_mas.ForeColor = Color.Gainsboro
        btn_mas.Location = New Point(0, 0)
        btn_mas.Name = "btn_mas"
        btn_mas.Padding = New Padding(35, 0, 0, 0)
        btn_mas.Size = New Size(220, 30)
        btn_mas.TabIndex = 2
        btn_mas.Text = "Proximamente"
        btn_mas.TextAlign = ContentAlignment.MiddleLeft
        btn_mas.UseVisualStyleBackColor = True
        ' 
        ' Form_Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(983, 597)
        Controls.Add(pnl_busqueda)
        Controls.Add(Panel_Menu)
        Controls.Add(Panel_Lateral)
        Controls.Add(Panel_Superior)
        MaximumSize = New Size(999, 636)
        MinimumSize = New Size(999, 636)
        Name = "Form_Menu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel_Superior.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel_Menu.ResumeLayout(False)
        pnl_socli.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        pnl_busqueda.ResumeLayout(False)
        pnl_busqueda.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel_pln_lateral.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Pnl_submenu_socios.ResumeLayout(False)
        Pnl_Sub_menu_Actividades.ResumeLayout(False)
        Pnl_Sub_menu_Informe.ResumeLayout(False)
        Panel_Lateral.ResumeLayout(False)
        pnl_mas.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel_Superior As FlowLayoutPanel
    Friend WithEvents Panel_Menu As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pnl_busqueda As Panel
    Friend WithEvents pnl_socli As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txt_bus_cliente As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents Panel_pln_lateral As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_Socio As Button
    Friend WithEvents Pnl_submenu_socios As Panel
    Friend WithEvents btn_lista_socio As Button
    Friend WithEvents btn_agregar_socio As Button
    Friend WithEvents Btn_Actividades As Button
    Friend WithEvents Pnl_Sub_menu_Actividades As Panel
    Friend WithEvents btn_ejercicio As Button
    Friend WithEvents Btn_Informe As Button
    Friend WithEvents Pnl_Sub_menu_Informe As Panel
    Friend WithEvents btn_caja As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel_Lateral As Panel
    Friend WithEvents btn_sub As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents pnl_mas As Panel
    Friend WithEvents btn_mas As Button
End Class
