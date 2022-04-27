<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetirarDinero
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
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.btn50 = New System.Windows.Forms.Button()
        Me.btn100 = New System.Windows.Forms.Button()
        Me.btn200 = New System.Windows.Forms.Button()
        Me.btn500 = New System.Windows.Forms.Button()
        Me.btn1000 = New System.Windows.Forms.Button()
        Me.btn2500 = New System.Windows.Forms.Button()
        Me.btnOtra = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSaldo
        '
        Me.lblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSaldo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSaldo.Location = New System.Drawing.Point(323, 161)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(150, 50)
        Me.lblSaldo.TabIndex = 0
        Me.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn50
        '
        Me.btn50.Location = New System.Drawing.Point(51, 125)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(75, 23)
        Me.btn50.TabIndex = 1
        Me.btn50.Text = "$50"
        Me.btn50.UseVisualStyleBackColor = True
        '
        'btn100
        '
        Me.btn100.Location = New System.Drawing.Point(51, 206)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(75, 23)
        Me.btn100.TabIndex = 2
        Me.btn100.Text = "$100"
        Me.btn100.UseVisualStyleBackColor = True
        '
        'btn200
        '
        Me.btn200.Location = New System.Drawing.Point(51, 294)
        Me.btn200.Name = "btn200"
        Me.btn200.Size = New System.Drawing.Size(75, 23)
        Me.btn200.TabIndex = 3
        Me.btn200.Text = "$200"
        Me.btn200.UseVisualStyleBackColor = True
        '
        'btn500
        '
        Me.btn500.Location = New System.Drawing.Point(51, 378)
        Me.btn500.Name = "btn500"
        Me.btn500.Size = New System.Drawing.Size(75, 23)
        Me.btn500.TabIndex = 4
        Me.btn500.Text = "$500"
        Me.btn500.UseVisualStyleBackColor = True
        '
        'btn1000
        '
        Me.btn1000.Location = New System.Drawing.Point(659, 161)
        Me.btn1000.Name = "btn1000"
        Me.btn1000.Size = New System.Drawing.Size(75, 23)
        Me.btn1000.TabIndex = 5
        Me.btn1000.Text = "$1000"
        Me.btn1000.UseVisualStyleBackColor = True
        '
        'btn2500
        '
        Me.btn2500.Location = New System.Drawing.Point(659, 222)
        Me.btn2500.Name = "btn2500"
        Me.btn2500.Size = New System.Drawing.Size(75, 23)
        Me.btn2500.TabIndex = 6
        Me.btn2500.Text = "$2500"
        Me.btn2500.UseVisualStyleBackColor = True
        '
        'btnOtra
        '
        Me.btnOtra.Location = New System.Drawing.Point(659, 294)
        Me.btnOtra.Name = "btnOtra"
        Me.btnOtra.Size = New System.Drawing.Size(75, 23)
        Me.btnOtra.TabIndex = 7
        Me.btnOtra.Text = "Otra Cantidad"
        Me.btnOtra.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(659, 362)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmRetirarDinero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnOtra)
        Me.Controls.Add(Me.btn2500)
        Me.Controls.Add(Me.btn1000)
        Me.Controls.Add(Me.btn500)
        Me.Controls.Add(Me.btn200)
        Me.Controls.Add(Me.btn100)
        Me.Controls.Add(Me.btn50)
        Me.Controls.Add(Me.lblSaldo)
        Me.Name = "frmRetirarDinero"
        Me.Text = "frmRetirarDinero"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblSaldo As Label
    Friend WithEvents btn50 As Button
    Friend WithEvents btn100 As Button
    Friend WithEvents btn200 As Button
    Friend WithEvents btn500 As Button
    Friend WithEvents btn1000 As Button
    Friend WithEvents btn2500 As Button
    Friend WithEvents btnOtra As Button
    Friend WithEvents btnSalir As Button
End Class
