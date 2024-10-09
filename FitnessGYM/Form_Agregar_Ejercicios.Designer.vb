<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Agregar_Ejercicios
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
        dgv_list_ejer = New DataGridView()
        cbx_sub = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        dgv_lis_final = New DataGridView()
        Label3 = New Label()
        cbx_rut = New ComboBox()
        Label4 = New Label()
        txt_series = New TextBox()
        txt_rep = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        eliminar_final = New FontAwesome.Sharp.IconButton()
        cargar_final = New FontAwesome.Sharp.IconButton()
        Panel1 = New Panel()
        Bbusqueda = New Button()
        CType(dgv_list_ejer, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_lis_final, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgv_list_ejer
        ' 
        dgv_list_ejer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_list_ejer.Location = New Point(12, 33)
        dgv_list_ejer.Name = "dgv_list_ejer"
        dgv_list_ejer.RowTemplate.Height = 25
        dgv_list_ejer.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_list_ejer.Size = New Size(183, 347)
        dgv_list_ejer.TabIndex = 0
        ' 
        ' cbx_sub
        ' 
        cbx_sub.FormattingEnabled = True
        cbx_sub.Location = New Point(23, 41)
        cbx_sub.Name = "cbx_sub"
        cbx_sub.Size = New Size(183, 23)
        cbx_sub.TabIndex = 43
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(23, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 17)
        Label2.TabIndex = 44
        Label2.Text = "Suscripcion"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(12, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 17)
        Label1.TabIndex = 45
        Label1.Text = "Lista de Ejercicios"
        ' 
        ' dgv_lis_final
        ' 
        dgv_lis_final.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_lis_final.Location = New Point(402, 114)
        dgv_lis_final.Name = "dgv_lis_final"
        dgv_lis_final.RowTemplate.Height = 25
        dgv_lis_final.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_lis_final.Size = New Size(372, 360)
        dgv_lis_final.TabIndex = 46
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(402, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 17)
        Label3.TabIndex = 47
        Label3.Text = "Lista Final"
        ' 
        ' cbx_rut
        ' 
        cbx_rut.FormattingEnabled = True
        cbx_rut.Location = New Point(267, 41)
        cbx_rut.Name = "cbx_rut"
        cbx_rut.Size = New Size(183, 23)
        cbx_rut.TabIndex = 48
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(267, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 17)
        Label4.TabIndex = 49
        Label4.Text = "Rutinas"
        ' 
        ' txt_series
        ' 
        txt_series.Location = New Point(201, 136)
        txt_series.Name = "txt_series"
        txt_series.Size = New Size(117, 23)
        txt_series.TabIndex = 51
        ' 
        ' txt_rep
        ' 
        txt_rep.Location = New Point(201, 180)
        txt_rep.Name = "txt_rep"
        txt_rep.Size = New Size(117, 23)
        txt_rep.TabIndex = 52
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(201, 160)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 17)
        Label5.TabIndex = 53
        Label5.Text = "Repeticiones"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ButtonFace
        Label6.Location = New Point(201, 116)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 17)
        Label6.TabIndex = 54
        Label6.Text = "Series"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Gainsboro
        Button1.Location = New Point(456, 41)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 24)
        Button1.TabIndex = 55
        Button1.Text = "Agregar Rutina"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' eliminar_final
        ' 
        eliminar_final.FlatAppearance.BorderSize = 0
        eliminar_final.FlatStyle = FlatStyle.Flat
        eliminar_final.ForeColor = SystemColors.ActiveCaptionText
        eliminar_final.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft
        eliminar_final.IconColor = Color.WhiteSmoke
        eliminar_final.IconFont = FontAwesome.Sharp.IconFont.Auto
        eliminar_final.IconSize = 30
        eliminar_final.Location = New Point(359, 263)
        eliminar_final.Name = "eliminar_final"
        eliminar_final.Size = New Size(37, 35)
        eliminar_final.TabIndex = 57
        eliminar_final.UseVisualStyleBackColor = True
        ' 
        ' cargar_final
        ' 
        cargar_final.FlatAppearance.BorderSize = 0
        cargar_final.FlatStyle = FlatStyle.Flat
        cargar_final.ForeColor = SystemColors.ActiveCaptionText
        cargar_final.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight
        cargar_final.IconColor = Color.WhiteSmoke
        cargar_final.IconFont = FontAwesome.Sharp.IconFont.Auto
        cargar_final.IconSize = 30
        cargar_final.Location = New Point(359, 223)
        cargar_final.Name = "cargar_final"
        cargar_final.Size = New Size(37, 35)
        cargar_final.TabIndex = 56
        cargar_final.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Panel1.Controls.Add(txt_series)
        Panel1.Controls.Add(txt_rep)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(dgv_list_ejer)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(23, 94)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(330, 397)
        Panel1.TabIndex = 58
        ' 
        ' Bbusqueda
        ' 
        Bbusqueda.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        Bbusqueda.FlatAppearance.BorderSize = 0
        Bbusqueda.FlatStyle = FlatStyle.Flat
        Bbusqueda.ForeColor = Color.Gainsboro
        Bbusqueda.Location = New Point(620, 41)
        Bbusqueda.Name = "Bbusqueda"
        Bbusqueda.Size = New Size(108, 24)
        Bbusqueda.TabIndex = 59
        Bbusqueda.Text = "Madamada"
        Bbusqueda.UseVisualStyleBackColor = False
        ' 
        ' Form_Agregar_Ejercicios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(10), CByte(10))
        ClientSize = New Size(798, 562)
        Controls.Add(Bbusqueda)
        Controls.Add(Panel1)
        Controls.Add(eliminar_final)
        Controls.Add(cargar_final)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(cbx_rut)
        Controls.Add(Label3)
        Controls.Add(dgv_lis_final)
        Controls.Add(Label2)
        Controls.Add(cbx_sub)
        MaximumSize = New Size(814, 601)
        MinimumSize = New Size(814, 601)
        Name = "Form_Agregar_Ejercicios"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form_Agregar_Ejercicios"
        CType(dgv_list_ejer, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_lis_final, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgv_list_ejer As DataGridView
    Friend WithEvents cbx_sub As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_lis_final As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents cbx_rut As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_series As TextBox
    Friend WithEvents txt_rep As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents eliminar_final As FontAwesome.Sharp.IconButton
    Friend WithEvents cargar_final As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Bbusqueda As Button
End Class
