Public Class frmConsultarSaldo
    Private Sub frmCajeroSaldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmCajeroAcceso.idioma Then 'Usa la variable global idiomas para detemrinar
            btnRegresar.Visible = True  'sí carga el panel con la interfaz en íngles o español
            btnReturn.Visible = False
        Else
            btnRegresar.Visible = False
            btnReturn.Visible = True
        End If

        Dim saldo As String = Val(frmCajeroAcceso.saldo)
        lblSaldo.Text = "$" + saldo
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        frmCajeroOpciones.Show()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
        frmCajeroOpciones.Show()
    End Sub

    Private Sub lblSaldo_Click(sender As Object, e As EventArgs) Handles lblSaldo.Click

    End Sub
End Class