Public Class FrmTelefono
    Public valor As Integer 'Valor de recarga seleccionado en el FrmTiempoAire
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        IngresarNumero(1) 'Llama al metodo de IngresarNumero
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        IngresarNumero(2) 'Llama al metodo de IngresarNumero
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        IngresarNumero(3) 'Llama al metodo de IngresarNumero
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        IngresarNumero(4) 'Llama al metodo de IngresarNumero
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        IngresarNumero(5) 'Llama al metodo de IngresarNumero
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        IngresarNumero(6) 'Llama al metodo de IngresarNumero
    End Sub
    Private Sub IngresarNumero(numero As Integer) 'Metodo para insertar numeros
        If (TbxNumero.Text.Length < 10) Then 'Revisa si el textbox no contiene mas de 10 digitos
            TbxNumero.Text = TbxNumero.Text + numero.ToString 'Añade el digito del boton presionado
        End If
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        IngresarNumero(7) 'Llama al metodo de IngresarNumero
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        IngresarNumero(8) 'Llama al metodo de IngresarNumero
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        IngresarNumero(9) 'Llama al metodo de IngresarNumero
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        IngresarNumero(0) ''Llama al metodo de IngresarNumero
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        TbxNumero.Text = "" 'Borra los numeros del textbox
        Me.Close() 'Cierra el form
        FrmTiempoAire.Show() 'Abre el form de tiempo aire
    End Sub

    Private Sub BtnContinuar_Click(sender As Object, e As EventArgs) Handles BtnContinuar.Click
        If (TbxNumero.Text = "" Or TbxNumero.Text.Count <> 10 Or frmCajeroAcceso.saldo < valor) Then 'Revisa si el textbox no esta vacio y si tiene 10 digitos, ademas de ver que se pueda pagar
            MsgBox("Ingrese un numero valido", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Aviso") 'Avisa que algo esta mal en los datos
        Else
            MsgBox("Se realizo la recarga de la compañia " + FrmTiempoAire.compania + " de un valor de " + valor.ToString + " al numero de " + TbxNumero.Text, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Aviso") 'Imprime que se logro hacer la transaccion
            frmCajeroAcceso.saldo = frmCajeroAcceso.saldo - valor 'Cambia la variable de saldo
            FrmCompania.Dispose() 'Descarga el form de compañia
            FrmTiempoAire.Dispose() 'Descarga el form de tiempo aire
            Me.Close() 'Se cierra este form
            frmCajeroAcceso.Show() 'Abre el menu de opciones
        End If

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        If TbxNumero.Text.Length <> 0 Then 'Revisa si el textbox no esta vacio
            TbxNumero.Text = TbxNumero.Text.Remove(TbxNumero.Text.Length - 1) 'Elimina el ultimo digito de la textbox
        End If
    End Sub

    Private Sub TbxNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbxNumero.KeyPress
        If Not IsNumeric(e.KeyChar) Then 'Revisa que la tecla presionada sea un numero
            e.Handled = True 'Si es asi deja que se inserte el numero
        End If
    End Sub
End Class