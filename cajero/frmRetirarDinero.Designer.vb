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
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnOtraCantidad = New System.Windows.Forms.Button()
        Me.btn2500 = New System.Windows.Forms.Button()
        Me.btn1000 = New System.Windows.Forms.Button()
        Me.btn500 = New System.Windows.Forms.Button()
        Me.btn200 = New System.Windows.Forms.Button()
        Me.btn100 = New System.Windows.Forms.Button()
        Me.btn50 = New System.Windows.Forms.Button()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.pbxNombreBanco = New System.Windows.Forms.PictureBox()
        Me.pbxLogoBanco = New System.Windows.Forms.PictureBox()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegresar
        '
        Me.btnRegresar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRegresar.Location = New System.Drawing.Point(572, 322)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(95, 47)
        Me.btnRegresar.TabIndex = 26
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnOtraCantidad
        '
        Me.btnOtraCantidad.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnOtraCantidad.Location = New System.Drawing.Point(572, 268)
        Me.btnOtraCantidad.Name = "btnOtraCantidad"
        Me.btnOtraCantidad.Size = New System.Drawing.Size(95, 47)
        Me.btnOtraCantidad.TabIndex = 25
        Me.btnOtraCantidad.Text = "Otra Cantidad"
        Me.btnOtraCantidad.UseVisualStyleBackColor = True
        '
        'btn2500
        '
        Me.btn2500.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn2500.Location = New System.Drawing.Point(572, 209)
        Me.btn2500.Name = "btn2500"
        Me.btn2500.Size = New System.Drawing.Size(95, 47)
        Me.btn2500.TabIndex = 24
        Me.btn2500.Text = "$2500"
        Me.btn2500.UseVisualStyleBackColor = True
        '
        'btn1000
        '
        Me.btn1000.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn1000.Location = New System.Drawing.Point(572, 148)
        Me.btn1000.Name = "btn1000"
        Me.btn1000.Size = New System.Drawing.Size(95, 47)
        Me.btn1000.TabIndex = 23
        Me.btn1000.Text = "$1000"
        Me.btn1000.UseVisualStyleBackColor = True
        '
        'btn500
        '
        Me.btn500.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn500.Location = New System.Drawing.Point(36, 322)
        Me.btn500.Name = "btn500"
        Me.btn500.Size = New System.Drawing.Size(95, 47)
        Me.btn500.TabIndex = 22
        Me.btn500.Text = "$500"
        Me.btn500.UseVisualStyleBackColor = True
        '
        'btn200
        '
        Me.btn200.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn200.Location = New System.Drawing.Point(36, 256)
        Me.btn200.Name = "btn200"
        Me.btn200.Size = New System.Drawing.Size(95, 47)
        Me.btn200.TabIndex = 21
        Me.btn200.Text = "$200"
        Me.btn200.UseVisualStyleBackColor = True
        '
        'btn100
        '
        Me.btn100.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn100.Location = New System.Drawing.Point(36, 198)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(95, 47)
        Me.btn100.TabIndex = 20
        Me.btn100.Text = "$100"
        Me.btn100.UseVisualStyleBackColor = True
        '
        'btn50
        '
        Me.btn50.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn50.Location = New System.Drawing.Point(36, 142)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(95, 47)
        Me.btn50.TabIndex = 19
        Me.btn50.Text = "$50"
        Me.btn50.UseVisualStyleBackColor = True
        '
        'lblSaldo
        '
        Me.lblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSaldo.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSaldo.Location = New System.Drawing.Point(277, 169)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(150, 50)
        Me.lblSaldo.TabIndex = 18
        Me.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'frmRetirarDinero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(703, 386)
        Me.Controls.Add(Me.pbxNombreBanco)
        Me.Controls.Add(Me.pbxLogoBanco)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnOtraCantidad)
        Me.Controls.Add(Me.btn2500)
        Me.Controls.Add(Me.btn1000)
        Me.Controls.Add(Me.btn500)
        Me.Controls.Add(Me.btn200)
        Me.Controls.Add(Me.btn100)
        Me.Controls.Add(Me.btn50)
        Me.Controls.Add(Me.lblSaldo)
        Me.Name = "frmRetirarDinero"
        Me.Text = "Retirar Dinero"
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnOtraCantidad As Button
    Friend WithEvents btn2500 As Button
    Friend WithEvents btn1000 As Button
    Friend WithEvents btn500 As Button
    Friend WithEvents btn200 As Button
    Friend WithEvents btn100 As Button
    Friend WithEvents btn50 As Button
    Friend WithEvents lblSaldo As Label
    Friend WithEvents pbxNombreBanco As PictureBox
    Friend WithEvents pbxLogoBanco As PictureBox
End Class
