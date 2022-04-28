Public Class FrmCompania
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click 'Cierra todo y abre el menu de opciones
        FrmTelefono.Dispose()
        FrmTiempoAire.Dispose()
        Me.Close()
        frmCajeroAcceso.Show()
    End Sub

    Private Sub BtnWeex_Click(sender As Object, e As EventArgs) Handles BtnWeex.Click 'Oculta este form y setea el valor de FrmTiempoAire.compania en Weex
        FrmTiempoAire.compania = "Weex"
        Me.Hide()
        FrmTiempoAire.ShowDialog()
    End Sub

    Private Sub BtnUnefon_Click(sender As Object, e As EventArgs) Handles BtnUnefon.Click 'Oculta este form y setea el valor de FrmTiempoAire.compania en Unefon
        FrmTiempoAire.compania = "Unefon"
        Me.Hide()
        FrmTiempoAire.ShowDialog()
    End Sub

    Private Sub BtnMovistar_Click(sender As Object, e As EventArgs) Handles BtnMovistar.Click 'Oculta este form y setea el valor de FrmTiempoAire.compania en Movistar
        FrmTiempoAire.compania = "Movistar"
        Me.Hide()
        FrmTiempoAire.ShowDialog()
    End Sub

    Private Sub BtnTelcel_Click(sender As Object, e As EventArgs) Handles BtnTelcel.Click 'Oculta este form y setea el valor de FrmTiempoAire.compania en Telcel
        FrmTiempoAire.compania = "Telcel"
        Me.Hide()
        FrmTiempoAire.ShowDialog()
    End Sub
End Class