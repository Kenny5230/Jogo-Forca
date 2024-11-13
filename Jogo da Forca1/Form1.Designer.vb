<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblPalavra = New System.Windows.Forms.Label()
        Me.txtLetra = New System.Windows.Forms.TextBox()
        Me.btnTentar = New System.Windows.Forms.Button()
        Me.lblTentativas = New System.Windows.Forms.Label()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.picBoneco = New System.Windows.Forms.PictureBox()
        Me.lblLetrasDigitadas = New System.Windows.Forms.Label()
        Me.lblNumeroLetras = New System.Windows.Forms.Label()
        Me.lblPista = New System.Windows.Forms.Label()
        CType(Me.picBoneco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPalavra
        '
        Me.lblPalavra.AutoSize = True
        Me.lblPalavra.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPalavra.Location = New System.Drawing.Point(124, 151)
        Me.lblPalavra.Name = "lblPalavra"
        Me.lblPalavra.Size = New System.Drawing.Size(183, 31)
        Me.lblPalavra.TabIndex = 0
        Me.lblPalavra.Text = "_ _ _ _ _ _ _ _"
        '
        'txtLetra
        '
        Me.txtLetra.Location = New System.Drawing.Point(308, 185)
        Me.txtLetra.Name = "txtLetra"
        Me.txtLetra.Size = New System.Drawing.Size(42, 20)
        Me.txtLetra.TabIndex = 1
        '
        'btnTentar
        '
        Me.btnTentar.Location = New System.Drawing.Point(361, 184)
        Me.btnTentar.Name = "btnTentar"
        Me.btnTentar.Size = New System.Drawing.Size(75, 23)
        Me.btnTentar.TabIndex = 2
        Me.btnTentar.Text = "Tentar"
        Me.btnTentar.UseVisualStyleBackColor = True
        '
        'lblTentativas
        '
        Me.lblTentativas.AutoSize = True
        Me.lblTentativas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTentativas.Location = New System.Drawing.Point(124, 267)
        Me.lblTentativas.Name = "lblTentativas"
        Me.lblTentativas.Size = New System.Drawing.Size(170, 20)
        Me.lblTentativas.TabIndex = 3
        Me.lblTentativas.Text = "Tentativas restantes: 6"
        '
        'btnReiniciar
        '
        Me.btnReiniciar.Location = New System.Drawing.Point(361, 216)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(92, 23)
        Me.btnReiniciar.TabIndex = 4
        Me.btnReiniciar.Text = "Reiniciar Jogo"
        Me.btnReiniciar.UseVisualStyleBackColor = True
        '
        'picBoneco
        '
        Me.picBoneco.Location = New System.Drawing.Point(14, 48)
        Me.picBoneco.Name = "picBoneco"
        Me.picBoneco.Size = New System.Drawing.Size(105, 196)
        Me.picBoneco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoneco.TabIndex = 5
        Me.picBoneco.TabStop = False
        '
        'lblLetrasDigitadas
        '
        Me.lblLetrasDigitadas.AutoSize = True
        Me.lblLetrasDigitadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetrasDigitadas.Location = New System.Drawing.Point(5, 286)
        Me.lblLetrasDigitadas.Name = "lblLetrasDigitadas"
        Me.lblLetrasDigitadas.Size = New System.Drawing.Size(126, 20)
        Me.lblLetrasDigitadas.TabIndex = 6
        Me.lblLetrasDigitadas.Text = "Letras digitadas:"
        '
        'lblNumeroLetras
        '
        Me.lblNumeroLetras.AutoSize = True
        Me.lblNumeroLetras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroLetras.Location = New System.Drawing.Point(124, 211)
        Me.lblNumeroLetras.Name = "lblNumeroLetras"
        Me.lblNumeroLetras.Size = New System.Drawing.Size(134, 20)
        Me.lblNumeroLetras.TabIndex = 7
        Me.lblNumeroLetras.Text = "Número de letras:"
        '
        'lblPista
        '
        Me.lblPista.AutoSize = True
        Me.lblPista.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPista.Location = New System.Drawing.Point(124, 240)
        Me.lblPista.Name = "lblPista"
        Me.lblPista.Size = New System.Drawing.Size(48, 20)
        Me.lblPista.TabIndex = 8
        Me.lblPista.Text = "Pista:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 311)
        Me.Controls.Add(Me.lblPista)
        Me.Controls.Add(Me.lblNumeroLetras)
        Me.Controls.Add(Me.lblLetrasDigitadas)
        Me.Controls.Add(Me.picBoneco)
        Me.Controls.Add(Me.btnReiniciar)
        Me.Controls.Add(Me.lblTentativas)
        Me.Controls.Add(Me.btnTentar)
        Me.Controls.Add(Me.txtLetra)
        Me.Controls.Add(Me.lblPalavra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jogo da Forca"
        CType(Me.picBoneco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPalavra As Label
    Friend WithEvents txtLetra As TextBox
    Friend WithEvents btnTentar As Button
    Friend WithEvents lblTentativas As Label
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents picBoneco As PictureBox
    Friend WithEvents lblLetrasDigitadas As Label
    Friend WithEvents lblNumeroLetras As Label
    Friend WithEvents lblPista As Label
End Class
