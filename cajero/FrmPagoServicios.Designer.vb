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
        Me.btnAgua = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.LblInstruccion = New System.Windows.Forms.Label()
        Me.btnOtro = New System.Windows.Forms.Button()
        Me.btnLuz = New System.Windows.Forms.Button()
        Me.btnInternet = New System.Windows.Forms.Button()
        Me.pbxNombreBanco = New System.Windows.Forms.PictureBox()
        Me.pbxLogoBanco = New System.Windows.Forms.PictureBox()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgua
        '
        Me.btnAgua.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAgua.Location = New System.Drawing.Point(36, 198)
        Me.btnAgua.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAgua.Name = "btnAgua"
        Me.btnAgua.Size = New System.Drawing.Size(95, 47)
        Me.btnAgua.TabIndex = 16
        Me.btnAgua.Text = "Agua" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CEA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnAgua.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRegresar.Location = New System.Drawing.Point(573, 310)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(95, 47)
        Me.btnRegresar.TabIndex = 18
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'LblInstruccion
        '
        Me.LblInstruccion.AutoSize = True
        Me.LblInstruccion.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblInstruccion.Location = New System.Drawing.Point(241, 205)
        Me.LblInstruccion.Name = "LblInstruccion"
        Me.LblInstruccion.Size = New System.Drawing.Size(238, 20)
        Me.LblInstruccion.TabIndex = 13
        Me.LblInstruccion.Text = "Seleccione el tipo de servicio a pagar"
        '
        'btnOtro
        '
        Me.btnOtro.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnOtro.Location = New System.Drawing.Point(573, 198)
        Me.btnOtro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOtro.Name = "btnOtro"
        Me.btnOtro.Size = New System.Drawing.Size(95, 47)
        Me.btnOtro.TabIndex = 17
        Me.btnOtro.Text = "Otros"
        Me.btnOtro.UseVisualStyleBackColor = True
        '
        'btnLuz
        '
        Me.btnLuz.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLuz.Location = New System.Drawing.Point(36, 142)
        Me.btnLuz.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLuz.Name = "btnLuz"
        Me.btnLuz.Size = New System.Drawing.Size(95, 47)
        Me.btnLuz.TabIndex = 14
        Me.btnLuz.Text = "Luz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CFE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnLuz.UseVisualStyleBackColor = True
        '
        'btnInternet
        '
        Me.btnInternet.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnInternet.Location = New System.Drawing.Point(573, 137)
        Me.btnInternet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInternet.Name = "btnInternet"
        Me.btnInternet.Size = New System.Drawing.Size(95, 47)
        Me.btnInternet.TabIndex = 15
        Me.btnInternet.Text = "Internet"
        Me.btnInternet.UseVisualStyleBackColor = True
        '
        'pbxNombreBanco
        '
        Me.pbxNombreBanco.BackgroundImage = CType(resources.GetObject("pbxNombreBanco.BackgroundImage"), System.Drawing.Image)
        Me.pbxNombreBanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxNombreBanco.Location = New System.Drawing.Point(124, 10)
        Me.pbxNombreBanco.Margin = New System.Windows.Forms.Padding(1)
        Me.pbxNombreBanco.Name = "pbxNombreBanco"
        Me.pbxNombreBanco.Size = New System.Drawing.Size(424, 92)
        Me.pbxNombreBanco.TabIndex = 32
        Me.pbxNombreBanco.TabStop = False
        '
        'pbxLogoBanco
        '
        Me.pbxLogoBanco.BackgroundImage = CType(resources.GetObject("pbxLogoBanco.BackgroundImage"), System.Drawing.Image)
        Me.pbxLogoBanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxLogoBanco.Location = New System.Drawing.Point(10, 10)
        Me.pbxLogoBanco.Margin = New System.Windows.Forms.Padding(1)
        Me.pbxLogoBanco.Name = "pbxLogoBanco"
        Me.pbxLogoBanco.Size = New System.Drawing.Size(102, 92)
        Me.pbxLogoBanco.TabIndex = 31
        Me.pbxLogoBanco.TabStop = False
        '
        'FrmPagoservicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(703, 386)
        Me.Controls.Add(Me.pbxNombreBanco)
        Me.Controls.Add(Me.pbxLogoBanco)
        Me.Controls.Add(Me.btnAgua)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.LblInstruccion)
        Me.Controls.Add(Me.btnOtro)
        Me.Controls.Add(Me.btnLuz)
        Me.Controls.Add(Me.btnInternet)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmPagoservicio"
        Me.Text = "Pagar Servicios"
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgua As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents LblInstruccion As Label
    Friend WithEvents btnOtro As Button
    Friend WithEvents btnLuz As Button
    Friend WithEvents btnInternet As Button
    Friend WithEvents pbxNombreBanco As PictureBox
    Friend WithEvents pbxLogoBanco As PictureBox
End Class
