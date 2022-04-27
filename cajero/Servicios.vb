Public Class FrmPagoservicio
    Public Servicio As String
    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        FrmCompañiasint.Dispose()
        Me.Close()
        frmCajeroOpciones.Show()
    End Sub

    Private Sub BtnLuz_Click(sender As Object, e As EventArgs) Handles BtnLuz.Click
        setServicio("Luz")
    End Sub

    Private Sub BtnOtro_Click(sender As Object, e As EventArgs) Handles BtnOtro.Click
        setServicio("Otro")
    End Sub

    Private Sub BtnAgua_Click(sender As Object, e As EventArgs) Handles BtnAgua.Click
        setServicio("Agua")
    End Sub

    Private Sub BtnInternet_Click(sender As Object, e As EventArgs) Handles BtnInternet.Click
        Servicio = "Internet"
        Me.Hide()
        FrmCompañiasint.ShowDialog()
    End Sub
    Private Sub setServicio(tipo As String)
        Servicio = tipo
        Me.Hide()
        FrmDatos.Show()
    End Sub

    Private Sub FrmPagoservicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
