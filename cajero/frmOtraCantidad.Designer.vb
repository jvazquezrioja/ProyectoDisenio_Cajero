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
        Me.pbxNombreBanco = New System.Windows.Forms.PictureBox()
        Me.pbxLogoBanco = New System.Windows.Forms.PictureBox()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.lblSaldoRetirar = New System.Windows.Forms.Label()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCantidadSaldo
        '
        Me.lblCantidadSaldo.BackColor = System.Drawing.Color.White
        Me.lblCantidadSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCantidadSaldo.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCantidadSaldo.Location = New System.Drawing.Point(379, 253)
        Me.lblCantidadSaldo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCantidadSaldo.Name = "lblCantidadSaldo"
        Me.lblCantidadSaldo.Size = New System.Drawing.Size(243, 73)
        Me.lblCantidadSaldo.TabIndex = 0
        Me.lblCantidadSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSaldoRetirar
        '
        Me.txtSaldoRetirar.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSaldoRetirar.Location = New System.Drawing.Point(382, 361)
        Me.txtSaldoRetirar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSaldoRetirar.Name = "txtSaldoRetirar"
        Me.txtSaldoRetirar.Size = New System.Drawing.Size(243, 40)
        Me.txtSaldoRetirar.TabIndex = 1
        Me.txtSaldoRetirar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRegresar
        '
        Me.btnRegresar.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRegresar.Location = New System.Drawing.Point(51, 536)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(136, 65)
        Me.btnRegresar.TabIndex = 2
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnRetirar
        '
        Me.btnRetirar.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRetirar.Location = New System.Drawing.Point(817, 536)
        Me.btnRetirar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(136, 65)
        Me.btnRetirar.TabIndex = 3
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.UseVisualStyleBackColor = True
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
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSaldo.Location = New System.Drawing.Point(461, 217)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(92, 33)
        Me.lblSaldo.TabIndex = 13
        Me.lblSaldo.Text = "Saldo"
        '
        'lblSaldoRetirar
        '
        Me.lblSaldoRetirar.AutoSize = True
        Me.lblSaldoRetirar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSaldoRetirar.Location = New System.Drawing.Point(398, 329)
        Me.lblSaldoRetirar.Name = "lblSaldoRetirar"
        Me.lblSaldoRetirar.Size = New System.Drawing.Size(211, 29)
        Me.lblSaldoRetirar.TabIndex = 14
        Me.lblSaldoRetirar.Text = "Cantidad a retirar"
        '
        'frmOtraCantidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1004, 644)
        Me.Controls.Add(Me.lblSaldoRetirar)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.lblCantidadSaldo)
        Me.Controls.Add(Me.txtSaldoRetirar)
        Me.Controls.Add(Me.pbxNombreBanco)
        Me.Controls.Add(Me.pbxLogoBanco)
        Me.Controls.Add(Me.btnRetirar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmOtraCantidad"
        Me.Text = "frmOtraCantidad"
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCantidadSaldo As Label
    Friend WithEvents txtSaldoRetirar As TextBox
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnRetirar As Button
    Friend WithEvents pbxNombreBanco As PictureBox
    Friend WithEvents pbxLogoBanco As PictureBox
    Friend WithEvents lblSaldo As Label
    Friend WithEvents lblSaldoRetirar As Label
End Class
