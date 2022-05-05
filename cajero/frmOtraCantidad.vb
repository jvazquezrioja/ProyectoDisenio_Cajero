Public Class frmOtraCantidad
    Private Sub frmOtraCantidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim saldo As String = Val(FrmAcceso.saldo) 'Transformamos el valor double de saldo a string
        lblCantidadSaldo.Text = "$" + saldo 'Visualización del saldo en pantalla

        If Not FrmAcceso.idioma Then 'Revisa sí la idioma es false(versión inglés)
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
        If (FrmAcceso.saldo >= retiro) Then
            FrmAcceso.saldo -= retiro
            MessageBox.Show("Exito")

            lblCantidadSaldo.Text = "$" + FrmAcceso.saldo.ToString
            frmRetirarDinero.lblSaldo.Text = "$" + FrmAcceso.saldo.ToString
            If FrmAcceso.idioma Then 'Agrega la operación al ArrayList dependiendo del idioma seleccionado
                FrmOpciones.conjuntoDeOperaciones.Add("Retiro de efectivo con un monto de $" + retiro.ToString)
            Else
                FrmOpciones.conjuntoDeOperaciones.Add("Fund withdrawal: $" + retiro.ToString)
            End If
        Else
            If FrmAcceso.idioma Then
                MessageBox.Show("No cuentas con suficientes fondos")
            Else
                MessageBox.Show("Not enough funds")
            End If

        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
    End Sub

    Private Sub txtSaldoRetirar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaldoRetirar.KeyPress 'Hace que Referencia solo acepte numeros
        Dim ascii As Integer
        ascii = Asc(e.KeyChar)
        If Not ((ascii = 46) Or (ascii = 8) Or (ascii >= 48 And ascii <= 57)) Then 'Revisa que la tecla presionada sea un numero
            e.Handled = True 'Si no es asi evita la insercion de la letra presionada
        End If
    End Sub

    Private Sub txtSaldoRetirar_TextChanged(sender As Object, e As EventArgs) Handles txtSaldoRetirar.TextChanged

    End Sub
End Class