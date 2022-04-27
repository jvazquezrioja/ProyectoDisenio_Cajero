<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCajeroOpciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCajeroOpciones))
        Me.pbxNombreBanco = New System.Windows.Forms.PictureBox()
        Me.pbxLogoBanco = New System.Windows.Forms.PictureBox()
        Me.pnlEspañol = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGenerarComprobante = New System.Windows.Forms.Button()
        Me.btnPagarServicios = New System.Windows.Forms.Button()
        Me.btnTiempoAire = New System.Windows.Forms.Button()
        Me.btnTransferirDinero = New System.Windows.Forms.Button()
        Me.btnRetirarDinero = New System.Windows.Forms.Button()
        Me.btnConsultaSaldo = New System.Windows.Forms.Button()
        Me.lblInstrucción = New System.Windows.Forms.Label()
        Me.pnlEnglish = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnGenrateReceipt = New System.Windows.Forms.Button()
        Me.btnPayUtilities = New System.Windows.Forms.Button()
        Me.btnAirTime = New System.Windows.Forms.Button()
        Me.btnTransferMoney = New System.Windows.Forms.Button()
        Me.btnWithdrawCash = New System.Windows.Forms.Button()
        Me.btnCheckBalance = New System.Windows.Forms.Button()
        Me.lblOptions = New System.Windows.Forms.Label()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEspañol.SuspendLayout()
        Me.pnlEnglish.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbxNombreBanco
        '
        Me.pbxNombreBanco.Image = CType(resources.GetObject("pbxNombreBanco.Image"), System.Drawing.Image)
        Me.pbxNombreBanco.Location = New System.Drawing.Point(175, 12)
        Me.pbxNombreBanco.Name = "pbxNombreBanco"
        Me.pbxNombreBanco.Size = New System.Drawing.Size(606, 154)
        Me.pbxNombreBanco.TabIndex = 4
        Me.pbxNombreBanco.TabStop = False
        '
        'pbxLogoBanco
        '
        Me.pbxLogoBanco.Image = CType(resources.GetObject("pbxLogoBanco.Image"), System.Drawing.Image)
        Me.pbxLogoBanco.Location = New System.Drawing.Point(12, 12)
        Me.pbxLogoBanco.Name = "pbxLogoBanco"
        Me.pbxLogoBanco.Size = New System.Drawing.Size(145, 154)
        Me.pbxLogoBanco.TabIndex = 3
        Me.pbxLogoBanco.TabStop = False
        '
        'pnlEspañol
        '
        Me.pnlEspañol.Controls.Add(Me.btnSalir)
        Me.pnlEspañol.Controls.Add(Me.btnGenerarComprobante)
        Me.pnlEspañol.Controls.Add(Me.btnPagarServicios)
        Me.pnlEspañol.Controls.Add(Me.btnTiempoAire)
        Me.pnlEspañol.Controls.Add(Me.btnTransferirDinero)
        Me.pnlEspañol.Controls.Add(Me.btnRetirarDinero)
        Me.pnlEspañol.Controls.Add(Me.btnConsultaSaldo)
        Me.pnlEspañol.Controls.Add(Me.lblInstrucción)
        Me.pnlEspañol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEspañol.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pnlEspañol.Location = New System.Drawing.Point(0, 0)
        Me.pnlEspañol.Name = "pnlEspañol"
        Me.pnlEspañol.Size = New System.Drawing.Size(1004, 644)
        Me.pnlEspañol.TabIndex = 5
        Me.pnlEspañol.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(817, 526)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(136, 65)
        Me.btnSalir.TabIndex = 20
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGenerarComprobante
        '
        Me.btnGenerarComprobante.Location = New System.Drawing.Point(817, 437)
        Me.btnGenerarComprobante.Name = "btnGenerarComprobante"
        Me.btnGenerarComprobante.Size = New System.Drawing.Size(136, 65)
        Me.btnGenerarComprobante.TabIndex = 19
        Me.btnGenerarComprobante.Text = "Generar Comprobante"
        Me.btnGenerarComprobante.UseVisualStyleBackColor = True
        '
        'btnPagarServicios
        '
        Me.btnPagarServicios.Location = New System.Drawing.Point(817, 339)
        Me.btnPagarServicios.Name = "btnPagarServicios"
        Me.btnPagarServicios.Size = New System.Drawing.Size(136, 65)
        Me.btnPagarServicios.TabIndex = 18
        Me.btnPagarServicios.Text = "Pagar Servicios"
        Me.btnPagarServicios.UseVisualStyleBackColor = True
        '
        'btnTiempoAire
        '
        Me.btnTiempoAire.Location = New System.Drawing.Point(817, 237)
        Me.btnTiempoAire.Name = "btnTiempoAire"
        Me.btnTiempoAire.Size = New System.Drawing.Size(136, 65)
        Me.btnTiempoAire.TabIndex = 17
        Me.btnTiempoAire.Text = "Tiempo Aire"
        Me.btnTiempoAire.UseVisualStyleBackColor = True
        '
        'btnTransferirDinero
        '
        Me.btnTransferirDinero.Location = New System.Drawing.Point(51, 437)
        Me.btnTransferirDinero.Name = "btnTransferirDinero"
        Me.btnTransferirDinero.Size = New System.Drawing.Size(136, 65)
        Me.btnTransferirDinero.TabIndex = 16
        Me.btnTransferirDinero.Text = "Transferir Dinero"
        Me.btnTransferirDinero.UseVisualStyleBackColor = True
        '
        'btnRetirarDinero
        '
        Me.btnRetirarDinero.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRetirarDinero.Location = New System.Drawing.Point(51, 339)
        Me.btnRetirarDinero.Name = "btnRetirarDinero"
        Me.btnRetirarDinero.Size = New System.Drawing.Size(136, 65)
        Me.btnRetirarDinero.TabIndex = 15
        Me.btnRetirarDinero.Text = "Retirar Dinero"
        Me.btnRetirarDinero.UseVisualStyleBackColor = True
        '
        'btnConsultaSaldo
        '
        Me.btnConsultaSaldo.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnConsultaSaldo.Location = New System.Drawing.Point(51, 237)
        Me.btnConsultaSaldo.Name = "btnConsultaSaldo"
        Me.btnConsultaSaldo.Size = New System.Drawing.Size(136, 65)
        Me.btnConsultaSaldo.TabIndex = 14
        Me.btnConsultaSaldo.Text = "Consultar Saldo"
        Me.btnConsultaSaldo.UseVisualStyleBackColor = True
        '
        'lblInstrucción
        '
        Me.lblInstrucción.AutoSize = True
        Me.lblInstrucción.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInstrucción.Location = New System.Drawing.Point(408, 310)
        Me.lblInstrucción.Name = "lblInstrucción"
        Me.lblInstrucción.Size = New System.Drawing.Size(210, 29)
        Me.lblInstrucción.TabIndex = 13
        Me.lblInstrucción.Text = "Selecciona una opción"
        Me.lblInstrucción.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlEnglish
        '
        Me.pnlEnglish.Controls.Add(Me.btnExit)
        Me.pnlEnglish.Controls.Add(Me.btnGenrateReceipt)
        Me.pnlEnglish.Controls.Add(Me.btnPayUtilities)
        Me.pnlEnglish.Controls.Add(Me.btnAirTime)
        Me.pnlEnglish.Controls.Add(Me.btnTransferMoney)
        Me.pnlEnglish.Controls.Add(Me.btnWithdrawCash)
        Me.pnlEnglish.Controls.Add(Me.btnCheckBalance)
        Me.pnlEnglish.Controls.Add(Me.lblOptions)
        Me.pnlEnglish.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEnglish.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pnlEnglish.Location = New System.Drawing.Point(0, 0)
        Me.pnlEnglish.Name = "pnlEnglish"
        Me.pnlEnglish.Size = New System.Drawing.Size(1004, 644)
        Me.pnlEnglish.TabIndex = 6
        Me.pnlEnglish.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(817, 537)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(136, 65)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnGenrateReceipt
        '
        Me.btnGenrateReceipt.Location = New System.Drawing.Point(817, 437)
        Me.btnGenrateReceipt.Name = "btnGenrateReceipt"
        Me.btnGenrateReceipt.Size = New System.Drawing.Size(136, 65)
        Me.btnGenrateReceipt.TabIndex = 19
        Me.btnGenrateReceipt.Text = "Generate Receipt"
        Me.btnGenrateReceipt.UseVisualStyleBackColor = True
        '
        'btnPayUtilities
        '
        Me.btnPayUtilities.Location = New System.Drawing.Point(817, 339)
        Me.btnPayUtilities.Name = "btnPayUtilities"
        Me.btnPayUtilities.Size = New System.Drawing.Size(136, 65)
        Me.btnPayUtilities.TabIndex = 18
        Me.btnPayUtilities.Text = "Pay Utilites"
        Me.btnPayUtilities.UseVisualStyleBackColor = True
        '
        'btnAirTime
        '
        Me.btnAirTime.Location = New System.Drawing.Point(817, 237)
        Me.btnAirTime.Name = "btnAirTime"
        Me.btnAirTime.Size = New System.Drawing.Size(136, 65)
        Me.btnAirTime.TabIndex = 17
        Me.btnAirTime.Text = "Air Time"
        Me.btnAirTime.UseVisualStyleBackColor = True
        '
        'btnTransferMoney
        '
        Me.btnTransferMoney.Location = New System.Drawing.Point(51, 437)
        Me.btnTransferMoney.Name = "btnTransferMoney"
        Me.btnTransferMoney.Size = New System.Drawing.Size(136, 65)
        Me.btnTransferMoney.TabIndex = 16
        Me.btnTransferMoney.Text = "Transfer Money"
        Me.btnTransferMoney.UseVisualStyleBackColor = True
        '
        'btnWithdrawCash
        '
        Me.btnWithdrawCash.Location = New System.Drawing.Point(51, 339)
        Me.btnWithdrawCash.Name = "btnWithdrawCash"
        Me.btnWithdrawCash.Size = New System.Drawing.Size(136, 65)
        Me.btnWithdrawCash.TabIndex = 15
        Me.btnWithdrawCash.Text = "Withdraw Cash"
        Me.btnWithdrawCash.UseVisualStyleBackColor = True
        '
        'btnCheckBalance
        '
        Me.btnCheckBalance.Location = New System.Drawing.Point(51, 237)
        Me.btnCheckBalance.Name = "btnCheckBalance"
        Me.btnCheckBalance.Size = New System.Drawing.Size(136, 65)
        Me.btnCheckBalance.TabIndex = 14
        Me.btnCheckBalance.Text = "Check Balance"
        Me.btnCheckBalance.UseVisualStyleBackColor = True
        '
        'lblOptions
        '
        Me.lblOptions.AutoSize = True
        Me.lblOptions.Location = New System.Drawing.Point(425, 310)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(138, 24)
        Me.lblOptions.TabIndex = 13
        Me.lblOptions.Text = "Choose an option"
        Me.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCajeroOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1004, 644)
        Me.Controls.Add(Me.pbxNombreBanco)
        Me.Controls.Add(Me.pbxLogoBanco)
        Me.Controls.Add(Me.pnlEspañol)
        Me.Controls.Add(Me.pnlEnglish)
        Me.Name = "frmCajeroOpciones"
        Me.Text = "Menu Principal"
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEspañol.ResumeLayout(False)
        Me.pnlEspañol.PerformLayout()
        Me.pnlEnglish.ResumeLayout(False)
        Me.pnlEnglish.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbxNombreBanco As PictureBox
    Friend WithEvents pbxLogoBanco As PictureBox
    Friend WithEvents pnlEspañol As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGenerarComprobante As Button
    Friend WithEvents btnPagarServicios As Button
    Friend WithEvents btnTiempoAire As Button
    Friend WithEvents btnTransferirDinero As Button
    Friend WithEvents btnRetirarDinero As Button
    Friend WithEvents btnConsultaSaldo As Button
    Friend WithEvents lblInstrucción As Label
    Friend WithEvents pnlEnglish As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnGenrateReceipt As Button
    Friend WithEvents btnPayUtilities As Button
    Friend WithEvents btnAirTime As Button
    Friend WithEvents btnTransferMoney As Button
    Friend WithEvents btnWithdrawCash As Button
    Friend WithEvents btnCheckBalance As Button
    Friend WithEvents lblOptions As Label
End Class
