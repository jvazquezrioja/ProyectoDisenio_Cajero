<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmComprobantes
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
        Me.lbxComprobantes = New System.Windows.Forms.ListBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbxComprobantes
        '
        Me.lbxComprobantes.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbxComprobantes.FormattingEnabled = True
        Me.lbxComprobantes.ItemHeight = 16
        Me.lbxComprobantes.Location = New System.Drawing.Point(196, 12)
        Me.lbxComprobantes.Name = "lbxComprobantes"
        Me.lbxComprobantes.Size = New System.Drawing.Size(463, 340)
        Me.lbxComprobantes.TabIndex = 1
        '
        'btnRegresar
        '
        Me.btnRegresar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRegresar.Location = New System.Drawing.Point(24, 320)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(95, 47)
        Me.btnRegresar.TabIndex = 2
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'frmComprobantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 386)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lbxComprobantes)
        Me.Name = "frmComprobantes"
        Me.Text = "Generar Comprobante"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbxComprobantes As ListBox
    Friend WithEvents btnRegresar As Button
End Class
