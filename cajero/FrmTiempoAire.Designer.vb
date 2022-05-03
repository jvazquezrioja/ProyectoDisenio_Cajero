<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTiempoAire
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTiempoAire))
        Me.Btn20 = New System.Windows.Forms.Button()
        Me.Btn100 = New System.Windows.Forms.Button()
        Me.Btn50 = New System.Windows.Forms.Button()
        Me.Btn500 = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.lblnombreBanco = New System.Windows.Forms.Label()
        Me.lblInstruccion = New System.Windows.Forms.Label()
        Me.pbxNombreBanco = New System.Windows.Forms.PictureBox()
        Me.pbxLogoBanco = New System.Windows.Forms.PictureBox()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn20
        '
        Me.Btn20.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn20.Location = New System.Drawing.Point(36, 142)
        Me.Btn20.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn20.Name = "Btn20"
        Me.Btn20.Size = New System.Drawing.Size(95, 47)
        Me.Btn20.TabIndex = 0
        Me.Btn20.Text = "$20"
        Me.Btn20.UseVisualStyleBackColor = True
        '
        'Btn100
        '
        Me.Btn100.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn100.Location = New System.Drawing.Point(573, 137)
        Me.Btn100.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn100.Name = "Btn100"
        Me.Btn100.Size = New System.Drawing.Size(95, 47)
        Me.Btn100.TabIndex = 1
        Me.Btn100.Text = "$100"
        Me.Btn100.UseVisualStyleBackColor = True
        '
        'Btn50
        '
        Me.Btn50.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn50.Location = New System.Drawing.Point(36, 198)
        Me.Btn50.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn50.Name = "Btn50"
        Me.Btn50.Size = New System.Drawing.Size(95, 47)
        Me.Btn50.TabIndex = 2
        Me.Btn50.Text = "$50"
        Me.Btn50.UseVisualStyleBackColor = True
        '
        'Btn500
        '
        Me.Btn500.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn500.Location = New System.Drawing.Point(573, 198)
        Me.Btn500.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn500.Name = "Btn500"
        Me.Btn500.Size = New System.Drawing.Size(95, 47)
        Me.Btn500.TabIndex = 3
        Me.Btn500.Text = "$500"
        Me.Btn500.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnRegresar.Location = New System.Drawing.Point(573, 310)
        Me.BtnRegresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(95, 47)
        Me.BtnRegresar.TabIndex = 4
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'lblnombreBanco
        '
        Me.lblnombreBanco.AutoSize = True
        Me.lblnombreBanco.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblnombreBanco.Font = New System.Drawing.Font("Segoe UI Emoji", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblnombreBanco.Location = New System.Drawing.Point(74, 7)
        Me.lblnombreBanco.Name = "lblnombreBanco"
        Me.lblnombreBanco.Size = New System.Drawing.Size(0, 57)
        Me.lblnombreBanco.TabIndex = 5
        '
        'lblInstruccion
        '
        Me.lblInstruccion.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInstruccion.Location = New System.Drawing.Point(190, 168)
        Me.lblInstruccion.Name = "lblInstruccion"
        Me.lblInstruccion.Size = New System.Drawing.Size(305, 59)
        Me.lblInstruccion.TabIndex = 6
        Me.lblInstruccion.Text = "Seleccione la recarga que desea de la compañía"
        Me.lblInstruccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbxNombreBanco
        '
        Me.pbxNombreBanco.BackgroundImage = CType(resources.GetObject("pbxNombreBanco.BackgroundImage"), System.Drawing.Image)
        Me.pbxNombreBanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxNombreBanco.Location = New System.Drawing.Point(124, 10)
        Me.pbxNombreBanco.Margin = New System.Windows.Forms.Padding(1)
        Me.pbxNombreBanco.Name = "pbxNombreBanco"
        Me.pbxNombreBanco.Size = New System.Drawing.Size(424, 92)
        Me.pbxNombreBanco.TabIndex = 32
        Me.pbxNombreBanco.TabStop = False
        '
        'pbxLogoBanco
        '
        Me.pbxLogoBanco.BackgroundImage = CType(resources.GetObject("pbxLogoBanco.BackgroundImage"), System.Drawing.Image)
        Me.pbxLogoBanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxLogoBanco.Location = New System.Drawing.Point(10, 10)
        Me.pbxLogoBanco.Margin = New System.Windows.Forms.Padding(1)
        Me.pbxLogoBanco.Name = "pbxLogoBanco"
        Me.pbxLogoBanco.Size = New System.Drawing.Size(102, 92)
        Me.pbxLogoBanco.TabIndex = 31
        Me.pbxLogoBanco.TabStop = False
        '
        'frmTiempoAire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(703, 386)
        Me.Controls.Add(Me.pbxNombreBanco)
        Me.Controls.Add(Me.pbxLogoBanco)
        Me.Controls.Add(Me.lblInstruccion)
        Me.Controls.Add(Me.lblnombreBanco)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.Btn500)
        Me.Controls.Add(Me.Btn50)
        Me.Controls.Add(Me.Btn100)
        Me.Controls.Add(Me.Btn20)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmTiempoAire"
        Me.Text = "Cantidad Recarga(Tiempo Aire)"
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn20 As Button
    Friend WithEvents Btn100 As Button
    Friend WithEvents Btn50 As Button
    Friend WithEvents Btn500 As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents lblnombreBanco As Label
    Friend WithEvents lblInstruccion As Label
    Friend WithEvents pbxNombreBanco As PictureBox
    Friend WithEvents pbxLogoBanco As PictureBox
End Class
