Public Class frmCajeroOpciones
    Private Sub frmCajeroOpciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Not (frmCajeroAcceso.idioma)) Then 'Revisa sí la idioma es false(versión inglés)
            versionEnIngles()
        End If

    End Sub

    Private Sub versionEnIngles() 'Cambia el texto de todos los elementos a su traducción en inglés
        btnConsultaSaldo.Text = "Check Balance"
        btnRetirarDinero.Text = "Whitdraw Funds"
        btnTransferirDinero.Text = "Transfer Funds"
        btnTiempoAire.Text = "Air Time"
        btnPagarServicios.Text = "Pay Utilities"
        btnGenerarComprobante.Text = "Generate Receipt"
        btnSalir.Text = "Exit"

        lblInstruccion.Text = "Choose an option"
        lblInstruccion.Left = (lblInstruccion.Parent.Width \ 2) - (lblInstruccion.Width \ 2)
        lblInstruccion.Top = (lblInstruccion.Parent.Height \ 2) - (lblInstruccion.Height \ 2)

    End Sub

    'Public Shared saldo As Double = CInt(Int((5000 * Rnd()) + 100)) 'Genera un saldo nuevo para cada usuario
    Public Shared conjuntoDeOperaciones As ArrayList = New ArrayList() 'Arreglo dinamico Global para generar comprobante

    Private Sub btnConsultaSaldo_Click(sender As Object, e As EventArgs) Handles btnConsultaSaldo.Click
        frmComprobantes.Dispose()
        frmConsultarSaldo.Show() 'Abre el form de consular saldo
    End Sub

    Private Sub btnRetirarDinero_Click(sender As Object, e As EventArgs) Handles btnRetirarDinero.Click
        frmRetirarDinero.Show() 'Abre el form de retirar dinero
    End Sub

    Private Sub btnTransferirDinero_Click(sender As Object, e As EventArgs) Handles btnTransferirDinero.Click
        frmCajeroTransferirDinero.Show() 'Abre el form de transferir dinero
    End Sub

    Private Sub btnTiempoAire_Click(sender As Object, e As EventArgs) Handles btnTiempoAire.Click
        FrmCompania.ShowDialog() 'Abre el form de tiempo aire
    End Sub

    Private Sub btnPagarServicios_Click(sender As Object, e As EventArgs) Handles btnPagarServicios.Click
        FrmPagoservicio.Show() 'Abre el form de pagar servicios
    End Sub

    Private Sub btnGenerarComprobante_Click(sender As Object, e As EventArgs) Handles btnGenerarComprobante.Click
        frmComprobantes.Show() 'Abre el form de generar comprobante
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close() 'Cierra el menu de opciones
        frmCajeroAcceso.Show() 'Reabre la ventana de acceso del cajero
    End Sub

End Class