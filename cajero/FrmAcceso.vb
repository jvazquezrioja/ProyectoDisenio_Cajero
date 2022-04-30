Public Class FrmAcceso
    Public Shared idioma As Boolean = True  'Sí el valor es true entonces esta en español, false esta en inglés

    Public Shared saldo As Double
    Private Sub FrmAcceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not idioma Then
            versionEnIngles()
        End If
    End Sub

    Private Sub versionEnIngles()
        lblAcceso.Text = "Welcome"

    End Sub
    Private Sub btnMenuOpciones_Click(sender As Object, e As EventArgs) Handles btnMenuOpciones.Click
        FrmOpciones.Show() 'Abre el siguiente form con las opciones del cajero
        saldo = CInt(Int((5000 * Rnd()) + 100))
        FrmOpciones.conjuntoDeOperaciones.Clear()
    End Sub

    Private Sub cbxIdiomas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxIdiomas.SelectedIndexChanged
        If cbxIdiomas.SelectedItem = "English" Then 'Asigna los valores a la variable global de idioma
            lblAcceso.Text = "Welcome"     'dependiendo de la selección del usuario
            lblAcceso.Left = (lblAcceso.Parent.Width \ 2) - (lblAcceso.Width \ 2)
            idioma = False
        ElseIf cbxIdiomas.SelectedItem = "Español" Then
            lblAcceso.Text = "¡Bienvenido!"
            lblAcceso.Left = (lblAcceso.Parent.Width \ 2) - (lblAcceso.Width \ 2)
            idioma = True
        End If
    End Sub


End Class
