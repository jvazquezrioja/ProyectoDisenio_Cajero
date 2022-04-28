Public Class frmDatos
    Dim borrador As Boolean = True 'Variable que determina que textbox esta seleccionado: Referencia es True y Cantidad es False
    Private Sub frmDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCantidad.Text = ""
        txtReferencia.Text = ""

        If (Not (frmCajeroAcceso.idioma)) Then 'Revisa sí la idioma es false(versión inglés)
            versionEnIngles()
        End If
    End Sub

    Private Sub versionEnIngles() 'Cambia el texto de todos los elementos a su traducción en inglés
        btnBorrar.Text = "Delete"
        btnContinuar.Text = "Continue"
        btnRegresar.Text = "Return"

        lblInstrucciones.Text = "Input the required information"
        lblInstrucciones.Left = (lblInstrucciones.Parent.Width \ 2) - (lblInstrucciones.Width \ 2) 'Centra horizontalmente el label con el nuevo texto

        gbxCantidad.Text = "Amount"
        gbxReferencia.Text = "Reference"
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click 'Dependiendo del textbox seleccionado, el boton borra un caracter a la izquierda de su contenido
        If (borrador.Equals(True)) Then
            If (txtReferencia.Text.Length <> 0) Then
                txtReferencia.Text = txtReferencia.Text.Remove(txtReferencia.Text.Length - 1)
            End If
        Else
            If (txtCantidad.Text.Length <> 0) Then
                txtCantidad.Text = txtCantidad.Text.Remove(txtCantidad.Text.Length - 1)
            End If
        End If
    End Sub

    Private Sub txtReferencia_Click(sender As Object, e As EventArgs) Handles txtReferencia.Click 'en caso de ser seleccionado declara borrador como true
        borrador = True
    End Sub

    Private Sub txtCantidad_Click(sender As Object, e As EventArgs) Handles txtCantidad.Click ' en caso de ser seleccionado declara borrador como false
        borrador = False
    End Sub

    Private Sub ingresarLetra(letra As String) 'agrega un caracter al textbox, puede ser el de Referencia o Cantidad
        If (borrador.Equals(True)) Then
            txtReferencia.Text = txtReferencia.Text + letra
        Else
            txtCantidad.Text = txtCantidad.Text + letra
        End If
    End Sub
    'Botones de teclado 0 a 9, al ser seleccionados mandan el caracter del numero asignado al metodo ingresarLetra para agregados al textbox correspondiente
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        ingresarLetra("1")
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        ingresarLetra("2")
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        ingresarLetra("3")
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        ingresarLetra("4")
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        ingresarLetra("5")
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        ingresarLetra("6")
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        ingresarLetra("7")
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        ingresarLetra("8")
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        ingresarLetra("9")
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        ingresarLetra("0")
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click 'Agrega un punto al textbox de Cantidad
        If (borrador.Equals(False) And txtCantidad.Text.Contains(".").Equals(False)) Then 'Revisa que borrador sea false(si es false significa que el textbox de Cantidad esta seleccionado) y que no tenga ya un punto
            ingresarLetra(".") 'manda el cracter de punto para que el metodo ingresarLetra lo agregue al textbox de Cantidad
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        If (FrmPagoservicio.Servicio.Equals("Internet")) Then 'Regresa a la Form ComaniasInt en caso de haber seleccionado Internet en el Form de Servicios
            Me.Close()
            FrmCompañiasint.Show()
        Else                              'Sí no se seleccionó internet en el Form Servicios, regresa directamente a ese Form 
            Me.Close()
            FrmPagoservicio.Show()
        End If
    End Sub

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        If (txtCantidad.Text.Length <> 0 And txtReferencia.Text.Length <> 0) Then 'Verifica que los textbox Referencia y Cantidad tengan un valor
            If (FrmPagoservicio.Servicio.Equals("Internet") And frmCajeroAcceso.saldo >= Double.Parse(txtCantidad.Text)) Then 'Checa si se selecciono internet en el Form Servicios y que se cuenta con suficiente saldo para pagar la cantidad deseada
                MsgBox("Se realizo el pago del Internet de compañia " + FrmCompañiasint.Compania + " de numero de referencia " +
                   txtReferencia.Text + " por un total de $" + txtCantidad.Text, vbOKOnly + vbInformation, "Aviso")
                frmCajeroAcceso.saldo = frmCajeroAcceso.saldo - Double.Parse(txtCantidad.Text)
                Me.Close()
                frmCajeroOpciones.Show()
            ElseIf (frmCajeroAcceso.saldo >= Double.Parse(txtCantidad.Text)) Then 'En caso de no haber seleccionado internet en el Form Servicios, simplemente revisa que tengas suficiente saldo para pagar el servicio seleccionado
                MsgBox("Se realizo el pago del servicio de " + FrmPagoservicio.Servicio + " con un numero de referencia " +
                   txtReferencia.Text + " por un total de $" + txtCantidad.Text, vbOKOnly + vbInformation, "Aviso")
                frmCajeroAcceso.saldo = frmCajeroAcceso.saldo - Double.Parse(txtCantidad.Text)
                Me.Close()
                frmCajeroOpciones.Show()
            Else
                MsgBox("Ingrese un valor valido", vbCritical + vbOKOnly, "Error")
            End If
        Else
            MsgBox("Ingrese un valor valido", vbCritical + vbOKOnly, "Error")

        End If
    End Sub

    Private Sub txtReferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReferencia.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class