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
        Me.PnlFondo = New System.Windows.Forms.Panel()
        Me.Pbxbanco = New System.Windows.Forms.PictureBox()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.LblInstruccion = New System.Windows.Forms.Label()
        Me.BtnLuz = New System.Windows.Forms.Button()
        Me.BtnInternet = New System.Windows.Forms.Button()
        Me.BtnAgua = New System.Windows.Forms.Button()
        Me.BtnOtro = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.PnlFondo.SuspendLayout()
        CType(Me.Pbxbanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlFondo
        '
        Me.PnlFondo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PnlFondo.Controls.Add(Me.Pbxbanco)
        Me.PnlFondo.Controls.Add(Me.PbxLogo)
        Me.PnlFondo.Location = New System.Drawing.Point(-5, 0)
        Me.PnlFondo.Name = "PnlFondo"
        Me.PnlFondo.Size = New System.Drawing.Size(1072, 149)
        Me.PnlFondo.TabIndex = 0
        '
        'Pbxbanco
        '
        Me.Pbxbanco.Image = CType(resources.GetObject("Pbxbanco.Image"), System.Drawing.Image)
        Me.Pbxbanco.Location = New System.Drawing.Point(161, 13)
        Me.Pbxbanco.Name = "Pbxbanco"
        Me.Pbxbanco.Size = New System.Drawing.Size(339, 124)
        Me.Pbxbanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbxbanco.TabIndex = 1
        Me.Pbxbanco.TabStop = False
        '
        'PbxLogo
        '
        Me.PbxLogo.Image = CType(resources.GetObject("PbxLogo.Image"), System.Drawing.Image)
        Me.PbxLogo.Location = New System.Drawing.Point(35, 13)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(130, 124)
        Me.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxLogo.TabIndex = 0
        Me.PbxLogo.TabStop = False
        '
        'LblInstruccion
        '
        Me.LblInstruccion.AutoSize = True
        Me.LblInstruccion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblInstruccion.Location = New System.Drawing.Point(352, 165)
        Me.LblInstruccion.Name = "LblInstruccion"
        Me.LblInstruccion.Size = New System.Drawing.Size(334, 28)
        Me.LblInstruccion.TabIndex = 1
        Me.LblInstruccion.Text = "Seleccione el tipo de servicio a pagar"
        '
        'BtnLuz
        '
        Me.BtnLuz.Location = New System.Drawing.Point(12, 221)
        Me.BtnLuz.Name = "BtnLuz"
        Me.BtnLuz.Size = New System.Drawing.Size(235, 100)
        Me.BtnLuz.TabIndex = 2
        Me.BtnLuz.Text = "Luz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CFE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnLuz.UseVisualStyleBackColor = True
        '
        'BtnInternet
        '
        Me.BtnInternet.Location = New System.Drawing.Point(12, 348)
        Me.BtnInternet.Name = "BtnInternet"
        Me.BtnInternet.Size = New System.Drawing.Size(235, 100)
        Me.BtnInternet.TabIndex = 3
        Me.BtnInternet.Text = "Internet"
        Me.BtnInternet.UseVisualStyleBackColor = True
        '
        'BtnAgua
        '
        Me.BtnAgua.Location = New System.Drawing.Point(803, 221)
        Me.BtnAgua.Name = "BtnAgua"
        Me.BtnAgua.Size = New System.Drawing.Size(235, 100)
        Me.BtnAgua.TabIndex = 4
        Me.BtnAgua.Text = "Agua" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CEA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnAgua.UseVisualStyleBackColor = True
        '
        'BtnOtro
        '
        Me.BtnOtro.Location = New System.Drawing.Point(803, 348)
        Me.BtnOtro.Name = "BtnOtro"
        Me.BtnOtro.Size = New System.Drawing.Size(235, 100)
        Me.BtnOtro.TabIndex = 5
        Me.BtnOtro.Text = "Otros"
        Me.BtnOtro.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(12, 485)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(235, 100)
        Me.BtnRegresar.TabIndex = 6
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'FrmPagoservicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 610)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnOtro)
        Me.Controls.Add(Me.BtnAgua)
        Me.Controls.Add(Me.BtnInternet)
        Me.Controls.Add(Me.BtnLuz)
        Me.Controls.Add(Me.LblInstruccion)
        Me.Controls.Add(Me.PnlFondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPagoservicio"
        Me.Text = "Form1"
        Me.PnlFondo.ResumeLayout(False)
        CType(Me.Pbxbanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlFondo As Panel
    Friend WithEvents Pbxbanco As PictureBox
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents LblInstruccion As Label
    Friend WithEvents BtnLuz As Button
    Friend WithEvents BtnInternet As Button
    Friend WithEvents BtnAgua As Button
    Friend WithEvents BtnOtro As Button
    Friend WithEvents BtnRegresar As Button
End Class
