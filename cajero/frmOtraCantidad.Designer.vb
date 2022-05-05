<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOtraCantidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOtraCantidad))
        Me.lblCantidadSaldo = New System.Windows.Forms.Label()
        Me.txtSaldoRetirar = New System.Windows.Forms.TextBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.lblSaldoRetirar = New System.Windows.Forms.Label()
        Me.lblAnuncioMultiplos = New System.Windows.Forms.Label()
        Me.pbxNombreBanco = New System.Windows.Forms.PictureBox()
        Me.pbxLogoBanco = New System.Windows.Forms.PictureBox()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCantidadSaldo
        '
        Me.lblCantidadSaldo.BackColor = System.Drawing.Color.White
        Me.lblCantidadSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCantidadSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCantidadSaldo.Location = New System.Drawing.Point(173, 191)
        Me.lblCantidadSaldo.Name = "lblCantidadSaldo"
        Me.lblCantidadSaldo.Size = New System.Drawing.Size(195, 59)
        Me.lblCantidadSaldo.TabIndex = 0
        Me.lblCantidadSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSaldoRetirar
        '
        Me.txtSaldoRetirar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSaldoRetirar.Location = New System.Drawing.Point(173, 397)
        Me.txtSaldoRetirar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSaldoRetirar.Name = "txtSaldoRetirar"
        Me.txtSaldoRetirar.Size = New System.Drawing.Size(195, 34)
        Me.txtSaldoRetirar.TabIndex = 1
        Me.txtSaldoRetirar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRegresar
        '
        Me.btnRegresar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRegresar.Location = New System.Drawing.Point(649, 428)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(109, 63)
        Me.btnRegresar.TabIndex = 2
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnRetirar
        '
        Me.btnRetirar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRetirar.Location = New System.Drawing.Point(649, 337)
        Me.btnRetirar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(109, 63)
        Me.btnRetirar.TabIndex = 3
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSaldo.Location = New System.Drawing.Point(238, 161)
        Me.lblSaldo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(79, 29)
        Me.lblSaldo.TabIndex = 13
        Me.lblSaldo.Text = "Saldo"
        '
        'lblSaldoRetirar
        '
        Me.lblSaldoRetirar.AutoSize = True
        Me.lblSaldoRetirar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSaldoRetirar.Location = New System.Drawing.Point(190, 319)
        Me.lblSaldoRetirar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSaldoRetirar.Name = "lblSaldoRetirar"
        Me.lblSaldoRetirar.Size = New System.Drawing.Size(175, 24)
        Me.lblSaldoRetirar.TabIndex = 14
        Me.lblSaldoRetirar.Text = "Cantidad a retirar"
        '
        'lblAnuncioMultiplos
        '
        Me.lblAnuncioMultiplos.AutoSize = True
        Me.lblAnuncioMultiplos.Location = New System.Drawing.Point(81, 353)
        Me.lblAnuncioMultiplos.Name = "lblAnuncioMultiplos"
        Me.lblAnuncioMultiplos.Size = New System.Drawing.Size(444, 20)
        Me.lblAnuncioMultiplos.TabIndex = 15
        Me.lblAnuncioMultiplos.Text = "Solo puede retirar efectivo en multiplos de $200 (Maximo $5,000)"
        '
        'pbxNombreBanco
        '
        Me.pbxNombreBanco.BackgroundImage = CType(resources.GetObject("pbxNombreBanco.BackgroundImage"), System.Drawing.Image)
        Me.pbxNombreBanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxNombreBanco.Location = New System.Drawing.Point(142, 13)
        Me.pbxNombreBanco.Margin = New System.Windows.Forms.Padding(1)
        Me.pbxNombreBanco.Name = "pbxNombreBanco"
        Me.pbxNombreBanco.Size = New System.Drawing.Size(485, 123)
        Me.pbxNombreBanco.TabIndex = 32
        Me.pbxNombreBanco.TabStop = False
        '
        'pbxLogoBanco
        '
        Me.pbxLogoBanco.BackgroundImage = CType(resources.GetObject("pbxLogoBanco.BackgroundImage"), System.Drawing.Image)
        Me.pbxLogoBanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxLogoBanco.Location = New System.Drawing.Point(11, 13)
        Me.pbxLogoBanco.Margin = New System.Windows.Forms.Padding(1)
        Me.pbxLogoBanco.Name = "pbxLogoBanco"
        Me.pbxLogoBanco.Size = New System.Drawing.Size(117, 123)
        Me.pbxLogoBanco.TabIndex = 31
        Me.pbxLogoBanco.TabStop = False
        '
        'frmOtraCantidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(803, 515)
        Me.Controls.Add(Me.pbxNombreBanco)
        Me.Controls.Add(Me.pbxLogoBanco)
        Me.Controls.Add(Me.lblAnuncioMultiplos)
        Me.Controls.Add(Me.lblSaldoRetirar)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.lblCantidadSaldo)
        Me.Controls.Add(Me.txtSaldoRetirar)
        Me.Controls.Add(Me.btnRetirar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmOtraCantidad"
        Me.Text = "Otra Cantidad"
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCantidadSaldo As Label
    Friend WithEvents txtSaldoRetirar As TextBox
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnRetirar As Button
    Friend WithEvents lblSaldo As Label
    Friend WithEvents lblSaldoRetirar As Label
    Friend WithEvents lblAnuncioMultiplos As Label
    Friend WithEvents pbxNombreBanco As PictureBox
    Friend WithEvents pbxLogoBanco As PictureBox
End Class
