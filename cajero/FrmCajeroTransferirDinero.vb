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

    Private Sub btnTransferir_Click(sender As Object, e As EventArgs) Handles btnTransferir.Click
        If (rbtnBanco1.Checked Or rbtnBanco2.Checked Or rbtnBanco3.Checked Or rbtnBanco4.Checked) Then 'Verifica que un banco este seleccionado
            If (Not (String.IsNullOrEmpty(txtNumeroCuenta.Text))) Then 'Verifica que haya una cuenta
                Dim cantidadATransferir As Double = Val(txtCantidadTranferir.Text) 'Asigna el valor de la textbox como double
                If (cantidadATransferir <= frmCajeroOpciones.saldo And cantidadATransferir > 0) Then 'Checa que el valor que quiere transferir el usuario es menor al saldo y que no sea 0 o negativo
                    MessageBox.Show("!Exito!") 'mensaje de exito
                    frmCajeroOpciones.saldo -= cantidadATransferir 'Resta la cantidad de transferencia del saldo
                Else
                    MessageBox.Show("Cantidad no es valida") 'mensaje de error
                End If
            Else
                MessageBox.Show("Favor de introducir el numero de cuenta")
            End If
        Else
                MessageBox.Show("Favor de seleccionar un banco")
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        frmCajeroOpciones.Show()
    End Sub

    Private Sub btnTransfer_Click_1(sender As Object, e As EventArgs) Handles btnTransfer.Click
        If (rbtnBank1.Checked Or rbtnBank2.Checked Or rbtnBank3.Checked Or rbtnBank4.Checked) Then 'Verifica que un banco este seleccionado
            If (Not (String.IsNullOrEmpty(txtAccountNumber.Text))) Then 'Verifica que haya una cuenta
                Dim cantidadATransferir As Double = Val(txtTransferAmount.Text) 'Asigna el valor de la textbox como double
                If (cantidadATransferir <= frmCajeroOpciones.saldo And cantidadATransferir > 0) Then 'Checa que el valor que quiere transferir el usuario es menor al saldo y que no sea 0 o negativo
                    MessageBox.Show("!Success!") 'mensaje de exito
                    frmCajeroOpciones.saldo -= cantidadATransferir 'Resta la cantidad de transferencia del saldo
                Else
                    MessageBox.Show("Amount is not valid") 'mensaje de error
                End If
            Else
                MessageBox.Show("Please enter an account number") 'mensaje de error
            End If
        Else
            MessageBox.Show("Please select a bank") 'mensaje de error
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
        frmCajeroOpciones.Show()
    End Sub
End Class