Imports MySql.Data.MySqlClient

Public Class Agregar_Socio
    Public Shared idUser As Integer

    Public condicionesSeleccionadas As New List(Of String)()
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Agregar_Socio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


        ''''########################################''''






    End Sub
    Private currentForm As Form = Nothing
    Private Sub openchieldForm(hijo_Form As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = hijo_Form
        hijo_Form.TopLevel = False
        hijo_Form.FormBorderStyle = FormBorderStyle.None
        hijo_Form.Dock = DockStyle.Fill
        Panel1.Controls.Add(hijo_Form)
        hijo_Form.BringToFront()
        hijo_Form.Show()


    End Sub


    Private Sub CheckedListBox_condicion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox_condicion.SelectedIndexChanged

    End Sub

    Private Sub txt_nombres_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombres.KeyPress, txt_apellido.KeyPress, txt_direccion.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True ' Evita que se escriba cualquier carácter que no sea letra o control
        End If
    End Sub
    Private Sub txt_dni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_dni.KeyPress, txt_telefono.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Evita que se escriba cualquier carácter que no sea un número o control
        End If
    End Sub
    Private Sub btn_agregar_Click_1(sender As Object, e As EventArgs) Handles btn_agregar.Click

        Try
            'Dim idUsuario As Integer = -1 ' Variable para almacenar el id_user insertado
            'Dim dniY As Integer = 0
            Conexiones()


            Dim consulta As String

            consulta = " INSERT INTO users (nombre,apellido,email,fecha_nacimiento,DNI,telefono,direccion,id_como_conocio,id_genero,id_suscripcion_actual)VALUE" &
                       "(@nombre, @apellido,@email,@fecha_nacimiento, @DNI, @telefono, @direccion,  @id_como_conocio, @id_genero,@id_suscripcion_actual);"
            '('" & DateTimePicker1.Text & "')
            Comando.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = Me.txt_nombres.Text
            Comando.Parameters.Add("@apellido", MySqlDbType.VarChar).Value = Me.txt_apellido.Text
            Comando.Parameters.Add("@email", MySqlDbType.VarChar).Value = Me.txt_correo.Text
            'Comando.Parameters.Add("@fecha_nacimiento", MySqlDbType.Date).Value = Me.DateTimePicker1
            Comando.Parameters.Add("@fecha_nacimiento", MySqlDbType.Date).Value = DateTimePicker1.Value

            Comando.Parameters.Add("@DNI", MySqlDbType.VarChar).Value = Me.txt_dni.Text
            Comando.Parameters.Add("@telefono", MySqlDbType.VarChar).Value = Me.txt_telefono.Text
            Comando.Parameters.Add("@direccion", MySqlDbType.VarChar).Value = Me.txt_direccion.Text
            Comando.Parameters.Add("@id_como_conocio", MySqlDbType.Int16).Value = Me.cbx_conocido.SelectedValue
            Comando.Parameters.Add("@id_genero", MySqlDbType.Int16).Value = Me.cbx_genero.SelectedValue
            Comando.Parameters.Add("@id_suscripcion_actual", MySqlDbType.Int64).Value = 1


            Comando.CommandType = CommandType.Text
            Comando.CommandText = consulta
            Comando.Connection = ConexionMySQL

            Dim dniY As Integer

            ' Verificar si el valor en txt_dni.Text es un número entero válido y guardarlo en dniY
            If Integer.TryParse(txt_dni.Text, dniY) Then
                ' El valor se pudo convertir correctamente a entero, ahora puedes usar dniY
                ' Por ejemplo, aquí puedes usar dniY en tu lógica
                ' ...
            Else
                ' El valor en txt_dni.Text no es un número entero válido
                ' Aquí puedes manejar la situación de error, mostrar un mensaje al usuario, etc.
                'MsgBox("El DNI debe ser un número entero válido.")
            End If

            If Comando.ExecuteNonQuery Then
                'limpiamos todos los campos 

                Me.txt_nombres.Clear()
                Me.txt_apellido.Clear()
                Me.txt_correo.Clear()
                'dniY = 0
                'Me.txt_dni.Clear()
                'Me.txt_dni.Clear()
                Me.txt_telefono.Clear()
                Me.txt_direccion.Clear()
                Me.cbx_conocido.SelectedIndex = 0
                Me.cbx_genero.SelectedIndex = 0
                openchieldForm(New Form_Suscripcion)

                '##################################################################


                '##################################################################

            Else
                MessageBox.Show("Registro insertado NO correcto", "Registro Informa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'MS.Dispose()
            End If
            Comando.Parameters.Clear()

            'Dim insertar_consulta As String = "INSERT INTO user_condi (id_user, id_condiciones_fisicas) VALUES (@id_user, @id_condiciones_fisicas)"

            'Comando.CommandType = CommandType.Text
            'Comando.CommandText = insertar_consulta
            'Comando.Connection = ConexionMySQL




            Dim idUser As Integer

            Dim consultaDNI As String = "SELECT id_user FROM users WHERE DNI =  @dniY"
            Comando.Parameters.Clear()
            Comando.CommandText = consultaDNI
            Comando.Parameters.Add("@dniY", MySqlDbType.Int64).Value = Convert.ToInt64(dniY)
            'idUser = Convert.ToInt32(consultaDNI)
            '#####################



            '#############
            Try
                ' Ejecutar la consulta SQL para obtener idUser
                Dim idUserQuery As Object = Comando.ExecuteScalar()

                If idUserQuery IsNot Nothing AndAlso Not IsDBNull(idUserQuery) Then
                    idUser = Convert.ToInt32(idUserQuery)
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
                    Try
                        Dim insertar_consulta As String = "INSERT INTO user_condi (id_user, id_condiciones_fisicas) VALUES (@id_user, @id_condicion)"

                        Comando.Parameters.Clear()
                        Comando.CommandType = CommandType.Text
                        Comando.CommandText = insertar_consulta
                        Comando.Connection = ConexionMySQL

                        Comando.Parameters.Add("@id_user", MySqlDbType.Int32).Value = idUser
                        Comando.Parameters.Add("@id_condicion", MySqlDbType.Int32).Value = conditionID

                        Comando.ExecuteNonQuery()
                        MsgBox("Inserción exitosa!")
                    Catch ex As Exception
                        MsgBox("Error al insertar!: " & ex.Message)
                    End Try
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Comando.Parameters.Clear()





    End Sub

    Private Sub btn_cancelar_Click_1(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub

    Private Sub cbx_genero_Click(sender As Object, e As EventArgs) Handles cbx_genero.Click
        Conexiones()

        Comando.CommandText = "SELECT id_genero, detalle_genero FROM genero"
        Comando.CommandType = CommandType.Text
        Comando.Connection = ConexionMySQL

        DataReader = Comando.ExecuteReader
        Dim dt1 As New DataTable
        dt1.Load(DataReader)
        Me.cbx_genero.DataSource = dt1
        Me.cbx_genero.DisplayMember = "detalle_genero"
        Me.cbx_genero.ValueMember = "id_genero"

        Dim dr1 As DataRow

        dr1 = dt1.NewRow
        dr1("id_genero") = 0
        dr1("detalle_genero") = "Seleccione un genero"
        dt1.Rows.InsertAt(dr1, 0)
        Me.cbx_genero.SelectedIndex = 0
        Me.cbx_genero.Enabled = True
        DataReader.Close()

        ConexionMySQL.Close()
    End Sub
    Private Sub cbx_conocio_Click(sender As Object, e As EventArgs) Handles cbx_conocido.Click
        Try
            Conexiones()

            Comando.CommandText = "SELECT id_como_conocio, detalle_como_conocio FROM como_conocio"
            Comando.CommandType = CommandType.Text
            Comando.Connection = ConexionMySQL

            DataReader = Comando.ExecuteReader
            Dim dt2 As New DataTable
            dt2.Load(DataReader)
            Me.cbx_conocido.DataSource = dt2
            Me.cbx_conocido.DisplayMember = "detalle_como_conocio"
            Me.cbx_conocido.ValueMember = "id_como_conocio"

            Dim dr2 As DataRow

            dr2 = dt2.NewRow
            dr2("id_como_conocio") = 0
            dr2("detalle_como_conocio") = "Seleccione un dato"
            dt2.Rows.InsertAt(dr2, 0)
            Me.cbx_conocido.SelectedIndex = 0
            Me.cbx_conocido.Enabled = True
            DataReader.Close()

            ConexionMySQL.Close()
        Catch ex As Exception
            MsgBox(ex.Message) ' Aquí puedes mostrar el mensaje de la excepción en un MessageBox o manejarla de otra manera
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        'Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Btn_Socio_Click(sender As Object, e As EventArgs) Handles Btn_Socio.Click
        'Form_Suscripcion.Hide()
    End Sub
End Class


''Comando.CommandText = "SELECT LAST_INSERT_ID();"
'Comando.CommandText = "Select id_user FROM fitnessgym.users WHERE DNI ='" & dniY & "'"
'Dim idUsuarioObj As Object = Comando.ExecuteScalar()
'If idUsuarioObj IsNot Nothing AndAlso Not DBNull.Value.Equals(idUsuarioObj) Then
'idUsuario = Convert.ToInt32(idUsuarioObj)
'End If
'For Each item As String In CheckedListBox_condicion.CheckedItems
'' Obtener el ID de la condición física seleccionada
'Comando.CommandText = "SELECT id_condiciones_fisicas FROM condiciones_fisicas WHERE descripcion_condicion = @descripcion_condicion;"
'Comando.Parameters.Clear()
'Comando.Parameters.Add("@descripcion_condicion", MySqlDbType.VarChar).Value = item
'Dim idCondicion As Object = Comando.ExecuteScalar()

'' Insertar en la tabla user_condi
'If idCondicion IsNot Nothing AndAlso idUsuario <> -1 Then
'Comando.CommandText = "INSERT INTO user_condi (id_user, id_condiciones_fisicas) VALUES (@id_user, @id_condiciones_fisicas);"
'Comando.Parameters.Clear()
'Comando.Parameters.Add("@id_user", MySqlDbType.Int32).Value = idUsuario
'Comando.Parameters.Add("@id_condiciones_fisicas", MySqlDbType.Int32).Value = Convert.ToInt32(idCondicion)
'Comando.ExecuteNonQuery()
'End If
'Next
'consulta = "SELECT id_user FROM users WHERE DNI = @dni"  ' Obtener el id_user del usuario recién insertado
'Comando.Parameters.Add("@dni", MySqlDbType.Int16).Value = Me.txt_dni.Text
''MsgBox("Producto Agregado Correctamente")
'' Ejecutar la consulta para obtener el id_user
'Dim reader As MySqlDataReader = Comando.ExecuteReader()
'If reader.Read() Then
'idUsuario = reader.GetInt32("id_user")
'End If
'reader.Close()
'' Insertar las condiciones físicas asociadas al usuario en user_condi
'If idUsuario <> -1 AndAlso condicionesSeleccionadas.Count > 0 Then
'consulta = "INSERT INTO user_condi (id_user, id_condiciones_fisicas) VALUES "

'For Each condicion As String In condicionesSeleccionadas
'consulta &= "(@idUsuario, @condicion),"

'' Añadir parámetros para esta condición
'Comando.Parameters.AddWithValue("@condicion", condicion)
'Next

'' Eliminar la última coma sobrante
'consulta = consulta.TrimEnd(","c)

'' Asignar la nueva consulta y ejecutarla
'Comando.CommandText = consulta

'' Asignar el valor del idUsuario
'Comando.Parameters.AddWithValue("@idUsuario", idUsuario)

'Comando.ExecuteNonQuery()
'End If