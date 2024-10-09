Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Login
    Public Shared idEmpleado As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Linea_Border(txt_user_login, Nothing, Nothing, Color.Gray, 1, 1)
        Linea_Border(txt_pass_login, Nothing, Nothing, Color.Gray, 1, 1)
        txt_user_login.ForeColor = Color.White
        txt_pass_login.ForeColor = Color.White
        'txt_pass_login.PasswordChar = "*"c

    End Sub

    Public Sub btn_iniciar_sesion(sender As Object, e As EventArgs) Handles btn_inciar_sesion.Click
        Conexiones()

        Try

            Dim consulta = " SELECT nombre_user,password_user FROM empleados WHERE nombre_user = '" & Me.txt_user_login.Text & "' AND password_user = '" & Me.txt_pass_login.Text & "'; "

            Comando = New MySqlCommand

            Comando.CommandText = consulta
            Comando.CommandType = CommandType.Text
            Comando.Connection = ConexionMySQL
            DataReader = Comando.ExecuteReader

            If DataReader.HasRows Then
                Form_Menu.Show()
                'Hide()
                DataReader.Read()
                Dim consultaIdEmpleado As String = "SELECT id_empleado FROM empleados WHERE nombre_user = '" & Me.txt_user_login.Text & "' AND password_user ='" & Me.txt_pass_login.Text & "';"
                Comando.CommandText = consultaIdEmpleado
                DataReader.Close()
                Dim result As Object = Comando.ExecuteScalar()
                'Hide() 'cerramos el formulario
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    idEmpleado = Convert.ToInt32(result)
                Else
                    ' Manejar el caso en el que no se pudo obtener el ID del empleado
                    MessageBox.Show("No se pudo obtener el ID del empleado.")
                End If

                Form_Menu.Show()
                If Form_Menu.IsDisposed Then ' Reemplaza Form_Menu.Close() por Form_Menu.IsDisposed
                    txt_user_login.Text = String.Empty ' Limpia el campo de usuario
                    txt_pass_login.Text = String.Empty ' Limpia el campo de contraseña
                End If
            Else
                MsgBox("Usuario o Contraseña Incorrecta")
                DataReader.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

End Class