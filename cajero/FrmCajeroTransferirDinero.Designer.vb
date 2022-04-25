<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCajeroTransferirDinero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCajeroTransferirDinero))
        Me.pbxNombreBanco = New System.Windows.Forms.PictureBox()
        Me.pbxLogoBanco = New System.Windows.Forms.PictureBox()
        Me.pnlEspañol = New System.Windows.Forms.Panel()
        Me.pnlTransferencia = New System.Windows.Forms.Panel()
        Me.txtCantidadTranferir = New System.Windows.Forms.TextBox()
        Me.btnTransferir = New System.Windows.Forms.Button()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.lblCantidadTransferencia = New System.Windows.Forms.Label()
        Me.txtNumeroCuenta = New System.Windows.Forms.TextBox()
        Me.btnBanco1 = New System.Windows.Forms.Button()
        Me.btnBanco4 = New System.Windows.Forms.Button()
        Me.btnBanco3 = New System.Windows.Forms.Button()
        Me.btnBanco2 = New System.Windows.Forms.Button()
        Me.lblEligeUnBanco = New System.Windows.Forms.Label()
        Me.lblRealizarTransferencia = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.pnlEnglish = New System.Windows.Forms.Panel()
        Me.pnlTransferAmount = New System.Windows.Forms.Panel()
        Me.txtTransferAmount = New System.Windows.Forms.TextBox()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.lblAccountNumber = New System.Windows.Forms.Label()
        Me.lblTransferAmount = New System.Windows.Forms.Label()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.btnBank1 = New System.Windows.Forms.Button()
        Me.btnBank4 = New System.Windows.Forms.Button()
        Me.btnBank3 = New System.Windows.Forms.Button()
        Me.btnBank2 = New System.Windows.Forms.Button()
        Me.lblChooseBank = New System.Windows.Forms.Label()
        Me.lblTransferBalance = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEspañol.SuspendLayout()
        Me.pnlTransferencia.SuspendLayout()
        Me.pnlEnglish.SuspendLayout()
        Me.pnlTransferAmount.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbxNombreBanco
        '
        Me.pbxNombreBanco.Image = CType(resources.GetObject("pbxNombreBanco.Image"), System.Drawing.Image)
        Me.pbxNombreBanco.Location = New System.Drawing.Point(175, 12)
        Me.pbxNombreBanco.Name = "pbxNombreBanco"
        Me.pbxNombreBanco.Size = New System.Drawing.Size(606, 154)
        Me.pbxNombreBanco.TabIndex = 6
        Me.pbxNombreBanco.TabStop = False
        '
        'pbxLogoBanco
        '
        Me.pbxLogoBanco.Image = CType(resources.GetObject("pbxLogoBanco.Image"), System.Drawing.Image)
        Me.pbxLogoBanco.Location = New System.Drawing.Point(12, 12)
        Me.pbxLogoBanco.Name = "pbxLogoBanco"
        Me.pbxLogoBanco.Size = New System.Drawing.Size(145, 154)
        Me.pbxLogoBanco.TabIndex = 5
        Me.pbxLogoBanco.TabStop = False
        '
        'pnlEspañol
        '
        Me.pnlEspañol.Controls.Add(Me.pnlTransferencia)
        Me.pnlEspañol.Controls.Add(Me.btnBanco1)
        Me.pnlEspañol.Controls.Add(Me.btnBanco4)
        Me.pnlEspañol.Controls.Add(Me.btnBanco3)
        Me.pnlEspañol.Controls.Add(Me.btnBanco2)
        Me.pnlEspañol.Controls.Add(Me.lblEligeUnBanco)
        Me.pnlEspañol.Controls.Add(Me.lblRealizarTransferencia)
        Me.pnlEspañol.Controls.Add(Me.btnRegresar)
        Me.pnlEspañol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEspañol.Location = New System.Drawing.Point(0, 0)
        Me.pnlEspañol.Name = "pnlEspañol"
        Me.pnlEspañol.Size = New System.Drawing.Size(1004, 644)
        Me.pnlEspañol.TabIndex = 9
        '
        'pnlTransferencia
        '
        Me.pnlTransferencia.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlTransferencia.Controls.Add(Me.txtCantidadTranferir)
        Me.pnlTransferencia.Controls.Add(Me.btnTransferir)
        Me.pnlTransferencia.Controls.Add(Me.lblCuenta)
        Me.pnlTransferencia.Controls.Add(Me.lblCantidadTransferencia)
        Me.pnlTransferencia.Controls.Add(Me.txtNumeroCuenta)
        Me.pnlTransferencia.Location = New System.Drawing.Point(541, 252)
        Me.pnlTransferencia.Name = "pnlTransferencia"
        Me.pnlTransferencia.Size = New System.Drawing.Size(300, 309)
        Me.pnlTransferencia.TabIndex = 39
        '
        'txtCantidadTranferir
        '
        Me.txtCantidadTranferir.Location = New System.Drawing.Point(73, 148)
        Me.txtCantidadTranferir.Name = "txtCantidadTranferir"
        Me.txtCantidadTranferir.Size = New System.Drawing.Size(150, 31)
        Me.txtCantidadTranferir.TabIndex = 29
        '
        'btnTransferir
        '
        Me.btnTransferir.Location = New System.Drawing.Point(88, 227)
        Me.btnTransferir.Name = "btnTransferir"
        Me.btnTransferir.Size = New System.Drawing.Size(136, 65)
        Me.btnTransferir.TabIndex = 30
        Me.btnTransferir.Text = "Transferir"
        Me.btnTransferir.UseVisualStyleBackColor = True
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(62, 26)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(167, 25)
        Me.lblCuenta.TabIndex = 26
        Me.lblCuenta.Text = "Cuenta de 7 digitos"
        '
        'lblCantidadTransferencia
        '
        Me.lblCantidadTransferencia.AutoSize = True
        Me.lblCantidadTransferencia.Location = New System.Drawing.Point(63, 119)
        Me.lblCantidadTransferencia.Name = "lblCantidadTransferencia"
        Me.lblCantidadTransferencia.Size = New System.Drawing.Size(172, 25)
        Me.lblCantidadTransferencia.TabIndex = 28
        Me.lblCantidadTransferencia.Text = "Cantidad a transferir"
        '
        'txtNumeroCuenta
        '
        Me.txtNumeroCuenta.Location = New System.Drawing.Point(73, 67)
        Me.txtNumeroCuenta.Name = "txtNumeroCuenta"
        Me.txtNumeroCuenta.Size = New System.Drawing.Size(150, 31)
        Me.txtNumeroCuenta.TabIndex = 27
        '
        'btnBanco1
        '
        Me.btnBanco1.BackgroundImage = CType(resources.GetObject("btnBanco1.BackgroundImage"), System.Drawing.Image)
        Me.btnBanco1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBanco1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBanco1.FlatAppearance.BorderSize = 0
        Me.btnBanco1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBanco1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBanco1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBanco1.Location = New System.Drawing.Point(194, 236)
        Me.btnBanco1.Name = "btnBanco1"
        Me.btnBanco1.Size = New System.Drawing.Size(231, 83)
        Me.btnBanco1.TabIndex = 38
        Me.btnBanco1.UseVisualStyleBackColor = True
        '
        'btnBanco4
        '
        Me.btnBanco4.BackgroundImage = CType(resources.GetObject("btnBanco4.BackgroundImage"), System.Drawing.Image)
        Me.btnBanco4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBanco4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBanco4.FlatAppearance.BorderSize = 0
        Me.btnBanco4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBanco4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBanco4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBanco4.Location = New System.Drawing.Point(194, 503)
        Me.btnBanco4.Name = "btnBanco4"
        Me.btnBanco4.Size = New System.Drawing.Size(231, 83)
        Me.btnBanco4.TabIndex = 37
        Me.btnBanco4.UseVisualStyleBackColor = True
        '
        'btnBanco3
        '
        Me.btnBanco3.BackgroundImage = CType(resources.GetObject("btnBanco3.BackgroundImage"), System.Drawing.Image)
        Me.btnBanco3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBanco3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBanco3.FlatAppearance.BorderSize = 0
        Me.btnBanco3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBanco3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBanco3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBanco3.Location = New System.Drawing.Point(194, 414)
        Me.btnBanco3.Name = "btnBanco3"
        Me.btnBanco3.Size = New System.Drawing.Size(231, 83)
        Me.btnBanco3.TabIndex = 36
        Me.btnBanco3.UseVisualStyleBackColor = True
        '
        'btnBanco2
        '
        Me.btnBanco2.BackgroundImage = CType(resources.GetObject("btnBanco2.BackgroundImage"), System.Drawing.Image)
        Me.btnBanco2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBanco2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBanco2.FlatAppearance.BorderSize = 0
        Me.btnBanco2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBanco2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBanco2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBanco2.Location = New System.Drawing.Point(194, 325)
        Me.btnBanco2.Name = "btnBanco2"
        Me.btnBanco2.Size = New System.Drawing.Size(231, 83)
        Me.btnBanco2.TabIndex = 35
        Me.btnBanco2.UseVisualStyleBackColor = True
        '
        'lblEligeUnBanco
        '
        Me.lblEligeUnBanco.BackColor = System.Drawing.Color.White
        Me.lblEligeUnBanco.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEligeUnBanco.Location = New System.Drawing.Point(38, 327)
        Me.lblEligeUnBanco.Name = "lblEligeUnBanco"
        Me.lblEligeUnBanco.Size = New System.Drawing.Size(97, 120)
        Me.lblEligeUnBanco.TabIndex = 33
        Me.lblEligeUnBanco.Text = "Elige un banco"
        Me.lblEligeUnBanco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRealizarTransferencia
        '
        Me.lblRealizarTransferencia.AutoSize = True
        Me.lblRealizarTransferencia.BackColor = System.Drawing.Color.White
        Me.lblRealizarTransferencia.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRealizarTransferencia.Location = New System.Drawing.Point(321, 181)
        Me.lblRealizarTransferencia.Name = "lblRealizarTransferencia"
        Me.lblRealizarTransferencia.Size = New System.Drawing.Size(362, 37)
        Me.lblRealizarTransferencia.TabIndex = 31
        Me.lblRealizarTransferencia.Text = "Realizar Transferencia"
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(855, 565)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(137, 67)
        Me.btnRegresar.TabIndex = 21
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'pnlEnglish
        '
        Me.pnlEnglish.Controls.Add(Me.pnlTransferAmount)
        Me.pnlEnglish.Controls.Add(Me.btnBank1)
        Me.pnlEnglish.Controls.Add(Me.btnBank4)
        Me.pnlEnglish.Controls.Add(Me.btnBank3)
        Me.pnlEnglish.Controls.Add(Me.btnBank2)
        Me.pnlEnglish.Controls.Add(Me.lblChooseBank)
        Me.pnlEnglish.Controls.Add(Me.lblTransferBalance)
        Me.pnlEnglish.Controls.Add(Me.btnReturn)
        Me.pnlEnglish.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEnglish.Location = New System.Drawing.Point(0, 0)
        Me.pnlEnglish.Name = "pnlEnglish"
        Me.pnlEnglish.Size = New System.Drawing.Size(1004, 644)
        Me.pnlEnglish.TabIndex = 10
        '
        'pnlTransferAmount
        '
        Me.pnlTransferAmount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlTransferAmount.Controls.Add(Me.txtTransferAmount)
        Me.pnlTransferAmount.Controls.Add(Me.btnTransfer)
        Me.pnlTransferAmount.Controls.Add(Me.lblAccountNumber)
        Me.pnlTransferAmount.Controls.Add(Me.lblTransferAmount)
        Me.pnlTransferAmount.Controls.Add(Me.txtAccountNumber)
        Me.pnlTransferAmount.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pnlTransferAmount.Location = New System.Drawing.Point(541, 252)
        Me.pnlTransferAmount.Name = "pnlTransferAmount"
        Me.pnlTransferAmount.Size = New System.Drawing.Size(300, 309)
        Me.pnlTransferAmount.TabIndex = 39
        '
        'txtTransferAmount
        '
        Me.txtTransferAmount.Location = New System.Drawing.Point(73, 148)
        Me.txtTransferAmount.Name = "txtTransferAmount"
        Me.txtTransferAmount.Size = New System.Drawing.Size(150, 35)
        Me.txtTransferAmount.TabIndex = 29
        '
        'btnTransfer
        '
        Me.btnTransfer.Location = New System.Drawing.Point(88, 224)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(136, 65)
        Me.btnTransfer.TabIndex = 30
        Me.btnTransfer.Text = "Transfer"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'lblAccountNumber
        '
        Me.lblAccountNumber.AutoSize = True
        Me.lblAccountNumber.Location = New System.Drawing.Point(43, 27)
        Me.lblAccountNumber.Name = "lblAccountNumber"
        Me.lblAccountNumber.Size = New System.Drawing.Size(210, 29)
        Me.lblAccountNumber.TabIndex = 26
        Me.lblAccountNumber.Text = "7 digit account number"
        '
        'lblTransferAmount
        '
        Me.lblTransferAmount.AutoSize = True
        Me.lblTransferAmount.Location = New System.Drawing.Point(66, 116)
        Me.lblTransferAmount.Name = "lblTransferAmount"
        Me.lblTransferAmount.Size = New System.Drawing.Size(158, 29)
        Me.lblTransferAmount.TabIndex = 28
        Me.lblTransferAmount.Text = "Transfer amount"
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Location = New System.Drawing.Point(73, 67)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(150, 35)
        Me.txtAccountNumber.TabIndex = 27
        '
        'btnBank1
        '
        Me.btnBank1.BackgroundImage = CType(resources.GetObject("btnBank1.BackgroundImage"), System.Drawing.Image)
        Me.btnBank1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBank1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBank1.FlatAppearance.BorderSize = 0
        Me.btnBank1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBank1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBank1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBank1.Location = New System.Drawing.Point(194, 236)
        Me.btnBank1.Name = "btnBank1"
        Me.btnBank1.Size = New System.Drawing.Size(231, 83)
        Me.btnBank1.TabIndex = 38
        Me.btnBank1.UseVisualStyleBackColor = True
        '
        'btnBank4
        '
        Me.btnBank4.BackgroundImage = CType(resources.GetObject("btnBank4.BackgroundImage"), System.Drawing.Image)
        Me.btnBank4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBank4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBank4.FlatAppearance.BorderSize = 0
        Me.btnBank4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBank4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBank4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBank4.Location = New System.Drawing.Point(194, 503)
        Me.btnBank4.Name = "btnBank4"
        Me.btnBank4.Size = New System.Drawing.Size(231, 83)
        Me.btnBank4.TabIndex = 37
        Me.btnBank4.UseVisualStyleBackColor = True
        '
        'btnBank3
        '
        Me.btnBank3.BackgroundImage = CType(resources.GetObject("btnBank3.BackgroundImage"), System.Drawing.Image)
        Me.btnBank3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBank3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBank3.FlatAppearance.BorderSize = 0
        Me.btnBank3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBank3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBank3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBank3.Location = New System.Drawing.Point(194, 414)
        Me.btnBank3.Name = "btnBank3"
        Me.btnBank3.Size = New System.Drawing.Size(231, 83)
        Me.btnBank3.TabIndex = 36
        Me.btnBank3.UseVisualStyleBackColor = True
        '
        'btnBank2
        '
        Me.btnBank2.BackgroundImage = CType(resources.GetObject("btnBank2.BackgroundImage"), System.Drawing.Image)
        Me.btnBank2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBank2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBank2.FlatAppearance.BorderSize = 0
        Me.btnBank2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBank2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBank2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBank2.Location = New System.Drawing.Point(194, 325)
        Me.btnBank2.Name = "btnBank2"
        Me.btnBank2.Size = New System.Drawing.Size(231, 83)
        Me.btnBank2.TabIndex = 35
        Me.btnBank2.UseVisualStyleBackColor = True
        '
        'lblChooseBank
        '
        Me.lblChooseBank.BackColor = System.Drawing.Color.White
        Me.lblChooseBank.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblChooseBank.Location = New System.Drawing.Point(38, 327)
        Me.lblChooseBank.Name = "lblChooseBank"
        Me.lblChooseBank.Size = New System.Drawing.Size(119, 116)
        Me.lblChooseBank.TabIndex = 33
        Me.lblChooseBank.Text = "Choose a bank"
        Me.lblChooseBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTransferBalance
        '
        Me.lblTransferBalance.AutoSize = True
        Me.lblTransferBalance.BackColor = System.Drawing.Color.White
        Me.lblTransferBalance.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTransferBalance.Location = New System.Drawing.Point(365, 181)
        Me.lblTransferBalance.Name = "lblTransferBalance"
        Me.lblTransferBalance.Size = New System.Drawing.Size(274, 37)
        Me.lblTransferBalance.TabIndex = 31
        Me.lblTransferBalance.Text = "Transfer balance"
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(855, 565)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(137, 67)
        Me.btnReturn.TabIndex = 21
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmCajeroTransferirDinero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1004, 644)
        Me.Controls.Add(Me.pbxNombreBanco)
        Me.Controls.Add(Me.pbxLogoBanco)
        Me.Controls.Add(Me.pnlEspañol)
        Me.Controls.Add(Me.pnlEnglish)
        Me.Name = "frmCajeroTransferirDinero"
        Me.Text = "Transferencias"
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEspañol.ResumeLayout(False)
        Me.pnlEspañol.PerformLayout()
        Me.pnlTransferencia.ResumeLayout(False)
        Me.pnlTransferencia.PerformLayout()
        Me.pnlEnglish.ResumeLayout(False)
        Me.pnlEnglish.PerformLayout()
        Me.pnlTransferAmount.ResumeLayout(False)
        Me.pnlTransferAmount.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbxNombreBanco As PictureBox
    Friend WithEvents pbxLogoBanco As PictureBox
    Friend WithEvents pnlEspañol As Panel
    Friend WithEvents btnRegresar As Button
    Friend WithEvents txtCantidadTranferir As TextBox
    Friend WithEvents lblCuenta As Label
    Friend WithEvents btnTransferir As Button
    Friend WithEvents txtNumeroCuenta As TextBox
    Friend WithEvents lblCantidadTransferencia As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblEligeUnBanco As Label
    Friend WithEvents lblRealizarTransferencia As Label
    Friend WithEvents btnBanco2 As Button
    Friend WithEvents btnBanco3 As Button
    Friend WithEvents btnBanco4 As Button
    Friend WithEvents btnBanco1 As Button
    Friend WithEvents pnlTransferencia As Panel
    Friend WithEvents pnlEnglish As Panel
    Friend WithEvents pnlTransferAmount As Panel
    Friend WithEvents txtTransferAmount As TextBox
    Friend WithEvents btnTransfer As Button
    Friend WithEvents lblAccountNumber As Label
    Friend WithEvents lblTransferAmount As Label
    Friend WithEvents txtAccountNumber As TextBox
    Friend WithEvents btnBank1 As Button
    Friend WithEvents btnBank4 As Button
    Friend WithEvents btnBank3 As Button
    Friend WithEvents btnBank2 As Button
    Friend WithEvents lblChooseBank As Label
    Friend WithEvents lblTransferBalance As Label
    Friend WithEvents btnReturn As Button
End Class
