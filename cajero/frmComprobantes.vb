Public Class frmComprobantes
    Private Sub frmComprobantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmCajeroAcceso.idioma Then
        Else
            versionEnIngles()
        End If
        If frmCajeroOpciones.conjuntoDeOperaciones.Count = 0 Then
            If frmCajeroAcceso.idioma Then
                lbxComprobantes.Items.Add("No hay transacciones recientes")
            Else
                lbxComprobantes.Items.Add("No recent transactions")
            End If
        Else
            For i As Integer = 0 To frmCajeroOpciones.conjuntoDeOperaciones.Count - 1
                Dim pruebaArray As String = frmCajeroOpciones.conjuntoDeOperaciones(i)
                lbxComprobantes.Items.Add(pruebaArray)
            Next
        End If

    End Sub

    Private Sub versionEnIngles()
        btnRegresar.Text = "Return"
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
        Me.Dispose()
    End Sub



End Class