﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCantidadSaldo
        '
        Me.lblCantidadSaldo.BackColor = System.Drawing.Color.White
        Me.lblCantidadSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCantidadSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCantidadSaldo.Location = New System.Drawing.Point(151, 143)
        Me.lblCantidadSaldo.Name = "lblCantidadSaldo"
        Me.lblCantidadSaldo.Size = New System.Drawing.Size(171, 45)
        Me.lblCantidadSaldo.TabIndex = 0
        Me.lblCantidadSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSaldoRetirar
        '
        Me.txtSaldoRetirar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSaldoRetirar.Location = New System.Drawing.Point(151, 298)
        Me.txtSaldoRetirar.Name = "txtSaldoRetirar"
        Me.txtSaldoRetirar.Size = New System.Drawing.Size(171, 29)
        Me.txtSaldoRetirar.TabIndex = 1
        Me.txtSaldoRetirar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRegresar
        '
        Me.btnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRegresar.Location = New System.Drawing.Point(568, 321)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(95, 39)
        Me.btnRegresar.TabIndex = 2
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnRetirar
        '
        Me.btnRetirar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRetirar.Location = New System.Drawing.Point(568, 253)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(95, 39)
        Me.btnRetirar.TabIndex = 3
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'pbxNombreBanco
        '
        Me.pbxNombreBanco.Image = CType(resources.GetObject("pbxNombreBanco.Image"), System.Drawing.Image)
        Me.pbxNombreBanco.Location = New System.Drawing.Point(122, 7)
        Me.pbxNombreBanco.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbxNombreBanco.Name = "pbxNombreBanco"
        Me.pbxNombreBanco.Size = New System.Drawing.Size(424, 92)
        Me.pbxNombreBanco.TabIndex = 12
        Me.pbxNombreBanco.TabStop = False
        '
        'pbxLogoBanco
        '
        Me.pbxLogoBanco.Image = CType(resources.GetObject("pbxLogoBanco.Image"), System.Drawing.Image)
        Me.pbxLogoBanco.Location = New System.Drawing.Point(8, 7)
        Me.pbxLogoBanco.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbxLogoBanco.Name = "pbxLogoBanco"
        Me.pbxLogoBanco.Size = New System.Drawing.Size(102, 92)
        Me.pbxLogoBanco.TabIndex = 11
        Me.pbxLogoBanco.TabStop = False
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSaldo.Location = New System.Drawing.Point(208, 121)
        Me.lblSaldo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(63, 22)
        Me.lblSaldo.TabIndex = 13
        Me.lblSaldo.Text = "Saldo"
        '
        'lblSaldoRetirar
        '
        Me.lblSaldoRetirar.AutoSize = True
        Me.lblSaldoRetirar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSaldoRetirar.Location = New System.Drawing.Point(166, 239)
        Me.lblSaldoRetirar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSaldoRetirar.Name = "lblSaldoRetirar"
        Me.lblSaldoRetirar.Size = New System.Drawing.Size(140, 19)
        Me.lblSaldoRetirar.TabIndex = 14
        Me.lblSaldoRetirar.Text = "Cantidad a retirar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Solo puede retirar efectivo en multiplos de $200 (Maximo $5,000)"
        '
        'frmOtraCantidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(703, 386)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSaldoRetirar)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.lblCantidadSaldo)
        Me.Controls.Add(Me.txtSaldoRetirar)
        Me.Controls.Add(Me.pbxNombreBanco)
        Me.Controls.Add(Me.pbxLogoBanco)
        Me.Controls.Add(Me.btnRetirar)
        Me.Controls.Add(Me.btnRegresar)
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
    Friend WithEvents Label1 As Label
End Class
