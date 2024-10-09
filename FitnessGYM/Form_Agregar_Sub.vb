Imports MySql.Data.MySqlClient

Public Class Form_Agregar_Sub

    'Private Sub txt_subs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre_sub.KeyPress
    '    If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
    '        e.Handled = True ' Evita que se escriba cualquier carácter que no sea letra o control
    '    End If
    'End Sub

    Private Sub txt_costo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_costo.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Evita que se escriba cualquier carácter que no sea un número o control
        End If
    End Sub

    Private Sub EstilizarDataGridView()
        ' Establecer el color de fondo y de las líneas
        dgv_subs.BackgroundColor = Color.Gray

        dgv_subs.GridColor = Color.DarkGray



        ' Ocultar encabezados de columna y de fila
        dgv_subs.RowHeadersVisible = False
        dgv_subs.ColumnHeadersVisible = False

        ' Establecer el color de las celdas
        dgv_subs.DefaultCellStyle.BackColor = Color.Gray
        dgv_subs.DefaultCellStyle.ForeColor = Color.White

        ' Ajustar las columnas al ancho del DataGridView
        dgv_subs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub CargarDatos()
        ' Realizar la consulta SQL para cargar los datos en el DataGridView
        Try
            Conexiones()
            Dim consulta As String = "SELECT c.id_coste, s.nombre_suscripcion, c.detalle_frecuencia, c.costo_mensual FROM suscripcion s INNER JOIN coste c ON s.id_suscripcion = c.id_suscripcion"

            'Dim consulta As String = "SELECT s.id_suscripcion s.nombre_suscripcion, c.detalle_frecuencia, c.costo_mensual FROM suscripcion s INNER JOIN coste c ON s.id_suscripcion = c.id_suscripcion"

            Comando = New MySqlCommand(consulta, ConexionMySQL)
            Dim DataAdapter As New MySqlDataAdapter(Comando)
            Dim DataTable As New DataTable()
            DataAdapter.Fill(DataTable)

            dgv_subs.DataSource = DataTable

        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub
    Private Sub Form_Agregar_Sub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
        EstilizarDataGridView()
        CargarSuscripciones()
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

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        ' Obtener los valores de los campos



        ' Obtener los valores de los campos
        Dim nombreSuscripcion As String = cbx_sub.Text
        Dim costoMensual As Decimal = Convert.ToDecimal(txt_costo.Text)
        Dim detalleFrecuencia As String = cbx_frecuencia.SelectedItem.ToString()

        Try
            Conexiones()

            ' Obtener el id_suscripcion
            Dim consultaIdSuscripcion As String = "SELECT id_suscripcion FROM suscripcion WHERE nombre_suscripcion = @nombre"
            Comando = New MySqlCommand(consultaIdSuscripcion, ConexionMySQL)
            Comando.Parameters.AddWithValue("@nombre", nombreSuscripcion)

            Dim result As Object = Comando.ExecuteScalar()
            Dim idSuscripcion As Integer

            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                idSuscripcion = Convert.ToInt32(result)
            Else
                MessageBox.Show("No se pudo obtener el ID de la suscripción.")
                Return
            End If

            ' Insertar en la tabla coste
            Dim consultaCoste As String = "INSERT INTO coste (id_suscripcion, detalle_frecuencia, costo_mensual) VALUES (@id_suscripcion, @detalle_frecuencia, @costo_mensual)"
            Comando = New MySqlCommand(consultaCoste, ConexionMySQL)
            Comando.Parameters.AddWithValue("@id_suscripcion", idSuscripcion)
            Comando.Parameters.AddWithValue("@detalle_frecuencia", detalleFrecuencia)
            Comando.Parameters.AddWithValue("@costo_mensual", costoMensual)
            Comando.ExecuteNonQuery()

            ' Actualizar el DataGridView después de la inserción
            CargarDatos()
            cbx_sub.SelectedIndex = -1 ' Limpia la selección del ComboBox
            txt_costo.Clear()
            cbx_frecuencia.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al agregar la suscripción: " & ex.Message)
        End Try


    End Sub


    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        ' Verificar si hay una fila seleccionada en el DataGridView
        If dgv_subs.SelectedRows.Count > 0 Then
            ' Obtener el valor de la columna 'id_suscripcion' de la fila seleccionada
            Dim idCoste As Integer = Convert.ToInt32(dgv_subs.SelectedRows(0).Cells("id_coste").Value)

            Try
                Conexiones()

                '' Consulta para eliminar la suscripción de la tabla 'suscripcion'
                'Dim consultaEliminarSuscripcion As String = "DELETE FROM suscripcion WHERE id_suscripcion = @id"
                'Comando = New MySqlCommand(consultaEliminarSuscripcion, ConexionMySQL)
                'Comando.Parameters.AddWithValue("@id", idSuscripcion)
                'Comando.ExecuteNonQuery()

                ' Consulta para eliminar el costo de la suscripción de la tabla 'coste'
                Dim consultaEliminarCosto As String = "DELETE FROM coste WHERE id_coste = @id"
                Comando = New MySqlCommand(consultaEliminarCosto, ConexionMySQL)
                Comando.Parameters.AddWithValue("@id", idCoste)
                Comando.ExecuteNonQuery()

                ' Actualizar el DataGridView después de la eliminación
                CargarDatos()

            Catch ex As Exception
                MessageBox.Show("Error al eliminar la suscripción: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Selecciona una suscripción para eliminar.")
        End If
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        'CargarDatos()

        Try
            ' Verificar si hay una fila seleccionada en el DataGridView
            If dgv_subs.SelectedRows.Count > 0 Then
                ' Obtener el id_suscripcion del DataGridView seleccionado
                Dim idCoste As Integer = Convert.ToInt32(dgv_subs.SelectedRows(0).Cells("id_coste").Value)
                Dim nuevoCosto As Decimal = Convert.ToDecimal(txt_costo.Text)

                ' Actualizar solo el campo de costo_mensual en la base de datos
                Conexiones()
                CargarDatos()
                Dim consultaUpdate As String = "UPDATE coste SET costo_mensual = @costo WHERE id_coste = @id"
                Comando = New MySqlCommand(consultaUpdate, ConexionMySQL)
                Comando.Parameters.AddWithValue("@costo", nuevoCosto)
                Comando.Parameters.AddWithValue("@id", idCoste)
                Comando.ExecuteNonQuery()

                ' Habilitar nuevamente los ComboBox después de la modificación
                'cbx_sub.Enabled = True
                'cbx_frecuencia.Enabled = True
                ' txt_costo.Enabled = False ' Deshabilitar la edición del txt_costo

                ' Opcional: Volver a cargar los datos después de la actualización
                ' CargarDatos()
            End If
            CargarDatos()
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el costo: " & ex.Message)
        End Try
    End Sub

    Private Sub dgv_subs_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_subs.SelectionChanged
        Try
            ' Verificar si hay una fila seleccionada en el DataGridView
            If dgv_subs.SelectedRows.Count > 0 Then
                ' Obtener los valores de la fila seleccionada y cargarlos en los campos correspondientes
                Dim nombreSuscripcion As String = dgv_subs.SelectedRows(0).Cells("nombre_suscripcion").Value.ToString()
                Dim detalleFrecuencia As String = dgv_subs.SelectedRows(0).Cells("detalle_frecuencia").Value.ToString()
                Dim costoMensual As Decimal = Convert.ToDecimal(dgv_subs.SelectedRows(0).Cells("costo_mensual").Value)

                ' Cargar los valores en los ComboBox y TextBox y deshabilitar los campos que no se deben editar
                cbx_sub.Text = nombreSuscripcion
                cbx_frecuencia.Text = detalleFrecuencia
                txt_costo.Text = costoMensual.ToString()

                ' Habilitar solo la edición del campo txt_costo y deshabilitar los ComboBox
                'cbx_sub.Enabled = False
                'cbx_frecuencia.Enabled = False
                'txt_costo.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub
End Class