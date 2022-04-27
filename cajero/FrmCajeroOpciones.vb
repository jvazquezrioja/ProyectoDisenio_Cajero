Public Class frmCajeroOpciones
    Private Sub frmCajeroOpciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmCajeroAcceso.idioma Then 'Usa la variable global idiomas para detemrinar
            pnlEspañol.Visible = True  'sí carga el panel con la interfaz en íngles o español
            pnlEnglish.Visible = False
        Else
            pnlEspañol.Visible = False
            pnlEnglish.Visible = True
        End If

    End Sub


    'Public Shared saldo As Double = CInt(Int((5000 * Rnd()) + 100)) 'Genera un saldo nuevo para cada usuario
    Public Shared conjuntoDeOperaciones As ArrayList = New ArrayList() 'Arreglo dinamico Global para generar comprobante

    Private Sub btnConsultaSaldo_Click(sender As Object, e As EventArgs) Handles btnConsultaSaldo.Click
        frmConsultarSaldo.Show() 'Abre el form de consular saldo
    End Sub

    Private Sub btnRetirarDinero_Click(sender As Object, e As EventArgs) Handles btnRetirarDinero.Click
        frmRetirarDinero.Show() 'Abre el form de retirar dinero
    End Sub

    Private Sub btnTransferirDinero_Click(sender As Object, e As EventArgs) Handles btnTransferirDinero.Click
        frmCajeroTransferirDinero.Show() 'Abre el form de transferir dinero
    End Sub

    Private Sub btnTiempoAire_Click(sender As Object, e As EventArgs) Handles btnTiempoAire.Click
        'Abre el form de tiempo aire
    End Sub

    Private Sub btnPagarServicios_Click(sender As Object, e As EventArgs) Handles btnPagarServicios.Click
        Me.Hide()
        FrmPagoservicio.ShowDialog() 'Abre el form de pagar servicios
    End Sub

    Private Sub btnGenerarComprobante_Click(sender As Object, e As EventArgs) Handles btnGenerarComprobante.Click
        frmComprobantes.Show() 'Abre el form de generar comprobante
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close() 'Cierra el menu de opciones
        frmCajeroAcceso.Show() 'Reabre la ventana de acceso del cajero
    End Sub

    'Versión de menu de opciones en inglés
    Private Sub btnCheckBalance_Click(sender As Object, e As EventArgs) Handles btnCheckBalance.Click
        frmConsultarSaldo.Show() 'Abre el form de consular saldo
    End Sub

    Private Sub btnWithdrawCash_Click(sender As Object, e As EventArgs) Handles btnWithdrawCash.Click
        frmRetirarDinero.Show() 'Abre el form de retirar dinero
    End Sub

    Private Sub btnTransferMoney_Click(sender As Object, e As EventArgs) Handles btnTransferMoney.Click
        frmCajeroTransferirDinero.Show() 'Abre el form de transferir dinero
    End Sub

    Private Sub btnAirTime_Click(sender As Object, e As EventArgs) Handles btnAirTime.Click
        'Abre el form de tiempo aire
    End Sub

    Private Sub btnPayUtilities_Click(sender As Object, e As EventArgs) Handles btnPayUtilities.Click
        'Abre el form de pagar servicios
    End Sub

    Private Sub btnGenrateReceipt_Click(sender As Object, e As EventArgs) Handles btnGenrateReceipt.Click
        'Abre el form de generar comprobante
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'Cierra el menu de opciones
        frmCajeroAcceso.Show() 'Reabre la ventana de acceso del cajero
    End Sub

End Class