<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_modulo_ejercicios
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
        lbl_nombre = New Label()
        dgv_condiciones = New DataGridView()
        Label4 = New Label()
        cbx_rut = New ComboBox()
        Label5 = New Label()
        btn_cancelar = New Button()
        Button1 = New Button()
        Label6 = New Label()
        dgv_list_final = New DataGridView()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        Button2 = New Button()
        Panel1 = New Panel()
        txt_series = New TextBox()
        txt_rep = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        dgv_list_ejer = New DataGridView()
        Label9 = New Label()
        Label2 = New Label()
        CType(dgv_condiciones, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_list_final, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(dgv_list_ejer, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl_nombre
        ' 
        lbl_nombre.AutoSize = True
        lbl_nombre.BackColor = Color.Transparent
        lbl_nombre.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        lbl_nombre.ForeColor = SystemColors.ButtonFace
        lbl_nombre.Location = New Point(10, 18)
        lbl_nombre.Name = "lbl_nombre"
        lbl_nombre.Size = New Size(66, 17)
        lbl_nombre.TabIndex = 37
        lbl_nombre.Text = "Nombres"
        ' 
        ' dgv_condiciones
        ' 
        dgv_condiciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_condiciones.Location = New Point(560, 38)
        dgv_condiciones.Name = "dgv_condiciones"
        dgv_condiciones.RowTemplate.Height = 25
        dgv_condiciones.Size = New Size(201, 82)
        dgv_condiciones.TabIndex = 42
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(560, 18)
        Label4.Name = "Label4"
        Label4.Size = New Size(151, 17)
        Label4.TabIndex = 44
        Label4.Text = "Condiciones del Socio"
        ' 
        ' cbx_rut
        ' 
        cbx_rut.FormattingEnabled = True
        cbx_rut.Location = New Point(40, 97)
        cbx_rut.Name = "cbx_rut"
        cbx_rut.Size = New Size(127, 23)
        cbx_rut.TabIndex = 45
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(40, 77)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 17)
        Label5.TabIndex = 46
        Label5.Text = "Rutinas"
        ' 
        ' btn_cancelar
        ' 
        btn_cancelar.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btn_cancelar.FlatAppearance.BorderSize = 0
        btn_cancelar.FlatStyle = FlatStyle.Flat
        btn_cancelar.ForeColor = Color.Gainsboro
        btn_cancelar.Location = New Point(588, 438)
        btn_cancelar.Name = "btn_cancelar"
        btn_cancelar.Size = New Size(79, 24)
        btn_cancelar.TabIndex = 47
        btn_cancelar.Text = "Finalizar"
        btn_cancelar.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Gainsboro
        Button1.Location = New Point(682, 438)
        Button1.Name = "Button1"
        Button1.Size = New Size(79, 24)
        Button1.TabIndex = 48
        Button1.Text = "Cancelar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ButtonFace
        Label6.Location = New Point(431, 123)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 17)
        Label6.TabIndex = 49
        Label6.Text = "Lista Final"
        ' 
        ' dgv_list_final
        ' 
        dgv_list_final.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_list_final.Location = New Point(431, 143)
        dgv_list_final.Name = "dgv_list_final"
        dgv_list_final.RowTemplate.Height = 25
        dgv_list_final.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_list_final.Size = New Size(330, 281)
        dgv_list_final.TabIndex = 50
        ' 
        ' IconButton1
        ' 
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.ForeColor = SystemColors.ActiveCaptionText
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight
        IconButton1.IconColor = Color.WhiteSmoke
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 30
        IconButton1.Location = New Point(388, 230)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(37, 35)
        IconButton1.TabIndex = 51
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' IconButton2
        ' 
        IconButton2.FlatAppearance.BorderSize = 0
        IconButton2.FlatStyle = FlatStyle.Flat
        IconButton2.ForeColor = SystemColors.ActiveCaptionText
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.Minus
        IconButton2.IconColor = Color.WhiteSmoke
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton2.IconSize = 30
        IconButton2.Location = New Point(388, 271)
        IconButton2.Name = "IconButton2"
        IconButton2.Size = New Size(37, 35)
        IconButton2.TabIndex = 52
        IconButton2.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Gainsboro
        Button2.Location = New Point(173, 95)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 24)
        Button2.TabIndex = 56
        Button2.Text = "Agregar Rutina"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Panel1.Controls.Add(txt_series)
        Panel1.Controls.Add(txt_rep)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(dgv_list_ejer)
        Panel1.Controls.Add(Label9)
        Panel1.Location = New Point(12, 143)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(370, 310)
        Panel1.TabIndex = 59
        ' 
        ' txt_series
        ' 
        txt_series.Location = New Point(228, 53)
        txt_series.Name = "txt_series"
        txt_series.Size = New Size(117, 23)
        txt_series.TabIndex = 51
        ' 
        ' txt_rep
        ' 
        txt_rep.Location = New Point(228, 99)
        txt_rep.Name = "txt_rep"
        txt_rep.Size = New Size(117, 23)
        txt_rep.TabIndex = 52
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ButtonFace
        Label7.Location = New Point(228, 79)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 17)
        Label7.TabIndex = 53
        Label7.Text = "Repeticiones"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ButtonFace
        Label8.Location = New Point(228, 33)
        Label8.Name = "Label8"
        Label8.Size = New Size(49, 17)
        Label8.TabIndex = 54
        Label8.Text = "Series"
        ' 
        ' dgv_list_ejer
        ' 
        dgv_list_ejer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_list_ejer.Location = New Point(3, 20)
        dgv_list_ejer.Name = "dgv_list_ejer"
        dgv_list_ejer.RowTemplate.Height = 25
        dgv_list_ejer.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_list_ejer.Size = New Size(219, 261)
        dgv_list_ejer.TabIndex = 0
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label9.ForeColor = SystemColors.ButtonFace
        Label9.Location = New Point(12, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(126, 17)
        Label9.TabIndex = 45
        Label9.Text = "Lista de Ejercicios"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Yu Gothic", 14.25F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(82, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 25)
        Label2.TabIndex = 60
        Label2.Text = "Nombres"
        ' 
        ' Form_modulo_ejercicios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(10), CByte(10))
        ClientSize = New Size(800, 492)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(Button2)
        Controls.Add(IconButton2)
        Controls.Add(IconButton1)
        Controls.Add(dgv_list_final)
        Controls.Add(Label6)
        Controls.Add(Button1)
        Controls.Add(btn_cancelar)
        Controls.Add(Label5)
        Controls.Add(cbx_rut)
        Controls.Add(Label4)
        Controls.Add(dgv_condiciones)
        Controls.Add(lbl_nombre)
        Name = "Form_modulo_ejercicios"
        Text = "Form_modulo_ejercicios"
        CType(dgv_condiciones, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_list_final, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgv_list_ejer, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents txt_nombres As TextBox
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents dgv_condiciones As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents cbx_rut As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents dgv_list_final As DataGridView
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_series As TextBox
    Friend WithEvents txt_rep As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dgv_list_ejer As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
End Class
