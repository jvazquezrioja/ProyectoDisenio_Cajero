Public Class frmRetirarDinero
    Private Sub frmRetirarDinero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Not (FrmAcceso.idioma)) Then 'Revisa sí la idioma es false(versión inglés)
            versionEnIngles()
        End If

        Dim saldo As String = Val(FrmAcceso.saldo) 'Transformamos el valor double de saldo a string
        lblSaldo.Text = "$" + saldo 'Visualización del saldo en pantalla
    End Sub

    Private Sub versionEnIngles() 'Cambia el texto de todos los elementos a su traducción en inglés
        btnOtraCantidad.Text = "Custom Amount"
        btnRegresar.Text = "Return"
    End Sub

    Private Sub btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click
        verificarCantidad(50)
    End Sub

    Private Sub btn100_Click(sender As Object, e As EventArgs) Handles btn100.Click
        verificarCantidad(100)
    End Sub

    Private Sub btn200_Click(sender As Object, e As EventArgs) Handles btn200.Click
        verificarCantidad(200)
    End Sub

    Private Sub btn500_Click(sender As Object, e As EventArgs) Handles btn500.Click
        verificarCantidad(500)
    End Sub

    Private Sub btn1000_Click(sender As Object, e As EventArgs) Handles btn1000.Click
        verificarCantidad(1000)
    End Sub

    Private Sub btn2500_Click(sender As Object, e As EventArgs) Handles btn2500.Click
        verificarCantidad(2500)
    End Sub

    Private Sub btnOtraCantidad_Click(sender As Object, e As EventArgs) Handles btnOtraCantidad.Click
        frmOtraCantidad.Show()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
    End Sub

    Private Sub verificarCantidad(cantidad As Double) 'Toma el valor del boton seleccionado, checa que sea menor que el saldo y se lo resta
        If (FrmAcceso.saldo >= cantidad) Then
            FrmAcceso.saldo -= cantidad
            If FrmAcceso.idioma Then
                MessageBox.Show("!Exito!")
            Else
                MessageBox.Show("Success!")
            End If

            Dim saldo As String = Val(FrmAcceso.saldo)
            lblSaldo.Text = "$" + saldo
            Dim retiro As String = Val(cantidad)
            If FrmAcceso.idioma Then 'Agrega la operación al ArrayList dependiendo del idioma seleccionado
                FrmOpciones.conjuntoDeOperaciones.Add("Retiro de efectivo con un monto de $" + retiro)
            Else
                FrmOpciones.conjuntoDeOperaciones.Add("Fund withdrawal: $" + retiro)
            End If
        Else
            If FrmAcceso.idioma Then
                MessageBox.Show("No cuentas con suficientes fondos")
            Else
                MessageBox.Show("Not enough funds")
            End If
        End If
    End Sub

End Class