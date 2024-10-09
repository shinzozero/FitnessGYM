Imports MySql.Data.MySqlClient

Public Class Form_Cargar_Ejercicio
    Private Sub txt_nombres_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre_ejer.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True ' Evita que se escriba cualquier carácter que no sea letra o control
        End If
    End Sub
    Private Sub btn_cargar_Click(sender As Object, e As EventArgs) Handles btn_Cargar.Click
        CargarDatos()

        Try
            'Dim idUsuario As Integer = -1 ' Variable para almacenar el id_user insertado
            'Dim dniY As Integer = 0
            Conexiones()

            If Not String.IsNullOrEmpty(txt_nombre_ejer.Text.Trim()) Then
                If CheckedListBox_condicion.CheckedItems.Count > 0 Then
                    Dim consulta As String

                    consulta = " INSERT INTO ejercicios (nombre_ejercicio)VALUE" &
                               "(@nombre_ejercicio);"
                    '('" & DateTimePicker1.Text & "')
                    Comando.Parameters.Add("@nombre_ejercicio", MySqlDbType.VarChar).Value = Me.txt_nombre_ejer.Text



                    Comando.CommandType = CommandType.Text
                    Comando.CommandText = consulta
                    Comando.Connection = ConexionMySQL

                    If Comando.ExecuteNonQuery Then
                        'limpiamos todos los campos 

                        'Me.txt_nombre_ejer.Clear()
                        CargarDatos()
                    Else
                        MessageBox.Show("Registro insertado NO correcto", "Registro Informa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        'MS.Dispose()
                    End If
                    Comando.Parameters.Clear()



                    Dim id_ejer As Integer

                    Dim consultaDNI As String = "SELECT id_ejercicio FROM ejercicios WHERE nombre_ejercicio = '" & txt_nombre_ejer.Text & "';"
                    Comando.Parameters.Clear()
                    Comando.CommandText = consultaDNI
                    'Comando.Parameters.Add("@dniY", MySqlDbType.Int64).Value = Convert.ToInt64(dniY)
                    'idUser = Convert.ToInt32(consultaDNI)
                    '#####################

                    '#############

                    Try
                        ' Ejecutar la consulta SQL para obtener idUser
                        Dim id_ejercicio As Object = Comando.ExecuteScalar()

                        If id_ejercicio IsNot Nothing AndAlso Not IsDBNull(id_ejercicio) Then
                            id_ejer = Convert.ToInt32(id_ejercicio)
                            'MsgBox(idUser)
                            ' MsgBox(idUserQuery)
                        End If

                        ' Insertar registros en user_condi para cada elemento seleccionado en CheckedListBox

                        Dim selectedConditionIDs As New List(Of Integer)()


                        For i As Integer = 0 To CheckedListBox_condicion.Items.Count - 1
                            If CheckedListBox_condicion.GetItemChecked(i) Then ' Verificar si la casilla está marcada
                                Dim selectedDescription As String = CheckedListBox_condicion.Items(i).ToString()

                                ' Realizar una consulta para obtener el ID de la descripción seleccionada
                                Dim consultaID As String = "SELECT id_condiciones_fisicas FROM condiciones_fisicas WHERE descripcion_condicion = @descripcion;"
                                Comando = New MySql.Data.MySqlClient.MySqlCommand(consultaID, ConexionMySQL)
                                Comando.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = selectedDescription

                                Try
                                    Dim idCondicion As Integer = Convert.ToInt32(Comando.ExecuteScalar())
                                    selectedConditionIDs.Add(idCondicion) ' Agregar el ID a la lista
                                Catch ex As Exception
                                    MsgBox("Error al obtener el ID de la condición física: " & ex.Message)
                                End Try
                            End If
                        Next
                        ' Insertar registros en user_condi para cada ID de condición física seleccionada
                        For Each conditionID As Integer In selectedConditionIDs
                            'If id_ejer <> 0 AndAlso conditionID <> 0 Then
                            Try
                                Dim insertar_consulta As String = "INSERT INTO condi_ejercicio (id_ejercicio, id_condiciones_fisicas) VALUES (@id_ejercicio, @id_condicion)"

                                Comando.Parameters.Clear()
                                Comando.CommandType = CommandType.Text
                                Comando.CommandText = insertar_consulta
                                Comando.Connection = ConexionMySQL

                                Comando.Parameters.Add("@id_ejercicio", MySqlDbType.Int32).Value = id_ejer
                                Comando.Parameters.Add("@id_condicion", MySqlDbType.Int32).Value = conditionID

                                Comando.ExecuteNonQuery()
                                'MsgBox("Inserción exitosa en la tablita :3")
                            Catch ex As Exception
                                MsgBox("Error al insertar en : " & ex.Message)
                            End Try
                            'Else MessageBox.Show("No se puede efectuar la carga. Asegúrese de seleccionar al menos un dato.")
                            'End If
                        Next
                        txt_nombre_ejer.Clear()
                        For i As Integer = 0 To CheckedListBox_condicion.Items.Count - 1
                            CheckedListBox_condicion.SetItemChecked(i, False)
                        Next
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    MessageBox.Show("No se puede efectuar la carga. Asegúrese de seleccionar al menos un dato en el CheckedListBox.")
                End If
            Else
                MessageBox.Show("No se puede efectuar la carga. Asegúrese de escribir un nombre en el campo de texto.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Comando.Parameters.Clear()
    End Sub
    Private Sub CargarDatos()
        ' Realizar la consulta SQL para cargar los datos en el DataGridView
        Try
            Conexiones()

            Dim consulta As String = "SELECT id_ejercicio, nombre_ejercicio FROM ejercicios"

            Comando = New MySqlCommand(consulta, ConexionMySQL)
            Dim DataAdapter As New MySqlDataAdapter(Comando)
            Dim DataTable As New DataTable()
            DataAdapter.Fill(DataTable)

            dgv_ejer.DataSource = DataTable

        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub
    Private Sub EstilizarDataGridView()
        ' Establecer el color de fondo y de las líneas
        dgv_ejer.BackgroundColor = Color.Gray

        dgv_ejer.GridColor = Color.DarkGray



        ' Ocultar encabezados de columna y de fila
        dgv_ejer.RowHeadersVisible = False
        dgv_ejer.ColumnHeadersVisible = False

        ' Establecer el color de las celdas
        dgv_ejer.DefaultCellStyle.BackColor = Color.Gray
        dgv_ejer.DefaultCellStyle.ForeColor = Color.White

        ' Ajustar las columnas al ancho del DataGridView
        dgv_ejer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub Form_Cargar_Ejercicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarDatos()
        EstilizarDataGridView()


        Conexiones()
        'aca lo que hace es hacer una consulta para cargar el combo list box
        Dim consulta As String = "SELECT descripcion_condicion FROM condiciones_fisicas;"
        ' Crear el comando y asignar la consulta y la conexión
        Comando = New MySql.Data.MySqlClient.MySqlCommand(consulta, ConexionMySQL)

        ' Crear un DataReader para leer los resultados de la consulta
        DataReader = Comando.ExecuteReader()

        While DataReader.Read()
            ' Agregar cada elemento al CheckedListBox
            CheckedListBox_condicion.Items.Add(DataReader.GetString(0))
        End While

        ' Cerrar el DataReader después de usarlo
        DataReader.Close()
    End Sub



    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

        If dgv_ejer.SelectedRows.Count > 0 Then
            ' Obtener el valor de la columna 'id_ejercicio' de la fila seleccionada
            Dim idEjercicio As Integer = Convert.ToInt32(dgv_ejer.SelectedRows(0).Cells("id_ejercicio").Value)

            ' Eliminar el registro de la base de datos
            Try
                Conexiones()

                ' Consulta para eliminar el ejercicio
                Dim consultaDelete As String = "DELETE FROM ejercicios WHERE id_ejercicio = @id"

                Comando = New MySqlCommand(consultaDelete, ConexionMySQL)
                Comando.Parameters.AddWithValue("@id", idEjercicio)
                'Comando.Parameters.Add("@id", MySqlDbType.VarChar).Value = idEjercicio
                Comando.ExecuteNonQuery()

                ' También eliminar en la tabla condi_ejer (suponiendo que esta tabla tiene una columna id_ejercicio)
                Dim consultaDeleteCondiEjer As String = "DELETE FROM condi_ejercicio WHERE id_ejercicio = @id"

                Comando = New MySqlCommand(consultaDeleteCondiEjer, ConexionMySQL)
                Comando.Parameters.Add("@id", MySqlDbType.VarChar).Value = idEjercicio
                Comando.ExecuteNonQuery()

                ' Volver a cargar los datos en el DataGridView después de eliminar
                CargarDatos()

            Catch ex As Exception
                MessageBox.Show("Error al eliminar el ejercicio: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Selecciona un ejercicio para eliminar.")
        End If
    End Sub
End Class