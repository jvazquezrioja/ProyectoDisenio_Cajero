<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultarSaldo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultarSaldo))
        Me.pbxNombreBanco = New System.Windows.Forms.PictureBox()
        Me.pbxLogoBanco = New System.Windows.Forms.PictureBox()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.pnlEsapñol = New System.Windows.Forms.Panel()
        Me.btnReturn = New System.Windows.Forms.Button()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEsapñol.SuspendLayout()
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
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSaldo.Font = New System.Drawing.Font("Arial Narrow", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSaldo.Location = New System.Drawing.Point(444, 280)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(117, 85)
        Me.lblSaldo.TabIndex = 5
        Me.lblSaldo.Text = "     "
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(856, 567)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(136, 65)
        Me.btnRegresar.TabIndex = 7
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'pnlEsapñol
        '
        Me.pnlEsapñol.Controls.Add(Me.lblSaldo)
        Me.pnlEsapñol.Controls.Add(Me.btnReturn)
        Me.pnlEsapñol.Controls.Add(Me.btnRegresar)
        Me.pnlEsapñol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEsapñol.Location = New System.Drawing.Point(0, 0)
        Me.pnlEsapñol.Name = "pnlEsapñol"
        Me.pnlEsapñol.Size = New System.Drawing.Size(1004, 644)
        Me.pnlEsapñol.TabIndex = 8
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(856, 567)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(136, 65)
        Me.btnReturn.TabIndex = 8
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        Me.btnReturn.Visible = False
        '
        'frmConsultarSaldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1004, 644)
        Me.Controls.Add(Me.pbxNombreBanco)
        Me.Controls.Add(Me.pbxLogoBanco)
        Me.Controls.Add(Me.pnlEsapñol)
        Me.Name = "frmConsultarSaldo"
        Me.Text = "Consultar Saldo"
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEsapñol.ResumeLayout(False)
        Me.pnlEsapñol.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbxNombreBanco As PictureBox
    Friend WithEvents pbxLogoBanco As PictureBox
    Friend WithEvents lblSaldo As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents pnlEsapñol As Panel
    Friend WithEvents btnReturn As Button
End Class
