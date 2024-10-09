Imports MySql.Data.MySqlClient

Public Class Form_Agregar_Ejercicios
    Private Sub Form_Agregar_Ejercicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSuscripciones()
        LlenarComboBoxSuscripciones()
        EstilizarDataGridView()
        CargarEjercicios()


    End Sub
    Private Sub dgv_lis_final_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_lis_final.SelectionChanged

    End Sub
    Private Sub LlenarComboBoxSuscripciones()
        ' Llenar el ComboBox de suscripciones con los datos de la base de datos
        Try
            Conexiones()

            Dim consulta As String = "SELECT id_suscripcion, nombre_suscripcion FROM suscripcion"
            Comando = New MySqlCommand(consulta, ConexionMySQL)
            Dim DataReader As MySqlDataReader = Comando.ExecuteReader()

            Dim dtSuscripciones As New DataTable()
            dtSuscripciones.Load(DataReader)

            cbx_sub.DataSource = dtSuscripciones
            cbx_sub.DisplayMember = "nombre_suscripcion"
            cbx_sub.ValueMember = "id_suscripcion"

            DataReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar las suscripciones: " & ex.Message)
        Finally
            ConexionMySQL.Close()
        End Try
    End Sub
    Private Sub CargarSuscripciones()
        Conexiones()

        Comando.CommandText = "SELECT id_suscripcion, nombre_suscripcion FROM suscripcion"
        Comando.CommandType = CommandType.Text
        Comando.Connection = ConexionMySQL

        DataReader = Comando.ExecuteReader
        Dim dt1 As New DataTable
        dt1.Load(DataReader)
        Me.cbx_sub.DataSource = dt1
        Me.cbx_sub.DisplayMember = "nombre_suscripcion"
        Me.cbx_sub.ValueMember = "id_suscripcion"

        Dim dr1 As DataRow

        dr1 = dt1.NewRow
        dr1("id_suscripcion") = 0
        dr1("nombre_suscripcion") = "Seleccione una suscripcion"
        dt1.Rows.InsertAt(dr1, 0)
        Me.cbx_sub.SelectedIndex = 0
        Me.cbx_sub.Enabled = True
        DataReader.Close()

        ConexionMySQL.Close()
    End Sub
    Private Sub CargarEjercicios()
        ' Realizar la consulta SQL para cargar los datos en el DataGridView
        Try
            Conexiones()

            Dim consulta As String = "SELECT id_ejercicio,nombre_ejercicio  FROM ejercicios"

            Comando = New MySqlCommand(consulta, ConexionMySQL)
            Dim DataAdapter As New MySqlDataAdapter(Comando)
            Dim DataTable As New DataTable()
            DataAdapter.Fill(DataTable)

            dgv_list_ejer.DataSource = DataTable

        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub
    Private Sub EstilizarDataGridView()
        ' Establecer el color de fondo y de las líneas
        dgv_list_ejer.BackgroundColor = Color.Gray
        dgv_lis_final.BackgroundColor = Color.Gray
        dgv_list_ejer.GridColor = Color.DarkGray
        dgv_lis_final.GridColor = Color.DarkGray


        ' Ocultar encabezados de columna y de fila
        dgv_list_ejer.RowHeadersVisible = False
        dgv_list_ejer.ColumnHeadersVisible = False
        dgv_lis_final.RowHeadersVisible = False
        'dgv_lis_final.ColumnHeadersVisible = False

        ' Establecer el color de las celdas
        dgv_list_ejer.DefaultCellStyle.BackColor = Color.Gray
        dgv_list_ejer.DefaultCellStyle.ForeColor = Color.White
        dgv_lis_final.DefaultCellStyle.BackColor = Color.Gray
        dgv_lis_final.DefaultCellStyle.ForeColor = Color.White
        ' Ajustar las columnas al ancho del DataGridView
        dgv_list_ejer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_lis_final.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_modulo_ejercicios.Show()
        'Form_Cargar_Rutinas.Show()
    End Sub
    Private Sub txt_dni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_series.KeyPress, txt_rep.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Evita que se escriba cualquier carácter que no sea un número o control
        End If
    End Sub
    Private Sub cargar_final_Click(sender As Object, e As EventArgs) Handles cargar_final.Click

    End Sub


    Private Sub cbx_rut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_rut.SelectedIndexChanged
        ' Verificar que haya algo seleccionado en el ComboBox
        If cbx_rut.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrEmpty(cbx_rut.SelectedValue.ToString()) Then
            ' Obtener el ID de la rutina seleccionada
            Dim idRutina As Integer
            If Integer.TryParse(cbx_rut.SelectedValue.ToString(), idRutina) Then
                ' Realizar la consulta SQL para obtener los ejercicios asociados a la rutina seleccionada
                Try
                    Conexiones()

                    Dim consulta As String = "SELECT e.id_ejercicio AS ID_Ejercicio, e.nombre_ejercicio AS Nombre_Ejercicio, " &
        "re.repeticiones AS Repeticiones, re.series AS Series " &
        "FROM rutina_ejercicios re " &
        "INNER JOIN ejercicios e ON re.id_ejercicio = e.id_ejercicio " &
        "WHERE re.id_rutina = @id_rutina"

                    Comando = New MySqlCommand(consulta, ConexionMySQL)
                    Comando.Parameters.AddWithValue("@id_rutina", idRutina)
                    Dim DataAdapter As New MySqlDataAdapter(Comando)
                    Dim DataTable As New DataTable()
                    DataAdapter.Fill(DataTable)

                    If DataTable.Rows.Count = 0 Then
                        ' Limpiar el DataGridView antes de agregar un nuevo mensaje
                        dgv_lis_final.DataSource = Nothing

                        ' Crear un nuevo DataTable solo para el mensaje
                        Dim mensajeTable As New DataTable()
                        mensajeTable.Columns.Add("Mensaje")

                        ' Agregar la fila con el mensaje
                        mensajeTable.Rows.Add("Esta rutina no posee ejercicios")

                        ' Mostrar el DataTable con el mensaje en el DataGridView
                        dgv_lis_final.DataSource = mensajeTable
                    Else
                        ' Si hay datos, mostrar el DataTable normal en el DataGridView
                        dgv_lis_final.DataSource = DataTable
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error al cargar los ejercicios de la rutina: " & ex.Message)
                Finally
                    ConexionMySQL.Close()
                End Try
            Else
                'MessageBox.Show("El valor seleccionado no es un ID de rutina válido.")
            End If
        Else
            MessageBox.Show("No hay ninguna rutina seleccionada.")
        End If
    End Sub


    Private Sub cbx_subs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_sub.SelectedIndexChanged
        ' Al seleccionar una suscripción, filtrar las rutinas asociadas y llenar el ComboBox de rutinas
        Try
            Dim idSuscripcion As Integer = Convert.ToInt32(cbx_sub.SelectedValue)

            Conexiones()

            Dim consulta As String = "SELECT sr.id_rutina, r.nombre_rutina " &
                                     "FROM suscripcion_rutina sr " &
                                     "INNER JOIN rutinas r ON sr.id_rutina = r.id_rutina " &
                                     "WHERE sr.id_suscripcion = @id_suscripcion"

            Comando = New MySqlCommand(consulta, ConexionMySQL)
            Comando.Parameters.AddWithValue("@id_suscripcion", idSuscripcion)
            Dim DataReader As MySqlDataReader = Comando.ExecuteReader()

            Dim dtRutinas As New DataTable()
            dtRutinas.Load(DataReader)

            cbx_rut.DataSource = dtRutinas
            cbx_rut.DisplayMember = "nombre_rutina"
            cbx_rut.ValueMember = "id_rutina"

            DataReader.Close()
        Catch ex As Exception
            'MessageBox.Show("Error al cargar las rutinas de la suscripción: " & ex.Message)
        Finally
            ConexionMySQL.Close()
        End Try
    End Sub

    Private Sub eliminar_final_Click(sender As Object, e As EventArgs) Handles eliminar_final.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Bbusqueda.Click


    End Sub
End Class