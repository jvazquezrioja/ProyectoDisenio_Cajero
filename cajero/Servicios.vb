Public Class FrmPagoservicio
    Private Sub FrmPagoservicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmCajeroAcceso.idioma Then 'Usa la variable global idiomas para detemrinar
            pnlEspañol.Visible = True  'sí carga el panel con la interfaz en íngles o español
            pnlEnglish.Visible = False
        Else
            pnlEspañol.Visible = False
            pnlEnglish.Visible = True
        End If
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
    'Versión del codigo en inglés
    Private Sub btnElectricity_Click(sender As Object, e As EventArgs) Handles btnElectricity.Click
        setServicio("Electricty")
    End Sub

    Private Sub btnOther_Click(sender As Object, e As EventArgs) Handles btnOther.Click
        setServicio("Other")
    End Sub

    Private Sub btnWater_Click(sender As Object, e As EventArgs) Handles btnWater.Click
        setServicio("Water")
    End Sub

    Private Sub btnInternete_Click(sender As Object, e As EventArgs) Handles btnInternete.Click
        Servicio = "Internet" 'Cambia el valor de Servicio directamente, sin irse a setServicio
        Me.Hide()
        FrmCompañiasint.Show()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        FrmCompañiasint.Dispose()
        Me.Close()
        frmCajeroOpciones.Show()
    End Sub
End Class
