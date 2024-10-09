<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Actualizar_Cobro
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
        lbl_nombre = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lbl_sub = New Label()
        DateTimePicker1 = New DateTimePicker()
        btn_cobrar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(12, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 17)
        Label1.TabIndex = 1
        Label1.Text = "Socio:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Yu Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(139, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 26)
        Label2.TabIndex = 2
        Label2.Text = "Pago de Cuota"
        ' 
        ' lbl_nombre
        ' 
        lbl_nombre.AutoSize = True
        lbl_nombre.BackColor = Color.Transparent
        lbl_nombre.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_nombre.ForeColor = SystemColors.ButtonFace
        lbl_nombre.Location = New Point(66, 62)
        lbl_nombre.Name = "lbl_nombre"
        lbl_nombre.Size = New Size(59, 17)
        lbl_nombre.TabIndex = 3
        lbl_nombre.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(12, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 17)
        Label3.TabIndex = 4
        Label3.Text = "Suscripcion:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(12, 139)
        Label4.Name = "Label4"
        Label4.Size = New Size(164, 17)
        Label4.TabIndex = 5
        Label4.Text = "Elige el NUEVO periodo:"
        ' 
        ' lbl_sub
        ' 
        lbl_sub.AutoSize = True
        lbl_sub.BackColor = Color.Transparent
        lbl_sub.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_sub.ForeColor = SystemColors.ButtonFace
        lbl_sub.Location = New Point(105, 91)
        lbl_sub.Name = "lbl_sub"
        lbl_sub.Size = New Size(83, 17)
        lbl_sub.TabIndex = 6
        lbl_sub.Text = "Suscripcion"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(12, 159)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(183, 23)
        DateTimePicker1.TabIndex = 49
        ' 
        ' btn_cobrar
        ' 
        btn_cobrar.BackColor = Color.ForestGreen
        btn_cobrar.FlatAppearance.BorderSize = 0
        btn_cobrar.FlatStyle = FlatStyle.Flat
        btn_cobrar.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_cobrar.ForeColor = Color.Black
        btn_cobrar.Location = New Point(306, 212)
        btn_cobrar.Name = "btn_cobrar"
        btn_cobrar.Size = New Size(95, 43)
        btn_cobrar.TabIndex = 50
        btn_cobrar.Text = "Cobrar"
        btn_cobrar.UseVisualStyleBackColor = False
        ' 
        ' Form_Actualizar_Cobro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(10), CByte(10))
        ClientSize = New Size(433, 267)
        Controls.Add(btn_cobrar)
        Controls.Add(DateTimePicker1)
        Controls.Add(lbl_sub)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(lbl_nombre)
        Controls.Add(Label2)
        Controls.Add(Label1)
        MaximumSize = New Size(449, 306)
        MinimumSize = New Size(449, 306)
        Name = "Form_Actualizar_Cobro"
        Text = "Form_Actualizar_Cobro"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_sub As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btn_cobrar As Button
End Class
