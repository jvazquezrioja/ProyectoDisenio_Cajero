<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTiempoAire
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTiempoAire))
        Me.Btn20 = New System.Windows.Forms.Button()
        Me.Btn100 = New System.Windows.Forms.Button()
        Me.Btn50 = New System.Windows.Forms.Button()
        Me.Btn500 = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.lblnombreBanco = New System.Windows.Forms.Label()
        Me.lblInstruccion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PbxLogobanco = New System.Windows.Forms.PictureBox()
        Me.PbxBanco = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PbxLogobanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn20
        '
        Me.Btn20.Location = New System.Drawing.Point(12, 169)
        Me.Btn20.Name = "Btn20"
        Me.Btn20.Size = New System.Drawing.Size(235, 100)
        Me.Btn20.TabIndex = 0
        Me.Btn20.Text = "$20"
        Me.Btn20.UseVisualStyleBackColor = True
        '
        'Btn100
        '
        Me.Btn100.Location = New System.Drawing.Point(12, 334)
        Me.Btn100.Name = "Btn100"
        Me.Btn100.Size = New System.Drawing.Size(235, 100)
        Me.Btn100.TabIndex = 1
        Me.Btn100.Text = "$100"
        Me.Btn100.UseVisualStyleBackColor = True
        '
        'Btn50
        '
        Me.Btn50.Location = New System.Drawing.Point(775, 169)
        Me.Btn50.Name = "Btn50"
        Me.Btn50.Size = New System.Drawing.Size(235, 100)
        Me.Btn50.TabIndex = 2
        Me.Btn50.Text = "$50"
        Me.Btn50.UseVisualStyleBackColor = True
        '
        'Btn500
        '
        Me.Btn500.Location = New System.Drawing.Point(775, 334)
        Me.Btn500.Name = "Btn500"
        Me.Btn500.Size = New System.Drawing.Size(235, 100)
        Me.Btn500.TabIndex = 3
        Me.Btn500.Text = "$500"
        Me.Btn500.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(12, 467)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(235, 100)
        Me.BtnRegresar.TabIndex = 4
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'lblnombreBanco
        '
        Me.lblnombreBanco.AutoSize = True
        Me.lblnombreBanco.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblnombreBanco.Font = New System.Drawing.Font("Segoe UI Emoji", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblnombreBanco.Location = New System.Drawing.Point(85, 9)
        Me.lblnombreBanco.Name = "lblnombreBanco"
        Me.lblnombreBanco.Size = New System.Drawing.Size(0, 72)
        Me.lblnombreBanco.TabIndex = 5
        '
        'lblInstruccion
        '
        Me.lblInstruccion.AutoSize = True
        Me.lblInstruccion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInstruccion.Location = New System.Drawing.Point(284, 133)
        Me.lblInstruccion.Name = "lblInstruccion"
        Me.lblInstruccion.Size = New System.Drawing.Size(428, 28)
        Me.lblInstruccion.TabIndex = 6
        Me.lblInstruccion.Text = "Seleccione la recarga que desea de la Compañia"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.PbxBanco)
        Me.Panel1.Controls.Add(Me.PbxLogobanco)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1040, 130)
        Me.Panel1.TabIndex = 7
        '
        'PbxLogobanco
        '
        Me.PbxLogobanco.Image = CType(resources.GetObject("PbxLogobanco.Image"), System.Drawing.Image)
        Me.PbxLogobanco.Location = New System.Drawing.Point(39, 7)
        Me.PbxLogobanco.Name = "PbxLogobanco"
        Me.PbxLogobanco.Size = New System.Drawing.Size(147, 108)
        Me.PbxLogobanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxLogobanco.TabIndex = 0
        Me.PbxLogobanco.TabStop = False
        '
        'PbxBanco
        '
        Me.PbxBanco.Image = CType(resources.GetObject("PbxBanco.Image"), System.Drawing.Image)
        Me.PbxBanco.Location = New System.Drawing.Point(182, 7)
        Me.PbxBanco.Name = "PbxBanco"
        Me.PbxBanco.Size = New System.Drawing.Size(289, 108)
        Me.PbxBanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxBanco.TabIndex = 1
        Me.PbxBanco.TabStop = False
        '
        'FrmTiempoAire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 610)
        Me.Controls.Add(Me.lblInstruccion)
        Me.Controls.Add(Me.lblnombreBanco)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.Btn500)
        Me.Controls.Add(Me.Btn50)
        Me.Controls.Add(Me.Btn100)
        Me.Controls.Add(Me.Btn20)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTiempoAire"
        Me.Text = "FrmTiempoAire"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PbxLogobanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxBanco, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PbxBanco As PictureBox
    Friend WithEvents PbxLogobanco As PictureBox
End Class
