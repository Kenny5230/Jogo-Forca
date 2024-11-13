Public Class FormEscolherPalavra
    Public PalavraEscolhida As String
    Public Pista As String
    Private form1 As Form1 ' Armazena a referência do Form1

    ' Construtor único para receber a referência de Form1
    Public Sub New(f1 As Form1)
        InitializeComponent()
        form1 = f1 ' Armazena a referência do Form1
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        ' Verifica se a palavra e a pista estão preenchidas
        If txtPalavra.Text = "" AndAlso txtPista.Text = "" Then
            MessageBox.Show("Por favor, preencha tanto a palavra secreta quanto a pista.", "Aviso")
            txtPalavra.Focus() ' Coloca o foco na caixa de texto da palavra secreta
        ElseIf txtPalavra.Text = "" Then
            MessageBox.Show("Por favor, insira a palavra secreta.", "Aviso")
            txtPalavra.Focus() ' Coloca o foco na caixa de texto da palavra secreta
        ElseIf txtPista.Text = "" Then
            MessageBox.Show("Por favor, insira a pista.", "Aviso")
            txtPista.Focus() ' Coloca o foco na caixa de texto da pista
        Else
            ' Se ambos os campos estiverem preenchidos, continua o jogo
            PalavraEscolhida = txtPalavra.Text.ToUpper()
            Pista = txtPista.Text
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub txtPalavra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPalavra.KeyPress
        ' Verifica se a tecla pressionada não é uma letra ou é um caractere de controle (como Backspace)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Impede a digitação da tecla
            e.Handled = True
        End If
    End Sub
    Private Sub FormEscolherPalavra_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Reseta a variável de controle quando o FormEscolherPalavra for fechado
        If form1 IsNot Nothing Then
            form1.fechandoDoEscolherPalavra = False
        End If
    End Sub
End Class
