Public Class frmTiempoAire
    Public compania As String 'La compañia seleccionada en el FrmCompañia

    Private Sub tiempoAire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not FrmAcceso.idioma Then 'Revisa sí la idioma es false(versión inglés)
            versionEnIngles()
        Else
            lblInstruccion.Text = "Seleccione la recarga que desea de la compañia " + compania 'Pone el texto de lblInstrucciones con la compañia seleccioanda
        End If
    End Sub

    Private Sub versionEnIngles() 'Cambia el texto de todos los elementos a su traducción en inglés
        BtnRegresar.Text = "Return"

        lblInstruccion.Text = "Choose the payment amount for " + compania
        lblInstruccion.Left = (lblInstruccion.Parent.Width \ 2) - (lblInstruccion.Width \ 2)
        lblInstruccion.Top = (lblInstruccion.Parent.Height \ 2) - (lblInstruccion.Height \ 2)

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close() 'Cierra este form
        FrmCompania.Show() 'Abre el form de compañia
    End Sub

    Private Sub Btn20_Click(sender As Object, e As EventArgs) Handles Btn20.Click
        botones(20)
    End Sub

    Private Sub Btn50_Click(sender As Object, e As EventArgs) Handles Btn50.Click
        botones(50)
    End Sub

    Private Sub Btn100_Click(sender As Object, e As EventArgs) Handles Btn100.Click
        botones(100)
    End Sub

    Private Sub Btn500_Click(sender As Object, e As EventArgs) Handles Btn500.Click
        botones(500)
    End Sub

    Private Sub botones(cantidad As Integer)
        Me.Hide() 'Se oculta este form
        FrmTelefono.valor = cantidad 'Pone la cantidad del boton seleccionado
        Limpiar_Numero() 'Llama al metodo de Limpiar Numero
        FrmTelefono.ShowDialog() 'Muestra el FrmTelefono
    End Sub
    Private Sub Limpiar_Numero()
        FrmTelefono.TbxNumero.Text = "" 'Limpia el texto del textbox de numero para que no haya algo dentro, el textbox esta dentro del Form telefono
    End Sub
End Class
