<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompañiasint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCompañiasint))
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnIzzi = New System.Windows.Forms.Button()
        Me.BtnMovistar = New System.Windows.Forms.Button()
        Me.BtnMegacable = New System.Windows.Forms.Button()
        Me.BtnInfinitum = New System.Windows.Forms.Button()
        Me.LblInstruccion = New System.Windows.Forms.Label()
        Me.PnlFondo = New System.Windows.Forms.Panel()
        Me.Pbxbanco = New System.Windows.Forms.PictureBox()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.PnlFondo.SuspendLayout()
        CType(Me.Pbxbanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(12, 486)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(235, 100)
        Me.BtnRegresar.TabIndex = 13
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnIzzi
        '
        Me.BtnIzzi.Location = New System.Drawing.Point(803, 349)
        Me.BtnIzzi.Name = "BtnIzzi"
        Me.BtnIzzi.Size = New System.Drawing.Size(235, 100)
        Me.BtnIzzi.TabIndex = 12
        Me.BtnIzzi.Text = "Izzi"
        Me.BtnIzzi.UseVisualStyleBackColor = True
        '
        'BtnMovistar
        '
        Me.BtnMovistar.Location = New System.Drawing.Point(803, 222)
        Me.BtnMovistar.Name = "BtnMovistar"
        Me.BtnMovistar.Size = New System.Drawing.Size(235, 100)
        Me.BtnMovistar.TabIndex = 11
        Me.BtnMovistar.Text = "Movistar"
        Me.BtnMovistar.UseVisualStyleBackColor = True
        '
        'BtnMegacable
        '
        Me.BtnMegacable.Location = New System.Drawing.Point(12, 349)
        Me.BtnMegacable.Name = "BtnMegacable"
        Me.BtnMegacable.Size = New System.Drawing.Size(235, 100)
        Me.BtnMegacable.TabIndex = 10
        Me.BtnMegacable.Text = "Megacable"
        Me.BtnMegacable.UseVisualStyleBackColor = True
        '
        'BtnInfinitum
        '
        Me.BtnInfinitum.Location = New System.Drawing.Point(12, 222)
        Me.BtnInfinitum.Name = "BtnInfinitum"
        Me.BtnInfinitum.Size = New System.Drawing.Size(235, 100)
        Me.BtnInfinitum.TabIndex = 9
        Me.BtnInfinitum.Text = "Infinitum"
        Me.BtnInfinitum.UseVisualStyleBackColor = True
        '
        'LblInstruccion
        '
        Me.LblInstruccion.AutoSize = True
        Me.LblInstruccion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblInstruccion.Location = New System.Drawing.Point(352, 166)
        Me.LblInstruccion.Name = "LblInstruccion"
        Me.LblInstruccion.Size = New System.Drawing.Size(315, 28)
        Me.LblInstruccion.TabIndex = 8
        Me.LblInstruccion.Text = "Seleccione la compañia de Internet"
        '
        'PnlFondo
        '
        Me.PnlFondo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PnlFondo.Controls.Add(Me.Pbxbanco)
        Me.PnlFondo.Controls.Add(Me.PbxLogo)
        Me.PnlFondo.Location = New System.Drawing.Point(-5, 1)
        Me.PnlFondo.Name = "PnlFondo"
        Me.PnlFondo.Size = New System.Drawing.Size(1072, 149)
        Me.PnlFondo.TabIndex = 7
        '
        'Pbxbanco
        '
        Me.Pbxbanco.Image = CType(resources.GetObject("Pbxbanco.Image"), System.Drawing.Image)
        Me.Pbxbanco.Location = New System.Drawing.Point(161, 13)
        Me.Pbxbanco.Name = "Pbxbanco"
        Me.Pbxbanco.Size = New System.Drawing.Size(339, 124)
        Me.Pbxbanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbxbanco.TabIndex = 1
        Me.Pbxbanco.TabStop = False
        '
        'PbxLogo
        '
        Me.PbxLogo.Image = CType(resources.GetObject("PbxLogo.Image"), System.Drawing.Image)
        Me.PbxLogo.Location = New System.Drawing.Point(35, 13)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(130, 124)
        Me.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxLogo.TabIndex = 0
        Me.PbxLogo.TabStop = False
        '
        'FrmCompañiasint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 610)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnIzzi)
        Me.Controls.Add(Me.BtnMovistar)
        Me.Controls.Add(Me.BtnMegacable)
        Me.Controls.Add(Me.BtnInfinitum)
        Me.Controls.Add(Me.LblInstruccion)
        Me.Controls.Add(Me.PnlFondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCompañiasint"
        Me.Text = "Form2"
        Me.PnlFondo.ResumeLayout(False)
        CType(Me.Pbxbanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnIzzi As Button
    Friend WithEvents BtnMovistar As Button
    Friend WithEvents BtnMegacable As Button
    Friend WithEvents BtnInfinitum As Button
    Friend WithEvents LblInstruccion As Label
    Friend WithEvents PnlFondo As Panel
    Friend WithEvents Pbxbanco As PictureBox
    Friend WithEvents PbxLogo As PictureBox
End Class
