<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario_Pagos
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Formulario_Pagos))
        DataGridView1 = New DataGridView()
        Label4 = New Label()
        NumericUpDown1 = New NumericUpDown()
        Label1 = New Label()
        Label2 = New Label()
        cbx_genero = New ComboBox()
        Label3 = New Label()
        btn_agregar = New Button()
        PictureBox1 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 150)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(776, 226)
        DataGridView1.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(12, 130)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 17)
        Label4.TabIndex = 45
        Label4.Text = "Historial de Pagos"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(52, 89)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(87, 23)
        NumericUpDown1.TabIndex = 46
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(12, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 17)
        Label1.TabIndex = 47
        Label1.Text = "Filtrar por :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(12, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 17)
        Label2.TabIndex = 49
        Label2.Text = "Año"
        ' 
        ' cbx_genero
        ' 
        cbx_genero.FormattingEnabled = True
        cbx_genero.Location = New Point(186, 88)
        cbx_genero.Name = "cbx_genero"
        cbx_genero.Size = New Size(112, 23)
        cbx_genero.TabIndex = 50
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Yu Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(145, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 17)
        Label3.TabIndex = 51
        Label3.Text = "Mes"
        ' 
        ' btn_agregar
        ' 
        btn_agregar.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btn_agregar.FlatAppearance.BorderSize = 0
        btn_agregar.FlatStyle = FlatStyle.Flat
        btn_agregar.ForeColor = Color.Gainsboro
        btn_agregar.Location = New Point(709, 408)
        btn_agregar.Name = "btn_agregar"
        btn_agregar.Size = New Size(79, 24)
        btn_agregar.TabIndex = 52
        btn_agregar.Text = "Salir"
        btn_agregar.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 69)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Formulario_Pagos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        ClientSize = New Size(800, 464)
        Controls.Add(PictureBox1)
        Controls.Add(btn_agregar)
        Controls.Add(Label3)
        Controls.Add(cbx_genero)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(NumericUpDown1)
        Controls.Add(Label4)
        Controls.Add(DataGridView1)
        Name = "Formulario_Pagos"
        Text = "Formulario_Pagos"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbx_genero As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_agregar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
