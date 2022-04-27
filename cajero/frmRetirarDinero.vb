Public Class frmRetirarDinero
    Private Sub frmRetirarDinero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim saldo As String = Val(frmCajeroAcceso.saldo) 'Transformamos el valor double de saldo a string
        lblSaldo.Text = "$" + saldo 'Visualización del saldo en pantalla
    End Sub

    Private Sub btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click
        If (frmCajeroAcceso.saldo >= 50) Then
            frmCajeroAcceso.saldo -= 50
            MessageBox.Show("!Exito!")

            Dim saldo As String = Val(frmCajeroAcceso.saldo)
            lblSaldo.Text = "$" + saldo
        Else
            MessageBox.Show("No cuentas con suficientes fondos")
        End If
    End Sub

    Private Sub btn100_Click(sender As Object, e As EventArgs) Handles btn100.Click
        If (frmCajeroAcceso.saldo >= 100) Then
            frmCajeroAcceso.saldo -= 100
            MessageBox.Show("!Exito!") 'hola

            Dim saldo As String = Val(frmCajeroAcceso.saldo)
            lblSaldo.Text = "$" + saldo
        Else
            MessageBox.Show("No cuentas con suficientes fondos")
        End If
    End Sub

    Private Sub btn200_Click(sender As Object, e As EventArgs) Handles btn200.Click
        If (frmCajeroAcceso.saldo >= 200) Then
            frmCajeroAcceso.saldo -= 200
            MessageBox.Show("!Exito!")

            Dim saldo As String = Val(frmCajeroAcceso.saldo)
            lblSaldo.Text = "$" + saldo
        Else
            MessageBox.Show("No cuentas con suficientes fondos")
        End If
    End Sub

    Private Sub btn500_Click(sender As Object, e As EventArgs) Handles btn500.Click
        If (frmCajeroAcceso.saldo >= 500) Then
            frmCajeroAcceso.saldo -= 500
            MessageBox.Show("!Exito!")

            Dim saldo As String = Val(frmCajeroAcceso.saldo)
            lblSaldo.Text = "$" + saldo
        Else
            MessageBox.Show("No cuentas con suficientes fondos")
        End If
    End Sub

    Private Sub btn1000_Click(sender As Object, e As EventArgs) Handles btn1000.Click
        If (frmCajeroAcceso.saldo >= 1000) Then
            frmCajeroAcceso.saldo -= 1000
            MessageBox.Show("!Exito!")

            Dim saldo As String = Val(frmCajeroAcceso.saldo)
            lblSaldo.Text = "$" + saldo
        Else
            MessageBox.Show("No cuentas con suficientes fondos")
        End If
    End Sub

    Private Sub btn2500_Click(sender As Object, e As EventArgs) Handles btn2500.Click
        If (frmCajeroAcceso.saldo >= 1000) Then
            frmCajeroAcceso.saldo -= 1000
            MessageBox.Show("!Exito!")

            Dim saldo As String = Val(frmCajeroAcceso.saldo)
            lblSaldo.Text = "$" + saldo
        Else
            MessageBox.Show("No cuentas con suficientes fondos")
        End If
    End Sub

    Private Sub btnOtra_Click(sender As Object, e As EventArgs) Handles btnOtra.Click
        frmOtraCantidad.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
    End Sub
End Class