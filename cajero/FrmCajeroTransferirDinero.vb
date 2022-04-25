Public Class frmCajeroTransferirDinero
    Private Sub frmCajeroTransferirDinero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmCajeroAcceso.idioma Then 'Usa la variable global idiomas para detemrinar
            pnlEspañol.Visible = True  'sí carga el panel con la interfaz en íngles o español
            pnlEnglish.Visible = False
        Else
            pnlEspañol.Visible = False
            pnlEnglish.Visible = True
        End If
    End Sub

    Private Sub btnReturn_Click_1(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
        frmCajeroOpciones.Show()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        frmCajeroOpciones.Show()
    End Sub

    Private Sub btnTransferir_Click(sender As Object, e As EventArgs) Handles btnTransferir.Click
        Dim cantidadATransferir As Double = Val(txtCantidadTranferir.Text) 'Asigna el valor de la textbox como double
        If (cantidadATransferir <= frmCajeroOpciones.saldo And cantidadATransferir > 0) Then 'Checa que el valor que quiere transferir el usuario es menor al saldo y que no sea 0 o negativo
            MessageBox.Show("!Exito!") 'mensaje de exito
            frmCajeroOpciones.saldo -= cantidadATransferir 'Resta la cantidad de transferencia del saldo
        Else
            MessageBox.Show("Cantidad no es valida") 'mensaje de error
        End If
    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        Dim cantidadATransferir As Double = Val(txtCantidadTranferir.Text) 'Asigna el valor de la textbox como double
        If (cantidadATransferir <= frmCajeroOpciones.saldo And cantidadATransferir > 0) Then 'Checa que el valor que quiere transferir el usuario es menor al saldo y que no sea 0 o negativo
            MessageBox.Show("!Success!") 'mensaje de exito
            frmCajeroOpciones.saldo -= cantidadATransferir 'Resta la cantidad de transferencia del saldo
        Else
            MessageBox.Show("Amount is not valid") 'mensaje de error
        End If
    End Sub
End Class