<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComprobantes
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
        Me.lbxComprobantes = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lbxComprobantes
        '
        Me.lbxComprobantes.FormattingEnabled = True
        Me.lbxComprobantes.ItemHeight = 15
        Me.lbxComprobantes.Location = New System.Drawing.Point(164, 12)
        Me.lbxComprobantes.Name = "lbxComprobantes"
        Me.lbxComprobantes.Size = New System.Drawing.Size(594, 409)
        Me.lbxComprobantes.TabIndex = 1
        '
        'frmComprobantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbxComprobantes)
        Me.Name = "frmComprobantes"
        Me.Text = "frmComprobantes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbxComprobantes As ListBox
End Class
