Imports MySql.Data.MySqlClient

Public Class Form_modulo_ejercicios
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CargarEjercicios()
    End Sub

    Private Sub Form_modulo_ejercicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEjercicios()
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
    Private Sub cbx_rut_SelectedIndexChanged(sender As Object, e As EventArgs)
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
                        dgv_list_final.DataSource = Nothing

                        ' Crear un nuevo DataTable solo para el mensaje
                        Dim mensajeTable As New DataTable()
                        mensajeTable.Columns.Add("Mensaje")

                        ' Agregar la fila con el mensaje
                        mensajeTable.Rows.Add("Esta rutina no posee ejercicios")

                        ' Mostrar el DataTable con el mensaje en el DataGridView
                        dgv_list_final.DataSource = mensajeTable
                    Else
                        ' Si hay datos, mostrar el DataTable normal en el DataGridView
                        dgv_list_final.DataSource = DataTable
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




    Private Sub ObtenerUltimoUsuario()
        Try
            Conexiones()

            ' Consulta para obtener el último id_user insertado
            Dim consultaIdUsuario As String = "SELECT MAX(id_user) AS UltimoUsuario FROM users"
            Comando = New MySqlCommand(consultaIdUsuario, ConexionMySQL)
            Dim ultimoIdUsuario As Integer = Convert.ToInt32(Comando.ExecuteScalar())

            ' Consulta para obtener el nombre y apellido del último usuario
            Dim consultaNombreApellido As String = "SELECT nombre, apellido FROM users WHERE id_user = @id_user"
            Comando = New MySqlCommand(consultaNombreApellido, ConexionMySQL)
            Comando.Parameters.AddWithValue("@id_user", ultimoIdUsuario)

            Dim reader As MySqlDataReader = Comando.ExecuteReader()
            If reader.Read() Then
                ' Actualizar el label con el nombre y apellido del usuario
                lbl_nombre.Text = reader("nombre").ToString() & " " & reader("apellido").ToString()
            End If
            reader.Close()

            ' Consulta para obtener las condiciones físicas del último usuario
            Dim consultaCondiciones As String = "SELECT cf.nombre_condicion AS Condicion " &
                                           "FROM condi_user cu " &
                                           "INNER JOIN condiciones_fisicas cf ON cu.id_condiciones_fisicas = cf.id_condiciones_fisicas " &
                                           "WHERE cu.id_user = @id_user"

            Comando = New MySqlCommand(consultaCondiciones, ConexionMySQL)
            Comando.Parameters.AddWithValue("@id_user", ultimoIdUsuario)
            Dim DataAdapter As New MySqlDataAdapter(Comando)
            Dim DataTable As New DataTable()
            DataAdapter.Fill(DataTable)

            dgv_condiciones.DataSource = DataTable

        Catch ex As Exception
            MessageBox.Show("Error al obtener el último usuario y sus condiciones físicas: " & ex.Message)
        Finally
            ConexionMySQL.Close()
        End Try
    End Sub



    Private Sub ActualizarNombreUsuario(idUsuario As Integer)
        Try
            Conexiones()

            Dim consultaNombre As String = "SELECT nombre, apellido FROM users WHERE id_user = @id_user"
            Comando = New MySqlCommand(consultaNombre, ConexionMySQL)
            Comando.Parameters.AddWithValue("@id_user", idUsuario)

            Dim reader As MySqlDataReader = Comando.ExecuteReader()

            If reader.Read() Then
                ' Asignar el nombre y apellido al label
                lbl_nombre.Text = $"{reader("apellido").ToString()}, {reader("nombre").ToString()}"
            Else
                ' No se encontró el usuario con el ID especificado
                lbl_nombre.Text = "Usuario no encontrado"
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener el nombre y apellido del usuario: " & ex.Message)
        Finally
            ConexionMySQL.Close()
        End Try
    End Sub



    Private Sub txt_series_TextChanged(sender As Object, e As EventArgs) Handles txt_series.TextChanged

    End Sub
End Class