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

    Dim bancoUsado As String = "" ' Variable global para el arreglo dinamico del comprobante, almacena el banco que se uso en la transferencia

    'Son los botones que asignan el valor a la variable global anterior, dependiendo de cual sea presionado, el banco cambia
    Private Sub rbtnBanco1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBanco1.CheckedChanged
        If (rbtnBanco1.Checked) Then
            bancoUsado = "Banco Azteca "
        End If
    End Sub

    Private Sub rbtnBanco2_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBanco2.CheckedChanged
        If (rbtnBanco1.Checked) Then
            bancoUsado = "Banco Santander "
        End If
    End Sub

    Private Sub rbtnBanco3_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBanco3.CheckedChanged
        If (rbtnBanco1.Checked) Then
            bancoUsado = "Banco citibanamex "
        End If
    End Sub

    Private Sub rbtnBanco4_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBanco4.CheckedChanged
        If (rbtnBanco1.Checked) Then
            bancoUsado = "Banco BBVA "
        End If
    End Sub

    Private Sub btnTransferir_Click(sender As Object, e As EventArgs) Handles btnTransferir.Click
        If (rbtnBanco1.Checked Or rbtnBanco2.Checked Or rbtnBanco3.Checked Or rbtnBanco4.Checked) Then 'Verifica que un banco este seleccionado
            If (Not (String.IsNullOrEmpty(txtNumeroCuenta.Text))) Then 'Verifica que haya una cuenta
                Dim cantidadATransferir As Double = Val(txtCantidadTranferir.Text) 'Asigna el valor de la textbox como double
                If (cantidadATransferir <= frmCajeroAcceso.saldo And cantidadATransferir > 0) Then 'Checa que el valor que quiere transferir el usuario es menor al saldo y que no sea 0 o negativo
                    MessageBox.Show("!Exito!") 'mensaje de exito
                    frmCajeroAcceso.saldo -= cantidadATransferir 'Resta la cantidad de transferencia del saldo
                    frmCajeroOpciones.conjuntoDeOperaciones.Add("Transferencia a " + bancoUsado + " de cuenta: " + txtNumeroCuenta.Text + " con un monto de: $" + txtCantidadTranferir.Text) 'Agrega todo el proceso de transferencia al arreglo para poder generar un comprobante
                Else
                    MessageBox.Show("Cantidad no es valida") 'mensaje de error sí la cantidad es mayor al saldo o igual/menor a 0
                End If
            Else
                MessageBox.Show("Favor de introducir el numero de cuenta") 'mensaje de error sí no se introdujo un numero de cuenta
            End If
        Else
            MessageBox.Show("Favor de seleccionar un banco") 'mensaje de error sí no se selecciono un banco
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click 'Boton que cierra FrmCajeroTransferencia y abre FrmcajeroOpciones
        Me.Close()
        frmCajeroOpciones.Show()
    End Sub
    'Versión del codigo en inglés
    Private Sub rbtnBank1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBank1.CheckedChanged
        If (rbtnBank1.Checked) Then
            bancoUsado = "Banco Azteca "
        End If
    End Sub

    Private Sub rbtnBank2_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBank2.CheckedChanged
        If (rbtnBank2.Checked) Then
            bancoUsado = "Banco Santander "
        End If
    End Sub

    Private Sub rbtnBank3_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBank3.CheckedChanged
        If (rbtnBank3.Checked) Then
            bancoUsado = "Banco citibanamex "
        End If
    End Sub

    Private Sub rbtnBank4_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBank4.CheckedChanged
        If (rbtnBank4.Checked) Then
            bancoUsado = "Banco BBVA "
        End If
    End Sub
    Private Sub btnTransfer_Click_1(sender As Object, e As EventArgs) Handles btnTransfer.Click
        If (rbtnBank1.Checked Or rbtnBank2.Checked Or rbtnBank3.Checked Or rbtnBank4.Checked) Then 'Verifica que un banco este seleccionado
            If (Not (String.IsNullOrEmpty(txtAccountNumber.Text))) Then 'Verifica que haya una cuenta
                Dim cantidadATransferir As Double = Val(txtTransferAmount.Text) 'Asigna el valor de la textbox como double
                If (cantidadATransferir <= frmCajeroAcceso.saldo And cantidadATransferir > 0) Then 'Checa que el valor que quiere transferir el usuario es menor al saldo y que no sea 0 o negativo
                    MessageBox.Show("!Success!") 'mensaje de exito
                    frmCajeroAcceso.saldo -= cantidadATransferir 'Resta la cantidad de transferencia del saldo
                    frmCajeroOpciones.conjuntoDeOperaciones.Add("Transfer to " + bancoUsado + " with account number: " + txtAccountNumber.Text + " con un monto de: $" + txtTransferAmount.Text) 'Agrega todo el proceso de transferencia al arreglo para poder generar un comprobante
                Else
                    MessageBox.Show("Amount is not valid") 'mensaje de error
                End If
            Else
                MessageBox.Show("Please enter an account number") 'mensaje de error sí no se introdujo un numero de cuenta
            End If
        Else
            MessageBox.Show("Please select a bank") 'mensaje de error sí no se selecciono un banco
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click 'Boton que cierra FrmCajeroTransferencia y abre FrmcajeroOpciones
        Me.Close()
        frmCajeroOpciones.Show()
    End Sub

End Class