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
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.tbxSaldoRetirar = New System.Windows.Forms.TextBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSaldo
        '
        Me.lblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSaldo.Location = New System.Drawing.Point(100, 112)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(100, 23)
        Me.lblSaldo.TabIndex = 0
        '
        'tbxSaldoRetirar
        '
        Me.tbxSaldoRetirar.Location = New System.Drawing.Point(353, 195)
        Me.tbxSaldoRetirar.Name = "tbxSaldoRetirar"
        Me.tbxSaldoRetirar.Size = New System.Drawing.Size(100, 23)
        Me.tbxSaldoRetirar.TabIndex = 1
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(56, 312)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 2
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnRetirar
        '
        Me.btnRetirar.Location = New System.Drawing.Point(672, 312)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(75, 23)
        Me.btnRetirar.TabIndex = 3
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'frmOtraCantidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRetirar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.tbxSaldoRetirar)
        Me.Controls.Add(Me.lblSaldo)
        Me.Name = "frmOtraCantidad"
        Me.Text = "frmOtraCantidad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSaldo As Label
    Friend WithEvents tbxSaldoRetirar As TextBox
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnRetirar As Button
End Class
