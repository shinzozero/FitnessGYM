<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_lista_socios
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
        DataGridView1 = New DataGridView()
        txt_nombres = New TextBox()
        Label1 = New Label()
        btn_modificar = New Button()
        Button1 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 63)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(776, 275)
        DataGridView1.TabIndex = 1
        ' 
        ' txt_nombres
        ' 
        txt_nombres.Location = New Point(314, 22)
        txt_nombres.Name = "txt_nombres"
        txt_nombres.Size = New Size(183, 23)
        txt_nombres.TabIndex = 34
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(208, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 17)
        Label1.TabIndex = 48
        Label1.Text = "Filtrar por DNI"
        ' 
        ' btn_modificar
        ' 
        btn_modificar.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btn_modificar.FlatAppearance.BorderSize = 0
        btn_modificar.FlatStyle = FlatStyle.Flat
        btn_modificar.ForeColor = Color.Gainsboro
        btn_modificar.Location = New Point(618, 361)
        btn_modificar.Name = "btn_modificar"
        btn_modificar.Size = New Size(79, 24)
        btn_modificar.TabIndex = 53
        btn_modificar.Text = "Modificar"
        btn_modificar.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Gainsboro
        Button1.Location = New Point(709, 361)
        Button1.Name = "Button1"
        Button1.Size = New Size(79, 24)
        Button1.TabIndex = 54
        Button1.Text = "Eliminar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form_lista_socios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        ClientSize = New Size(800, 397)
        Controls.Add(Button1)
        Controls.Add(btn_modificar)
        Controls.Add(Label1)
        Controls.Add(txt_nombres)
        Controls.Add(DataGridView1)
        MaximumSize = New Size(816, 436)
        MinimumSize = New Size(816, 436)
        Name = "Form_lista_socios"
        Text = "Form_lista_socios"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_nombres As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_modificar As Button
    Friend WithEvents Button1 As Button
End Class
