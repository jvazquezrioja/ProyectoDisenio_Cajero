Public Class frmOtraCantidad
    Private Sub frmOtraCantidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim saldo As String = Val(frmCajeroAcceso.saldo) 'Transformamos el valor double de saldo a string
        lblCantidadSaldo.Text = "$" + saldo 'Visualización del saldo en pantalla

        If (Not (frmCajeroAcceso.idioma)) Then 'Revisa sí la idioma es false(versión inglés)
            versionEnIngles()
        End If
    End Sub

    Private Sub versionEnIngles() 'Cambia el texto de todos los elementos a su traducción en inglés
        btnRetirar.Text = "Withdraw"
        btnRegresar.Text = "Return"

        lblSaldo.Text = "Balance"
        lblSaldo.Left = (lblSaldo.Parent.Width \ 2) - (lblSaldo.Width \ 2) 'Centra horizontalmente el label con el nuevo texto
        lblSaldoRetirar.Text = "Withdrawal amount"
        lblSaldo.Text = "Balance"
        lblSaldoRetirar.Left = (lblSaldoRetirar.Parent.Width \ 2) - (lblSaldoRetirar.Width \ 2)

    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Dim retiro As Double = Val(txtSaldoRetirar.Text)
        If retiro Mod 200 = 0 Then
            If (frmCajeroAcceso.saldo >= retiro) Then
                frmCajeroAcceso.saldo -= retiro
                MessageBox.Show("Exito")


                Dim saldo As String = Val(frmCajeroAcceso.saldo)
                lblCantidadSaldo.Text = "$" + saldo
                frmRetirarDinero.lblSaldo.Text = "$" + saldo
                txtSaldoRetirar.Clear()

                If frmCajeroAcceso.idioma Then 'Agrega la operación al ArrayList dependiendo del idioma seleccionado
                    frmCajeroOpciones.conjuntoDeOperaciones.Add("Retiro de efectivo con un monto de $" + retiro.ToString)
                Else
                    frmCajeroOpciones.conjuntoDeOperaciones.Add("Fund withdrawal: $" + retiro.ToString)
                End If
            Else
                If frmCajeroAcceso.idioma Then
                    MessageBox.Show("No cuentas con suficientes fondos")
                Else
                    MessageBox.Show("Not enough funds")
                End If

            End If
        Else
            MessageBox.Show("Cantidad Invalida")
        End If

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click

        Me.Hide()
    End Sub

    Private Sub txtSaldoRetirar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaldoRetirar.KeyPress 'Hace que Referencia solo acepte numeros
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class