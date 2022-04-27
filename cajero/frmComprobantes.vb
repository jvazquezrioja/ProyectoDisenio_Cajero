Public Class frmComprobantes
    Private Sub frmComprobantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim pruebaArray As String = frmCajeroOpciones.conjuntoDeOperaciones(0)
        'lbxComprobantes.Items.Add(pruebaArray)
        If frmCajeroOpciones.conjuntoDeOperaciones.Count = 0 Then
            lbxComprobantes.Items.Add("No hay transacciones recientes")
        Else
            For i As Integer = 0 To frmCajeroOpciones.conjuntoDeOperaciones.Count - 1
                Dim pruebaArray As String = frmCajeroOpciones.conjuntoDeOperaciones(i)
                lbxComprobantes.Items.Add(pruebaArray)
            Next
        End If

    End Sub
End Class