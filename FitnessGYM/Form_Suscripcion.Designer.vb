<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Suscripcion
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
        Panel1 = New Panel()
        Label1 = New Label()
        DataTimePicker_Sub = New DateTimePicker()
        cbx_sub = New ComboBox()
        btn_finalizar = New Button()
        Panel2 = New Panel()
        CheckedListBox_sub = New CheckedListBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(10), CByte(10), CByte(10))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(DataTimePicker_Sub)
        Panel1.Controls.Add(cbx_sub)
        Panel1.Controls.Add(btn_finalizar)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(725, 563)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(39, 410)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 17)
        Label1.TabIndex = 44
        Label1.Text = "Fecha de Vencimiento"
        ' 
        ' DataTimePicker_Sub
        ' 
        DataTimePicker_Sub.Location = New Point(39, 432)
        DataTimePicker_Sub.Name = "DataTimePicker_Sub"
        DataTimePicker_Sub.Size = New Size(200, 23)
        DataTimePicker_Sub.TabIndex = 43
        ' 
        ' cbx_sub
        ' 
        cbx_sub.FormattingEnabled = True
        cbx_sub.Location = New Point(39, 44)
        cbx_sub.Name = "cbx_sub"
        cbx_sub.Size = New Size(291, 23)
        cbx_sub.TabIndex = 42
        ' 
        ' btn_finalizar
        ' 
        btn_finalizar.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btn_finalizar.FlatAppearance.BorderSize = 0
        btn_finalizar.FlatStyle = FlatStyle.Flat
        btn_finalizar.ForeColor = Color.Gainsboro
        btn_finalizar.Location = New Point(606, 459)
        btn_finalizar.Name = "btn_finalizar"
        btn_finalizar.Size = New Size(79, 24)
        btn_finalizar.TabIndex = 27
        btn_finalizar.Text = "Finalizar"
        btn_finalizar.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Panel2.Controls.Add(CheckedListBox_sub)
        Panel2.Location = New Point(39, 73)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(646, 325)
        Panel2.TabIndex = 0
        ' 
        ' CheckedListBox_sub
        ' 
        CheckedListBox_sub.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        CheckedListBox_sub.CheckOnClick = True
        CheckedListBox_sub.Font = New Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckedListBox_sub.ForeColor = Color.WhiteSmoke
        CheckedListBox_sub.FormattingEnabled = True
        CheckedListBox_sub.Location = New Point(3, 24)
        CheckedListBox_sub.Name = "CheckedListBox_sub"
        CheckedListBox_sub.Size = New Size(640, 228)
        CheckedListBox_sub.TabIndex = 47
        ' 
        ' Form_Suscripcion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(10), CByte(10))
        ClientSize = New Size(725, 563)
        Controls.Add(Panel1)
        ForeColor = SystemColors.ControlText
        Name = "Form_Suscripcion"
        Text = "Form_Suscripcion"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_finalizar As Button
    Friend WithEvents cbx_sub As ComboBox
    Friend WithEvents CheckedListBox_sub As CheckedListBox
    Friend WithEvents DataTimePicker_Sub As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
