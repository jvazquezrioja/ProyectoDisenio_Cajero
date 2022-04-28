Public Class frmCajeroTransferirDinero
    Private Sub frmCajeroTransferirDinero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Not (frmCajeroAcceso.idioma)) Then 'Revisa sí la idioma es false(versión inglés)
            versionEnIngles()
        End If
    End Sub

    Private Sub versionEnIngles() 'Cambia el texto de todos los elementos a su traducción en inglés
        btnTransferir.Text = "Transfer"
        btnRegresar.Text = "Return"

        lblRealizarTransferencia.Text = "Transfer Funds"
        lblRealizarTransferencia.Left = (lblRealizarTransferencia.Parent.Width \ 2) - (lblRealizarTransferencia.Width \ 2)
        lblEligeUnBanco.Text = "Choose a bank"
        lblLlenaDatos.Text = "Fill out the form"
        lblCuenta.Text = "7 Digit account number"
        lblCantidadTransferencia.Text = "Transfer amount"

    End Sub

    Dim bancoUsado As String = "" ' Variable global para el arreglo dinamico del comprobante, almacena el banco que se uso en la transferencia

    'Son los botones que asignan el valor a la variable global anterior, dependiendo de cual sea presionado, el banco cambia
    Private Sub rbtnBanco1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBanco1.CheckedChanged
        If (rbtnBanco1.Checked) Then
            bancoUsado = "Azteca"
        End If
    End Sub

    Private Sub rbtnBanco2_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBanco2.CheckedChanged
        If (rbtnBanco2.Checked) Then
            bancoUsado = "Santander"
        End If
    End Sub

    Private Sub rbtnBanco3_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBanco3.CheckedChanged
        If (rbtnBanco3.Checked) Then
            bancoUsado = "citibanamex"
        End If
    End Sub

    Private Sub rbtnBanco4_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBanco4.CheckedChanged
        If (rbtnBanco4.Checked) Then
            bancoUsado = "BBVA"
        End If
    End Sub

    Private Sub btnTransferir_Click(sender As Object, e As EventArgs) Handles btnTransferir.Click
        If (rbtnBanco1.Checked Or rbtnBanco2.Checked Or rbtnBanco3.Checked Or rbtnBanco4.Checked) Then 'Verifica que un banco este seleccionado

            If (Not (String.IsNullOrEmpty(txtNumeroCuenta.Text))) Then 'Verifica que haya una cuenta

                Dim cantidadATransferir As Double = Val(txtCantidadTranferir.Text) 'Asigna el valor de la textbox como double

                If (cantidadATransferir <= frmCajeroAcceso.saldo And cantidadATransferir > 0) Then 'Checa que el valor que quiere transferir el usuario es menor al saldo y que no sea 0 o negativo

                    If frmCajeroAcceso.idioma Then

                        MessageBox.Show("!Exito!") 'mensaje de exito
                        frmCajeroOpciones.conjuntoDeOperaciones.Add("Transferencia a banco " + bancoUsado + " de cuenta: " + txtNumeroCuenta.Text + " con un monto de: $" + txtCantidadTranferir.Text) 'Agrega todo el proceso de transferencia al arreglo para poder generar un comprobante

                    Else

                        MessageBox.Show("Success!")
                        frmCajeroOpciones.conjuntoDeOperaciones.Add("Funds transfer to " + bancoUsado + " bank Account: " + txtNumeroCuenta.Text + " Funds Transferred: $" + txtCantidadTranferir.Text)

                    End If

                    frmCajeroAcceso.saldo -= cantidadATransferir 'Resta la cantidad de transferencia del saldo

                Else

                    If frmCajeroAcceso.idioma Then
                        MessageBox.Show("Cantidad no es valida") 'mensaje de error sí la cantidad es mayor al saldo o igual/menor a 0
                    Else
                        MessageBox.Show("Invalid amount")
                    End If

                End If
            Else

                If frmCajeroAcceso.idioma Then

                    MessageBox.Show("Favor de introducir el numero de cuenta") 'mensaje de error sí no se introdujo un numero de cuenta

                Else

                    MessageBox.Show("Please enter an account number")

                End If

            End If

        Else

            If frmCajeroAcceso.idioma Then

                MessageBox.Show("Favor de seleccionar un banco") 'mensaje de error sí no se selecciono un banco

            Else

                MessageBox.Show("Please select a bank")

            End If

        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click 'Boton que cierra FrmCajeroTransferencia y abre FrmcajeroOpciones
        Me.Close()
        frmCajeroOpciones.Show()
    End Sub

End Class