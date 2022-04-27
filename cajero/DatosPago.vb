Public Class FrmDatos
    Dim borrador As Boolean = True
    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        If (borrador.Equals(True)) Then
            If (TbxReferencia.Text.Length <> 0) Then
                TbxReferencia.Text = TbxReferencia.Text.Remove(TbxReferencia.Text.Length - 1)
            End If
        Else
            If (TbxCantidad.Text.Length <> 0) Then
                TbxCantidad.Text = TbxCantidad.Text.Remove(TbxCantidad.Text.Length - 1)
            End If
        End If
    End Sub

    Private Sub TbxReferencia_Click(sender As Object, e As EventArgs) Handles TbxReferencia.Click
        borrador = True
    End Sub

    Private Sub TbxCantidad_Click(sender As Object, e As EventArgs) Handles TbxCantidad.Click
        borrador = False
    End Sub

    Private Sub ingresarLetra(letra As String)
        If (borrador.Equals(True)) Then
            TbxReferencia.Text = TbxReferencia.Text + letra
        Else
            TbxCantidad.Text = TbxCantidad.Text + letra
        End If
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        ingresarLetra("1")
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        ingresarLetra("2")
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        ingresarLetra("3")
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        ingresarLetra("4")
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        ingresarLetra("5")
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        ingresarLetra("6")
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        ingresarLetra("7")
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        ingresarLetra("8")
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        ingresarLetra("9")
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        ingresarLetra("0")
    End Sub

    Private Sub BtnPunto_Click(sender As Object, e As EventArgs) Handles BtnPunto.Click
        If (borrador.Equals(False) And TbxCantidad.Text.Contains(".").Equals(False)) Then
            ingresarLetra(".")
        End If
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        If (FrmPagoservicio.Servicio.Equals("Internet")) Then
            Me.Close()
            FrmCompañiasint.Show()
        Else
            Me.Close()
            FrmPagoservicio.Show()
        End If
    End Sub

    Private Sub BtnContinuar_Click(sender As Object, e As EventArgs) Handles BtnContinuar.Click
        If (FrmPagoservicio.Servicio.Equals("Internet") And frmCajeroAcceso.saldo >= Double.Parse(TbxCantidad.Text)) Then
            MsgBox("Se realizo el pago del Internet de compañia " + FrmCompañiasint.Compania + " de numero de referencia " +
                   TbxReferencia.Text + " por un total de $" + TbxCantidad.Text, vbOKOnly + vbInformation, "Aviso")
            frmCajeroAcceso.saldo = frmCajeroAcceso.saldo - Double.Parse(TbxCantidad.Text)
            Me.Close()
            frmCajeroOpciones.Show()
        ElseIf (frmCajeroAcceso.saldo >= Double.Parse(TbxCantidad.Text)) Then
            MsgBox("Se realizo el pago del servicio de " + FrmPagoservicio.Servicio + " con un numero de referencia " +
                   TbxReferencia.Text + " por un total de $" + TbxCantidad.Text, vbOKOnly + vbInformation, "Aviso")
            frmCajeroAcceso.saldo = frmCajeroAcceso.saldo - Double.Parse(TbxCantidad.Text)
            Me.Close()
            frmCajeroOpciones.Show()
        Else
            MsgBox("Ingrese un valor valido", vbCritical + vbOKOnly, "Error")
        End If
    End Sub

    Private Sub FrmDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbxCantidad.Text = ""
        TbxReferencia.Text = ""
    End Sub
End Class