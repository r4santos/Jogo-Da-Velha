using System;
using System.Windows.Forms;

namespace Jogo_Da_Velha
{
    public partial class Form1 : Form
    {
        private string[,] velha = new string[3, 3];
        private int cont = 0;
        public Form1()
        {
            InitializeComponent();

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    velha[linha, coluna] = "";
                }
            }

            lbl_jogador.Text = "X";

            lbl_jogo.Text = "";

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    if (velha[linha, coluna] == "")
                    {
                        lbl_jogo.Text += " | " + " ";
                    }
                    else
                    {
                        lbl_jogo.Text += " | " + velha[linha, coluna];
                    }
                }
                lbl_jogo.Text += " |\n";
            }
        }

        private void btn_jogar_Click(object sender, EventArgs e)
        {
            if (txt_linha.Text == null || txt_linha.Text == "" || txt_coluna.Text == null || txt_coluna.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos de linha e coluna.");
                return;
            }

            int linhas = int.Parse(txt_linha.Text) - 1;
            int colunas = int.Parse(txt_coluna.Text) - 1;

            lbl_resultado.Text = "";

            if (velha[linhas, colunas] == "")
            {
                velha[linhas, colunas] = lbl_jogador.Text;

                if (lbl_jogador.Text == "X")
                {
                    lbl_jogador.Text = "O";
                }
                else
                {
                    lbl_jogador.Text = "X";
                }

                cont++;

                lbl_jogo.Text = "";
                for (int linha = 0; linha < 3; linha++)
                {
                    for (int coluna = 0; coluna < 3; coluna++)
                    {
                        lbl_jogo.Text += " | " + (velha[linha, coluna] == "" ? " " : velha[linha, coluna]);
                    }
                    lbl_jogo.Text += " |\n";
                }

                for (int i = 0; i < 3; i++)
                {
                    if ((velha[i, 0] == "X" && velha[i, 1] == "X" && velha[i, 2] == "X") || (velha[0, i] == "X" && velha[1, i] == "X" && velha[2, i] == "X"))
                    {
                        lbl_resultado.Text = "'X' venceu!";
                        txt_coluna.Enabled = false;
                        txt_linha.Enabled = false;
                        btn_jogar.Enabled = false;
                        break;
                    }
                    else if ((velha[i, 0] == "O" && velha[i, 1] == "O" && velha[i, 2] == "O") || (velha[0, i] == "O" && velha[1, i] == "O" && velha[2, i] == "O"))
                    {
                        lbl_resultado.Text = "'O' venceu!";
                        txt_coluna.Enabled = false;
                        txt_linha.Enabled = false;
                        btn_jogar.Enabled = false;
                        break;
                    }
                }

                if (lbl_resultado.Text == "")
                {
                    if ((velha[0, 0] == "X" && velha[1, 1] == "X" && velha[2, 2] == "X") || (velha[0, 2] == "X" && velha[1, 1] == "X" && velha[2, 0] == "X"))
                    {
                        lbl_resultado.Text = "'X' venceu!";
                        txt_coluna.Enabled = false;
                        txt_linha.Enabled = false;
                        btn_jogar.Enabled = false;
                    }
                    else if ((velha[0, 0] == "O" && velha[1, 1] == "O" && velha[2, 2] == "O") || (velha[0, 2] == "O" && velha[1, 1] == "O" && velha[2, 0] == "O"))
                    {
                        lbl_resultado.Text = "'O' venceu!";
                        txt_coluna.Enabled = false;
                        txt_linha.Enabled = false;
                        btn_jogar.Enabled = false;
                    }
                }

                if (lbl_resultado.Text == "" && cont == 9)
                {
                    lbl_resultado.Text = "Deu véia!!!";
                    txt_coluna.Enabled = false;
                    txt_linha.Enabled = false;
                    btn_jogar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("O espaço já está ocupado");
            }
        }

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            cont = 0;

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    velha[linha, coluna] = "";
                }
            }

            lbl_jogador.Text = "X";
            lbl_resultado.Text = "";

            lbl_jogo.Text = "";
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    lbl_jogo.Text += " | " + (velha[linha, coluna] == "" ? " " : velha[linha, coluna]);
                }
                lbl_jogo.Text += " |\n";
            }

            txt_coluna.Enabled = Enabled;
            txt_linha.Enabled = Enabled;
            btn_jogar.Enabled = Enabled;
        }
    }
}
