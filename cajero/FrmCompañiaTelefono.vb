Public Class FrmCompania
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not FrmAcceso.idioma Then 'Revisa sí la idioma es false(versión inglés)
            versionEnIngles()
        End If
    End Sub

    Private Sub versionEnIngles() 'Cambia el texto de todos los elementos a su traducción en inglés
        BtnRegresar.Text = "Return"

        lblInstruccion.Text = "Slect your provider"
        lblInstruccion.Left = (lblInstruccion.Parent.Width \ 2) - (lblInstruccion.Width \ 2)
        lblInstruccion.Top = (lblInstruccion.Parent.Height \ 2) - (lblInstruccion.Height \ 2)

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click 'Cierra todo y abre el menu de opciones
        FrmTelefono.Dispose()
        FrmTiempoAire.Dispose()
        Me.Close()
        FrmAcceso.Show()
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