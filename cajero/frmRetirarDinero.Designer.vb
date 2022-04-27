<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetirarDinero
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRetirarDinero))
        Me.pbxNombreBanco = New System.Windows.Forms.PictureBox()
        Me.pbxLogoBanco = New System.Windows.Forms.PictureBox()
        Me.pnlEspañol = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnOtra = New System.Windows.Forms.Button()
        Me.btn2500 = New System.Windows.Forms.Button()
        Me.btn1000 = New System.Windows.Forms.Button()
        Me.btn500 = New System.Windows.Forms.Button()
        Me.btn200 = New System.Windows.Forms.Button()
        Me.btn100 = New System.Windows.Forms.Button()
        Me.btn50 = New System.Windows.Forms.Button()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.pnlEnglish = New System.Windows.Forms.Panel()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnCustomAmount = New System.Windows.Forms.Button()
        Me.btn2500e = New System.Windows.Forms.Button()
        Me.btn1000e = New System.Windows.Forms.Button()
        Me.btn500e = New System.Windows.Forms.Button()
        Me.btn200e = New System.Windows.Forms.Button()
        Me.btn100e = New System.Windows.Forms.Button()
        Me.btn50e = New System.Windows.Forms.Button()
        Me.lblSaldoe = New System.Windows.Forms.Label()
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
        Me.pbxNombreBanco.TabIndex = 10
        Me.pbxNombreBanco.TabStop = False
        '
        'pbxLogoBanco
        '
        Me.pbxLogoBanco.Image = CType(resources.GetObject("pbxLogoBanco.Image"), System.Drawing.Image)
        Me.pbxLogoBanco.Location = New System.Drawing.Point(12, 12)
        Me.pbxLogoBanco.Name = "pbxLogoBanco"
        Me.pbxLogoBanco.Size = New System.Drawing.Size(145, 154)
        Me.pbxLogoBanco.TabIndex = 9
        Me.pbxLogoBanco.TabStop = False
        '
        'pnlEspañol
        '
        Me.pnlEspañol.Controls.Add(Me.btnSalir)
        Me.pnlEspañol.Controls.Add(Me.btnOtra)
        Me.pnlEspañol.Controls.Add(Me.btn2500)
        Me.pnlEspañol.Controls.Add(Me.btn1000)
        Me.pnlEspañol.Controls.Add(Me.btn500)
        Me.pnlEspañol.Controls.Add(Me.btn200)
        Me.pnlEspañol.Controls.Add(Me.btn100)
        Me.pnlEspañol.Controls.Add(Me.btn50)
        Me.pnlEspañol.Controls.Add(Me.lblSaldo)
        Me.pnlEspañol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEspañol.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pnlEspañol.Location = New System.Drawing.Point(0, 0)
        Me.pnlEspañol.Name = "pnlEspañol"
        Me.pnlEspañol.Size = New System.Drawing.Size(1004, 644)
        Me.pnlEspañol.TabIndex = 11
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(818, 517)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(136, 65)
        Me.btnSalir.TabIndex = 17
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnOtra
        '
        Me.btnOtra.Location = New System.Drawing.Point(818, 428)
        Me.btnOtra.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOtra.Name = "btnOtra"
        Me.btnOtra.Size = New System.Drawing.Size(136, 65)
        Me.btnOtra.TabIndex = 16
        Me.btnOtra.Text = "Otra Cantidad"
        Me.btnOtra.UseVisualStyleBackColor = True
        '
        'btn2500
        '
        Me.btn2500.Location = New System.Drawing.Point(818, 330)
        Me.btn2500.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn2500.Name = "btn2500"
        Me.btn2500.Size = New System.Drawing.Size(136, 65)
        Me.btn2500.TabIndex = 15
        Me.btn2500.Text = "$2500"
        Me.btn2500.UseVisualStyleBackColor = True
        '
        'btn1000
        '
        Me.btn1000.Location = New System.Drawing.Point(818, 228)
        Me.btn1000.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn1000.Name = "btn1000"
        Me.btn1000.Size = New System.Drawing.Size(136, 65)
        Me.btn1000.TabIndex = 14
        Me.btn1000.Text = "$1000"
        Me.btn1000.UseVisualStyleBackColor = True
        '
        'btn500
        '
        Me.btn500.Location = New System.Drawing.Point(52, 517)
        Me.btn500.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn500.Name = "btn500"
        Me.btn500.Size = New System.Drawing.Size(136, 65)
        Me.btn500.TabIndex = 13
        Me.btn500.Text = "$500"
        Me.btn500.UseVisualStyleBackColor = True
        '
        'btn200
        '
        Me.btn200.Location = New System.Drawing.Point(52, 428)
        Me.btn200.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn200.Name = "btn200"
        Me.btn200.Size = New System.Drawing.Size(136, 65)
        Me.btn200.TabIndex = 12
        Me.btn200.Text = "$200"
        Me.btn200.UseVisualStyleBackColor = True
        '
        'btn100
        '
        Me.btn100.Location = New System.Drawing.Point(52, 330)
        Me.btn100.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(136, 65)
        Me.btn100.TabIndex = 11
        Me.btn100.Text = "$100"
        Me.btn100.UseVisualStyleBackColor = True
        '
        'btn50
        '
        Me.btn50.Location = New System.Drawing.Point(51, 237)
        Me.btn50.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(136, 65)
        Me.btn50.TabIndex = 10
        Me.btn50.Text = "$50"
        Me.btn50.UseVisualStyleBackColor = True
        '
        'lblSaldo
        '
        Me.lblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSaldo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSaldo.Location = New System.Drawing.Point(397, 272)
        Me.lblSaldo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(213, 82)
        Me.lblSaldo.TabIndex = 9
        Me.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlEnglish
        '
        Me.pnlEnglish.Controls.Add(Me.btnReturn)
        Me.pnlEnglish.Controls.Add(Me.btnCustomAmount)
        Me.pnlEnglish.Controls.Add(Me.btn2500e)
        Me.pnlEnglish.Controls.Add(Me.btn1000e)
        Me.pnlEnglish.Controls.Add(Me.btn500e)
        Me.pnlEnglish.Controls.Add(Me.btn200e)
        Me.pnlEnglish.Controls.Add(Me.btn100e)
        Me.pnlEnglish.Controls.Add(Me.btn50e)
        Me.pnlEnglish.Controls.Add(Me.lblSaldoe)
        Me.pnlEnglish.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEnglish.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pnlEnglish.Location = New System.Drawing.Point(0, 0)
        Me.pnlEnglish.Name = "pnlEnglish"
        Me.pnlEnglish.Size = New System.Drawing.Size(1004, 644)
        Me.pnlEnglish.TabIndex = 12
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(818, 517)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(136, 65)
        Me.btnReturn.TabIndex = 17
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnCustomAmount
        '
        Me.btnCustomAmount.Location = New System.Drawing.Point(818, 428)
        Me.btnCustomAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCustomAmount.Name = "btnCustomAmount"
        Me.btnCustomAmount.Size = New System.Drawing.Size(136, 65)
        Me.btnCustomAmount.TabIndex = 16
        Me.btnCustomAmount.Text = "Custom Amount"
        Me.btnCustomAmount.UseVisualStyleBackColor = True
        '
        'btn2500e
        '
        Me.btn2500e.Location = New System.Drawing.Point(818, 330)
        Me.btn2500e.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn2500e.Name = "btn2500e"
        Me.btn2500e.Size = New System.Drawing.Size(136, 65)
        Me.btn2500e.TabIndex = 15
        Me.btn2500e.Text = "$2500"
        Me.btn2500e.UseVisualStyleBackColor = True
        '
        'btn1000e
        '
        Me.btn1000e.Location = New System.Drawing.Point(818, 228)
        Me.btn1000e.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn1000e.Name = "btn1000e"
        Me.btn1000e.Size = New System.Drawing.Size(136, 65)
        Me.btn1000e.TabIndex = 14
        Me.btn1000e.Text = "$1000"
        Me.btn1000e.UseVisualStyleBackColor = True
        '
        'btn500e
        '
        Me.btn500e.Location = New System.Drawing.Point(52, 517)
        Me.btn500e.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn500e.Name = "btn500e"
        Me.btn500e.Size = New System.Drawing.Size(136, 65)
        Me.btn500e.TabIndex = 13
        Me.btn500e.Text = "$500"
        Me.btn500e.UseVisualStyleBackColor = True
        '
        'btn200e
        '
        Me.btn200e.Location = New System.Drawing.Point(52, 428)
        Me.btn200e.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn200e.Name = "btn200e"
        Me.btn200e.Size = New System.Drawing.Size(136, 65)
        Me.btn200e.TabIndex = 12
        Me.btn200e.Text = "$200"
        Me.btn200e.UseVisualStyleBackColor = True
        '
        'btn100e
        '
        Me.btn100e.Location = New System.Drawing.Point(52, 330)
        Me.btn100e.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn100e.Name = "btn100e"
        Me.btn100e.Size = New System.Drawing.Size(136, 65)
        Me.btn100e.TabIndex = 11
        Me.btn100e.Text = "$100"
        Me.btn100e.UseVisualStyleBackColor = True
        '
        'btn50e
        '
        Me.btn50e.Location = New System.Drawing.Point(51, 237)
        Me.btn50e.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn50e.Name = "btn50e"
        Me.btn50e.Size = New System.Drawing.Size(136, 65)
        Me.btn50e.TabIndex = 10
        Me.btn50e.Text = "$50"
        Me.btn50e.UseVisualStyleBackColor = True
        '
        'lblSaldoe
        '
        Me.lblSaldoe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSaldoe.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSaldoe.Location = New System.Drawing.Point(397, 272)
        Me.lblSaldoe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaldoe.Name = "lblSaldoe"
        Me.lblSaldoe.Size = New System.Drawing.Size(213, 82)
        Me.lblSaldoe.TabIndex = 9
        Me.lblSaldoe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRetirarDinero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1004, 644)
        Me.Controls.Add(Me.pbxNombreBanco)
        Me.Controls.Add(Me.pbxLogoBanco)
        Me.Controls.Add(Me.pnlEspañol)
        Me.Controls.Add(Me.pnlEnglish)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmRetirarDinero"
        Me.Text = "Retirar Dinero"
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEspañol.ResumeLayout(False)
        Me.pnlEnglish.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbxNombreBanco As PictureBox
    Friend WithEvents pbxLogoBanco As PictureBox
    Friend WithEvents pnlEspañol As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnOtra As Button
    Friend WithEvents btn2500 As Button
    Friend WithEvents btn1000 As Button
    Friend WithEvents btn500 As Button
    Friend WithEvents btn200 As Button
    Friend WithEvents btn100 As Button
    Friend WithEvents btn50 As Button
    Friend WithEvents lblSaldo As Label
    Friend WithEvents pnlEnglish As Panel
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnCustomAmount As Button
    Friend WithEvents btn2500e As Button
    Friend WithEvents btn1000e As Button
    Friend WithEvents btn500e As Button
    Friend WithEvents btn200e As Button
    Friend WithEvents btn100e As Button
    Friend WithEvents btn50e As Button
    Friend WithEvents lblSaldoe As Label
End Class
