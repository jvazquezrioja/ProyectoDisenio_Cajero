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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRetirarDinero))
        Me.pbxNombreBanco = New System.Windows.Forms.PictureBox()
        Me.pbxLogoBanco = New System.Windows.Forms.PictureBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnOtraCantidad = New System.Windows.Forms.Button()
        Me.btn2500 = New System.Windows.Forms.Button()
        Me.btn1000 = New System.Windows.Forms.Button()
        Me.btn500 = New System.Windows.Forms.Button()
        Me.btn200 = New System.Windows.Forms.Button()
        Me.btn100 = New System.Windows.Forms.Button()
        Me.btn50 = New System.Windows.Forms.Button()
        Me.lblSaldo = New System.Windows.Forms.Label()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxNombreBanco
        '
        Me.pbxNombreBanco.Image = CType(resources.GetObject("pbxNombreBanco.Image"), System.Drawing.Image)
        Me.pbxNombreBanco.Location = New System.Drawing.Point(175, 12)
        Me.pbxNombreBanco.Name = "pbxNombreBanco"
        Me.pbxNombreBanco.Size = New System.Drawing.Size(606, 154)
        Me.pbxNombreBanco.TabIndex = 10
        Me.pbxNombreBanco.TabStop = False
        '
        'pbxLogoBanco
        '
        Me.pbxLogoBanco.Image = CType(resources.GetObject("pbxLogoBanco.Image"), System.Drawing.Image)
        Me.pbxLogoBanco.Location = New System.Drawing.Point(12, 12)
        Me.pbxLogoBanco.Name = "pbxLogoBanco"
        Me.pbxLogoBanco.Size = New System.Drawing.Size(145, 154)
        Me.pbxLogoBanco.TabIndex = 9
        Me.pbxLogoBanco.TabStop = False
        '
        'btnRegresar
        '
        Me.btnRegresar.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRegresar.Location = New System.Drawing.Point(817, 536)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(136, 65)
        Me.btnRegresar.TabIndex = 26
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnOtraCantidad
        '
        Me.btnOtraCantidad.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOtraCantidad.Location = New System.Drawing.Point(817, 447)
        Me.btnOtraCantidad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOtraCantidad.Name = "btnOtraCantidad"
        Me.btnOtraCantidad.Size = New System.Drawing.Size(136, 65)
        Me.btnOtraCantidad.TabIndex = 25
        Me.btnOtraCantidad.Text = "Otra Cantidad"
        Me.btnOtraCantidad.UseVisualStyleBackColor = True
        '
        'btn2500
        '
        Me.btn2500.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn2500.Location = New System.Drawing.Point(817, 349)
        Me.btn2500.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn2500.Name = "btn2500"
        Me.btn2500.Size = New System.Drawing.Size(136, 65)
        Me.btn2500.TabIndex = 24
        Me.btn2500.Text = "$2500"
        Me.btn2500.UseVisualStyleBackColor = True
        '
        'btn1000
        '
        Me.btn1000.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn1000.Location = New System.Drawing.Point(817, 247)
        Me.btn1000.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn1000.Name = "btn1000"
        Me.btn1000.Size = New System.Drawing.Size(136, 65)
        Me.btn1000.TabIndex = 23
        Me.btn1000.Text = "$1000"
        Me.btn1000.UseVisualStyleBackColor = True
        '
        'btn500
        '
        Me.btn500.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn500.Location = New System.Drawing.Point(51, 536)
        Me.btn500.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn500.Name = "btn500"
        Me.btn500.Size = New System.Drawing.Size(136, 65)
        Me.btn500.TabIndex = 22
        Me.btn500.Text = "$500"
        Me.btn500.UseVisualStyleBackColor = True
        '
        'btn200
        '
        Me.btn200.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn200.Location = New System.Drawing.Point(52, 426)
        Me.btn200.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn200.Name = "btn200"
        Me.btn200.Size = New System.Drawing.Size(136, 65)
        Me.btn200.TabIndex = 21
        Me.btn200.Text = "$200"
        Me.btn200.UseVisualStyleBackColor = True
        '
        'btn100
        '
        Me.btn100.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn100.Location = New System.Drawing.Point(52, 330)
        Me.btn100.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(136, 65)
        Me.btn100.TabIndex = 20
        Me.btn100.Text = "$100"
        Me.btn100.UseVisualStyleBackColor = True
        '
        'btn50
        '
        Me.btn50.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn50.Location = New System.Drawing.Point(51, 237)
        Me.btn50.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(136, 65)
        Me.btn50.TabIndex = 19
        Me.btn50.Text = "$50"
        Me.btn50.UseVisualStyleBackColor = True
        '
        'lblSaldo
        '
        Me.lblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSaldo.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSaldo.Location = New System.Drawing.Point(396, 281)
        Me.lblSaldo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(213, 82)
        Me.lblSaldo.TabIndex = 18
        Me.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRetirarDinero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1004, 644)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnOtraCantidad)
        Me.Controls.Add(Me.btn2500)
        Me.Controls.Add(Me.btn1000)
        Me.Controls.Add(Me.btn500)
        Me.Controls.Add(Me.btn200)
        Me.Controls.Add(Me.btn100)
        Me.Controls.Add(Me.btn50)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.pbxNombreBanco)
        Me.Controls.Add(Me.pbxLogoBanco)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmRetirarDinero"
        Me.Text = "Retirar Dinero"
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbxNombreBanco As PictureBox
    Friend WithEvents pbxLogoBanco As PictureBox
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnOtraCantidad As Button
    Friend WithEvents btn2500 As Button
    Friend WithEvents btn1000 As Button
    Friend WithEvents btn500 As Button
    Friend WithEvents btn200 As Button
    Friend WithEvents btn100 As Button
    Friend WithEvents btn50 As Button
    Friend WithEvents lblSaldo As Label
End Class
