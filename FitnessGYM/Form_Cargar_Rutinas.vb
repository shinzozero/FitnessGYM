Imports MySql.Data.MySqlClient

Public Class Form_Cargar_Rutinas
    Private Sub EstilizarDataGridView()
        ' Establecer el color de fondo y de las líneas
        dgv_ruti.BackgroundColor = Color.Gray

        dgv_ruti.GridColor = Color.DarkGray



        ' Ocultar encabezados de columna y de fila
        dgv_ruti.RowHeadersVisible = False
        dgv_ruti.ColumnHeadersVisible = False

        ' Establecer el color de las celdas
        dgv_ruti.DefaultCellStyle.BackColor = Color.Gray
        dgv_ruti.DefaultCellStyle.ForeColor = Color.White

        ' Ajustar las columnas al ancho del DataGridView
        dgv_ruti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Private Sub Form_Cargar_Rutinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstilizarDataGridView()
        CargarDatos()

    End Sub
    Private Sub txt_nombre_rutina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre_rutina.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True ' Evita que se escriba cualquier carácter que no sea letra o control
        End If
    End Sub
    Private Sub CargarDatos()
        ' Realizar la consulta SQL para cargar los datos en el DataGridView
        Try
            Conexiones()

            Dim consulta As String = "SELECT s.nombre_suscripcion, r.nombre_rutina " &
                                     "FROM suscripcion s " &
                                     "INNER JOIN suscripcion_rutina sr ON s.id_suscripcion = sr.id_suscripcion " &
                                     "INNER JOIN rutinas r ON sr.id_rutina = r.id_rutina"

            Comando = New MySqlCommand(consulta, ConexionMySQL)
            Dim DataAdapter As New MySqlDataAdapter(Comando)
            Dim DataTable As New DataTable()
            DataAdapter.Fill(DataTable)

            dgv_ruti.DataSource = DataTable

        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

        If dgv_ruti.SelectedRows.Count > 0 Then
            ' Obtener los valores de la fila seleccionada
            Dim nombreSuscripcion As String = dgv_ruti.SelectedRows(0).Cells("nombre_suscripcion").Value.ToString()
            Dim nombreRutina As String = dgv_ruti.SelectedRows(0).Cells("nombre_rutina").Value.ToString()

            ' Eliminar el registro de la base de datos
            Try
                Conexiones()

                ' Obtener el ID de la rutina seleccionada
                Dim consultaIdRutina As String = "SELECT sr.id_rutina " &
                                            "FROM suscripcion_rutina sr " &
                                            "INNER JOIN suscripcion s ON sr.id_suscripcion = s.id_suscripcion " &
                                            "INNER JOIN rutinas r ON sr.id_rutina = r.id_rutina " &
                                            "WHERE s.nombre_suscripcion = @nombre_suscripcion AND r.nombre_rutina = @nombre_rutina"

                Comando = New MySqlCommand(consultaIdRutina, ConexionMySQL)
                Comando.Parameters.AddWithValue("@nombre_suscripcion", nombreSuscripcion)
                Comando.Parameters.AddWithValue("@nombre_rutina", nombreRutina)
                Dim idRutina As Integer = Convert.ToInt32(Comando.ExecuteScalar())

                ' Consulta para eliminar la relación en la tabla suscripcion_rutina
                Dim consultaDeleteSuscripcionRutina As String = "DELETE FROM suscripcion_rutina WHERE id_rutina = @id_rutina"

                Comando = New MySqlCommand(consultaDeleteSuscripcionRutina, ConexionMySQL)
                Comando.Parameters.AddWithValue("@id_rutina", idRutina)
                Comando.ExecuteNonQuery()

                ' Consulta para eliminar la rutina
                Dim consultaDeleteRutina As String = "DELETE FROM rutinas WHERE id_rutina = @id_rutina"

                Comando = New MySqlCommand(consultaDeleteRutina, ConexionMySQL)
                Comando.Parameters.AddWithValue("@id_rutina", idRutina)
                Comando.ExecuteNonQuery()

                CargarDatos()
            Catch ex As Exception
                MessageBox.Show("Error al eliminar la rutina: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Selecciona una rutina para eliminar.")
        End If
    End Sub

    Private Sub btn_cargar_ruti_Click(sender As Object, e As EventArgs) Handles btn_cargar_ruti.Click
        CargarDatos()

        Try
            'Dim idUsuario As Integer = -1 ' Variable para almacenar el id_user insertado
            'Dim dniY As Integer = 0
            Conexiones()

            If Not String.IsNullOrEmpty(txt_nombre_rutina.Text.Trim()) AndAlso cbx_sub.SelectedIndex <> 0 Then
                Dim idSuscripcion As Integer = Convert.ToInt32(cbx_sub.SelectedValue)


                Dim consulta As String = "INSERT INTO rutinas (nombre_rutina) VALUES (@nombre_rutina); SELECT LAST_INSERT_ID();"

                Comando = New MySqlCommand(consulta, ConexionMySQL)
                Comando.Parameters.AddWithValue("@nombre_rutina", txt_nombre_rutina.Text)
                Dim idRutina As Integer = Convert.ToInt32(Comando.ExecuteScalar())

                ' Insertar en la tabla suscripcion_rutina
                Dim consultaInsert As String = "INSERT INTO suscripcion_rutina (id_suscripcion, id_rutina) VALUES (@id_suscripcion, @id_rutina)"

                Comando = New MySqlCommand(consultaInsert, ConexionMySQL)
                Comando.Parameters.AddWithValue("@id_suscripcion", idSuscripcion)
                Comando.Parameters.AddWithValue("@id_rutina", idRutina)
                Comando.ExecuteNonQuery()

                CargarDatos()
                txt_nombre_rutina.Clear()
            Else
                    MessageBox.Show("Registro insertado NO correcto", "Registro Informa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    'MS.Dispose()
                End If
                Comando.Parameters.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Comando.Parameters.Clear()
    End Sub
    Private Sub cbx_sub_Click(sender As Object, e As EventArgs) Handles cbx_sub.Click
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
        dr1("nombre_suscripcion") = "Seleccione un dato"
        dt1.Rows.InsertAt(dr1, 0)
        Me.cbx_sub.SelectedIndex = 0
        Me.cbx_sub.Enabled = True
        DataReader.Close()

        ConexionMySQL.Close()
    End Sub
End Class