<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCompania
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCompania))
        Me.lblInstruccion = New System.Windows.Forms.Label()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnWeex = New System.Windows.Forms.Button()
        Me.BtnUnefon = New System.Windows.Forms.Button()
        Me.BtnMovistar = New System.Windows.Forms.Button()
        Me.BtnTelcel = New System.Windows.Forms.Button()
        Me.pbxNombreBanco = New System.Windows.Forms.PictureBox()
        Me.pbxLogoBanco = New System.Windows.Forms.PictureBox()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInstruccion
        '
        Me.lblInstruccion.AutoSize = True
        Me.lblInstruccion.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInstruccion.Location = New System.Drawing.Point(242, 184)
        Me.lblInstruccion.Name = "lblInstruccion"
        Me.lblInstruccion.Size = New System.Drawing.Size(218, 20)
        Me.lblInstruccion.TabIndex = 14
        Me.lblInstruccion.Text = "Seleccione su compañía telefonica"
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnRegresar.Location = New System.Drawing.Point(573, 310)
        Me.BtnRegresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(97, 45)
        Me.BtnRegresar.TabIndex = 12
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnWeex
        '
        Me.BtnWeex.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnWeex.Location = New System.Drawing.Point(573, 198)
        Me.BtnWeex.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnWeex.Name = "BtnWeex"
        Me.BtnWeex.Size = New System.Drawing.Size(97, 45)
        Me.BtnWeex.TabIndex = 11
        Me.BtnWeex.Text = "Weex"
        Me.BtnWeex.UseVisualStyleBackColor = True
        '
        'BtnUnefon
        '
        Me.BtnUnefon.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnUnefon.Location = New System.Drawing.Point(573, 137)
        Me.BtnUnefon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnUnefon.Name = "BtnUnefon"
        Me.BtnUnefon.Size = New System.Drawing.Size(97, 45)
        Me.BtnUnefon.TabIndex = 10
        Me.BtnUnefon.Text = "Unefon"
        Me.BtnUnefon.UseVisualStyleBackColor = True
        '
        'BtnMovistar
        '
        Me.BtnMovistar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnMovistar.Location = New System.Drawing.Point(36, 198)
        Me.BtnMovistar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnMovistar.Name = "BtnMovistar"
        Me.BtnMovistar.Size = New System.Drawing.Size(97, 45)
        Me.BtnMovistar.TabIndex = 9
        Me.BtnMovistar.Text = "Movistar"
        Me.BtnMovistar.UseVisualStyleBackColor = True
        '
        'BtnTelcel
        '
        Me.BtnTelcel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTelcel.Location = New System.Drawing.Point(36, 142)
        Me.BtnTelcel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnTelcel.Name = "BtnTelcel"
        Me.BtnTelcel.Size = New System.Drawing.Size(97, 45)
        Me.BtnTelcel.TabIndex = 8
        Me.BtnTelcel.Text = "Telcel"
        Me.BtnTelcel.UseVisualStyleBackColor = True
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
        'FrmCompania
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(703, 386)
        Me.Controls.Add(Me.pbxNombreBanco)
        Me.Controls.Add(Me.pbxLogoBanco)
        Me.Controls.Add(Me.lblInstruccion)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnWeex)
        Me.Controls.Add(Me.BtnUnefon)
        Me.Controls.Add(Me.BtnMovistar)
        Me.Controls.Add(Me.BtnTelcel)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmCompania"
        Me.Text = "Compañía Telefonica"
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstruccion As Label
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnWeex As Button
    Friend WithEvents BtnUnefon As Button
    Friend WithEvents BtnMovistar As Button
    Friend WithEvents BtnTelcel As Button
    Friend WithEvents pbxNombreBanco As PictureBox
    Friend WithEvents pbxLogoBanco As PictureBox
End Class
