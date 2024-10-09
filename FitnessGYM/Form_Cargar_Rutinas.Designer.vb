<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Cargar_Rutinas
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
        dgv_ruti = New DataGridView()
        Panel1 = New Panel()
        Label2 = New Label()
        btn_eliminar = New Button()
        txt_nombre_rutina = New TextBox()
        Label1 = New Label()
        btn_cargar_ruti = New Button()
        cbx_sub = New ComboBox()
        Label3 = New Label()
        CType(dgv_ruti, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgv_ruti
        ' 
        dgv_ruti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_ruti.Location = New Point(19, 33)
        dgv_ruti.Name = "dgv_ruti"
        dgv_ruti.RowTemplate.Height = 25
        dgv_ruti.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_ruti.Size = New Size(258, 185)
        dgv_ruti.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btn_eliminar)
        Panel1.Controls.Add(dgv_ruti)
        Panel1.Location = New Point(279, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(291, 291)
        Panel1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(19, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 17)
        Label2.TabIndex = 50
        Label2.Text = "Lista de las Rutinas"
        ' 
        ' btn_eliminar
        ' 
        btn_eliminar.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btn_eliminar.FlatAppearance.BorderSize = 0
        btn_eliminar.FlatStyle = FlatStyle.Flat
        btn_eliminar.ForeColor = Color.Gainsboro
        btn_eliminar.Location = New Point(198, 246)
        btn_eliminar.Name = "btn_eliminar"
        btn_eliminar.Size = New Size(79, 24)
        btn_eliminar.TabIndex = 48
        btn_eliminar.Text = "Eliminar"
        btn_eliminar.UseVisualStyleBackColor = False
        ' 
        ' txt_nombre_rutina
        ' 
        txt_nombre_rutina.Location = New Point(12, 45)
        txt_nombre_rutina.Name = "txt_nombre_rutina"
        txt_nombre_rutina.Size = New Size(163, 23)
        txt_nombre_rutina.TabIndex = 41
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(12, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 17)
        Label1.TabIndex = 40
        Label1.Text = "Nombre de la Rutina"
        ' 
        ' btn_cargar_ruti
        ' 
        btn_cargar_ruti.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btn_cargar_ruti.FlatAppearance.BorderSize = 0
        btn_cargar_ruti.FlatStyle = FlatStyle.Flat
        btn_cargar_ruti.ForeColor = Color.Gainsboro
        btn_cargar_ruti.Location = New Point(12, 135)
        btn_cargar_ruti.Name = "btn_cargar_ruti"
        btn_cargar_ruti.Size = New Size(79, 24)
        btn_cargar_ruti.TabIndex = 49
        btn_cargar_ruti.Text = "Cargar"
        btn_cargar_ruti.UseVisualStyleBackColor = False
        ' 
        ' cbx_sub
        ' 
        cbx_sub.FormattingEnabled = True
        cbx_sub.Location = New Point(12, 93)
        cbx_sub.Name = "cbx_sub"
        cbx_sub.Size = New Size(163, 23)
        cbx_sub.TabIndex = 50
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(12, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(163, 17)
        Label3.TabIndex = 51
        Label3.Text = "Seleccionar Suscripción"
        ' 
        ' Form_Cargar_Rutinas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(10), CByte(10))
        ClientSize = New Size(582, 315)
        Controls.Add(Label3)
        Controls.Add(cbx_sub)
        Controls.Add(btn_cargar_ruti)
        Controls.Add(txt_nombre_rutina)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        MaximumSize = New Size(598, 354)
        MinimumSize = New Size(598, 354)
        Name = "Form_Cargar_Rutinas"
        Text = "Form_Cargar_Rutinas"
        CType(dgv_ruti, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgv_ruti As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents txt_nombre_rutina As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cargar_ruti As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cbx_sub As ComboBox
    Friend WithEvents Label3 As Label
End Class
