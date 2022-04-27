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
        Me.BtnLuz = New System.Windows.Forms.Button()
        Me.BtnInternet = New System.Windows.Forms.Button()
        Me.BtnAgua = New System.Windows.Forms.Button()
        Me.BtnOtro = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.pnlEspañol = New System.Windows.Forms.Panel()
        Me.pbxNombreBanco = New System.Windows.Forms.PictureBox()
        Me.pbxLogoBanco = New System.Windows.Forms.PictureBox()
        Me.pnlEspañol.SuspendLayout()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblInstruccion
        '
        Me.LblInstruccion.AutoSize = True
        Me.LblInstruccion.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblInstruccion.Location = New System.Drawing.Point(297, 306)
        Me.LblInstruccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblInstruccion.Name = "LblInstruccion"
        Me.LblInstruccion.Size = New System.Drawing.Size(335, 29)
        Me.LblInstruccion.TabIndex = 1
        Me.LblInstruccion.Text = "Seleccione el tipo de servicio a pagar"
        '
        'BtnLuz
        '
        Me.BtnLuz.Location = New System.Drawing.Point(51, 237)
        Me.BtnLuz.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLuz.Name = "BtnLuz"
        Me.BtnLuz.Size = New System.Drawing.Size(136, 65)
        Me.BtnLuz.TabIndex = 2
        Me.BtnLuz.Text = "Luz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CFE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnLuz.UseVisualStyleBackColor = True
        '
        'BtnInternet
        '
        Me.BtnInternet.Location = New System.Drawing.Point(818, 228)
        Me.BtnInternet.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnInternet.Name = "BtnInternet"
        Me.BtnInternet.Size = New System.Drawing.Size(136, 65)
        Me.BtnInternet.TabIndex = 3
        Me.BtnInternet.Text = "Internet"
        Me.BtnInternet.UseVisualStyleBackColor = True
        '
        'BtnAgua
        '
        Me.BtnAgua.Location = New System.Drawing.Point(52, 330)
        Me.BtnAgua.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAgua.Name = "BtnAgua"
        Me.BtnAgua.Size = New System.Drawing.Size(136, 65)
        Me.BtnAgua.TabIndex = 4
        Me.BtnAgua.Text = "Agua" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CEA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnAgua.UseVisualStyleBackColor = True
        '
        'BtnOtro
        '
        Me.BtnOtro.Location = New System.Drawing.Point(818, 330)
        Me.BtnOtro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnOtro.Name = "BtnOtro"
        Me.BtnOtro.Size = New System.Drawing.Size(136, 65)
        Me.BtnOtro.TabIndex = 5
        Me.BtnOtro.Text = "Otros"
        Me.BtnOtro.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(818, 517)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(136, 65)
        Me.btnRegresar.TabIndex = 6
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'pnlEspañol
        '
        Me.pnlEspañol.Controls.Add(Me.BtnAgua)
        Me.pnlEspañol.Controls.Add(Me.btnRegresar)
        Me.pnlEspañol.Controls.Add(Me.LblInstruccion)
        Me.pnlEspañol.Controls.Add(Me.BtnOtro)
        Me.pnlEspañol.Controls.Add(Me.BtnLuz)
        Me.pnlEspañol.Controls.Add(Me.BtnInternet)
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
        'FrmPagoservicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1004, 644)
        Me.Controls.Add(Me.pbxNombreBanco)
        Me.Controls.Add(Me.pbxLogoBanco)
        Me.Controls.Add(Me.pnlEspañol)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmPagoservicio"
        Me.Text = "Pagar Servicios"
        Me.pnlEspañol.ResumeLayout(False)
        Me.pnlEspañol.PerformLayout()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblInstruccion As Label
    Friend WithEvents BtnLuz As Button
    Friend WithEvents BtnInternet As Button
    Friend WithEvents BtnAgua As Button
    Friend WithEvents BtnOtro As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents pnlEspañol As Panel
    Friend WithEvents pbxNombreBanco As PictureBox
    Friend WithEvents pbxLogoBanco As PictureBox
End Class
