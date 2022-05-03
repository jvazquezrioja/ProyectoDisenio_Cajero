<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAcceso
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAcceso))
        Me.btnMenuOpciones = New System.Windows.Forms.Button()
        Me.pbxLogoBanco = New System.Windows.Forms.PictureBox()
        Me.pbxNombreBanco = New System.Windows.Forms.PictureBox()
        Me.lblAcceso = New System.Windows.Forms.Label()
        Me.cbxIdiomas = New System.Windows.Forms.ComboBox()
        Me.pbxIdioma = New System.Windows.Forms.PictureBox()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxIdioma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMenuOpciones
        '
        Me.btnMenuOpciones.BackColor = System.Drawing.Color.White
        Me.btnMenuOpciones.BackgroundImage = CType(resources.GetObject("btnMenuOpciones.BackgroundImage"), System.Drawing.Image)
        Me.btnMenuOpciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMenuOpciones.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMenuOpciones.FlatAppearance.BorderSize = 0
        Me.btnMenuOpciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnMenuOpciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnMenuOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuOpciones.Font = New System.Drawing.Font("Showcard Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMenuOpciones.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnMenuOpciones.Location = New System.Drawing.Point(222, 130)
        Me.btnMenuOpciones.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnMenuOpciones.Name = "btnMenuOpciones"
        Me.btnMenuOpciones.Size = New System.Drawing.Size(257, 210)
        Me.btnMenuOpciones.TabIndex = 0
        Me.btnMenuOpciones.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMenuOpciones.UseVisualStyleBackColor = False
        '
        'pbxLogoBanco
        '
        Me.pbxLogoBanco.BackgroundImage = CType(resources.GetObject("pbxLogoBanco.BackgroundImage"), System.Drawing.Image)
        Me.pbxLogoBanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxLogoBanco.Location = New System.Drawing.Point(8, 7)
        Me.pbxLogoBanco.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.pbxLogoBanco.Name = "pbxLogoBanco"
        Me.pbxLogoBanco.Size = New System.Drawing.Size(102, 92)
        Me.pbxLogoBanco.TabIndex = 1
        Me.pbxLogoBanco.TabStop = False
        '
        'pbxNombreBanco
        '
        Me.pbxNombreBanco.BackgroundImage = CType(resources.GetObject("pbxNombreBanco.BackgroundImage"), System.Drawing.Image)
        Me.pbxNombreBanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxNombreBanco.Location = New System.Drawing.Point(122, 7)
        Me.pbxNombreBanco.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.pbxNombreBanco.Name = "pbxNombreBanco"
        Me.pbxNombreBanco.Size = New System.Drawing.Size(424, 92)
        Me.pbxNombreBanco.TabIndex = 2
        Me.pbxNombreBanco.TabStop = False
        '
        'lblAcceso
        '
        Me.lblAcceso.AutoSize = True
        Me.lblAcceso.Font = New System.Drawing.Font("Showcard Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAcceso.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblAcceso.Location = New System.Drawing.Point(265, 101)
        Me.lblAcceso.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblAcceso.Name = "lblAcceso"
        Me.lblAcceso.Size = New System.Drawing.Size(173, 28)
        Me.lblAcceso.TabIndex = 3
        Me.lblAcceso.Text = "¡Bienvenido!"
        '
        'cbxIdiomas
        '
        Me.cbxIdiomas.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbxIdiomas.FormattingEnabled = True
        Me.cbxIdiomas.Items.AddRange(New Object() {"Español", "English"})
        Me.cbxIdiomas.Location = New System.Drawing.Point(475, 342)
        Me.cbxIdiomas.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cbxIdiomas.Name = "cbxIdiomas"
        Me.cbxIdiomas.Size = New System.Drawing.Size(129, 28)
        Me.cbxIdiomas.TabIndex = 5
        Me.cbxIdiomas.Text = "Idiomas"
        '
        'pbxIdioma
        '
        Me.pbxIdioma.BackgroundImage = CType(resources.GetObject("pbxIdioma.BackgroundImage"), System.Drawing.Image)
        Me.pbxIdioma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxIdioma.Location = New System.Drawing.Point(606, 310)
        Me.pbxIdioma.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.pbxIdioma.Name = "pbxIdioma"
        Me.pbxIdioma.Size = New System.Drawing.Size(87, 76)
        Me.pbxIdioma.TabIndex = 6
        Me.pbxIdioma.TabStop = False
        '
        'FrmAcceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(703, 386)
        Me.Controls.Add(Me.pbxIdioma)
        Me.Controls.Add(Me.lblAcceso)
        Me.Controls.Add(Me.cbxIdiomas)
        Me.Controls.Add(Me.pbxNombreBanco)
        Me.Controls.Add(Me.pbxLogoBanco)
        Me.Controls.Add(Me.btnMenuOpciones)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "FrmAcceso"
        Me.Text = "Cajero"
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxIdioma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMenuOpciones As Button
    Friend WithEvents pbxLogoBanco As PictureBox
    Friend WithEvents pbxNombreBanco As PictureBox
    Friend WithEvents lblAcceso As Label
    Friend WithEvents cbxIdiomas As ComboBox
    Friend WithEvents pbxIdioma As PictureBox
End Class
