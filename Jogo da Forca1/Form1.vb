Public Class Form1
    ' Declaração das variáveis
    Dim palavra As String
    Dim palavraOculta As String
    Dim tentativasRestantes As Integer = 6
    Dim imagensForca() As Image ' Array de imagens para cada etapa do boneco
    Dim letrasDigitadas As New List(Of Char)() ' Lista para armazenar as letras digitadas
    Dim pista As String ' Variável para armazenar a pista fornecida

    ' Variável para controle de fechamento do FormEscolherPalavra
    Public fechandoDoEscolherPalavra As Boolean = False

    ' Evento de carregamento do formulário
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cria e exibe o formulário de escolha da palavra
        Dim formEscolherPalavra As New FormEscolherPalavra(Me) ' Passando o Form1 como parâmetro
        formEscolherPalavra.Show()

        ' Carregar as imagens da forca na memória
        imagensForca = {
            My.Resources.estrutura,  ' Estrutura vazia
            My.Resources.forca0,  ' Cabeça
            My.Resources.forca1,  ' Cabeça e corpo
            My.Resources.forca2,  ' Uma perna
            My.Resources.forca3,  ' Duas pernas
            My.Resources.forca4,  ' Um braço
            My.Resources.forca5   ' Boneco completo
        }

        IniciarJogo()
    End Sub

    ' Método para iniciar ou reiniciar o jogo
    Private Sub IniciarJogo()
        Dim formEscolherPalavra As New FormEscolherPalavra(Me) ' Passando a referência do Form1

        ' Exibe o formulário para o usuário escolher a palavra e a pista
        If formEscolherPalavra.ShowDialog() = DialogResult.OK Then
            palavra = formEscolherPalavra.PalavraEscolhida
            pista = formEscolherPalavra.Pista
            palavraOculta = New String("_"c, palavra.Length)
            tentativasRestantes = 6
            letrasDigitadas.Clear() ' Limpa a lista de letras digitadas
            AtualizarTela()
            AtualizarImagemForca()
        Else
            ' Se o usuário cancelar, o jogo não inicia
            MessageBox.Show("Jogo cancelado.", "Fim de Jogo")
            Me.Close()
        End If
    End Sub

    ' Evento de clique do botão "Tentar"
    Private Sub btnTentar_Click(sender As Object, e As EventArgs) Handles btnTentar.Click
        Dim letra As String = txtLetra.Text.ToUpper()

        ' Valida a entrada
        If letra.Length = 1 AndAlso Char.IsLetter(letra) Then
            ' Verifica se a letra já foi digitada
            If letrasDigitadas.Contains(letra(0)) Then
                MessageBox.Show("Você já digitou essa letra. Tente outra.", "Aviso")
            Else
                Dim acertou As Boolean = False
                Dim novaPalavraOculta As Char() = palavraOculta.ToCharArray()

                ' Verifica se a letra existe na palavra e atualiza a palavra oculta
                For i As Integer = 0 To palavra.Length - 1
                    If palavra(i) = letra(0) Then
                        novaPalavraOculta(i) = letra(0)
                        acertou = True
                    End If
                Next

                palavraOculta = New String(novaPalavraOculta)

                ' Se a letra não está na palavra, reduz o número de tentativas
                If Not acertou Then
                    tentativasRestantes -= 1
                    AtualizarImagemForca()
                End If

                ' Adiciona a letra digitada à lista e atualiza a label
                letrasDigitadas.Add(letra(0))
                AtualizarTela()
                VerificarFimDeJogo()
            End If
        Else
            MessageBox.Show("Por favor, insira apenas uma letra.", "Aviso")
        End If

        ' Limpa o campo de texto e coloca o foco de volta na TextBox
        txtLetra.Clear()
        txtLetra.Focus()
    End Sub

    ' Atualiza os elementos da interface
    Private Sub AtualizarTela()
        lblPalavra.Text = String.Join(" ", palavraOculta.ToCharArray())
        lblTentativas.Text = "Tentativas restantes: " & tentativasRestantes
        lblLetrasDigitadas.Text = "Letras digitadas: " & String.Join(", ", letrasDigitadas)
        lblNumeroLetras.Text = "Número de letras: " & palavra.Length ' Atualiza a label com o número de letras da palavra
        lblPista.Text = "Pista: " & pista ' Mostra a pista na interface
    End Sub

    ' Atualiza a imagem do boneco da forca de acordo com o número de tentativas
    Private Sub AtualizarImagemForca()
        picBoneco.Image = imagensForca(6 - tentativasRestantes)
    End Sub

    ' Verifica se o jogo acabou (vitória ou derrota)
    Private Sub VerificarFimDeJogo()
        If palavraOculta = palavra Then
            Dim resultado = MessageBox.Show("Parabéns, você ganhou! Deseja iniciar um novo jogo?", "Fim de Jogo", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then
                IniciarJogo()
            Else
                Me.Close()
            End If
        ElseIf tentativasRestantes = 0 Then
            Dim resultado = MessageBox.Show("Você perdeu! A palavra era: " & palavra & ". Deseja iniciar um novo jogo?", "Fim de Jogo", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then
                IniciarJogo()
            Else
                Me.Close()
            End If
        End If
    End Sub

    ' Evento de clique do botão "Reiniciar Jogo"
    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        ' Exibe uma mensagem de confirmação antes de reiniciar o jogo
        Dim resultado As DialogResult = MessageBox.Show("Você tem certeza que deseja iniciar um novo jogo?", "Confirmar Novo Jogo", MessageBoxButtons.YesNo)

        If resultado = DialogResult.Yes Then
            ' Limpa a TextBox e coloca o foco nela
            txtLetra.Clear()
            txtLetra.Focus()

            ' Inicia um novo jogo
            IniciarJogo()
        End If
    End Sub

    ' Método para setar a variável fechandoDoEscolherPalavra
    Public Sub SetFechandoDoEscolherPalavra(valor As Boolean)
        fechandoDoEscolherPalavra = valor
    End Sub
End Class
