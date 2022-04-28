Public Class FrmCompañiasint
    Public Compania As String
    Private Sub FrmCompañiasint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Not (frmCajeroAcceso.idioma)) Then 'Revisa sí la idioma es false(versión inglés)
            versionEnIngles()
        End If
    End Sub

    Private Sub versionEnIngles() 'Cambia el texto de todos los elementos a su traducción en inglés
        BtnRegresar.Text = "Return"

        LblInstruccion.Text = "Choose your internet provider"
        LblInstruccion.Left = (LblInstruccion.Parent.Width \ 2) - (LblInstruccion.Width \ 2)
        LblInstruccion.Top = (LblInstruccion.Parent.Height \ 2) - (LblInstruccion.Height \ 2)

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
        FrmPagoservicio.Show()
    End Sub

    Private Sub BtnInfinitum_Click(sender As Object, e As EventArgs) Handles BtnInfinitum.Click
        setCompania("Infinitum")
    End Sub

    Private Sub BtnMovistar_Click(sender As Object, e As EventArgs) Handles BtnMovistar.Click
        setCompania("Movistar")
    End Sub

    Private Sub BtnMegacable_Click(sender As Object, e As EventArgs) Handles BtnMegacable.Click
        setCompania("Megacable")
    End Sub

    Private Sub BtnIzzi_Click(sender As Object, e As EventArgs) Handles BtnIzzi.Click
        setCompania("Izzi")
    End Sub
    Private Sub setCompania(texto As String)
        Compania = texto
        Me.Hide()
        FrmDatos.Show()
    End Sub

End Class