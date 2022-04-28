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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGenerarComprobante = New System.Windows.Forms.Button()
        Me.btnPagarServicios = New System.Windows.Forms.Button()
        Me.btnTiempoAire = New System.Windows.Forms.Button()
        Me.btnTransferirDinero = New System.Windows.Forms.Button()
        Me.btnRetirarDinero = New System.Windows.Forms.Button()
        Me.btnConsultaSaldo = New System.Windows.Forms.Button()
        Me.lblInstrucción = New System.Windows.Forms.Label()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(818, 517)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(136, 65)
        Me.btnSalir.TabIndex = 28
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGenerarComprobante
        '
        Me.btnGenerarComprobante.Location = New System.Drawing.Point(818, 426)
        Me.btnGenerarComprobante.Name = "btnGenerarComprobante"
        Me.btnGenerarComprobante.Size = New System.Drawing.Size(136, 65)
        Me.btnGenerarComprobante.TabIndex = 27
        Me.btnGenerarComprobante.Text = "Generar Comprobante"
        Me.btnGenerarComprobante.UseVisualStyleBackColor = True
        '
        'btnPagarServicios
        '
        Me.btnPagarServicios.Location = New System.Drawing.Point(818, 330)
        Me.btnPagarServicios.Name = "btnPagarServicios"
        Me.btnPagarServicios.Size = New System.Drawing.Size(136, 65)
        Me.btnPagarServicios.TabIndex = 26
        Me.btnPagarServicios.Text = "Pagar Servicios"
        Me.btnPagarServicios.UseVisualStyleBackColor = True
        '
        'btnTiempoAire
        '
        Me.btnTiempoAire.Location = New System.Drawing.Point(818, 228)
        Me.btnTiempoAire.Name = "btnTiempoAire"
        Me.btnTiempoAire.Size = New System.Drawing.Size(136, 65)
        Me.btnTiempoAire.TabIndex = 25
        Me.btnTiempoAire.Text = "Tiempo Aire"
        Me.btnTiempoAire.UseVisualStyleBackColor = True
        '
        'btnTransferirDinero
        '
        Me.btnTransferirDinero.Location = New System.Drawing.Point(52, 426)
        Me.btnTransferirDinero.Name = "btnTransferirDinero"
        Me.btnTransferirDinero.Size = New System.Drawing.Size(136, 65)
        Me.btnTransferirDinero.TabIndex = 24
        Me.btnTransferirDinero.Text = "Transferir Dinero"
        Me.btnTransferirDinero.UseVisualStyleBackColor = True
        '
        'btnRetirarDinero
        '
        Me.btnRetirarDinero.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRetirarDinero.Location = New System.Drawing.Point(52, 330)
        Me.btnRetirarDinero.Name = "btnRetirarDinero"
        Me.btnRetirarDinero.Size = New System.Drawing.Size(136, 65)
        Me.btnRetirarDinero.TabIndex = 23
        Me.btnRetirarDinero.Text = "Retirar Dinero"
        Me.btnRetirarDinero.UseVisualStyleBackColor = True
        '
        'btnConsultaSaldo
        '
        Me.btnConsultaSaldo.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnConsultaSaldo.Location = New System.Drawing.Point(51, 237)
        Me.btnConsultaSaldo.Name = "btnConsultaSaldo"
        Me.btnConsultaSaldo.Size = New System.Drawing.Size(136, 65)
        Me.btnConsultaSaldo.TabIndex = 22
        Me.btnConsultaSaldo.Text = "Consultar Saldo"
        Me.btnConsultaSaldo.UseVisualStyleBackColor = True
        '
        'lblInstrucción
        '
        Me.lblInstrucción.AutoSize = True
        Me.lblInstrucción.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInstrucción.Location = New System.Drawing.Point(397, 308)
        Me.lblInstrucción.Name = "lblInstrucción"
        Me.lblInstrucción.Size = New System.Drawing.Size(210, 29)
        Me.lblInstrucción.TabIndex = 21
        Me.lblInstrucción.Text = "Selecciona una opción"
        Me.lblInstrucción.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCajeroOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1004, 644)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGenerarComprobante)
        Me.Controls.Add(Me.btnPagarServicios)
        Me.Controls.Add(Me.btnTiempoAire)
        Me.Controls.Add(Me.btnTransferirDinero)
        Me.Controls.Add(Me.btnRetirarDinero)
        Me.Controls.Add(Me.btnConsultaSaldo)
        Me.Controls.Add(Me.lblInstrucción)
        Me.Controls.Add(Me.pbxNombreBanco)
        Me.Controls.Add(Me.pbxLogoBanco)
        Me.Name = "frmCajeroOpciones"
        Me.Text = "Menu Principal"
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxNombreBanco As PictureBox
    Friend WithEvents pbxLogoBanco As PictureBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGenerarComprobante As Button
    Friend WithEvents btnPagarServicios As Button
    Friend WithEvents btnTiempoAire As Button
    Friend WithEvents btnTransferirDinero As Button
    Friend WithEvents btnRetirarDinero As Button
    Friend WithEvents btnConsultaSaldo As Button
    Friend WithEvents lblInstrucción As Label
End Class
