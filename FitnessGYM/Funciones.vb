Module Funciones
    Public Function ObtenerIdSocioActual() As Integer
        Dim idUsuario As Integer = 0
        Dim query As String = "SELECT LAST_INSERT_ID();"

        Try
            ' Ejecutar consulta para obtener el último ID insertado
            Comando.CommandText = query
            Dim result As Object = Comando.ExecuteScalar()

            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                idUsuario = Convert.ToInt32(result)
            Else
                ' Manejar el caso de que no se pueda obtener el ID
                MessageBox.Show("No se pudo obtener el ID del usuario recién insertado.")
            End If
        Catch ex As Exception
            ' Manejar excepciones si ocurre algún error al obtener el ID
            MessageBox.Show("Error al obtener el ID del usuario: " & ex.Message)
        End Try

        Return idUsuario
    End Function
    Public Function ObtenerIdEmpleado() As Integer
        Return Login.idEmpleado ' Devuelve el ID del empleado almacenado en Login.idEmpleado
    End Function


End Module
