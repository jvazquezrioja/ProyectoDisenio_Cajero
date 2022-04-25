Public Class frmCajeroAcceso
    Public Shared idioma As Boolean = True  'Sí el valor es true entonces esta en español, false esta en inglés

    Private Sub btnMenuOpciones_Click(sender As Object, e As EventArgs) Handles btnMenuOpciones.Click
        frmCajeroOpciones.Show() 'Abre el siguiente form con las opciones del cajero
    End Sub

    Private Sub cbxIdiomas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxIdiomas.SelectedIndexChanged
        If cbxIdiomas.SelectedItem = "English" Then 'Asigna los valores a la variable global de idioma
            lblAcceso.Visible = False     'dependiendo de la selección del usuario
            lblWelcome.Visible = True
            idioma = False
        ElseIf cbxIdiomas.SelectedItem = "Español" Then
            lblAcceso.Visible = True
            lblWelcome.Visible = False
            idioma = True
        End If
    End Sub

End Class
