<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompania
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCompania))
        Me.lblInstruccion = New System.Windows.Forms.Label()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnWeex = New System.Windows.Forms.Button()
        Me.BtnUnefon = New System.Windows.Forms.Button()
        Me.BtnMovistar = New System.Windows.Forms.Button()
        Me.BtnTelcel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PbxBanco = New System.Windows.Forms.PictureBox()
        Me.PbxLogobanco = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PbxBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxLogobanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInstruccion
        '
        Me.lblInstruccion.AutoSize = True
        Me.lblInstruccion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInstruccion.Location = New System.Drawing.Point(330, 129)
        Me.lblInstruccion.Name = "lblInstruccion"
        Me.lblInstruccion.Size = New System.Drawing.Size(326, 28)
        Me.lblInstruccion.TabIndex = 14
        Me.lblInstruccion.Text = "Seleccione la compañia del Telefono"
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(12, 479)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(235, 100)
        Me.BtnRegresar.TabIndex = 12
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnWeex
        '
        Me.BtnWeex.Location = New System.Drawing.Point(762, 313)
        Me.BtnWeex.Name = "BtnWeex"
        Me.BtnWeex.Size = New System.Drawing.Size(235, 100)
        Me.BtnWeex.TabIndex = 11
        Me.BtnWeex.Text = "Weex"
        Me.BtnWeex.UseVisualStyleBackColor = True
        '
        'BtnUnefon
        '
        Me.BtnUnefon.Location = New System.Drawing.Point(762, 148)
        Me.BtnUnefon.Name = "BtnUnefon"
        Me.BtnUnefon.Size = New System.Drawing.Size(235, 100)
        Me.BtnUnefon.TabIndex = 10
        Me.BtnUnefon.Text = "Unefon"
        Me.BtnUnefon.UseVisualStyleBackColor = True
        '
        'BtnMovistar
        '
        Me.BtnMovistar.Location = New System.Drawing.Point(12, 313)
        Me.BtnMovistar.Name = "BtnMovistar"
        Me.BtnMovistar.Size = New System.Drawing.Size(235, 100)
        Me.BtnMovistar.TabIndex = 9
        Me.BtnMovistar.Text = "Movistar"
        Me.BtnMovistar.UseVisualStyleBackColor = True
        '
        'BtnTelcel
        '
        Me.BtnTelcel.Location = New System.Drawing.Point(12, 148)
        Me.BtnTelcel.Name = "BtnTelcel"
        Me.BtnTelcel.Size = New System.Drawing.Size(235, 100)
        Me.BtnTelcel.TabIndex = 8
        Me.BtnTelcel.Text = "Telcel"
        Me.BtnTelcel.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.PbxBanco)
        Me.Panel1.Controls.Add(Me.PbxLogobanco)
        Me.Panel1.Location = New System.Drawing.Point(-13, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1063, 128)
        Me.Panel1.TabIndex = 15
        '
        'PbxBanco
        '
        Me.PbxBanco.Image = CType(resources.GetObject("PbxBanco.Image"), System.Drawing.Image)
        Me.PbxBanco.Location = New System.Drawing.Point(184, 12)
        Me.PbxBanco.Name = "PbxBanco"
        Me.PbxBanco.Size = New System.Drawing.Size(289, 108)
        Me.PbxBanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxBanco.TabIndex = 3
        Me.PbxBanco.TabStop = False
        '
        'PbxLogobanco
        '
        Me.PbxLogobanco.Image = CType(resources.GetObject("PbxLogobanco.Image"), System.Drawing.Image)
        Me.PbxLogobanco.Location = New System.Drawing.Point(41, 12)
        Me.PbxLogobanco.Name = "PbxLogobanco"
        Me.PbxLogobanco.Size = New System.Drawing.Size(147, 108)
        Me.PbxLogobanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxLogobanco.TabIndex = 2
        Me.PbxLogobanco.TabStop = False
        '
        'FrmCompania
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 610)
        Me.Controls.Add(Me.lblInstruccion)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnWeex)
        Me.Controls.Add(Me.BtnUnefon)
        Me.Controls.Add(Me.BtnMovistar)
        Me.Controls.Add(Me.BtnTelcel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCompania"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PbxBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxLogobanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstruccion As Label
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnWeex As Button
    Friend WithEvents BtnUnefon As Button
    Friend WithEvents BtnMovistar As Button
    Friend WithEvents BtnTelcel As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PbxBanco As PictureBox
    Friend WithEvents PbxLogobanco As PictureBox
End Class
