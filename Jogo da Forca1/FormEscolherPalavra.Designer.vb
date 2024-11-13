<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEscolherPalavra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEscolherPalavra))
        Me.txtPalavra = New System.Windows.Forms.TextBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.txtPista = New System.Windows.Forms.TextBox()
        Me.lblPista = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPalavra
        '
        Me.txtPalavra.Location = New System.Drawing.Point(127, 44)
        Me.txtPalavra.Name = "txtPalavra"
        Me.txtPalavra.Size = New System.Drawing.Size(129, 20)
        Me.txtPalavra.TabIndex = 0
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(149, 100)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(107, 23)
        Me.btnConfirmar.TabIndex = 1
        Me.btnConfirmar.Text = "Confirmar Palavra"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'txtPista
        '
        Me.txtPista.Location = New System.Drawing.Point(142, 70)
        Me.txtPista.Name = "txtPista"
        Me.txtPista.Size = New System.Drawing.Size(114, 20)
        Me.txtPista.TabIndex = 2
        '
        'lblPista
        '
        Me.lblPista.AutoSize = True
        Me.lblPista.Location = New System.Drawing.Point(64, 77)
        Me.lblPista.Name = "lblPista"
        Me.lblPista.Size = New System.Drawing.Size(72, 13)
        Me.lblPista.TabIndex = 3
        Me.lblPista.Text = "Digite a Pista:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Escolha uma palavra:"
        '
        'FormEscolherPalavra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 194)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPista)
        Me.Controls.Add(Me.txtPista)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.txtPalavra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormEscolherPalavra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Escolher Palavra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPalavra As TextBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents txtPista As TextBox
    Friend WithEvents lblPista As Label
    Friend WithEvents Label1 As Label
End Class
