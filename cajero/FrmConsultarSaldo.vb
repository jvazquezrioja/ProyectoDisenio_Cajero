Public Class frmConsultarSaldo
    Private Sub frmCajeroSaldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmCajeroAcceso.idioma Then 'Usa la variable global idiomas para detemrinar
            versionEnIngles()
        End If
        Dim saldo As String = Val(frmCajeroAcceso.saldo) 'Transformamos el valor double de saldo a string
        lblSaldo.Text = "$" + saldo 'Visualización del saldo en pantalla
    End Sub

    Private Sub versionEnIngles()
        btnRegresar.Text = "Return"
    End Sub

    'Botones que cierran FrmConsultarSaldo y te regresan a FrmOpciones
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        frmCajeroOpciones.Show()
    End Sub

End Class