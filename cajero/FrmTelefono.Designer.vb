<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTelefono
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTelefono))
        Me.lblInstruccion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PbxBanco = New System.Windows.Forms.PictureBox()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.TbxNumero = New System.Windows.Forms.TextBox()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Btn0 = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnContinuar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PbxBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInstruccion
        '
        Me.lblInstruccion.AutoSize = True
        Me.lblInstruccion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInstruccion.Location = New System.Drawing.Point(364, 134)
        Me.lblInstruccion.Name = "lblInstruccion"
        Me.lblInstruccion.Size = New System.Drawing.Size(272, 28)
        Me.lblInstruccion.TabIndex = 17
        Me.lblInstruccion.Text = "Ingrese Su Numero Telefonico"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.PbxBanco)
        Me.Panel1.Controls.Add(Me.PbxLogo)
        Me.Panel1.Location = New System.Drawing.Point(-1, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1052, 128)
        Me.Panel1.TabIndex = 18
        '
        'PbxBanco
        '
        Me.PbxBanco.Image = CType(resources.GetObject("PbxBanco.Image"), System.Drawing.Image)
        Me.PbxBanco.Location = New System.Drawing.Point(174, 9)
        Me.PbxBanco.Name = "PbxBanco"
        Me.PbxBanco.Size = New System.Drawing.Size(289, 108)
        Me.PbxBanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxBanco.TabIndex = 33
        Me.PbxBanco.TabStop = False
        '
        'PbxLogo
        '
        Me.PbxLogo.Image = CType(resources.GetObject("PbxLogo.Image"), System.Drawing.Image)
        Me.PbxLogo.Location = New System.Drawing.Point(31, 9)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(147, 108)
        Me.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxLogo.TabIndex = 32
        Me.PbxLogo.TabStop = False
        '
        'TbxNumero
        '
        Me.TbxNumero.Location = New System.Drawing.Point(383, 216)
        Me.TbxNumero.Name = "TbxNumero"
        Me.TbxNumero.Size = New System.Drawing.Size(240, 27)
        Me.TbxNumero.TabIndex = 19
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(351, 303)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(111, 43)
        Me.Btn1.TabIndex = 20
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(449, 303)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(102, 43)
        Me.Btn2.TabIndex = 21
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Location = New System.Drawing.Point(549, 303)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(111, 43)
        Me.Btn3.TabIndex = 22
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.Location = New System.Drawing.Point(351, 342)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(111, 43)
        Me.Btn4.TabIndex = 23
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'Btn5
        '
        Me.Btn5.Location = New System.Drawing.Point(449, 342)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(102, 43)
        Me.Btn5.TabIndex = 24
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = True
        '
        'Btn6
        '
        Me.Btn6.Location = New System.Drawing.Point(549, 342)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(111, 43)
        Me.Btn6.TabIndex = 25
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = True
        '
        'Btn7
        '
        Me.Btn7.Location = New System.Drawing.Point(351, 383)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(111, 43)
        Me.Btn7.TabIndex = 26
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = True
        '
        'Btn8
        '
        Me.Btn8.Location = New System.Drawing.Point(449, 383)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(102, 43)
        Me.Btn8.TabIndex = 27
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = True
        '
        'Btn9
        '
        Me.Btn9.Location = New System.Drawing.Point(549, 383)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(111, 43)
        Me.Btn9.TabIndex = 28
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = True
        '
        'Btn0
        '
        Me.Btn0.Location = New System.Drawing.Point(449, 422)
        Me.Btn0.Name = "Btn0"
        Me.Btn0.Size = New System.Drawing.Size(102, 43)
        Me.Btn0.TabIndex = 29
        Me.Btn0.Text = "0"
        Me.Btn0.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(12, 498)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(235, 100)
        Me.BtnRegresar.TabIndex = 30
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnContinuar
        '
        Me.BtnContinuar.Location = New System.Drawing.Point(803, 498)
        Me.BtnContinuar.Name = "BtnContinuar"
        Me.BtnContinuar.Size = New System.Drawing.Size(235, 100)
        Me.BtnContinuar.TabIndex = 31
        Me.BtnContinuar.Text = "Continuar"
        Me.BtnContinuar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(549, 422)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(111, 43)
        Me.BtnBorrar.TabIndex = 32
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'FrmTelefono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 610)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnContinuar)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.Btn0)
        Me.Controls.Add(Me.Btn9)
        Me.Controls.Add(Me.Btn8)
        Me.Controls.Add(Me.Btn7)
        Me.Controls.Add(Me.Btn6)
        Me.Controls.Add(Me.Btn5)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.TbxNumero)
        Me.Controls.Add(Me.lblInstruccion)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTelefono"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PbxBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstruccion As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TbxNumero As TextBox
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents Btn7 As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents Btn0 As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnContinuar As Button
    Friend WithEvents PbxBanco As PictureBox
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents BtnBorrar As Button
End Class
