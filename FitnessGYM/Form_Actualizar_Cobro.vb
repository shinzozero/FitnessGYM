Imports MySql.Data.MySqlClient

Public Class Form_Actualizar_Cobro
    Public Property NombreSocio As String
    Public Property Suscripcion As String

    Private Sub Form_Actualizar_Cobro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar los datos del socio en los controles correspondientes
        lbl_nombre.Text = NombreSocio
        lbl_sub.Text = Suscripcion
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_cobrar.Click
        Try
            ' Obtener las fechas seleccionadas en el DateTimePicker
            Dim fechaInicio As Date = DateTimePicker1.Value.Date
            Dim fechaFin As Date = fechaInicio.AddMonths(1)

            ' Se supone que aquí obtienes los IDs de usuario, empleado y costo de alguna forma
            'Dim idUsuario As Integer = ObtenerIdUsuario() ' Función que debe obtener el ID del usuario
            Dim idEmpleado As Integer = ObtenerIdEmpleado() ' Función que debe obtener el ID del empleado
            'Dim idCoste As Integer = ObtenerIdCoste() ' Función que debe obtener el ID del costo

            ' Realizar la inserción en la tabla historial_suscripcion
            Dim consultaInsert As String = "INSERT INTO historial_suscripcion (id_historial_suscripcion, id_users, fecha_inicio, fecha_fin, id_empleado, id_coste) " &
                                       "VALUES (NULL, @idUsuario, @fechaInicio, @fechaFin, @idEmpleado, @idCoste)"

            Comando = New MySqlCommand(consultaInsert, ConexionMySQL)

            ' Agregar parámetros para el insert
            'Comando.Parameters.AddWithValue("@idUsuario", idUsuario)
            Comando.Parameters.AddWithValue("@fechaInicio", fechaInicio)
            Comando.Parameters.AddWithValue("@fechaFin", fechaFin)
            Comando.Parameters.AddWithValue("@idEmpleado", idEmpleado)
            'Comando.Parameters.AddWithValue("@idCoste", idCoste)

            ' Ejecutar el insert en la base de datos
            Comando.ExecuteNonQuery()
            MessageBox.Show("Datos insertados correctamente en historial_suscripcion.")

        Catch ex As Exception
            MessageBox.Show("Error al insertar datos en historial_suscripcion: " & ex.Message)
        End Try
    End Sub
End Class
