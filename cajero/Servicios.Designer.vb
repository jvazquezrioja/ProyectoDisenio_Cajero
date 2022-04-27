<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPagoservicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPagoservicio))
        Me.LblInstruccion = New System.Windows.Forms.Label()
        Me.btnLuz = New System.Windows.Forms.Button()
        Me.btnInternet = New System.Windows.Forms.Button()
        Me.btnAgua = New System.Windows.Forms.Button()
        Me.btnOtro = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.pnlEspañol = New System.Windows.Forms.Panel()
        Me.pbxNombreBanco = New System.Windows.Forms.PictureBox()
        Me.pbxLogoBanco = New System.Windows.Forms.PictureBox()
        Me.pnlEnglish = New System.Windows.Forms.Panel()
        Me.btnWater = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOther = New System.Windows.Forms.Button()
        Me.btnElectricity = New System.Windows.Forms.Button()
        Me.btnInternete = New System.Windows.Forms.Button()
        Me.pnlEspañol.SuspendLayout()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEnglish.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblInstruccion
        '
        Me.LblInstruccion.AutoSize = True
        Me.LblInstruccion.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblInstruccion.Location = New System.Drawing.Point(335, 308)
        Me.LblInstruccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblInstruccion.Name = "LblInstruccion"
        Me.LblInstruccion.Size = New System.Drawing.Size(335, 29)
        Me.LblInstruccion.TabIndex = 1
        Me.LblInstruccion.Text = "Seleccione el tipo de servicio a pagar"
        '
        'btnLuz
        '
        Me.btnLuz.Location = New System.Drawing.Point(51, 237)
        Me.btnLuz.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLuz.Name = "btnLuz"
        Me.btnLuz.Size = New System.Drawing.Size(136, 65)
        Me.btnLuz.TabIndex = 2
        Me.btnLuz.Text = "Luz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CFE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnLuz.UseVisualStyleBackColor = True
        '
        'btnInternet
        '
        Me.btnInternet.Location = New System.Drawing.Point(818, 228)
        Me.btnInternet.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInternet.Name = "btnInternet"
        Me.btnInternet.Size = New System.Drawing.Size(136, 65)
        Me.btnInternet.TabIndex = 3
        Me.btnInternet.Text = "Internet"
        Me.btnInternet.UseVisualStyleBackColor = True
        '
        'btnAgua
        '
        Me.btnAgua.Location = New System.Drawing.Point(52, 330)
        Me.btnAgua.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgua.Name = "btnAgua"
        Me.btnAgua.Size = New System.Drawing.Size(136, 65)
        Me.btnAgua.TabIndex = 4
        Me.btnAgua.Text = "Agua" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CEA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnAgua.UseVisualStyleBackColor = True
        '
        'btnOtro
        '
        Me.btnOtro.Location = New System.Drawing.Point(818, 330)
        Me.btnOtro.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOtro.Name = "btnOtro"
        Me.btnOtro.Size = New System.Drawing.Size(136, 65)
        Me.btnOtro.TabIndex = 5
        Me.btnOtro.Text = "Otros"
        Me.btnOtro.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(818, 517)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(136, 65)
        Me.btnRegresar.TabIndex = 6
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'pnlEspañol
        '
        Me.pnlEspañol.Controls.Add(Me.btnAgua)
        Me.pnlEspañol.Controls.Add(Me.btnRegresar)
        Me.pnlEspañol.Controls.Add(Me.LblInstruccion)
        Me.pnlEspañol.Controls.Add(Me.btnOtro)
        Me.pnlEspañol.Controls.Add(Me.btnLuz)
        Me.pnlEspañol.Controls.Add(Me.btnInternet)
        Me.pnlEspañol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEspañol.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pnlEspañol.Location = New System.Drawing.Point(0, 0)
        Me.pnlEspañol.Name = "pnlEspañol"
        Me.pnlEspañol.Size = New System.Drawing.Size(1004, 644)
        Me.pnlEspañol.TabIndex = 7
        '
        'pbxNombreBanco
        '
        Me.pbxNombreBanco.Image = CType(resources.GetObject("pbxNombreBanco.Image"), System.Drawing.Image)
        Me.pbxNombreBanco.Location = New System.Drawing.Point(175, 12)
        Me.pbxNombreBanco.Name = "pbxNombreBanco"
        Me.pbxNombreBanco.Size = New System.Drawing.Size(606, 154)
        Me.pbxNombreBanco.TabIndex = 12
        Me.pbxNombreBanco.TabStop = False
        '
        'pbxLogoBanco
        '
        Me.pbxLogoBanco.Image = CType(resources.GetObject("pbxLogoBanco.Image"), System.Drawing.Image)
        Me.pbxLogoBanco.Location = New System.Drawing.Point(12, 12)
        Me.pbxLogoBanco.Name = "pbxLogoBanco"
        Me.pbxLogoBanco.Size = New System.Drawing.Size(145, 154)
        Me.pbxLogoBanco.TabIndex = 11
        Me.pbxLogoBanco.TabStop = False
        '
        'pnlEnglish
        '
        Me.pnlEnglish.Controls.Add(Me.btnWater)
        Me.pnlEnglish.Controls.Add(Me.btnReturn)
        Me.pnlEnglish.Controls.Add(Me.Label1)
        Me.pnlEnglish.Controls.Add(Me.btnOther)
        Me.pnlEnglish.Controls.Add(Me.btnElectricity)
        Me.pnlEnglish.Controls.Add(Me.btnInternete)
        Me.pnlEnglish.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pnlEnglish.Location = New System.Drawing.Point(8, 8)
        Me.pnlEnglish.Name = "pnlEnglish"
        Me.pnlEnglish.Size = New System.Drawing.Size(1004, 644)
        Me.pnlEnglish.TabIndex = 13
        '
        'btnWater
        '
        Me.btnWater.Location = New System.Drawing.Point(52, 330)
        Me.btnWater.Margin = New System.Windows.Forms.Padding(4)
        Me.btnWater.Name = "btnWater"
        Me.btnWater.Size = New System.Drawing.Size(136, 65)
        Me.btnWater.TabIndex = 4
        Me.btnWater.Text = "Water" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CEA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnWater.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(818, 517)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(136, 65)
        Me.btnReturn.TabIndex = 6
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(335, 308)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione el tipo de servicio a pagar"
        '
        'btnOther
        '
        Me.btnOther.Location = New System.Drawing.Point(818, 330)
        Me.btnOther.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOther.Name = "btnOther"
        Me.btnOther.Size = New System.Drawing.Size(136, 65)
        Me.btnOther.TabIndex = 5
        Me.btnOther.Text = "Other"
        Me.btnOther.UseVisualStyleBackColor = True
        '
        'btnElectricity
        '
        Me.btnElectricity.Location = New System.Drawing.Point(51, 237)
        Me.btnElectricity.Margin = New System.Windows.Forms.Padding(4)
        Me.btnElectricity.Name = "btnElectricity"
        Me.btnElectricity.Size = New System.Drawing.Size(136, 65)
        Me.btnElectricity.TabIndex = 2
        Me.btnElectricity.Text = "Electricity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CFE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnElectricity.UseVisualStyleBackColor = True
        '
        'btnInternete
        '
        Me.btnInternete.Location = New System.Drawing.Point(818, 228)
        Me.btnInternete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInternete.Name = "btnInternete"
        Me.btnInternete.Size = New System.Drawing.Size(136, 65)
        Me.btnInternete.TabIndex = 3
        Me.btnInternete.Text = "Internet"
        Me.btnInternete.UseVisualStyleBackColor = True
        '
        'FrmPagoservicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1004, 644)
        Me.Controls.Add(Me.pbxNombreBanco)
        Me.Controls.Add(Me.pbxLogoBanco)
        Me.Controls.Add(Me.pnlEspañol)
        Me.Controls.Add(Me.pnlEnglish)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPagoservicio"
        Me.Text = "Pagar Servicios"
        Me.pnlEspañol.ResumeLayout(False)
        Me.pnlEspañol.PerformLayout()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEnglish.ResumeLayout(False)
        Me.pnlEnglish.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblInstruccion As Label
    Friend WithEvents btnLuz As Button
    Friend WithEvents btnInternet As Button
    Friend WithEvents btnAgua As Button
    Friend WithEvents btnOtro As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents pnlEspañol As Panel
    Friend WithEvents pbxNombreBanco As PictureBox
    Friend WithEvents pbxLogoBanco As PictureBox
    Friend WithEvents pnlEnglish As Panel
    Friend WithEvents btnWater As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnOther As Button
    Friend WithEvents btnElectricity As Button
    Friend WithEvents btnInternete As Button
End Class
