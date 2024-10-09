Imports System.Windows.Forms.VisualStyles
Imports MySql.Data.MySqlClient


Public Class Form_Suscripcion
    'Public Shared idUser

    Public SubSeleccionada As New List(Of String)()
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

    Private Sub cbx_sub_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_sub.SelectedIndexChanged
        Conexiones()

        ' Verificar si se ha seleccionado un elemento válido en el ComboBox
        If cbx_sub.SelectedIndex > 0 Then
            ' Obtener el ID de suscripción seleccionado
            Dim idSuscripcion As Integer = Convert.ToInt32(cbx_sub.SelectedValue)

            ' Limpiar el CheckedListBox
            CheckedListBox_sub.Items.Clear()

            ' Realizar la consulta para obtener los datos de la suscripción seleccionada
            Dim consulta As String = "SELECT s.nombre_suscripcion, c.detalle_frecuencia, c.costo_mensual " &
                                     "FROM suscripcion s INNER JOIN coste c ON s.id_suscripcion = c.id_suscripcion " &
                                     "WHERE s.id_suscripcion = @id_suscripcion"

            ' Crear el comando y asignar la consulta y la conexión
            Comando = New MySql.Data.MySqlClient.MySqlCommand(consulta, ConexionMySQL)
            Comando.Parameters.AddWithValue("@id_suscripcion", idSuscripcion)
            ' Esto permite seleccionar solo un elemento a la vez


            ' Crear un DataReader para leer los resultados de la consulta
            DataReader = Comando.ExecuteReader()

            ' Agregar elementos al CheckedListBox basados en los resultados de la consulta
            While DataReader.Read()
                Dim suscripcionInfo As String = $"              {DataReader.GetString(0)}              {DataReader.GetString(1)}              ${DataReader.GetDecimal(2)}"
                CheckedListBox_sub.Items.Add(suscripcionInfo)
            End While

            ' Cerrar el DataReader después de usarlo
            DataReader.Close()
        Else
            ' Limpiar el CheckedListBox si no se selecciona ninguna suscripción
            CheckedListBox_sub.Items.Clear()
        End If
        CheckedListBox_sub.SelectionMode = SelectionMode.One
    End Sub
    Private Sub Form_Suscripcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckedListBox_sub.DrawMode = DrawMode.OwnerDrawFixed
        CheckedListBox_sub.ItemHeight = 25 ' Altura deseada del elemento

    End Sub

    Private Sub CheckedListBox_sub_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBox_sub.ItemCheck

        If e.NewValue = CheckState.Checked Then
            For i As Integer = 0 To CheckedListBox_sub.Items.Count - 1
                If i <> e.Index Then
                    CheckedListBox_sub.SetItemChecked(i, False)
                End If
            Next
        End If
    End Sub

    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        'MsgBox(Agregar_Socio.idUser)

        Conexiones()

        ' Obtener el ID del usuario más reciente
        Dim consultaId_usi As String = "SELECT id_user FROM users ORDER BY id_user DESC LIMIT 1"
        Comando = New MySqlCommand(consultaId_usi, ConexionMySQL)
        Comando.Parameters.AddWithValue("@nombreUsuario", Agregar_Socio.txt_dni.Text)
        Dim id_usi As Integer = Convert.ToInt32(Comando.ExecuteScalar())


        'Comando = New MySqlCommand(consultaIdUsuario, ConexionMySQL)

        Dim idUsuario As Integer = Convert.ToInt32(Comando.ExecuteScalar())

        Dim consultaXD As String = "Select DNI From users Where = idUsuario "

        ' Obtener el ID de suscripción seleccionado
        Dim idSuscripcion As Integer = Convert.ToInt32(cbx_sub.SelectedValue)

        ' Obtener la fecha de inicio del DateTimePicker_Sub
        Dim fechaInicio As Date = DataTimePicker_Sub.Value.Date

        ' Calcular la fecha de fin (el próximo mes)
        Dim fechaFin As Date = fechaInicio.AddMonths(1)

        ' Obtener el ID del empleado del Form_login
        Dim consultaIdEmpleado As String = "SELECT id_empleado FROM empleados WHERE nombre_user = @nombreUsuario AND password_user = @passwordUsuario"
        Comando = New MySqlCommand(consultaIdEmpleado, ConexionMySQL)
        Comando.Parameters.AddWithValue("@nombreUsuario", Login.txt_user_login.Text)
        Comando.Parameters.AddWithValue("@passwordUsuario", Login.txt_pass_login.Text)
        Dim idEmpleado As Integer = Convert.ToInt32(Comando.ExecuteScalar())


        Dim consultaIdCoste As String = "SELECT id_coste FROM coste WHERE id_suscripcion = @idSuscripcion"
        Comando = New MySqlCommand(consultaIdCoste, ConexionMySQL)
        Comando.Parameters.AddWithValue("@idSuscripcion", idSuscripcion)
        Dim idCoste As Integer = Convert.ToInt32(Comando.ExecuteScalar())

        ' Realizar la inserción en la tabla historial_suscripcion
        Dim consultaInsert As String = "INSERT INTO historial_suscripcion (id_historial_suscripcion, id_users, fecha_inicio, fecha_fin, id_empleado, id_coste) " &
                               "VALUES (NULL, @idUsuario, @fechaInicio, @fechaFin, @idEmpleado, @idCoste)"


        Comando = New MySqlCommand(consultaInsert, ConexionMySQL)
        Comando.Parameters.AddWithValue("@idUsuario", idUsuario)
        'Comando.Parameters.AddWithValue("@idSuscripcion", idSuscripcion)
        Comando.Parameters.AddWithValue("@fechaInicio", fechaInicio)
        Comando.Parameters.AddWithValue("@fechaFin", fechaFin)
        Comando.Parameters.AddWithValue("@idEmpleado", idEmpleado)
        Comando.Parameters.AddWithValue("@idCoste", idCoste)

        Try
            Comando.ExecuteNonQuery()
            MessageBox.Show("Datos insertados correctamente en historial_suscripcion.")
            MessageBox.Show("Datos insertados correctamente al usuario =" & consultaXD)
        Catch ex As Exception
            MessageBox.Show("Error al insertar datos en historial_suscripcion: " & ex.Message)
        End Try
        Dim consultaCondiciones As String = "SELECT uc.id_user " &
                                        "FROM user_condi uc " &
                                        "INNER JOIN condi_ejercicio ce ON uc.id_condiciones_fisicas = ce.id_condiciones_fisicas " &
                                        "INNER JOIN rutina_ejercicios re ON ce.id_ejercicio = re.id_ejercicio " &
                                        "INNER JOIN suscripcion_rutina sr ON re.id_rutina = sr.id_rutina " &
                                        "WHERE uc.id_user = @idUsuario AND sr.id_suscripcion = @idSuscripcion"

        Comando = New MySqlCommand(consultaCondiciones, ConexionMySQL)
        Comando.Parameters.AddWithValue("@idUsuario", idUsuario)
        Comando.Parameters.AddWithValue("@idSuscripcion", idSuscripcion)

        ' Obtener el resultado de la consulta de compatibilidad
        Dim resultadoCondiciones As Object = Comando.ExecuteScalar()

        ' Verificar si las condiciones del socio son compatibles con la suscripción
        If resultadoCondiciones IsNot Nothing Then
            ' Si son compatibles, mostrar el mensaje y abrir el formulario
            Dim respuesta As DialogResult = MessageBox.Show("Se detectó que las condiciones del socio registrado son compatibles con esta suscripción. ¿Deseas cargar el formulario de módulo de ejercicios?", "Condiciones compatibles", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If respuesta = DialogResult.Yes Then
                ' Mostrar el formulario de módulo de ejercicios
                Form_modulo_ejercicios.Show()
            End If
        Else
            ' Si las condiciones no son compatibles, mostrar el mensaje
            MessageBox.Show("Se detectó que las condiciones del socio registrado no son compatibles con esta suscripción.", "Condiciones no compatibles", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ' ... (tu código existente)
    End Sub

    Private Sub DataTimePicker_Sub_ValueChanged(sender As Object, e As EventArgs) Handles DataTimePicker_Sub.ValueChanged

    End Sub
End Class

'For Each itemIndex As Integer In CheckedListBox_sub.CheckedIndices
'    SubSeleccionada.Add(CheckedListBox_sub.Items(itemIndex).ToString())
'Next
'Try
'    Conexiones()

'    Dim consulta As String = "INSERT INTO users (nombre, apellido, email, fecha_nacimiento, DNI, telefono, direccion, id_como_conocio, id_genero, id_suscripcion_actual) " &
'                     "VALUES (@nombre, @apellido, @correo, @fechaNacimiento, @dni, @telefono, @direccion, @idComoConocio, @idGenero, @idSuscripcion)"

'    'Dim Comando As New SqlCommand(consulta, Conexiones)

'    Comando.Parameters.Clear()
'    ' Configurar los parámetros para la inserción de datos
'    Comando.Parameters.AddWithValue("@nombre", Agregar_Socio.nombre)
'    Comando.Parameters.AddWithValue("@apellido", Agregar_Socio.apellido)
'    Comando.Parameters.AddWithValue("@email", Agregar_Socio.correo)
'    Comando.Parameters.AddWithValue("@fecha_nacimiento", Agregar_Socio.fechaNacimiento)
'    Comando.Parameters.AddWithValue("@DNI", Agregar_Socio.dni)
'    Comando.Parameters.AddWithValue("@telefono", Agregar_Socio.telefono)
'    Comando.Parameters.AddWithValue("@direccion", Agregar_Socio.direccion)
'    Comando.Parameters.AddWithValue("@id_como_conocio", Agregar_Socio.conocido)
'    Comando.Parameters.AddWithValue("@id_genero", Agregar_Socio.genero)
'    'Comando.Parameters.AddWithValue("@imangen", "dffdv3")


'    Comando.Parameters.AddWithValue("@id_suscripcion_actual", Me.SubSeleccionada)

'    Comando.CommandType = CommandType.Text
'    Comando.CommandText = consulta
'    Comando.Connection = ConexionMySQL

'    If Comando.ExecuteNonQuery() > 0 Then
'        ' Limpiamos todos los campos 
'        'Comando.Parameters.Clear()
'        MsgBox("Usuario Agregado Correctamente")
'    Else
'        MessageBox.Show("Registro insertado NO correcto", "Registro Informa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
'    End If

'Catch ex As MySqlException
'    MsgBox("Error: " & ex.Message)
'Finally
'    ConexionMySQL.Close() ' Asegúrate de cerrar la conexión
'End Try

'    Comando.CommandType = CommandType.Text
'    Comando.CommandText = consulta
'    Comando.Connection = ConexionMySQL

'    If Comando.ExecuteNonQuery Then
'        'limpiamos todos los campos 
'        Comando.Parameters.Clear()
'        MsgBox("Producto Agregado Correctamente")

'    Else
'        MessageBox.Show("Registro insertado NO correcto", "Registro Informa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
'        '     ms.Dispose()
'    End If
'    Comando.Parameters.Clear()

'Catch ex As Exception
'    MsgBox(ex.Message)
'End Try
'Comando.Parameters.Clear()
'Comando.ExecuteNonQuery()
