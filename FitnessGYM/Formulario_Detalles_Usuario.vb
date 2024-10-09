Public Class Formulario_Detalles_Usuario
    Private Sub Formulario_Detalles_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Linea_Border(txt_nombre_detalle, Nothing, Nothing, Color.Gray, 1, 1)
        Linea_Border(txt_apellido, Nothing, Nothing, Color.Gray, 1, 1)
        Linea_Border(txt_correo, Nothing, Nothing, Color.Gray, 1, 1)
        Linea_Border(txt_dni, Nothing, Nothing, Color.Gray, 1, 1)
        Linea_Border(txt_domicilio, Nothing, Nothing, Color.Gray, 1, 1)
        Linea_Border(txt_observaciones, Nothing, Nothing, Color.Gray, 1, 1)
        Linea_Border(txt_suscripcion, Nothing, Nothing, Color.Gray, 1, 1)
        Linea_Border(txt_telefono, Nothing, Nothing, Color.Gray, 1, 1)

    End Sub
End Class