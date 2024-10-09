<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Cargar_Ejercicio
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
        Label6 = New Label()
        txt_nombre_ejer = New TextBox()
        btn_Cargar = New Button()
        CheckedListBox_condicion = New CheckedListBox()
        Label1 = New Label()
        dgv_ejer = New DataGridView()
        Label2 = New Label()
        Panel1 = New Panel()
        btn_eliminar = New Button()
        CType(dgv_ejer, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ButtonFace
        Label6.Location = New Point(53, 21)
        Label6.Name = "Label6"
        Label6.Size = New Size(118, 17)
        Label6.TabIndex = 57
        Label6.Text = "Nombre Ejercicio"
        ' 
        ' txt_nombre_ejer
        ' 
        txt_nombre_ejer.Location = New Point(53, 41)
        txt_nombre_ejer.Name = "txt_nombre_ejer"
        txt_nombre_ejer.Size = New Size(146, 23)
        txt_nombre_ejer.TabIndex = 56
        ' 
        ' btn_Cargar
        ' 
        btn_Cargar.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btn_Cargar.FlatAppearance.BorderSize = 0
        btn_Cargar.FlatStyle = FlatStyle.Flat
        btn_Cargar.ForeColor = Color.Gainsboro
        btn_Cargar.Location = New Point(224, 281)
        btn_Cargar.Name = "btn_Cargar"
        btn_Cargar.Size = New Size(79, 24)
        btn_Cargar.TabIndex = 55
        btn_Cargar.Text = "Cargar"
        btn_Cargar.UseVisualStyleBackColor = False
        ' 
        ' CheckedListBox_condicion
        ' 
        CheckedListBox_condicion.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        CheckedListBox_condicion.CheckOnClick = True
        CheckedListBox_condicion.Font = New Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        CheckedListBox_condicion.ForeColor = Color.WhiteSmoke
        CheckedListBox_condicion.FormattingEnabled = True
        CheckedListBox_condicion.Location = New Point(53, 87)
        CheckedListBox_condicion.Name = "CheckedListBox_condicion"
        CheckedListBox_condicion.Size = New Size(250, 188)
        CheckedListBox_condicion.TabIndex = 58
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(53, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 17)
        Label1.TabIndex = 59
        Label1.Text = "Asociar Condicion"
        ' 
        ' dgv_ejer
        ' 
        dgv_ejer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_ejer.Location = New Point(12, 30)
        dgv_ejer.Name = "dgv_ejer"
        dgv_ejer.RowTemplate.Height = 25
        dgv_ejer.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_ejer.Size = New Size(424, 215)
        dgv_ejer.TabIndex = 60
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(12, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 17)
        Label2.TabIndex = 61
        Label2.Text = "Lista Final"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Panel1.Controls.Add(btn_eliminar)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(dgv_ejer)
        Panel1.Location = New Point(328, 21)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(451, 304)
        Panel1.TabIndex = 62
        ' 
        ' btn_eliminar
        ' 
        btn_eliminar.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btn_eliminar.FlatAppearance.BorderSize = 0
        btn_eliminar.FlatStyle = FlatStyle.Flat
        btn_eliminar.ForeColor = Color.Gainsboro
        btn_eliminar.Location = New Point(357, 260)
        btn_eliminar.Name = "btn_eliminar"
        btn_eliminar.Size = New Size(79, 24)
        btn_eliminar.TabIndex = 61
        btn_eliminar.Text = "Eliminar"
        btn_eliminar.UseVisualStyleBackColor = False
        ' 
        ' Form_Cargar_Ejercicio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        ClientSize = New Size(795, 337)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(CheckedListBox_condicion)
        Controls.Add(Label6)
        Controls.Add(txt_nombre_ejer)
        Controls.Add(btn_Cargar)
        Location = New Point(239, 324)
        MaximumSize = New Size(811, 376)
        MinimumSize = New Size(811, 376)
        Name = "Form_Cargar_Ejercicio"
        Text = "Form_Cargar_Ejercicio"
        CType(dgv_ejer, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txt_nombre_ejer As TextBox
    Friend WithEvents btn_Cargar As Button
    Friend WithEvents CheckedListBox_condicion As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_ejer As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_eliminar As Button
End Class
