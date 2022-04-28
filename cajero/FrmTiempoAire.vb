Public Class FrmTiempoAire
    Public compania As String 'La compañia seleccionada en el FrmCompañia
    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close() 'Cierra este form
        FrmCompania.Show() 'Abre el form de compañia
    End Sub

    Private Sub tiempoAire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInstruccion.Text = "Seleccione la recarga que desea de la Compañia " + compania 'Pone el texto de lblInstrucciones con la compañia seleccioanda
    End Sub

    Private Sub Btn20_Click(sender As Object, e As EventArgs) Handles Btn20.Click
        Me.Hide() 'Se oculta este form
        FrmTelefono.valor = 20 'Pone el valor a pagar en 20
        Limpiar_Numero() 'Llama al metodo de Limpiar Numero
        FrmTelefono.ShowDialog() 'Muestra el FrmTelefono

    End Sub

    Private Sub Btn100_Click(sender As Object, e As EventArgs) Handles Btn100.Click
        Me.Hide() 'Se oculta este form
        FrmTelefono.valor = 100 'Pone el valor a pagar en 100
        Limpiar_Numero() 'Llama al metodo de Limpiar Numero
        FrmTelefono.ShowDialog() 'Muestra el FrmTelefono
    End Sub

    Private Sub Btn50_Click(sender As Object, e As EventArgs) Handles Btn50.Click
        Me.Hide() 'Se oculta este form
        FrmTelefono.valor = 50 'Pone el valor a pagar en 50
        Limpiar_Numero() 'Llama al metodo de Limpiar Numero
        FrmTelefono.ShowDialog() 'Muestra el FrmTelefono
    End Sub

    Private Sub Btn500_Click(sender As Object, e As EventArgs) Handles Btn500.Click
        Me.Hide() 'Se oculta este form
        FrmTelefono.valor = 500 'Pone el valor a pagar en 500
        Limpiar_Numero() 'Llama al metodo de Limpiar Numero
        FrmTelefono.ShowDialog() 'Muestra el FrmTelefono
    End Sub
    Private Sub Limpiar_Numero()
        FrmTelefono.TbxNumero.Text = "" 'Limpia el texto del textbox de numero para que no haya algo dentro
    End Sub
End Class
