<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCompañiasint
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
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnIzzi = New System.Windows.Forms.Button()
        Me.BtnMovistar = New System.Windows.Forms.Button()
        Me.BtnMegacable = New System.Windows.Forms.Button()
        Me.BtnInfinitum = New System.Windows.Forms.Button()
        Me.LblInstruccion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(15, 608)
        Me.BtnRegresar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(294, 125)
        Me.BtnRegresar.TabIndex = 13
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnIzzi
        '
        Me.BtnIzzi.Location = New System.Drawing.Point(1004, 436)
        Me.BtnIzzi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnIzzi.Name = "BtnIzzi"
        Me.BtnIzzi.Size = New System.Drawing.Size(294, 125)
        Me.BtnIzzi.TabIndex = 12
        Me.BtnIzzi.Text = "Izzi"
        Me.BtnIzzi.UseVisualStyleBackColor = True
        '
        'BtnMovistar
        '
        Me.BtnMovistar.Location = New System.Drawing.Point(1004, 278)
        Me.BtnMovistar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnMovistar.Name = "BtnMovistar"
        Me.BtnMovistar.Size = New System.Drawing.Size(294, 125)
        Me.BtnMovistar.TabIndex = 11
        Me.BtnMovistar.Text = "Movistar"
        Me.BtnMovistar.UseVisualStyleBackColor = True
        '
        'BtnMegacable
        '
        Me.BtnMegacable.Location = New System.Drawing.Point(15, 436)
        Me.BtnMegacable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnMegacable.Name = "BtnMegacable"
        Me.BtnMegacable.Size = New System.Drawing.Size(294, 125)
        Me.BtnMegacable.TabIndex = 10
        Me.BtnMegacable.Text = "Megacable"
        Me.BtnMegacable.UseVisualStyleBackColor = True
        '
        'BtnInfinitum
        '
        Me.BtnInfinitum.Location = New System.Drawing.Point(15, 278)
        Me.BtnInfinitum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnInfinitum.Name = "BtnInfinitum"
        Me.BtnInfinitum.Size = New System.Drawing.Size(294, 125)
        Me.BtnInfinitum.TabIndex = 9
        Me.BtnInfinitum.Text = "Infinitum"
        Me.BtnInfinitum.UseVisualStyleBackColor = True
        '
        'LblInstruccion
        '
        Me.LblInstruccion.AutoSize = True
        Me.LblInstruccion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblInstruccion.Location = New System.Drawing.Point(440, 208)
        Me.LblInstruccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblInstruccion.Name = "LblInstruccion"
        Me.LblInstruccion.Size = New System.Drawing.Size(389, 32)
        Me.LblInstruccion.TabIndex = 8
        Me.LblInstruccion.Text = "Seleccione la compañia de Internet"
        '
        'FrmCompañiasint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 762)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnIzzi)
        Me.Controls.Add(Me.BtnMovistar)
        Me.Controls.Add(Me.BtnMegacable)
        Me.Controls.Add(Me.BtnInfinitum)
        Me.Controls.Add(Me.LblInstruccion)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmCompañiasint"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnIzzi As Button
    Friend WithEvents BtnMovistar As Button
    Friend WithEvents BtnMegacable As Button
    Friend WithEvents BtnInfinitum As Button
    Friend WithEvents LblInstruccion As Label
End Class
