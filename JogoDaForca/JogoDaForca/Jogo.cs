using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class Jogo : Form
    {
        public Jogo()
        {
            InitializeComponent();
            Começo();

            JogarNovidade.Hide();
            Sair.Hide();

            #region "palavraSorteada"
          //  Dica -> palavraSorteada
            if (JogoClass.palavraSorteada == "BANANA" || JogoClass.palavraSorteada == "CAJÚ"){
                Dica.Text = "Fruta"; }
            else if (JogoClass.palavraSorteada == "SELVA"){
                Dica.Text = "Reino Animal"; }
            else if (JogoClass.palavraSorteada == "ARARAQUARA"){
                Dica.Text = "Cidade"; }
            else if (JogoClass.palavraSorteada == "VOLKSWAGEN" || JogoClass.palavraSorteada == "HYUNDAI"){
                Dica.Text = "Marca De Carros"; }
            else if (JogoClass.palavraSorteada == "DONINHA" || JogoClass.palavraSorteada == "PAPAGAIO"){
                Dica.Text = "Animais"; }
            else if (JogoClass.palavraSorteada == "BRASIL"){
                Dica.Text = "País"; }
            else if (JogoClass.palavraSorteada == "SKATE"){
                Dica.Text = "Objeto"; }
            else if (JogoClass.palavraSorteada == "PETRÓLEO"){
                Dica.Text = "Matéria Orgânica";
            }
            else if (JogoClass.palavraSorteada == "PIPOCA"){
                Dica.Text = "Comida";
            }
            #endregion
        }

        public static void Começo()
        {
            Random rand = new Random();
            JogoClass.palavraSorteada = JogoClass.bancoDePalavras[rand.Next(0, JogoClass.bancoDePalavras.Length)];
            string impressao = "";
            JogoClass.palavraManipulada = new char[JogoClass.bancoDePalavras.Length];
            for (int i = 0; i < JogoClass.palavraSorteada.Length; i++)
            {
                impressao += "_ ";
                JogoClass.palavraManipulada[i] = '_';
            }
            Jogo jogo = new Jogo();
            jogo.Tela.Text = impressao;
            if (JogoClass.debugOn)
                jogo.label1.Text = JogoClass.palavraSorteada;
            //Butons escondidos
            jogo.JogarNovidade.Hide();
            jogo.Sair.Hide();
        }

        private void processarLetra(char letra)
        {
            if (!JogoClass.fimDeJogo)
            {
                bool letraValida = false;
                for (int i = 0; i < JogoClass.palavraSorteada.Length; i++)
                {
                    if (JogoClass.palavraSorteada[i] == letra)
                    {
                        letraValida = true;
                        JogoClass.qtdLetrasEncontradas++;
                        JogoClass.palavraManipulada[i] = letra;
                    }
                }
                string impressao = "";
                foreach (char c in JogoClass.palavraManipulada)
                {
                    impressao += (c + " ");
                }
                Tela.Text = impressao;
                if (!letraValida)
                {
                    JogoClass.tentativasRestantes--;
                    if (JogoClass.tentativasRestantes == 5)
                        pictureBox1.Image = JogoDaForca.Properties.Resources.imagem02;
                    else if (JogoClass.tentativasRestantes == 4)
                        pictureBox1.Image = JogoDaForca.Properties.Resources.imagem03;
                    else if (JogoClass.tentativasRestantes == 3)
                        pictureBox1.Image = JogoDaForca.Properties.Resources.imagem04;
                    else if (JogoClass.tentativasRestantes == 2)
                        pictureBox1.Image = JogoDaForca.Properties.Resources.imagem05;
                    else if (JogoClass.tentativasRestantes == 1)
                        pictureBox1.Image = JogoDaForca.Properties.Resources.imagem06;
                    else if (JogoClass.tentativasRestantes == 0)
                    {
                        pictureBox1.Image = JogoDaForca.Properties.Resources.imagem07;
                        JogoClass.fimDeJogo = true;
                        MessageBox.Show("Fim de Jogo. Você perdeu!!");
                        JogarNovidade.Show();
                        Sair.Show();
                    }
                }
                else if (JogoClass.qtdLetrasEncontradas == JogoClass.palavraSorteada.Length)
                {
                    JogoClass.fimDeJogo = true;
                    MessageBox.Show("Fim de Jogo. Você ganhou, PARABÉNS!!");
                    JogarNovidade.Show();
                    Sair.Show();
                }
            }
        }

        #region"sair e Jogar"
        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void JogarNovidade_Click(object sender, EventArgs e)
        {
            JogoClass.tentativasRestantes = 6;
            JogoClass.fimDeJogo = false;
            //FUNCIONA MAIS DA ERRO
            Jogo();
        }
        #endregion

        //      ERRO
        //private void Click(object sender, EventArgs e)
        //{
        //    char letra;
        //    letra = Convert.ToChar((Button)sender);
        //    processarLetra(letra);
        //    ((Button)sender).Enabled = false;
        //}

        #region "Buttons Click"
        private void A_Click(object sender, EventArgs e)
        {
            processarLetra('A');
            ((Button)sender).Enabled = false;
        }

        private void B_Click(object sender, EventArgs e)
        {
            processarLetra('B');
            ((Button)sender).Enabled = false;
        }

        private void C_Click(object sender, EventArgs e)
        {
            processarLetra('C');
            ((Button)sender).Enabled = false;
        }

        private void D_Click(object sender, EventArgs e)
        {
            processarLetra('D');
            ((Button)sender).Enabled = false;
        }

        private void E_Click(object sender, EventArgs e)
        {
            processarLetra('E');
            ((Button)sender).Enabled = false;
        }

        private void F_Click(object sender, EventArgs e)
        {
            processarLetra('F');
            ((Button)sender).Enabled = false;
        }

        private void G_Click(object sender, EventArgs e)
        {
            processarLetra('G');
            ((Button)sender).Enabled = false;
        }

        private void H_Click(object sender, EventArgs e)
        {
            processarLetra('H');
            ((Button)sender).Enabled = false;
        }

        private void I_Click(object sender, EventArgs e)
        {
            processarLetra('I');
            ((Button)sender).Enabled = false;
        }

        private void J_Click(object sender, EventArgs e)
        {
            processarLetra('J');
            ((Button)sender).Enabled = false;
        }

        private void K_Click(object sender, EventArgs e)
        {
            processarLetra('K');
            ((Button)sender).Enabled = false;
        }

        private void L_Click(object sender, EventArgs e)
        { 
            processarLetra('L');
            ((Button)sender).Enabled = false;
        }

        private void M_Click(object sender, EventArgs e)
        {
            processarLetra('M');
            ((Button)sender).Enabled = false;
        }

        private void N_Click(object sender, EventArgs e)
        {
            processarLetra('N');
            ((Button)sender).Enabled = false;
        }

        private void O_Click(object sender, EventArgs e)
        {
            processarLetra('O');
            ((Button)sender).Enabled = false;
        }

        private void P_Click(object sender, EventArgs e)
        {
            processarLetra('P');
            ((Button)sender).Enabled = false;
        }

        private void Q_Click(object sender, EventArgs e)
        {
            processarLetra('Q');
            ((Button)sender).Enabled = false;
        }

        private void R_Click(object sender, EventArgs e)
        {
            processarLetra('R');
            ((Button)sender).Enabled = false;
        }

        private void S_Click(object sender, EventArgs e)
        {
            processarLetra('S');
            ((Button)sender).Enabled = false;
        }

        private void T_Click(object sender, EventArgs e)
        {
            processarLetra('T');
            ((Button)sender).Enabled = false;
        }

        private void U_Click(object sender, EventArgs e)
        {
            processarLetra('U');
            ((Button)sender).Enabled = false;
        }

        private void V_Click(object sender, EventArgs e)
        {
            processarLetra('V');
            ((Button)sender).Enabled = false;
        }

        private void W_Click(object sender, EventArgs e)
        {
            processarLetra('W');
            ((Button)sender).Enabled = false;
        }

        private void X_Click(object sender, EventArgs e)
        {
            processarLetra('X');
            ((Button)sender).Enabled = false;
        }

        private void Y_Click(object sender, EventArgs e)
        {
            processarLetra('Y');
            ((Button)sender).Enabled = false;
        }

        private void Z_Click(object sender, EventArgs e)
        {
            processarLetra('Z');
            ((Button)sender).Enabled = false;
        }
#endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
