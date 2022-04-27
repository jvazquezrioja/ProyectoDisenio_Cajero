<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDatos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDatos))
        Me.Pbxbanco = New System.Windows.Forms.PictureBox()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.PnlFondo = New System.Windows.Forms.Panel()
        Me.GbxReferencia = New System.Windows.Forms.GroupBox()
        Me.TbxReferencia = New System.Windows.Forms.TextBox()
        Me.GbxCantidad = New System.Windows.Forms.GroupBox()
        Me.TbxCantidad = New System.Windows.Forms.TextBox()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.Btn0 = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnPunto = New System.Windows.Forms.Button()
        Me.LblInstrucciones = New System.Windows.Forms.Label()
        Me.BtnContinuar = New System.Windows.Forms.Button()
        CType(Me.Pbxbanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlFondo.SuspendLayout()
        Me.GbxReferencia.SuspendLayout()
        Me.GbxCantidad.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pbxbanco
        '
        Me.Pbxbanco.Image = CType(resources.GetObject("Pbxbanco.Image"), System.Drawing.Image)
        Me.Pbxbanco.Location = New System.Drawing.Point(155, 13)
        Me.Pbxbanco.Name = "Pbxbanco"
        Me.Pbxbanco.Size = New System.Drawing.Size(339, 124)
        Me.Pbxbanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbxbanco.TabIndex = 1
        Me.Pbxbanco.TabStop = False
        '
        'PbxLogo
        '
        Me.PbxLogo.Image = CType(resources.GetObject("PbxLogo.Image"), System.Drawing.Image)
        Me.PbxLogo.Location = New System.Drawing.Point(29, 13)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(130, 124)
        Me.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxLogo.TabIndex = 0
        Me.PbxLogo.TabStop = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(12, 498)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(235, 100)
        Me.BtnRegresar.TabIndex = 8
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'PnlFondo
        '
        Me.PnlFondo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PnlFondo.Controls.Add(Me.Pbxbanco)
        Me.PnlFondo.Controls.Add(Me.PbxLogo)
        Me.PnlFondo.Location = New System.Drawing.Point(0, 2)
        Me.PnlFondo.Name = "PnlFondo"
        Me.PnlFondo.Size = New System.Drawing.Size(1072, 149)
        Me.PnlFondo.TabIndex = 7
        '
        'GbxReferencia
        '
        Me.GbxReferencia.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GbxReferencia.Controls.Add(Me.TbxReferencia)
        Me.GbxReferencia.Location = New System.Drawing.Point(241, 206)
        Me.GbxReferencia.Name = "GbxReferencia"
        Me.GbxReferencia.Size = New System.Drawing.Size(547, 76)
        Me.GbxReferencia.TabIndex = 9
        Me.GbxReferencia.TabStop = False
        Me.GbxReferencia.Text = "Referencia"
        '
        'TbxReferencia
        '
        Me.TbxReferencia.Location = New System.Drawing.Point(27, 31)
        Me.TbxReferencia.Name = "TbxReferencia"
        Me.TbxReferencia.Size = New System.Drawing.Size(498, 27)
        Me.TbxReferencia.TabIndex = 0
        '
        'GbxCantidad
        '
        Me.GbxCantidad.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GbxCantidad.Controls.Add(Me.TbxCantidad)
        Me.GbxCantidad.Location = New System.Drawing.Point(241, 282)
        Me.GbxCantidad.Name = "GbxCantidad"
        Me.GbxCantidad.Size = New System.Drawing.Size(547, 76)
        Me.GbxCantidad.TabIndex = 10
        Me.GbxCantidad.TabStop = False
        Me.GbxCantidad.Text = "Cantidad"
        '
        'TbxCantidad
        '
        Me.TbxCantidad.Location = New System.Drawing.Point(27, 31)
        Me.TbxCantidad.Name = "TbxCantidad"
        Me.TbxCantidad.Size = New System.Drawing.Size(498, 27)
        Me.TbxCantidad.TabIndex = 0
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(350, 365)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(100, 50)
        Me.Btn1.TabIndex = 11
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(456, 365)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(100, 50)
        Me.Btn2.TabIndex = 12
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Location = New System.Drawing.Point(562, 364)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(100, 50)
        Me.Btn3.TabIndex = 13
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Btn6
        '
        Me.Btn6.Location = New System.Drawing.Point(562, 421)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(100, 50)
        Me.Btn6.TabIndex = 16
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = True
        '
        'Btn5
        '
        Me.Btn5.Location = New System.Drawing.Point(456, 421)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(100, 50)
        Me.Btn5.TabIndex = 15
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.Location = New System.Drawing.Point(350, 421)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(100, 50)
        Me.Btn4.TabIndex = 14
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'Btn9
        '
        Me.Btn9.Location = New System.Drawing.Point(562, 477)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(100, 50)
        Me.Btn9.TabIndex = 19
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = True
        '
        'Btn8
        '
        Me.Btn8.Location = New System.Drawing.Point(456, 477)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(100, 50)
        Me.Btn8.TabIndex = 18
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = True
        '
        'Btn7
        '
        Me.Btn7.Location = New System.Drawing.Point(350, 477)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(100, 50)
        Me.Btn7.TabIndex = 17
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = True
        '
        'Btn0
        '
        Me.Btn0.Location = New System.Drawing.Point(456, 533)
        Me.Btn0.Name = "Btn0"
        Me.Btn0.Size = New System.Drawing.Size(100, 50)
        Me.Btn0.TabIndex = 20
        Me.Btn0.Text = "0"
        Me.Btn0.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(562, 533)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(100, 50)
        Me.BtnBorrar.TabIndex = 21
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnPunto
        '
        Me.BtnPunto.Location = New System.Drawing.Point(350, 533)
        Me.BtnPunto.Name = "BtnPunto"
        Me.BtnPunto.Size = New System.Drawing.Size(100, 50)
        Me.BtnPunto.TabIndex = 22
        Me.BtnPunto.Text = "."
        Me.BtnPunto.UseVisualStyleBackColor = True
        '
        'LblInstrucciones
        '
        Me.LblInstrucciones.AutoSize = True
        Me.LblInstrucciones.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblInstrucciones.Location = New System.Drawing.Point(422, 165)
        Me.LblInstrucciones.Name = "LblInstrucciones"
        Me.LblInstrucciones.Size = New System.Drawing.Size(161, 28)
        Me.LblInstrucciones.TabIndex = 23
        Me.LblInstrucciones.Text = "Ingrese sus datos"
        '
        'BtnContinuar
        '
        Me.BtnContinuar.Location = New System.Drawing.Point(803, 498)
        Me.BtnContinuar.Name = "BtnContinuar"
        Me.BtnContinuar.Size = New System.Drawing.Size(235, 100)
        Me.BtnContinuar.TabIndex = 24
        Me.BtnContinuar.Text = "Continuar"
        Me.BtnContinuar.UseVisualStyleBackColor = True
        '
        'FrmDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 610)
        Me.Controls.Add(Me.BtnContinuar)
        Me.Controls.Add(Me.LblInstrucciones)
        Me.Controls.Add(Me.BtnPunto)
        Me.Controls.Add(Me.BtnBorrar)
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
        Me.Controls.Add(Me.GbxCantidad)
        Me.Controls.Add(Me.GbxReferencia)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.PnlFondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDatos"
        Me.Text = "Form3"
        CType(Me.Pbxbanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlFondo.ResumeLayout(False)
        Me.GbxReferencia.ResumeLayout(False)
        Me.GbxReferencia.PerformLayout()
        Me.GbxCantidad.ResumeLayout(False)
        Me.GbxCantidad.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pbxbanco As PictureBox
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents PnlFondo As Panel
    Friend WithEvents GbxReferencia As GroupBox
    Friend WithEvents TbxReferencia As TextBox
    Friend WithEvents GbxCantidad As GroupBox
    Friend WithEvents TbxCantidad As TextBox
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents Btn7 As Button
    Friend WithEvents Btn0 As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnPunto As Button
    Friend WithEvents LblInstrucciones As Label
    Friend WithEvents BtnContinuar As Button
End Class
