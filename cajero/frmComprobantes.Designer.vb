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
        Me.lbxComprobantes.FormattingEnabled = True
        Me.lbxComprobantes.ItemHeight = 25
        Me.lbxComprobantes.Location = New System.Drawing.Point(280, 20)
        Me.lbxComprobantes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lbxComprobantes.Name = "lbxComprobantes"
        Me.lbxComprobantes.Size = New System.Drawing.Size(660, 579)
        Me.lbxComprobantes.TabIndex = 1
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(34, 534)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(136, 65)
        Me.btnRegresar.TabIndex = 2
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'frmComprobantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 644)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lbxComprobantes)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmComprobantes"
        Me.Text = "Generar Comprobante"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbxComprobantes As ListBox
    Friend WithEvents btnRegresar As Button
End Class
