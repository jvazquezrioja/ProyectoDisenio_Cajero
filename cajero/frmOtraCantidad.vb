Public Class frmOtraCantidad
    Private Sub frmOtraCantidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim saldo As String = Val(frmCajeroAcceso.saldo) 'Transformamos el valor double de saldo a string
        lblSaldo.Text = "$" + saldo 'Visualización del saldo en pantalla
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Dim retiro As Double = Val(tbxSaldoRetirar.Text)
        If (frmCajeroAcceso.saldo >= retiro) Then
            frmCajeroAcceso.saldo -= retiro
            MessageBox.Show("Exito")

            Dim saldo As String = Val(frmCajeroAcceso.saldo)
            lblSaldo.Text = "$" + saldo
        Else
            MessageBox.Show("No cuentas con suficientes fondos")
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
    End Sub
End Class