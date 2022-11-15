using System;
using System.Linq;
using System.Windows.Forms;

//Júlia Enriquetto de Brito - 22139
namespace apProjeto2_22139
{
    public partial class FrmPrincipal : Form
    {
        //Variáveis globais 
        Vetor vetor = new Vetor(); //objeto da classe Vetor
        string frase;
        string letrasFrase;
        string letrasCorretas;
        string dica;
        int pontuacao = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnValidarLetra_Click(object sender, EventArgs e) 
        {
            if (txtLetra.Text.Length == 1)
            {
                char letraDigitada = txtLetra.Text[0];

                if (frase.Contains(letraDigitada))
                {
                    if (!letrasCorretas.Contains(letraDigitada))
                    {
                        letrasCorretas += letraDigitada;

                        txtPalavra.Clear();

                        // for que releva as letras
                        // já acertadas (letras corretas)
                        // da frase
                        foreach (char letra in frase)
                        {
                            // se o jogador já acertou a letra,
                            // a letra é revelada
                            if (letrasCorretas.Contains(letra))
                                txtPalavra.Text += letra;

                            else if (letra == ' ')
                                txtPalavra.Text += "  ";

                            else
                                txtPalavra.Text += "_ ";
                        }
                        
                        // as letras corretas contêm todas as
                        // letras da frase, ou seja, o jogador
                        // digitou todas as letras certas
                        if (letrasCorretas.Contains(letrasFrase))
                        {
                            MessageBox.Show("Parabéns, você ganhou!");
                        }

                        pontuacao += 2; //cada acerto vale 2 pontos 
                    }
                    else
                        MessageBox.Show("Letra já digitada!");
                }
                else
                {
                    pontuacao--; //cada erro vale -1 ponto
                }

                lbPontucao.Text = $"Pontuação: {pontuacao}";
            }
            else
            {
                MessageBox.Show("Digite uma letra!");
            }
           
            txtLetra.Clear();
            txtLetra.Focus();
        }

        private void btnExibirDica_Click(object sender, EventArgs e)
        {
            if (dica != null && dica != "")
                MessageBox.Show(dica); //mostra dica no messageBox
        }

        private void btnGirarRoleta_Click(object sender, EventArgs e)
        {
            Random numAleatorio = new Random(); //Classe Random()

            int valorInteiro = numAleatorio.Next(0, 29); //Next retorna um valor inteiro entre 0 e 29

            txtNumSorteado.Text = valorInteiro.ToString();

            txtLetra.Clear();
            txtLetra.Focus();
            txtPalavra.Clear();

            frase = vetor.getVetorFrase()[valorInteiro]; //vetor frase e dica indexado de um mesmo valor int aleatório                                //valor aleatório sorteado
            dica = vetor.getVetorDica()[valorInteiro];

            letrasFrase = "";
            letrasCorretas = "";

            foreach (char letra in frase) //para cada letra no vetor frase
            {
                if (letra == ' ') 
                    txtPalavra.Text += "  "; //troca pra espaço se for ' '

                else
                {
                    txtPalavra.Text += "_ "; //se não troca para _ 

                    // frase sem repetições e sem espaço
                    if (!letrasFrase.Contains(letra))
                        letrasFrase += letra;
                }
            }
        }
    }
}
