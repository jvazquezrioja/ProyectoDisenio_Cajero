Public Class frmRetirarDinero
    Private Sub frmRetirarDinero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmCajeroAcceso.idioma Then 'Usa la variable global idiomas para detemrinar
            pnlEspañol.Visible = True  'sí carga el panel con la interfaz en íngles o español
            pnlEnglish.Visible = False
        Else
            pnlEspañol.Visible = False
            pnlEnglish.Visible = True
        End If

        Dim saldo As String = Val(frmCajeroAcceso.saldo) 'Transformamos el valor double de saldo a string
        lblSaldo.Text = "$" + saldo 'Visualización del saldo en pantalla
        lblSaldoe.Text = "$" + saldo
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

    Private Sub btn200_Click(sender As Object, e As EventArgs)
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

    'Codigo en inglés
    Private Sub btn50e_Click(sender As Object, e As EventArgs) Handles btn50e.Click
        If (frmCajeroAcceso.saldo >= 50) Then
            frmCajeroAcceso.saldo -= 50
            MessageBox.Show("Success")

            Dim saldo As String = Val(frmCajeroAcceso.saldo)
            lblSaldo.Text = "$" + saldo
        Else
            MessageBox.Show("Not enouch funds")
        End If
    End Sub

    Private Sub btn100e_Click(sender As Object, e As EventArgs) Handles btn100e.Click
        If (frmCajeroAcceso.saldo >= 100) Then
            frmCajeroAcceso.saldo -= 100
            MessageBox.Show("!Exito!")

            Dim saldo As String = Val(frmCajeroAcceso.saldo)
            lblSaldo.Text = "$" + saldo
        Else
            MessageBox.Show("No cuentas con suficientes fondos")
        End If
    End Sub

    Private Sub btn200e_Click(sender As Object, e As EventArgs) Handles btn200e.Click
        If (frmCajeroAcceso.saldo >= 200) Then
            frmCajeroAcceso.saldo -= 200
            MessageBox.Show("!Exito!")

            Dim saldo As String = Val(frmCajeroAcceso.saldo)
            lblSaldo.Text = "$" + saldo
        Else
            MessageBox.Show("No cuentas con suficientes fondos")
        End If
    End Sub

    Private Sub btn500e_Click(sender As Object, e As EventArgs) Handles btn500e.Click
        If (frmCajeroAcceso.saldo >= 500) Then
            frmCajeroAcceso.saldo -= 500
            MessageBox.Show("!Exito!")

            Dim saldo As String = Val(frmCajeroAcceso.saldo)
            lblSaldo.Text = "$" + saldo
        Else
            MessageBox.Show("No cuentas con suficientes fondos")
        End If
    End Sub

    Private Sub btn1000e_Click(sender As Object, e As EventArgs) Handles btn1000e.Click
        If (frmCajeroAcceso.saldo >= 1000) Then
            frmCajeroAcceso.saldo -= 1000
            MessageBox.Show("!Exito!")

            Dim saldo As String = Val(frmCajeroAcceso.saldo)
            lblSaldo.Text = "$" + saldo
        Else
            MessageBox.Show("No cuentas con suficientes fondos")
        End If
    End Sub

    Private Sub btn2500e_Click(sender As Object, e As EventArgs) Handles btn2500e.Click
        If (frmCajeroAcceso.saldo >= 1000) Then
            frmCajeroAcceso.saldo -= 1000
            MessageBox.Show("!Exito!")

            Dim saldo As String = Val(frmCajeroAcceso.saldo)
            lblSaldo.Text = "$" + saldo
        Else
            MessageBox.Show("No cuentas con suficientes fondos")
        End If
    End Sub

    Private Sub btnCusttomAmount_Click(sender As Object, e As EventArgs) Handles btnCustomAmount.Click
        frmOtraCantidad.Show()
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide()
    End Sub
End Class