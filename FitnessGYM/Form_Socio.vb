Imports System.Globalization

Public Class Form_Socio
    Private Sub Form_Socio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Linea_Border(txt_nombre, Nothing, Nothing, Color.Gray, 1, 1)
        txt_nombre.ForeColor = Color.White

        Linea_Border(txt_frecuencia, Nothing, Nothing, Color.Gray, 1, 1)
        txt_frecuencia.ForeColor = Color.White

        Linea_Border(txt_sub, Nothing, Nothing, Color.Gray, 1, 1)
        txt_sub.ForeColor = Color.White

        Linea_Border(txt_vencimiento, Nothing, Nothing, Color.Gray, 1, 1)
        txt_vencimiento.ForeColor = Color.White

        ' Obtener la fecha de vencimiento desde el campo txt_vencimiento
        Dim fechaVencimientoString As String = txt_vencimiento.Text.Split(" "c)(0)

        ' Convertir la cadena de fecha a un objeto Date
        Dim fechaVencimiento As Date
        If Date.TryParseExact(fechaVencimientoString, "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, fechaVencimiento) Then
            ' Calcular la diferencia de días entre la fecha actual y la fecha de vencimiento
            Dim diasRestantes As Integer = (fechaVencimiento - DateTime.Today).Days

            ' Establecer el color y el texto del botón según la diferencia de días
            If diasRestantes < 0 Then
                ' Si ya venció
                btn_estado.BackColor = Color.Red
                btn_estado.Text = "VENCIDO/A"
            ElseIf diasRestantes < 6 Then
                ' Si está por vencer (menos de 6 días)
                btn_estado.BackColor = Color.Orange
                btn_estado.Text = "POR VENCER en: " & diasRestantes & " días"
            Else
                ' Si la cuota está vigente
                btn_estado.BackColor = Color.Green ' O el color que desees para indicar vigencia
                btn_estado.Text = "CUOTA VIGENTE"
            End If
        Else
            ' Manejar un formato de fecha incorrecto
            MessageBox.Show("Formato de fecha incorrecto.")
        End If
    End Sub

    Private Sub btn_detalle_Click(sender As Object, e As EventArgs) Handles btn_detalle.Click
        Formulario_Detalles_Usuario.Show()
    End Sub

    'Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    'End Sub

    'Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_estado.Click
        Dim actualizarCobroForm As New Form_Actualizar_Cobro()

        ' Pasar los datos necesarios al formulario Form_Actualizar_Cobro
        actualizarCobroForm.NombreSocio = txt_nombre.Text
        actualizarCobroForm.Suscripcion = txt_sub.Text

        ' Mostrar el formulario Form_Actualizar_Cobro
        actualizarCobroForm.ShowDialog()
    End Sub
End Class