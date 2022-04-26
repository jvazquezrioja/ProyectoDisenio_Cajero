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
        Me.pbxFlecha = New System.Windows.Forms.PictureBox()
        Me.lblLlenaDatos = New System.Windows.Forms.Label()
        Me.pnlBancos = New System.Windows.Forms.Panel()
        Me.rbtnBanco4 = New System.Windows.Forms.RadioButton()
        Me.rbtnBanco3 = New System.Windows.Forms.RadioButton()
        Me.rbtnBanco2 = New System.Windows.Forms.RadioButton()
        Me.rbtnBanco1 = New System.Windows.Forms.RadioButton()
        Me.pnlTransferencia = New System.Windows.Forms.Panel()
        Me.txtCantidadTranferir = New System.Windows.Forms.TextBox()
        Me.btnTransferir = New System.Windows.Forms.Button()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.lblCantidadTransferencia = New System.Windows.Forms.Label()
        Me.txtNumeroCuenta = New System.Windows.Forms.TextBox()
        Me.lblEligeUnBanco = New System.Windows.Forms.Label()
        Me.lblRealizarTransferencia = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.pnlEnglish = New System.Windows.Forms.Panel()
        Me.pbxArrow = New System.Windows.Forms.PictureBox()
        Me.lblFillForm = New System.Windows.Forms.Label()
        Me.pnlBanks = New System.Windows.Forms.Panel()
        Me.rbtnBank4 = New System.Windows.Forms.RadioButton()
        Me.rbtnBank3 = New System.Windows.Forms.RadioButton()
        Me.rbtnBank2 = New System.Windows.Forms.RadioButton()
        Me.rbtnBank1 = New System.Windows.Forms.RadioButton()
        Me.pnlTransfer = New System.Windows.Forms.Panel()
        Me.txtTransferAmount = New System.Windows.Forms.TextBox()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.lblAccountNumber = New System.Windows.Forms.Label()
        Me.lblTransferAmount = New System.Windows.Forms.Label()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.lblChooseBank = New System.Windows.Forms.Label()
        Me.lblTransferFunds = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEspañol.SuspendLayout()
        CType(Me.pbxFlecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBancos.SuspendLayout()
        Me.pnlTransferencia.SuspendLayout()
        Me.pnlEnglish.SuspendLayout()
        CType(Me.pbxArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBanks.SuspendLayout()
        Me.pnlTransfer.SuspendLayout()
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
        Me.pnlEspañol.Controls.Add(Me.pbxFlecha)
        Me.pnlEspañol.Controls.Add(Me.lblLlenaDatos)
        Me.pnlEspañol.Controls.Add(Me.pnlBancos)
        Me.pnlEspañol.Controls.Add(Me.pnlTransferencia)
        Me.pnlEspañol.Controls.Add(Me.lblEligeUnBanco)
        Me.pnlEspañol.Controls.Add(Me.lblRealizarTransferencia)
        Me.pnlEspañol.Controls.Add(Me.btnRegresar)
        Me.pnlEspañol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEspañol.Location = New System.Drawing.Point(0, 0)
        Me.pnlEspañol.Name = "pnlEspañol"
        Me.pnlEspañol.Size = New System.Drawing.Size(1004, 644)
        Me.pnlEspañol.TabIndex = 9
        '
        'pbxFlecha
        '
        Me.pbxFlecha.Image = CType(resources.GetObject("pbxFlecha.Image"), System.Drawing.Image)
        Me.pbxFlecha.Location = New System.Drawing.Point(424, 334)
        Me.pbxFlecha.Name = "pbxFlecha"
        Me.pbxFlecha.Size = New System.Drawing.Size(177, 136)
        Me.pbxFlecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxFlecha.TabIndex = 42
        Me.pbxFlecha.TabStop = False
        '
        'lblLlenaDatos
        '
        Me.lblLlenaDatos.BackColor = System.Drawing.Color.White
        Me.lblLlenaDatos.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLlenaDatos.Location = New System.Drawing.Point(649, 205)
        Me.lblLlenaDatos.Name = "lblLlenaDatos"
        Me.lblLlenaDatos.Size = New System.Drawing.Size(302, 47)
        Me.lblLlenaDatos.TabIndex = 41
        Me.lblLlenaDatos.Text = "Llena los datos"
        Me.lblLlenaDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlBancos
        '
        Me.pnlBancos.Controls.Add(Me.rbtnBanco4)
        Me.pnlBancos.Controls.Add(Me.rbtnBanco3)
        Me.pnlBancos.Controls.Add(Me.rbtnBanco2)
        Me.pnlBancos.Controls.Add(Me.rbtnBanco1)
        Me.pnlBancos.Location = New System.Drawing.Point(51, 252)
        Me.pnlBancos.Name = "pnlBancos"
        Me.pnlBancos.Size = New System.Drawing.Size(324, 309)
        Me.pnlBancos.TabIndex = 40
        '
        'rbtnBanco4
        '
        Me.rbtnBanco4.BackgroundImage = CType(resources.GetObject("rbtnBanco4.BackgroundImage"), System.Drawing.Image)
        Me.rbtnBanco4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rbtnBanco4.Location = New System.Drawing.Point(27, 240)
        Me.rbtnBanco4.Name = "rbtnBanco4"
        Me.rbtnBanco4.Size = New System.Drawing.Size(284, 64)
        Me.rbtnBanco4.TabIndex = 43
        Me.rbtnBanco4.TabStop = True
        Me.rbtnBanco4.UseVisualStyleBackColor = True
        '
        'rbtnBanco3
        '
        Me.rbtnBanco3.BackgroundImage = CType(resources.GetObject("rbtnBanco3.BackgroundImage"), System.Drawing.Image)
        Me.rbtnBanco3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rbtnBanco3.Location = New System.Drawing.Point(27, 161)
        Me.rbtnBanco3.Name = "rbtnBanco3"
        Me.rbtnBanco3.Size = New System.Drawing.Size(284, 64)
        Me.rbtnBanco3.TabIndex = 42
        Me.rbtnBanco3.TabStop = True
        Me.rbtnBanco3.UseVisualStyleBackColor = True
        '
        'rbtnBanco2
        '
        Me.rbtnBanco2.BackgroundImage = CType(resources.GetObject("rbtnBanco2.BackgroundImage"), System.Drawing.Image)
        Me.rbtnBanco2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rbtnBanco2.Location = New System.Drawing.Point(27, 82)
        Me.rbtnBanco2.Name = "rbtnBanco2"
        Me.rbtnBanco2.Size = New System.Drawing.Size(284, 64)
        Me.rbtnBanco2.TabIndex = 41
        Me.rbtnBanco2.TabStop = True
        Me.rbtnBanco2.UseVisualStyleBackColor = True
        '
        'rbtnBanco1
        '
        Me.rbtnBanco1.BackgroundImage = CType(resources.GetObject("rbtnBanco1.BackgroundImage"), System.Drawing.Image)
        Me.rbtnBanco1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rbtnBanco1.Location = New System.Drawing.Point(27, 3)
        Me.rbtnBanco1.Name = "rbtnBanco1"
        Me.rbtnBanco1.Size = New System.Drawing.Size(284, 64)
        Me.rbtnBanco1.TabIndex = 40
        Me.rbtnBanco1.TabStop = True
        Me.rbtnBanco1.UseVisualStyleBackColor = True
        '
        'pnlTransferencia
        '
        Me.pnlTransferencia.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlTransferencia.Controls.Add(Me.txtCantidadTranferir)
        Me.pnlTransferencia.Controls.Add(Me.btnTransferir)
        Me.pnlTransferencia.Controls.Add(Me.lblCuenta)
        Me.pnlTransferencia.Controls.Add(Me.lblCantidadTransferencia)
        Me.pnlTransferencia.Controls.Add(Me.txtNumeroCuenta)
        Me.pnlTransferencia.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pnlTransferencia.Location = New System.Drawing.Point(651, 255)
        Me.pnlTransferencia.Name = "pnlTransferencia"
        Me.pnlTransferencia.Size = New System.Drawing.Size(300, 309)
        Me.pnlTransferencia.TabIndex = 39
        '
        'txtCantidadTranferir
        '
        Me.txtCantidadTranferir.Location = New System.Drawing.Point(73, 146)
        Me.txtCantidadTranferir.Name = "txtCantidadTranferir"
        Me.txtCantidadTranferir.Size = New System.Drawing.Size(136, 35)
        Me.txtCantidadTranferir.TabIndex = 29
        '
        'btnTransferir
        '
        Me.btnTransferir.Location = New System.Drawing.Point(73, 212)
        Me.btnTransferir.Name = "btnTransferir"
        Me.btnTransferir.Size = New System.Drawing.Size(136, 65)
        Me.btnTransferir.TabIndex = 30
        Me.btnTransferir.Text = "Transferir"
        Me.btnTransferir.UseVisualStyleBackColor = True
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(55, 26)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(180, 29)
        Me.lblCuenta.TabIndex = 26
        Me.lblCuenta.Text = "Cuenta de 7 digitos"
        '
        'lblCantidadTransferencia
        '
        Me.lblCantidadTransferencia.AutoSize = True
        Me.lblCantidadTransferencia.Location = New System.Drawing.Point(44, 108)
        Me.lblCantidadTransferencia.Name = "lblCantidadTransferencia"
        Me.lblCantidadTransferencia.Size = New System.Drawing.Size(191, 29)
        Me.lblCantidadTransferencia.TabIndex = 28
        Me.lblCantidadTransferencia.Text = "Cantidad a transferir"
        '
        'txtNumeroCuenta
        '
        Me.txtNumeroCuenta.Location = New System.Drawing.Point(73, 64)
        Me.txtNumeroCuenta.Name = "txtNumeroCuenta"
        Me.txtNumeroCuenta.Size = New System.Drawing.Size(136, 35)
        Me.txtNumeroCuenta.TabIndex = 27
        '
        'lblEligeUnBanco
        '
        Me.lblEligeUnBanco.BackColor = System.Drawing.Color.White
        Me.lblEligeUnBanco.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEligeUnBanco.Location = New System.Drawing.Point(60, 202)
        Me.lblEligeUnBanco.Name = "lblEligeUnBanco"
        Me.lblEligeUnBanco.Size = New System.Drawing.Size(302, 47)
        Me.lblEligeUnBanco.TabIndex = 33
        Me.lblEligeUnBanco.Text = "Elige un banco"
        Me.lblEligeUnBanco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRealizarTransferencia
        '
        Me.lblRealizarTransferencia.AutoSize = True
        Me.lblRealizarTransferencia.BackColor = System.Drawing.Color.White
        Me.lblRealizarTransferencia.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRealizarTransferencia.Location = New System.Drawing.Point(321, 173)
        Me.lblRealizarTransferencia.Name = "lblRealizarTransferencia"
        Me.lblRealizarTransferencia.Size = New System.Drawing.Size(362, 37)
        Me.lblRealizarTransferencia.TabIndex = 31
        Me.lblRealizarTransferencia.Text = "Realizar Transferencia"
        '
        'btnRegresar
        '
        Me.btnRegresar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRegresar.Location = New System.Drawing.Point(724, 567)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(136, 67)
        Me.btnRegresar.TabIndex = 21
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'pnlEnglish
        '
        Me.pnlEnglish.Controls.Add(Me.pbxArrow)
        Me.pnlEnglish.Controls.Add(Me.lblFillForm)
        Me.pnlEnglish.Controls.Add(Me.pnlBanks)
        Me.pnlEnglish.Controls.Add(Me.pnlTransfer)
        Me.pnlEnglish.Controls.Add(Me.lblChooseBank)
        Me.pnlEnglish.Controls.Add(Me.lblTransferFunds)
        Me.pnlEnglish.Controls.Add(Me.btnReturn)
        Me.pnlEnglish.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEnglish.Location = New System.Drawing.Point(0, 0)
        Me.pnlEnglish.Name = "pnlEnglish"
        Me.pnlEnglish.Size = New System.Drawing.Size(1004, 644)
        Me.pnlEnglish.TabIndex = 10
        '
        'pbxArrow
        '
        Me.pbxArrow.Image = CType(resources.GetObject("pbxArrow.Image"), System.Drawing.Image)
        Me.pbxArrow.Location = New System.Drawing.Point(424, 334)
        Me.pbxArrow.Name = "pbxArrow"
        Me.pbxArrow.Size = New System.Drawing.Size(177, 136)
        Me.pbxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxArrow.TabIndex = 42
        Me.pbxArrow.TabStop = False
        '
        'lblFillForm
        '
        Me.lblFillForm.BackColor = System.Drawing.Color.White
        Me.lblFillForm.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFillForm.Location = New System.Drawing.Point(649, 205)
        Me.lblFillForm.Name = "lblFillForm"
        Me.lblFillForm.Size = New System.Drawing.Size(302, 47)
        Me.lblFillForm.TabIndex = 41
        Me.lblFillForm.Text = "Fill out the form"
        Me.lblFillForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlBanks
        '
        Me.pnlBanks.Controls.Add(Me.rbtnBank4)
        Me.pnlBanks.Controls.Add(Me.rbtnBank3)
        Me.pnlBanks.Controls.Add(Me.rbtnBank2)
        Me.pnlBanks.Controls.Add(Me.rbtnBank1)
        Me.pnlBanks.Location = New System.Drawing.Point(51, 252)
        Me.pnlBanks.Name = "pnlBanks"
        Me.pnlBanks.Size = New System.Drawing.Size(324, 309)
        Me.pnlBanks.TabIndex = 40
        '
        'rbtnBank4
        '
        Me.rbtnBank4.BackgroundImage = CType(resources.GetObject("rbtnBank4.BackgroundImage"), System.Drawing.Image)
        Me.rbtnBank4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rbtnBank4.Location = New System.Drawing.Point(27, 240)
        Me.rbtnBank4.Name = "rbtnBank4"
        Me.rbtnBank4.Size = New System.Drawing.Size(284, 64)
        Me.rbtnBank4.TabIndex = 43
        Me.rbtnBank4.TabStop = True
        Me.rbtnBank4.UseVisualStyleBackColor = True
        '
        'rbtnBank3
        '
        Me.rbtnBank3.BackgroundImage = CType(resources.GetObject("rbtnBank3.BackgroundImage"), System.Drawing.Image)
        Me.rbtnBank3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rbtnBank3.Location = New System.Drawing.Point(27, 161)
        Me.rbtnBank3.Name = "rbtnBank3"
        Me.rbtnBank3.Size = New System.Drawing.Size(284, 64)
        Me.rbtnBank3.TabIndex = 42
        Me.rbtnBank3.TabStop = True
        Me.rbtnBank3.UseVisualStyleBackColor = True
        '
        'rbtnBank2
        '
        Me.rbtnBank2.BackgroundImage = CType(resources.GetObject("rbtnBank2.BackgroundImage"), System.Drawing.Image)
        Me.rbtnBank2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rbtnBank2.Location = New System.Drawing.Point(27, 82)
        Me.rbtnBank2.Name = "rbtnBank2"
        Me.rbtnBank2.Size = New System.Drawing.Size(284, 64)
        Me.rbtnBank2.TabIndex = 41
        Me.rbtnBank2.TabStop = True
        Me.rbtnBank2.UseVisualStyleBackColor = True
        '
        'rbtnBank1
        '
        Me.rbtnBank1.BackgroundImage = CType(resources.GetObject("rbtnBank1.BackgroundImage"), System.Drawing.Image)
        Me.rbtnBank1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rbtnBank1.Location = New System.Drawing.Point(27, 3)
        Me.rbtnBank1.Name = "rbtnBank1"
        Me.rbtnBank1.Size = New System.Drawing.Size(284, 64)
        Me.rbtnBank1.TabIndex = 40
        Me.rbtnBank1.TabStop = True
        Me.rbtnBank1.UseVisualStyleBackColor = True
        '
        'pnlTransfer
        '
        Me.pnlTransfer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlTransfer.Controls.Add(Me.txtTransferAmount)
        Me.pnlTransfer.Controls.Add(Me.btnTransfer)
        Me.pnlTransfer.Controls.Add(Me.lblAccountNumber)
        Me.pnlTransfer.Controls.Add(Me.lblTransferAmount)
        Me.pnlTransfer.Controls.Add(Me.txtAccountNumber)
        Me.pnlTransfer.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pnlTransfer.Location = New System.Drawing.Point(651, 255)
        Me.pnlTransfer.Name = "pnlTransfer"
        Me.pnlTransfer.Size = New System.Drawing.Size(300, 309)
        Me.pnlTransfer.TabIndex = 39
        '
        'txtTransferAmount
        '
        Me.txtTransferAmount.Location = New System.Drawing.Point(73, 146)
        Me.txtTransferAmount.Name = "txtTransferAmount"
        Me.txtTransferAmount.Size = New System.Drawing.Size(136, 35)
        Me.txtTransferAmount.TabIndex = 29
        '
        'btnTransfer
        '
        Me.btnTransfer.Location = New System.Drawing.Point(73, 212)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(136, 65)
        Me.btnTransfer.TabIndex = 30
        Me.btnTransfer.Text = "Transfer"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'lblAccountNumber
        '
        Me.lblAccountNumber.AutoSize = True
        Me.lblAccountNumber.Location = New System.Drawing.Point(34, 26)
        Me.lblAccountNumber.Name = "lblAccountNumber"
        Me.lblAccountNumber.Size = New System.Drawing.Size(215, 29)
        Me.lblAccountNumber.TabIndex = 26
        Me.lblAccountNumber.Text = "7 Digit Account number"
        '
        'lblTransferAmount
        '
        Me.lblTransferAmount.AutoSize = True
        Me.lblTransferAmount.Location = New System.Drawing.Point(53, 108)
        Me.lblTransferAmount.Name = "lblTransferAmount"
        Me.lblTransferAmount.Size = New System.Drawing.Size(174, 29)
        Me.lblTransferAmount.TabIndex = 28
        Me.lblTransferAmount.Text = "Amount to transfer"
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Location = New System.Drawing.Point(73, 64)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(136, 35)
        Me.txtAccountNumber.TabIndex = 27
        '
        'lblChooseBank
        '
        Me.lblChooseBank.BackColor = System.Drawing.Color.White
        Me.lblChooseBank.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblChooseBank.Location = New System.Drawing.Point(60, 202)
        Me.lblChooseBank.Name = "lblChooseBank"
        Me.lblChooseBank.Size = New System.Drawing.Size(302, 47)
        Me.lblChooseBank.TabIndex = 33
        Me.lblChooseBank.Text = "Choose a bank"
        Me.lblChooseBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTransferFunds
        '
        Me.lblTransferFunds.AutoSize = True
        Me.lblTransferFunds.BackColor = System.Drawing.Color.White
        Me.lblTransferFunds.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTransferFunds.Location = New System.Drawing.Point(378, 173)
        Me.lblTransferFunds.Name = "lblTransferFunds"
        Me.lblTransferFunds.Size = New System.Drawing.Size(249, 37)
        Me.lblTransferFunds.TabIndex = 31
        Me.lblTransferFunds.Text = "Transfer Funds"
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnReturn.Location = New System.Drawing.Point(724, 567)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(136, 67)
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
        CType(Me.pbxFlecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBancos.ResumeLayout(False)
        Me.pnlTransferencia.ResumeLayout(False)
        Me.pnlTransferencia.PerformLayout()
        Me.pnlEnglish.ResumeLayout(False)
        Me.pnlEnglish.PerformLayout()
        CType(Me.pbxArrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBanks.ResumeLayout(False)
        Me.pnlTransfer.ResumeLayout(False)
        Me.pnlTransfer.PerformLayout()
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
    Friend WithEvents pnlTransferencia As Panel
    Friend WithEvents pnlBancos As Panel
    Friend WithEvents rbtnBanco3 As RadioButton
    Friend WithEvents rbtnBanco2 As RadioButton
    Friend WithEvents rbtnBanco1 As RadioButton
    Friend WithEvents rbtnBanco4 As RadioButton
    Friend WithEvents pbxFlecha As PictureBox
    Friend WithEvents lblLlenaDatos As Label
    Friend WithEvents pnlEnglish As Panel
    Friend WithEvents pbxArrow As PictureBox
    Friend WithEvents lblFillForm As Label
    Friend WithEvents pnlBanks As Panel
    Friend WithEvents rbtnBank4 As RadioButton
    Friend WithEvents rbtnBank3 As RadioButton
    Friend WithEvents rbtnBank2 As RadioButton
    Friend WithEvents rbtnBank1 As RadioButton
    Friend WithEvents pnlTransfer As Panel
    Friend WithEvents txtTransferAmount As TextBox
    Friend WithEvents btnTransfer As Button
    Friend WithEvents lblAccountNumber As Label
    Friend WithEvents lblTransferAmount As Label
    Friend WithEvents txtAccountNumber As TextBox
    Friend WithEvents lblChooseBank As Label
    Friend WithEvents lblTransferFunds As Label
    Friend WithEvents btnReturn As Button
End Class
