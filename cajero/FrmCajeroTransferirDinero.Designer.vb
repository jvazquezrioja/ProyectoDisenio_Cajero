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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
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
        Me.pbxFlecha = New System.Windows.Forms.PictureBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBancos.SuspendLayout()
        Me.pnlTransferencia.SuspendLayout()
        CType(Me.pbxFlecha, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lblLlenaDatos
        '
        Me.lblLlenaDatos.BackColor = System.Drawing.Color.White
        Me.lblLlenaDatos.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLlenaDatos.Location = New System.Drawing.Point(651, 201)
        Me.lblLlenaDatos.Name = "lblLlenaDatos"
        Me.lblLlenaDatos.Size = New System.Drawing.Size(302, 47)
        Me.lblLlenaDatos.TabIndex = 48
        Me.lblLlenaDatos.Text = "Llena los datos"
        Me.lblLlenaDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlBancos
        '
        Me.pnlBancos.Controls.Add(Me.rbtnBanco4)
        Me.pnlBancos.Controls.Add(Me.rbtnBanco3)
        Me.pnlBancos.Controls.Add(Me.rbtnBanco2)
        Me.pnlBancos.Controls.Add(Me.rbtnBanco1)
        Me.pnlBancos.Location = New System.Drawing.Point(53, 248)
        Me.pnlBancos.Name = "pnlBancos"
        Me.pnlBancos.Size = New System.Drawing.Size(324, 309)
        Me.pnlBancos.TabIndex = 47
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
        Me.pnlTransferencia.Location = New System.Drawing.Point(653, 251)
        Me.pnlTransferencia.Name = "pnlTransferencia"
        Me.pnlTransferencia.Size = New System.Drawing.Size(300, 309)
        Me.pnlTransferencia.TabIndex = 46
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
        Me.lblEligeUnBanco.Location = New System.Drawing.Point(62, 206)
        Me.lblEligeUnBanco.Name = "lblEligeUnBanco"
        Me.lblEligeUnBanco.Size = New System.Drawing.Size(302, 39)
        Me.lblEligeUnBanco.TabIndex = 45
        Me.lblEligeUnBanco.Text = "Elige un banco"
        Me.lblEligeUnBanco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRealizarTransferencia
        '
        Me.lblRealizarTransferencia.AutoSize = True
        Me.lblRealizarTransferencia.BackColor = System.Drawing.Color.White
        Me.lblRealizarTransferencia.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRealizarTransferencia.Location = New System.Drawing.Point(323, 169)
        Me.lblRealizarTransferencia.Name = "lblRealizarTransferencia"
        Me.lblRealizarTransferencia.Size = New System.Drawing.Size(362, 37)
        Me.lblRealizarTransferencia.TabIndex = 44
        Me.lblRealizarTransferencia.Text = "Realizar Transferencia"
        '
        'pbxFlecha
        '
        Me.pbxFlecha.Image = CType(resources.GetObject("pbxFlecha.Image"), System.Drawing.Image)
        Me.pbxFlecha.Location = New System.Drawing.Point(426, 330)
        Me.pbxFlecha.Name = "pbxFlecha"
        Me.pbxFlecha.Size = New System.Drawing.Size(177, 136)
        Me.pbxFlecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxFlecha.TabIndex = 49
        Me.pbxFlecha.TabStop = False
        '
        'btnRegresar
        '
        Me.btnRegresar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRegresar.Location = New System.Drawing.Point(726, 563)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(136, 67)
        Me.btnRegresar.TabIndex = 43
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'frmCajeroTransferirDinero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1004, 644)
        Me.Controls.Add(Me.lblLlenaDatos)
        Me.Controls.Add(Me.pnlBancos)
        Me.Controls.Add(Me.pnlTransferencia)
        Me.Controls.Add(Me.lblEligeUnBanco)
        Me.Controls.Add(Me.lblRealizarTransferencia)
        Me.Controls.Add(Me.pbxFlecha)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.pbxNombreBanco)
        Me.Controls.Add(Me.pbxLogoBanco)
        Me.Name = "frmCajeroTransferirDinero"
        Me.Text = "Transferencias"
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBancos.ResumeLayout(False)
        Me.pnlTransferencia.ResumeLayout(False)
        Me.pnlTransferencia.PerformLayout()
        CType(Me.pbxFlecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxNombreBanco As PictureBox
    Friend WithEvents pbxLogoBanco As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblLlenaDatos As Label
    Friend WithEvents pnlBancos As Panel
    Friend WithEvents rbtnBanco4 As RadioButton
    Friend WithEvents rbtnBanco3 As RadioButton
    Friend WithEvents rbtnBanco2 As RadioButton
    Friend WithEvents rbtnBanco1 As RadioButton
    Friend WithEvents pnlTransferencia As Panel
    Friend WithEvents txtCantidadTranferir As TextBox
    Friend WithEvents btnTransferir As Button
    Friend WithEvents lblCuenta As Label
    Friend WithEvents lblCantidadTransferencia As Label
    Friend WithEvents txtNumeroCuenta As TextBox
    Friend WithEvents lblEligeUnBanco As Label
    Friend WithEvents lblRealizarTransferencia As Label
    Friend WithEvents pbxFlecha As PictureBox
    Friend WithEvents btnRegresar As Button
End Class
