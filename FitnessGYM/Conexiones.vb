Imports MySql.Data.MySqlClient
Imports System.IO



Module Conexion
    ' Conexion a MySQL
    Public ConexionMySQL As New MySql.Data.MySqlClient.MySqlConnection
    Public Comando As New MySql.Data.MySqlClient.MySqlCommand
    Public DataReader As MySql.Data.MySqlClient.MySqlDataReader

    Public Function Conexiones() As Boolean
        Try
            If ConexionMySQL.State = ConnectionState.Closed Then
                ' Establece la cadena de conexión sin comillas en Uid y Pwd
                ConexionMySQL.ConnectionString = "Server=localhost;Database=fitnessgym;Port=3306;Uid=root;Pwd=root"
                ConexionMySQL.Open()
                Return True
            End If
            Return True ' Si ya está abierta, devuelve verdadero también
        Catch ex As Exception
            ' En lugar de MsgBox, podrías registrar el error o manejarlo de otra manera
            Console.WriteLine("Error al conectar a la base de datos: " & ex.Message)
            MsgBox("error")
            Return False
        End Try
    End Function




End Module
