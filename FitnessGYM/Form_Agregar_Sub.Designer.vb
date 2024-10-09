<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Agregar_Sub
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
        Label1 = New Label()
        Label2 = New Label()
        cbx_frecuencia = New ComboBox()
        txt_costo = New TextBox()
        Label3 = New Label()
        btn_agregar = New Button()
        Panel1 = New Panel()
        btn_modificar = New Button()
        btn_eliminar = New Button()
        Label4 = New Label()
        dgv_subs = New DataGridView()
        cbx_sub = New ComboBox()
        Panel1.SuspendLayout()
        CType(dgv_subs, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(12, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 17)
        Label1.TabIndex = 34
        Label1.Text = "Nombre de Suscripcion"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(12, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 17)
        Label2.TabIndex = 37
        Label2.Text = "Frecuencia"
        ' 
        ' cbx_frecuencia
        ' 
        cbx_frecuencia.FormattingEnabled = True
        cbx_frecuencia.Items.AddRange(New Object() {"2 veces por semana", "3 veces por semana", "5 veces por semana", "6 veces por semana"})
        cbx_frecuencia.Location = New Point(12, 98)
        cbx_frecuencia.Name = "cbx_frecuencia"
        cbx_frecuencia.Size = New Size(183, 23)
        cbx_frecuencia.TabIndex = 42
        ' 
        ' txt_costo
        ' 
        txt_costo.Location = New Point(12, 144)
        txt_costo.Name = "txt_costo"
        txt_costo.Size = New Size(183, 23)
        txt_costo.TabIndex = 43
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(12, 124)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 17)
        Label3.TabIndex = 44
        Label3.Text = "Costo"
        ' 
        ' btn_agregar
        ' 
        btn_agregar.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btn_agregar.FlatAppearance.BorderSize = 0
        btn_agregar.FlatStyle = FlatStyle.Flat
        btn_agregar.ForeColor = Color.Gainsboro
        btn_agregar.Location = New Point(116, 182)
        btn_agregar.Name = "btn_agregar"
        btn_agregar.Size = New Size(79, 24)
        btn_agregar.TabIndex = 45
        btn_agregar.Text = "Cargar"
        btn_agregar.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Panel1.Controls.Add(btn_modificar)
        Panel1.Controls.Add(btn_eliminar)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(dgv_subs)
        Panel1.Location = New Point(225, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(344, 262)
        Panel1.TabIndex = 46
        ' 
        ' btn_modificar
        ' 
        btn_modificar.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btn_modificar.FlatAppearance.BorderSize = 0
        btn_modificar.FlatStyle = FlatStyle.Flat
        btn_modificar.ForeColor = Color.Gainsboro
        btn_modificar.Location = New Point(177, 214)
        btn_modificar.Name = "btn_modificar"
        btn_modificar.Size = New Size(79, 24)
        btn_modificar.TabIndex = 62
        btn_modificar.Text = "Modificar"
        btn_modificar.UseVisualStyleBackColor = False
        ' 
        ' btn_eliminar
        ' 
        btn_eliminar.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btn_eliminar.FlatAppearance.BorderSize = 0
        btn_eliminar.FlatStyle = FlatStyle.Flat
        btn_eliminar.ForeColor = Color.Gainsboro
        btn_eliminar.Location = New Point(262, 214)
        btn_eliminar.Name = "btn_eliminar"
        btn_eliminar.Size = New Size(79, 24)
        btn_eliminar.TabIndex = 47
        btn_eliminar.Text = "Eliminar"
        btn_eliminar.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(3, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(154, 17)
        Label4.TabIndex = 47
        Label4.Text = "Lista de Suscripciones"
        ' 
        ' dgv_subs
        ' 
        dgv_subs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_subs.Location = New Point(3, 44)
        dgv_subs.Name = "dgv_subs"
        dgv_subs.RowTemplate.Height = 25
        dgv_subs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_subs.Size = New Size(338, 150)
        dgv_subs.TabIndex = 61
        ' 
        ' cbx_sub
        ' 
        cbx_sub.FormattingEnabled = True
        cbx_sub.Location = New Point(12, 56)
        cbx_sub.Name = "cbx_sub"
        cbx_sub.Size = New Size(183, 23)
        cbx_sub.TabIndex = 47
        ' 
        ' Form_Agregar_Sub
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(10), CByte(10))
        ClientSize = New Size(581, 286)
        Controls.Add(cbx_sub)
        Controls.Add(Panel1)
        Controls.Add(btn_agregar)
        Controls.Add(Label3)
        Controls.Add(txt_costo)
        Controls.Add(cbx_frecuencia)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form_Agregar_Sub"
        Text = "Form_Agregar_Sub"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgv_subs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbx_frecuencia As ComboBox
    Friend WithEvents txt_costo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_agregar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dgv_subs As DataGridView
    Friend WithEvents cbx_sub As ComboBox
End Class
