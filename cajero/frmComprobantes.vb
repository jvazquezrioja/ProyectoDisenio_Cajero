Public Class frmComprobantes
    Private Sub frmComprobantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not FrmAcceso.idioma Then
            versionEnIngles()
        End If

        If FrmOpciones.conjuntoDeOperaciones.Count = 0 Then
            If FrmAcceso.idioma Then
                lbxComprobantes.Items.Add("No hay transacciones recientes")
            Else
                lbxComprobantes.Items.Add("No recent transactions")
            End If
        Else
            For i As Integer = 0 To FrmOpciones.conjuntoDeOperaciones.Count - 1
                Dim pruebaArray As String = FrmOpciones.conjuntoDeOperaciones(i)
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