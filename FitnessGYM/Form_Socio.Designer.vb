<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Socio
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
        Label3 = New Label()
        Label4 = New Label()
        txt_nombre = New TextBox()
        txt_frecuencia = New TextBox()
        txt_sub = New TextBox()
        txt_vencimiento = New TextBox()
        btn_detalle = New Button()
        btn_estado = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(24, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 17)
        Label1.TabIndex = 0
        Label1.Text = "Nombre y Apellido"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(24, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 17)
        Label2.TabIndex = 2
        Label2.Text = "Frecuencia"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(24, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 17)
        Label3.TabIndex = 3
        Label3.Text = "Suscripción"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(24, 167)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 17)
        Label4.TabIndex = 4
        Label4.Text = "Vencimiento"
        ' 
        ' txt_nombre
        ' 
        txt_nombre.ForeColor = SystemColors.Control
        txt_nombre.Location = New Point(53, 49)
        txt_nombre.Name = "txt_nombre"
        txt_nombre.Size = New Size(277, 23)
        txt_nombre.TabIndex = 5
        ' 
        ' txt_frecuencia
        ' 
        txt_frecuencia.ForeColor = SystemColors.Control
        txt_frecuencia.Location = New Point(53, 141)
        txt_frecuencia.Name = "txt_frecuencia"
        txt_frecuencia.Size = New Size(277, 23)
        txt_frecuencia.TabIndex = 6
        ' 
        ' txt_sub
        ' 
        txt_sub.ForeColor = SystemColors.Control
        txt_sub.Location = New Point(53, 95)
        txt_sub.Name = "txt_sub"
        txt_sub.Size = New Size(277, 23)
        txt_sub.TabIndex = 7
        ' 
        ' txt_vencimiento
        ' 
        txt_vencimiento.ForeColor = SystemColors.Control
        txt_vencimiento.Location = New Point(53, 187)
        txt_vencimiento.Name = "txt_vencimiento"
        txt_vencimiento.Size = New Size(277, 23)
        txt_vencimiento.TabIndex = 8
        ' 
        ' btn_detalle
        ' 
        btn_detalle.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btn_detalle.FlatAppearance.BorderSize = 0
        btn_detalle.FlatStyle = FlatStyle.Flat
        btn_detalle.Font = New Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_detalle.ForeColor = Color.Gainsboro
        btn_detalle.Location = New Point(382, 14)
        btn_detalle.Name = "btn_detalle"
        btn_detalle.Size = New Size(79, 24)
        btn_detalle.TabIndex = 9
        btn_detalle.Text = "Detalles"
        btn_detalle.UseVisualStyleBackColor = False
        ' 
        ' btn_estado
        ' 
        btn_estado.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btn_estado.Dock = DockStyle.Bottom
        btn_estado.FlatAppearance.BorderSize = 0
        btn_estado.FlatStyle = FlatStyle.Flat
        btn_estado.Font = New Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_estado.ForeColor = Color.Gainsboro
        btn_estado.Location = New Point(0, 245)
        btn_estado.Name = "btn_estado"
        btn_estado.Size = New Size(473, 87)
        btn_estado.TabIndex = 10
        btn_estado.Text = "Estado"
        btn_estado.UseVisualStyleBackColor = False
        ' 
        ' Form_Socio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(10), CByte(10))
        ClientSize = New Size(473, 332)
        Controls.Add(btn_estado)
        Controls.Add(btn_detalle)
        Controls.Add(txt_vencimiento)
        Controls.Add(txt_sub)
        Controls.Add(txt_frecuencia)
        Controls.Add(txt_nombre)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form_Socio"
        Text = "Form_Socio"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_frecuencia As TextBox
    Friend WithEvents txt_sub As TextBox
    Friend WithEvents txt_vencimiento As TextBox
    Friend WithEvents btn_detalle As Button
    Friend WithEvents btn_estado As Button
End Class
