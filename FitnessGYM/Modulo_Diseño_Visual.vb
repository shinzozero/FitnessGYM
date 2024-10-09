Module Modulo_Diseño_Visual
    Public Sub Linea_Border(ByVal ctr As TextBox, ByVal bCol As Color, ByVal fCol As Color, ByVal borderCol As Color, ByVal boderzise As Integer, ByVal bordermargin As Integer)
        If bCol = Nothing Then
            bCol = ctr.Parent.BackColor

        End If
        If fCol = Nothing Then
            fCol = ctr.Parent.ForeColor

        End If
        If borderCol = Nothing Then
            borderCol = ctr.Parent.ForeColor
        End If
        ctr.BorderStyle = BorderStyle.None
        ctr.BackColor = bCol
        ctr.ForeColor = fCol
        Dim underlinePanel As New Panel
        underlinePanel.BackColor = borderCol
        underlinePanel.Height = boderzise
        underlinePanel.Width = ctr.Width
        underlinePanel.Location = New Point(ctr.Location.X, (ctr.Location.Y + ctr.Height + bordermargin))
        underlinePanel.BringToFront()
        ctr.Parent.Controls.Add(underlinePanel)

    End Sub
End Module
