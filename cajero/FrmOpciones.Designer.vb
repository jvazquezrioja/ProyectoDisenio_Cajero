<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOpciones
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpciones))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGenerarComprobante = New System.Windows.Forms.Button()
        Me.btnPagarServicios = New System.Windows.Forms.Button()
        Me.btnTiempoAire = New System.Windows.Forms.Button()
        Me.btnTransferirDinero = New System.Windows.Forms.Button()
        Me.btnRetirarDinero = New System.Windows.Forms.Button()
        Me.btnConsultaSaldo = New System.Windows.Forms.Button()
        Me.lblInstruccion = New System.Windows.Forms.Label()
        Me.pbxNombreBanco = New System.Windows.Forms.PictureBox()
        Me.pbxLogoBanco = New System.Windows.Forms.PictureBox()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSalir.Location = New System.Drawing.Point(573, 310)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(97, 45)
        Me.btnSalir.TabIndex = 28
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGenerarComprobante
        '
        Me.btnGenerarComprobante.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGenerarComprobante.Location = New System.Drawing.Point(573, 256)
        Me.btnGenerarComprobante.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGenerarComprobante.Name = "btnGenerarComprobante"
        Me.btnGenerarComprobante.Size = New System.Drawing.Size(97, 45)
        Me.btnGenerarComprobante.TabIndex = 27
        Me.btnGenerarComprobante.Text = "Generar Comprobante"
        Me.btnGenerarComprobante.UseVisualStyleBackColor = True
        '
        'btnPagarServicios
        '
        Me.btnPagarServicios.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPagarServicios.Location = New System.Drawing.Point(573, 198)
        Me.btnPagarServicios.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPagarServicios.Name = "btnPagarServicios"
        Me.btnPagarServicios.Size = New System.Drawing.Size(97, 45)
        Me.btnPagarServicios.TabIndex = 26
        Me.btnPagarServicios.Text = "Pagar Servicios"
        Me.btnPagarServicios.UseVisualStyleBackColor = True
        '
        'btnTiempoAire
        '
        Me.btnTiempoAire.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTiempoAire.Location = New System.Drawing.Point(573, 137)
        Me.btnTiempoAire.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTiempoAire.Name = "btnTiempoAire"
        Me.btnTiempoAire.Size = New System.Drawing.Size(97, 45)
        Me.btnTiempoAire.TabIndex = 25
        Me.btnTiempoAire.Text = "Tiempo Aire"
        Me.btnTiempoAire.UseVisualStyleBackColor = True
        '
        'btnTransferirDinero
        '
        Me.btnTransferirDinero.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTransferirDinero.Location = New System.Drawing.Point(36, 256)
        Me.btnTransferirDinero.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTransferirDinero.Name = "btnTransferirDinero"
        Me.btnTransferirDinero.Size = New System.Drawing.Size(97, 45)
        Me.btnTransferirDinero.TabIndex = 24
        Me.btnTransferirDinero.Text = "Transferir Dinero"
        Me.btnTransferirDinero.UseVisualStyleBackColor = True
        '
        'btnRetirarDinero
        '
        Me.btnRetirarDinero.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRetirarDinero.Location = New System.Drawing.Point(36, 198)
        Me.btnRetirarDinero.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRetirarDinero.Name = "btnRetirarDinero"
        Me.btnRetirarDinero.Size = New System.Drawing.Size(97, 45)
        Me.btnRetirarDinero.TabIndex = 23
        Me.btnRetirarDinero.Text = "Retirar Dinero"
        Me.btnRetirarDinero.UseVisualStyleBackColor = True
        '
        'btnConsultaSaldo
        '
        Me.btnConsultaSaldo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnConsultaSaldo.Location = New System.Drawing.Point(36, 142)
        Me.btnConsultaSaldo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnConsultaSaldo.Name = "btnConsultaSaldo"
        Me.btnConsultaSaldo.Size = New System.Drawing.Size(97, 45)
        Me.btnConsultaSaldo.TabIndex = 22
        Me.btnConsultaSaldo.Text = "Consultar Saldo"
        Me.btnConsultaSaldo.UseVisualStyleBackColor = True
        '
        'lblInstruccion
        '
        Me.lblInstruccion.AutoSize = True
        Me.lblInstruccion.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInstruccion.Location = New System.Drawing.Point(278, 183)
        Me.lblInstruccion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInstruccion.Name = "lblInstruccion"
        Me.lblInstruccion.Size = New System.Drawing.Size(146, 20)
        Me.lblInstruccion.TabIndex = 21
        Me.lblInstruccion.Text = "Selecciona una opción"
        Me.lblInstruccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbxNombreBanco
        '
        Me.pbxNombreBanco.BackgroundImage = CType(resources.GetObject("pbxNombreBanco.BackgroundImage"), System.Drawing.Image)
        Me.pbxNombreBanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxNombreBanco.Location = New System.Drawing.Point(124, 10)
        Me.pbxNombreBanco.Margin = New System.Windows.Forms.Padding(1)
        Me.pbxNombreBanco.Name = "pbxNombreBanco"
        Me.pbxNombreBanco.Size = New System.Drawing.Size(424, 92)
        Me.pbxNombreBanco.TabIndex = 30
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
        Me.pbxLogoBanco.TabIndex = 29
        Me.pbxLogoBanco.TabStop = False
        '
        'FrmOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(703, 386)
        Me.Controls.Add(Me.pbxNombreBanco)
        Me.Controls.Add(Me.pbxLogoBanco)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGenerarComprobante)
        Me.Controls.Add(Me.btnPagarServicios)
        Me.Controls.Add(Me.btnTiempoAire)
        Me.Controls.Add(Me.btnTransferirDinero)
        Me.Controls.Add(Me.btnRetirarDinero)
        Me.Controls.Add(Me.btnConsultaSaldo)
        Me.Controls.Add(Me.lblInstruccion)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmOpciones"
        Me.Text = "Menu Principal"
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGenerarComprobante As Button
    Friend WithEvents btnPagarServicios As Button
    Friend WithEvents btnTiempoAire As Button
    Friend WithEvents btnTransferirDinero As Button
    Friend WithEvents btnRetirarDinero As Button
    Friend WithEvents btnConsultaSaldo As Button
    Friend WithEvents lblInstruccion As Label
    Friend WithEvents pbxNombreBanco As PictureBox
    Friend WithEvents pbxLogoBanco As PictureBox
End Class
