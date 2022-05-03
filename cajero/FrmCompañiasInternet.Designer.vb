<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFrmCompañiasInt
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFrmCompañiasInt))
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnIzzi = New System.Windows.Forms.Button()
        Me.BtnMovistar = New System.Windows.Forms.Button()
        Me.BtnMegacable = New System.Windows.Forms.Button()
        Me.BtnInfinitum = New System.Windows.Forms.Button()
        Me.LblInstruccion = New System.Windows.Forms.Label()
        Me.pbxNombreBanco = New System.Windows.Forms.PictureBox()
        Me.pbxLogoBanco = New System.Windows.Forms.PictureBox()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnRegresar.Location = New System.Drawing.Point(573, 310)
        Me.BtnRegresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(97, 45)
        Me.BtnRegresar.TabIndex = 13
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnIzzi
        '
        Me.BtnIzzi.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnIzzi.Location = New System.Drawing.Point(573, 198)
        Me.BtnIzzi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnIzzi.Name = "BtnIzzi"
        Me.BtnIzzi.Size = New System.Drawing.Size(97, 45)
        Me.BtnIzzi.TabIndex = 12
        Me.BtnIzzi.Text = "Izzi"
        Me.BtnIzzi.UseVisualStyleBackColor = True
        '
        'BtnMovistar
        '
        Me.BtnMovistar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnMovistar.Location = New System.Drawing.Point(573, 137)
        Me.BtnMovistar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnMovistar.Name = "BtnMovistar"
        Me.BtnMovistar.Size = New System.Drawing.Size(97, 45)
        Me.BtnMovistar.TabIndex = 11
        Me.BtnMovistar.Text = "Movistar"
        Me.BtnMovistar.UseVisualStyleBackColor = True
        '
        'BtnMegacable
        '
        Me.BtnMegacable.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnMegacable.Location = New System.Drawing.Point(36, 198)
        Me.BtnMegacable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnMegacable.Name = "BtnMegacable"
        Me.BtnMegacable.Size = New System.Drawing.Size(97, 45)
        Me.BtnMegacable.TabIndex = 10
        Me.BtnMegacable.Text = "Megacable"
        Me.BtnMegacable.UseVisualStyleBackColor = True
        '
        'BtnInfinitum
        '
        Me.BtnInfinitum.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnInfinitum.Location = New System.Drawing.Point(36, 142)
        Me.BtnInfinitum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnInfinitum.Name = "BtnInfinitum"
        Me.BtnInfinitum.Size = New System.Drawing.Size(97, 45)
        Me.BtnInfinitum.TabIndex = 9
        Me.BtnInfinitum.Text = "Infinitum"
        Me.BtnInfinitum.UseVisualStyleBackColor = True
        '
        'LblInstruccion
        '
        Me.LblInstruccion.AutoSize = True
        Me.LblInstruccion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblInstruccion.Location = New System.Drawing.Point(216, 184)
        Me.LblInstruccion.Name = "LblInstruccion"
        Me.LblInstruccion.Size = New System.Drawing.Size(250, 21)
        Me.LblInstruccion.TabIndex = 8
        Me.LblInstruccion.Text = "Seleccione la compañía de Internet"
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
        'FrmFrmCompañiasInt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(703, 386)
        Me.Controls.Add(Me.pbxNombreBanco)
        Me.Controls.Add(Me.pbxLogoBanco)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnIzzi)
        Me.Controls.Add(Me.BtnMovistar)
        Me.Controls.Add(Me.BtnMegacable)
        Me.Controls.Add(Me.BtnInfinitum)
        Me.Controls.Add(Me.LblInstruccion)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmFrmCompañiasInt"
        Me.Text = "Companías de Internet"
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnIzzi As Button
    Friend WithEvents BtnMovistar As Button
    Friend WithEvents BtnMegacable As Button
    Friend WithEvents BtnInfinitum As Button
    Friend WithEvents LblInstruccion As Label
    Friend WithEvents pbxNombreBanco As PictureBox
    Friend WithEvents pbxLogoBanco As PictureBox
End Class
