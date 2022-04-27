<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCajeroAcceso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCajeroAcceso))
        Me.btnMenuOpciones = New System.Windows.Forms.Button()
        Me.pbxLogoBanco = New System.Windows.Forms.PictureBox()
        Me.pbxNombreBanco = New System.Windows.Forms.PictureBox()
        Me.lblAcceso = New System.Windows.Forms.Label()
        Me.cbxIdiomas = New System.Windows.Forms.ComboBox()
        Me.pbxIdioma = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        CType(Me.pbxLogoBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxNombreBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxIdioma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMenuOpciones
        '
        Me.btnMenuOpciones.BackColor = System.Drawing.Color.White
        Me.btnMenuOpciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMenuOpciones.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMenuOpciones.FlatAppearance.BorderSize = 0
        Me.btnMenuOpciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnMenuOpciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnMenuOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuOpciones.Font = New System.Drawing.Font("Showcard Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMenuOpciones.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnMenuOpciones.Image = CType(resources.GetObject("btnMenuOpciones.Image"), System.Drawing.Image)
        Me.btnMenuOpciones.Location = New System.Drawing.Point(254, 169)
        Me.btnMenuOpciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnMenuOpciones.Name = "btnMenuOpciones"
        Me.btnMenuOpciones.Size = New System.Drawing.Size(296, 178)
        Me.btnMenuOpciones.TabIndex = 0
        Me.btnMenuOpciones.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMenuOpciones.UseVisualStyleBackColor = False
        '
        'pbxLogoBanco
        '
        Me.pbxLogoBanco.Image = CType(resources.GetObject("pbxLogoBanco.Image"), System.Drawing.Image)
        Me.pbxLogoBanco.Location = New System.Drawing.Point(10, 10)
        Me.pbxLogoBanco.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbxLogoBanco.Name = "pbxLogoBanco"
        Me.pbxLogoBanco.Size = New System.Drawing.Size(116, 123)
        Me.pbxLogoBanco.TabIndex = 1
        Me.pbxLogoBanco.TabStop = False
        '
        'pbxNombreBanco
        '
        Me.pbxNombreBanco.Image = CType(resources.GetObject("pbxNombreBanco.Image"), System.Drawing.Image)
        Me.pbxNombreBanco.Location = New System.Drawing.Point(140, 10)
        Me.pbxNombreBanco.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbxNombreBanco.Name = "pbxNombreBanco"
        Me.pbxNombreBanco.Size = New System.Drawing.Size(485, 123)
        Me.pbxNombreBanco.TabIndex = 2
        Me.pbxNombreBanco.TabStop = False
        '
        'lblAcceso
        '
        Me.lblAcceso.AutoSize = True
        Me.lblAcceso.Font = New System.Drawing.Font("Showcard Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAcceso.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblAcceso.Location = New System.Drawing.Point(303, 135)
        Me.lblAcceso.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAcceso.Name = "lblAcceso"
        Me.lblAcceso.Size = New System.Drawing.Size(214, 33)
        Me.lblAcceso.TabIndex = 3
        Me.lblAcceso.Text = "¡Bienvenido!"
        '
        'cbxIdiomas
        '
        Me.cbxIdiomas.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbxIdiomas.FormattingEnabled = True
        Me.cbxIdiomas.Items.AddRange(New Object() {"Español", "English"})
        Me.cbxIdiomas.Location = New System.Drawing.Point(563, 459)
        Me.cbxIdiomas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxIdiomas.Name = "cbxIdiomas"
        Me.cbxIdiomas.Size = New System.Drawing.Size(146, 32)
        Me.cbxIdiomas.TabIndex = 5
        Me.cbxIdiomas.Text = "Idiomas"
        '
        'pbxIdioma
        '
        Me.pbxIdioma.Image = CType(resources.GetObject("pbxIdioma.Image"), System.Drawing.Image)
        Me.pbxIdioma.Location = New System.Drawing.Point(714, 433)
        Me.pbxIdioma.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbxIdioma.Name = "pbxIdioma"
        Me.pbxIdioma.Size = New System.Drawing.Size(80, 73)
        Me.pbxIdioma.TabIndex = 6
        Me.pbxIdioma.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Showcard Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblWelcome.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblWelcome.Location = New System.Drawing.Point(330, 139)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(152, 33)
        Me.lblWelcome.TabIndex = 3
        Me.lblWelcome.Text = "WELCOME"
        Me.lblWelcome.Visible = False
        '
        'frmCajeroAcceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(803, 515)
        Me.Controls.Add(Me.pbxIdioma)
        Me.Controls.Add(Me.lblAcceso)
        Me.Controls.Add(Me.cbxIdiomas)
        Me.Controls.Add(Me.pbxNombreBanco)
        Me.Controls.Add(Me.pbxLogoBanco)
        Me.Controls.Add(Me.btnMenuOpciones)
        Me.Controls.Add(Me.lblWelcome)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmCajeroAcceso"
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
    Friend WithEvents lblWelcome As Label
End Class
