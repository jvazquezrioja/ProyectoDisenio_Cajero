Public Class FrmPagoservicio
    Private Sub FrmPagoservicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Not (frmCajeroAcceso.idioma)) Then 'Revisa sí la idioma es false(versión inglés)
            versionEnIngles()
        End If
    End Sub

    Private Sub versionEnIngles() 'Cambia el texto de todos los elementos a su traducción en inglés
        btnLuz.Text = "ElectricityCFE"
        btnAgua.Text = "WaterCEA"
        btnOtro.Text = "Other"
        btnRegresar.Text = "Return"

        LblInstruccion.Text = "Choose a utiliy"
        LblInstruccion.Left = (LblInstruccion.Parent.Width \ 2) - (LblInstruccion.Width \ 2)
        LblInstruccion.Top = (LblInstruccion.Parent.Height \ 2) - (LblInstruccion.Height \ 2)

    End Sub
    Public Servicio As String 'Variable global que contiene el servicio dependiendo del boton seleccionado

    'Los botones de los servicios al ser seleccionados hacen uso del metodo serServicio para cambiar el valor de la variable
    Private Sub btnLuz_Click(sender As Object, e As EventArgs) Handles btnLuz.Click
        setServicio("Luz")
    End Sub

    Private Sub btnOtro_Click(sender As Object, e As EventArgs) Handles btnOtro.Click
        setServicio("Otro")
    End Sub

    Private Sub btnAgua_Click(sender As Object, e As EventArgs) Handles btnAgua.Click
        setServicio("Agua")
    End Sub

    Private Sub btnInternet_Click(sender As Object, e As EventArgs) Handles btnInternet.Click
        Servicio = "Internet" 'Cambia el valor de Servicio directamente, sin irse a setServicio
        Me.Hide()
        FrmCompañiasint.Show() 'Muestra el form CompaniasInt para que el usuario seleccione una compaía antes de llegar al Form DatosPago
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        FrmCompañiasint.Dispose()
        Me.Close()
        frmCajeroOpciones.Show()
    End Sub

    Private Sub setServicio(tipo As String) 'Proceso que cambia el valor de Servicio
        Servicio = tipo
        Me.Hide()
        frmDatos.Show() 'Abre el Form de DatosPago
    End Sub

End Class
