Imports MySql.Data.MySqlClient

Public Class Form_Menu
    Private Sub Form_Menu_Load(sender As Object, e As EventArgs)
        ' Establecer propiedades para hacer el formulario responsivo
        ' Por ejemplo, anclar al borde derecho e inferior los controles que deben mantener su posición relativa al borde del formulario

        ' Aquí puedes agregar más controles y definir sus propiedades Anchor o Dock según necesites
    End Sub
    Private Sub Form_Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Mostrar el formulario de inicio de sesión al cerrar el formulario actual

        Login.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubMenu()
        Login.Hide()


        Linea_Border(txt_bus_cliente, Nothing, Nothing, Color.Gray, 1, 1)


    End Sub
    Private Sub hideSubMenu()
        Pnl_submenu_socios.Visible = False
        Pnl_Sub_menu_Actividades.Visible = False
        Pnl_Sub_menu_Informe.Visible = False
        pnl_mas.Visible = False
    End Sub
    Private Sub showSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False

        End If

    End Sub

    Private Sub Btn_Socio_Click(sender As Object, e As EventArgs) Handles Btn_Socio.Click
        showSubMenu(Pnl_submenu_socios)


    End Sub

    Private Sub Btn_Actividades_Click(sender As Object, e As EventArgs) Handles Btn_Actividades.Click
        showSubMenu(Pnl_Sub_menu_Actividades)
    End Sub

    Private Sub Btn_Informe_Click(sender As Object, e As EventArgs) Handles Btn_Informe.Click
        showSubMenu(Pnl_Sub_menu_Informe)

    End Sub

    Private Sub btn_agregar_socio_Click(sender As Object, e As EventArgs) Handles btn_agregar_socio.Click
        'submenu ocultar
        hideSubMenu()
        Agregar_Socio.Show()

    End Sub

    Private Sub btn_lista_socio_Click(sender As Object, e As EventArgs) Handles btn_lista_socio.Click
        'submenu ocultar
        hideSubMenu()
        Form_lista_socios.Show()
    End Sub

    'Private Sub btn_baja_Click(sender As Object, e As EventArgs) Handles btn_dar_baja.Click
    '    'submenu ocultar
    '    hideSubMenu()
    'End Sub

    'Private Sub btn_rutina_Click(sender As Object, e As EventArgs) Handles btn_rutina.Click
    '    'submenu ocultar
    '    hideSubMenu()

    'End Sub

    Private Sub btn_ejercicio_Click(sender As Object, e As EventArgs) Handles btn_ejercicio.Click
        'submenu ocultar
        hideSubMenu()
        Form_Cargar_Ejercicio.Show()

    End Sub

    'Private Sub btn_asistencia_Click(sender As Object, e As EventArgs) Handles btn_asitencia.Click
    '    'submenu ocultar
    '    hideSubMenu()
    'End Sub

    Private Sub btn_caja_Click(sender As Object, e As EventArgs) Handles btn_caja.Click
        'submenu ocultar
        hideSubMenu()
        Formulario_Pagos.Show()
    End Sub

    'Private Sub btn_suscripcion_Click(sender As Object, e As EventArgs) Handles btn_suscripcion.Click
    '    'submenu ocultar
    '    hideSubMenu()
    'End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        showSubMenu(pnl_mas)
        'submenu ocultar
        'hideSubMenu()
    End Sub
    Private currentForm As Form = Nothing
    Private Sub openchieldForm(hijo_Form As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = hijo_Form
        hijo_Form.TopLevel = False
        hijo_Form.FormBorderStyle = FormBorderStyle.None
        hijo_Form.Dock = DockStyle.Fill
        pnl_socli.Controls.Add(hijo_Form)
        hijo_Form.BringToFront()
        hijo_Form.Show()

    End Sub
    Private Sub txt_bus_dni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bus_cliente.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Evita que se escriba cualquier carácter que no sea un número o control
        End If
    End Sub
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        Try
            Conexiones()

            Dim consulta As String = "SELECT u.nombre, u.apellido, s.nombre_suscripcion AS suscripcion, c.detalle_frecuencia, hs.fecha_fin " &
                        "FROM users u " &
                        "INNER JOIN historial_suscripcion hs ON u.id_user = hs.id_users " &
                        "INNER JOIN coste c ON hs.id_coste = c.id_coste " &
                        "INNER JOIN suscripcion s ON c.id_suscripcion = s.id_suscripcion " &
                        "WHERE u.DNI = @DNI"

            Comando = New MySqlCommand(consulta, ConexionMySQL)
            Comando.Parameters.AddWithValue("@DNI", txt_bus_cliente.Text)

            Dim DataAdapter As New MySqlDataAdapter(Comando)
            Dim DataTable As New DataTable()
            DataAdapter.Fill(DataTable)

            ' Verificamos si se encontraron resultados
            If DataTable.Rows.Count > 0 Then
                ' Creamos una instancia del formulario Form_Socio
                Dim formSocio As New Form_Socio()

                ' Asignamos los valores a los campos del formulario Form_Socio
                formSocio.txt_nombre.Text = DataTable.Rows(0)("nombre").ToString() & ", " & DataTable.Rows(0)("apellido").ToString()
                formSocio.txt_sub.Text = DataTable.Rows(0)("suscripcion").ToString()
                formSocio.txt_vencimiento.Text = DataTable.Rows(0)("fecha_fin").ToString()
                formSocio.txt_frecuencia.Text = DataTable.Rows(0)("detalle_frecuencia").ToString()


                ' Mostramos el formulario Form_Socio
                openchieldForm(formSocio)

                Dim timer As New Timer()
                timer.Interval = 120000 ' 2 minutos en milisegundos
                AddHandler timer.Tick, Sub()
                                           ' Ocultar el formulario después de 2 minutos
                                           Form_Socio.Hide()
                                           timer.Stop() ' Detener el temporizador después de ocultar el formulario
                                       End Sub
                timer.Start() ' Iniciar el temporizador
            Else
                MessageBox.Show("No se encontraron resultados para el DNI proporcionado.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error al buscar en la base de datos: " & ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub btn_sub_Click(sender As Object, e As EventArgs) Handles btn_sub.Click
        hideSubMenu()
        Form_Agregar_Sub.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form_Agregar_Ejercicios.Show()

    End Sub

    Private Sub pnl_socli_Paint(sender As Object, e As PaintEventArgs) Handles pnl_socli.Paint

    End Sub

    Private Sub txt_bus_cliente_TextChanged(sender As Object, e As EventArgs) Handles txt_bus_cliente.TextChanged

    End Sub

    Private Sub Pnl_Sub_menu_Informe_Paint(sender As Object, e As PaintEventArgs) Handles Pnl_Sub_menu_Informe.Paint

    End Sub

End Class
