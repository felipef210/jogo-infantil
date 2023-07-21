using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;
using System.Drawing.Imaging;
using AxWMPLib;

namespace Jogo_3
{
    public partial class Frm_Jogo3 : Form
    {
        public Frm_Jogo3()
        {
            InitializeComponent();
        }

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        #region Variáveis Globais

        int acertos = 0, erros = 0;
        int combinacaoAbobora, combinacaoChapeu, combinacaoPote, combinacaoPocao;
        int contChapeu = 0, contAbobora = 0, contPote = 0, contPocao = 0;
        int tipo;
        int tempo = 10;
        Random random = new Random();

        #endregion
        #region Valores Start
        private void Frm_Jogo3_Load(object sender, EventArgs e)
        {
            acertos = 0;
            erros = 0;

            Btn_Sim.Enabled = false;
            Btn_Nao.Enabled = false;
            Btn_Reiniciar.Enabled = false;
            Media_Pergunta.Visible = false;
            player.URL = (Directory.GetCurrentDirectory() + "\\seekanddestroy.mp3");
            timer1.Enabled = false;
            Pbx_Pergunta.Visible = false;

            Bitmap bmp = new Bitmap(new Bitmap(Directory.GetCurrentDirectory() + "\\cursor.png"), 32, 32);
            this.Cursor = new Cursor(bmp.GetHicon());

        }
        #endregion
        #region Iniciar
        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
            Btn_Sim.Enabled = true;
            Btn_Nao.Enabled = true;
            Btn_Reiniciar.Enabled = true;
            Media_Pergunta.Visible = true;
            player.URL = null;
            Pbx_Pergunta.Visible = true;
            timer1.Start();
            Lbl_Tempo.Text = Convert.ToString(tempo);
            Randomiza();
        }
        #endregion
        #region Aleatorizar
        private void Randomiza()
        {
            tipo = random.Next(1, 13);

            combinacaoAbobora = random.Next(0, 5);


            if (combinacaoAbobora == 0)
            {
                Pbx_Abobora1.Image = null;
            }

            else if (combinacaoAbobora == 1)
            {
                Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1abobora.png");
            }

            else if (combinacaoAbobora == 2)
            {
                Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2aboboras.png");
            }

            else if (combinacaoAbobora == 3)
            {
                Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3aboboras.png");
            }

            else if (combinacaoAbobora == 4)
            {
                Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4aboboras.png");
            }


            if (tipo == 1)
            {
                Lbl_Pergunta.Text = "Tem mais abóboras do que chapéus ?";
                Media_Pergunta.URL = (Directory.GetCurrentDirectory() + "\\pergunta.mp3");
                combinacaoChapeu = random.Next(0, 5);

                if (combinacaoChapeu == 0)
                {
                    Pbx_Chapeu1.Image = null;
                }

                else if (combinacaoChapeu == 1)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1chapeu.png");
                }

                else if (combinacaoChapeu == 2)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2chapeus.png");
                }

                else if (combinacaoChapeu == 3)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3chapeus.png");
                }

                else if (combinacaoChapeu == 4)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4chapeus.png");
                }
            }


            if (tipo == 2)
            {
                Lbl_Pergunta.Text = "Tem mais abóboras do que potes ?";
                Media_Pergunta.URL = (Directory.GetCurrentDirectory() + "\\aboborapote.mp3");
                combinacaoPote = random.Next(0, 5);
                if (combinacaoPote == 0)
                {
                    Pbx_Chapeu1.Image = null;
                }

                else if (combinacaoPote == 1)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1pote.png");
                }

                else if (combinacaoPote == 2)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2potes.png");
                }

                else if (combinacaoPote == 3)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3potes.png");
                }

                else if (combinacaoPote == 4)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4potes.png");
                }
            }

            if (tipo == 3)
            {
                Lbl_Pergunta.Text = "Tem mais abóboras do que poções ?";
                Media_Pergunta.URL = (Directory.GetCurrentDirectory() + "\\aboborapocao.mp3");
                combinacaoPocao = random.Next(0, 5);
                if (combinacaoPocao == 0)
                {
                    Pbx_Chapeu1.Image = null;
                }

                else if (combinacaoPocao == 1)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1pocao.png");
                }

                else if (combinacaoPocao == 2)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2pocoes.png");
                }

                else if (combinacaoPocao == 3)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3pocoes.png");
                }

                else if (combinacaoPocao == 4)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4pocoes.png");
                }
            }

            if (tipo == 4)
            {
                Lbl_Pergunta.Text = "Tem mais chapéus do que abóboras ?";
                Media_Pergunta.URL = (Directory.GetCurrentDirectory() + "\\chapeuabobora.mp3");
                combinacaoChapeu = random.Next(0, 5);
                combinacaoAbobora = random.Next(0, 5);
                //Randomiza Chapeu
                if (combinacaoChapeu == 0)
                {
                    Pbx_Chapeu1.Image = null;
                }

                else if (combinacaoChapeu == 1)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1chapeu.png");
                }

                else if (combinacaoChapeu == 2)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2chapeus.png");
                }

                else if (combinacaoChapeu == 3)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3chapeus.png");
                }

                else if (combinacaoChapeu == 4)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4chapeus.png");
                }

                //Randomiza Abobora
                if (combinacaoAbobora == 0)
                {
                    Pbx_Abobora1.Image = null;
                }

                else if (combinacaoAbobora == 1)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1abobora.png");
                }

                else if (combinacaoAbobora == 2)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2aboboras.png");
                }

                else if (combinacaoAbobora == 3)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3aboboras.png");
                }

                else if (combinacaoAbobora == 4)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4aboboras.png");
                }
            }
            if (tipo == 5)
            {
                Lbl_Pergunta.Text = "Tem mais chapéus do que potes ?";
                Media_Pergunta.URL = (Directory.GetCurrentDirectory() + "\\chapeupote.mp3");
                combinacaoChapeu = random.Next(0, 5);
                combinacaoPote = random.Next(0, 5);
                //Randomiza Chapeu
                if (combinacaoChapeu == 0)
                {
                    Pbx_Chapeu1.Image = null;
                }

                else if (combinacaoChapeu == 1)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1chapeu.png");
                }

                else if (combinacaoChapeu == 2)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2chapeus.png");
                }

                else if (combinacaoChapeu == 3)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3chapeus.png");
                }

                else if (combinacaoChapeu == 4)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4chapeus.png");
                }
                //Potes
                if (combinacaoPote == 0)
                {
                    Pbx_Abobora1.Image = null;
                }

                else if (combinacaoPote == 1)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1pote.png");
                }

                else if (combinacaoPote == 2)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2potes.png");
                }

                else if (combinacaoPote == 3)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3potes.png");
                }

                else if (combinacaoPote == 4)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4potes.png");
                }
            }

            if (tipo == 6)
            {
                Lbl_Pergunta.Text = "Tem mais chapéus do que poções ?";
                Media_Pergunta.URL = (Directory.GetCurrentDirectory() + "\\chapeupocao.mp3");
                combinacaoChapeu = random.Next(0, 5);
                combinacaoPocao = random.Next(0, 5);

                //Randomiza Chapeu
                if (combinacaoChapeu == 0)
                {
                    Pbx_Chapeu1.Image = null;
                }

                else if (combinacaoChapeu == 1)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1chapeu.png");
                }

                else if (combinacaoChapeu == 2)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2chapeus.png");
                }

                else if (combinacaoChapeu == 3)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3chapeus.png");
                }

                else if (combinacaoChapeu == 4)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4chapeus.png");
                }

                //Poção
                if (combinacaoPocao == 0)
                {
                    Pbx_Abobora1.Image = null;
                }

                else if (combinacaoPocao == 1)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1pocao.png");
                }

                else if (combinacaoPocao == 2)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2pocoes.png");
                }

                else if (combinacaoPocao == 3)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3pocoes.png");
                }

                else if (combinacaoPocao == 4)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4pocoes.png");
                }

            }

            if (tipo == 7)
            {
                Lbl_Pergunta.Text = "Tem mais potes do que abóboras ?";
                Media_Pergunta.URL = (Directory.GetCurrentDirectory() + "\\poteabobora.mp3");
                combinacaoPote = random.Next(0, 5);
                combinacaoAbobora = random.Next(0, 5);

                //Randomiza potes
                if (combinacaoPote == 0)
                {
                    Pbx_Chapeu1.Image = null;
                }

                else if (combinacaoPote == 1)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1pote.png");
                }

                else if (combinacaoPote == 2)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2potes.png");
                }

                else if (combinacaoPote == 3)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3potes.png");
                }

                else if (combinacaoPote == 4)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4potes.png");
                }

                //abóboras

                if (combinacaoAbobora == 0)
                {
                    Pbx_Abobora1.Image = null;
                }

                else if (combinacaoAbobora == 1)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1abobora.png");
                }

                else if (combinacaoAbobora == 2)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2aboboras.png");
                }

                else if (combinacaoAbobora == 3)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3aboboras.png");
                }

                else if (combinacaoAbobora == 4)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4aboboras.png");
                }
            }

            if (tipo == 8)
            {
                Lbl_Pergunta.Text = "Tem mais potes do que chapéus ?";
                Media_Pergunta.URL = (Directory.GetCurrentDirectory() + "\\potechapeu.mp3");
                combinacaoPote = random.Next(0, 5);
                combinacaoChapeu = random.Next(0, 5);

                //Randomiza Potes
                if (combinacaoPote == 0)
                {
                    Pbx_Abobora1.Image = null;
                }

                else if (combinacaoPote == 1)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1pote.png");
                }

                else if (combinacaoPote == 2)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2potes.png");
                }

                else if (combinacaoPote == 3)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3potes.png");
                }

                else if (combinacaoPote == 4)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4potes.png");
                }

                //Chapéus

                if (combinacaoChapeu == 0)
                {
                    Pbx_Chapeu1.Image = null;
                }

                else if (combinacaoChapeu == 1)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1chapeu.png");
                }

                else if (combinacaoChapeu == 2)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2chapeus.png");
                }

                else if (combinacaoChapeu == 3)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3chapeus.png");
                }

                else if (combinacaoChapeu == 4)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4chapeus.png");
                }
            }

            if (tipo == 9)
            {
                Lbl_Pergunta.Text = "Tem mais potes do que poções ?";
                Media_Pergunta.URL = (Directory.GetCurrentDirectory() + "\\potepocao.mp3");
                combinacaoPote = random.Next(0, 5);
                combinacaoPocao = random.Next(0, 5);

                //Randomiza Potes
                if (combinacaoPote == 0)
                {
                    Pbx_Abobora1.Image = null;
                }

                else if (combinacaoPote == 1)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1pote.png");
                }

                else if (combinacaoPote == 2)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2potes.png");
                }

                else if (combinacaoPote == 3)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3potes.png");
                }

                else if (combinacaoPote == 4)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4potes.png");
                }

                //Poção

                if (combinacaoPocao == 0)
                {
                    Pbx_Chapeu1.Image = null;
                }

                else if (combinacaoPocao == 1)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1pocao.png");
                }

                else if (combinacaoPocao == 2)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2pocoes.png");
                }

                else if (combinacaoPocao == 3)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3pocoes.png");
                }

                else if (combinacaoPocao == 4)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4pocoes.png");
                }

            }
            if (tipo == 10)
            {
                Lbl_Pergunta.Text = "Tem mais poções do que abóboras ?";
                Media_Pergunta.URL = (Directory.GetCurrentDirectory() + "\\pocaoabobora.mp3");
                combinacaoPocao = random.Next(0, 5);
                combinacaoAbobora = random.Next(0, 5);

                //Randomiza Potes
                if (combinacaoPocao == 0)
                {
                    Pbx_Chapeu1.Image = null;
                }

                else if (combinacaoPocao == 1)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1pocao.png");
                }

                else if (combinacaoPocao == 2)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2pocoes.png");
                }

                else if (combinacaoPocao == 3)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3pocoes.png");
                }

                else if (combinacaoPocao == 4)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4pocoes.png");
                }

                //Abóbora

                if (combinacaoAbobora == 0)
                {
                    Pbx_Abobora1.Image = null;
                }

                else if (combinacaoAbobora == 1)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1abobora.png");
                }

                else if (combinacaoAbobora == 2)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2aboboras.png");
                }

                else if (combinacaoAbobora == 3)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3aboboras.png");
                }

                else if (combinacaoAbobora == 4)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4aboboras.png");
                }         
            }

            if(tipo == 11)
            {
                Lbl_Pergunta.Text = "Tem mais poções do que chapéus ?";
                Media_Pergunta.URL = (Directory.GetCurrentDirectory() + "\\pocaochapeu.mp3");
                combinacaoPocao = random.Next(0, 5);
                combinacaoChapeu = random.Next(0, 5);

                //Randomiza Potes
                if (combinacaoPocao == 0)
                {
                    Pbx_Abobora1.Image = null;
                }

                else if (combinacaoPocao == 1)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1pocao.png");
                }

                else if (combinacaoPocao == 2)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2pocoes.png");
                }

                else if (combinacaoPocao == 3)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3pocoes.png");
                }

                else if (combinacaoPocao == 4)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4pocoes.png");
                }

                //Chapéus

                if (combinacaoChapeu == 0)
                {
                    Pbx_Chapeu1.Image = null;
                }

                else if (combinacaoChapeu == 1)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1chapeu.png");
                }

                else if (combinacaoChapeu == 2)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2chapeus.png");
                }

                else if (combinacaoChapeu == 3)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3chapeus.png");
                }

                else if (combinacaoChapeu == 4)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4chapeus.png");
                }
            }

            if(tipo == 12)
            {
                Lbl_Pergunta.Text = "Tem mais poções do que potes ?";
                Media_Pergunta.URL = (Directory.GetCurrentDirectory() + "\\pocaopote.mp3");
                combinacaoPocao = random.Next(0, 5);
                combinacaoPote = random.Next(0, 5);

                //Randomiza Potes
                if (combinacaoPocao == 0)
                {
                    Pbx_Abobora1.Image = null;
                }

                else if (combinacaoPocao == 1)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1pocao.png");
                }

                else if (combinacaoPocao == 2)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2pocoes.png");
                }

                else if (combinacaoPocao == 3)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3pocoes.png");
                }

                else if (combinacaoPocao == 4)
                {
                    Pbx_Abobora1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4pocoes.png");
                }

                //Potes

                if (combinacaoPote == 0)
                {
                    Pbx_Chapeu1.Image = null;
                }

                else if (combinacaoPote == 1)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\1pote.png");
                }

                else if (combinacaoPote == 2)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\2potes.png");
                }

                else if (combinacaoPote == 3)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\3potes.png");
                }

                else if (combinacaoPote == 4)
                {
                    Pbx_Chapeu1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\4potes.png");
                }
            }
                       
            tempo = 10;
            Lbl_Tempo.Text = Convert.ToString(tempo);
            timer1.Start();
                
            
        }
        #endregion
        #region Tempo
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tempo > 0)
            {
                tempo--;
                Lbl_Tempo.Text = Convert.ToString(tempo);
            }
            else
            {
                timer1.Stop();
                erros++;
                Lbl_Erros.Text = Convert.ToString(erros);
                Randomiza();
            }
        }
        #endregion
        #region Fechar
        private void Frm_Jogo3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("       Obrigado por jogar nosso jogo.\nIndependente do resultado não desanime !", "Monstro !!!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information) == DialogResult.OK)

            if (MessageBox.Show("Deseja Fechar ?", "Fechando...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion
        #region Reiniciar
        private void Btn_Reiniciar_Click(object sender, EventArgs e)
        {
            acertos = 0;
            erros = 0;

            Lbl_Acertos.Text = acertos.ToString();
            Lbl_Erros.Text = erros.ToString();

            Randomiza();
        }
        #endregion
        #region Sim
        private void Btn_Sim_Click(object sender, EventArgs e)
        {
            contAbobora = combinacaoAbobora;
            contChapeu = combinacaoChapeu;
            contPocao = combinacaoPocao;
            contPote = combinacaoPote;
            tempo = 10;
            Lbl_Tempo.Text = Convert.ToString(tempo);

            if (tipo == 1)
            {
                if (contAbobora > contChapeu && Btn_Sim.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                }
                else if (contAbobora <= contChapeu && Btn_Sim.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Nao.Focus();
                }
            }

            if (tipo == 2)
            {
                if (contAbobora > contPote && Btn_Sim.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                }

                else if (contAbobora <= contPote && Btn_Sim.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Nao.Focus();
                }
            }

            if (tipo == 3)
            {
                if (contAbobora > contPocao && Btn_Sim.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                }

                else if (contAbobora <= contPocao && Btn_Sim.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Nao.Focus();
                }
            }

            if (tipo == 4)
            {
                if(contChapeu > contAbobora && Btn_Sim.Enabled == true)
                {
                   acertos++;
                   Lbl_Acertos.Text = Convert.ToString(acertos);
                }

                else if(contChapeu <= contAbobora && Btn_Sim.Enabled == true)
                {
                   erros++;
                   Lbl_Erros.Text = Convert.ToString(erros);
                   Btn_Nao.Focus();
                }
            }

            if (tipo == 5)
            {
                if (contChapeu > contPote && Btn_Sim.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                }

                else if (contChapeu <= contPote && Btn_Sim.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Nao.Focus();
                }
            }

            if (tipo == 6)
            {
                    if (contChapeu > contPocao && Btn_Sim.Enabled == true)
                    {
                        acertos++;
                        Lbl_Acertos.Text = Convert.ToString(acertos);
                    }

                    else if (contChapeu <= contPocao && Btn_Sim.Enabled == true)
                    {
                        erros++;
                        Lbl_Erros.Text = Convert.ToString(erros);
                        Btn_Nao.Focus();
                    }
            }

            if (tipo == 7)
            {
                if (contPote > contAbobora && Btn_Sim.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                }

                else if (contPote <= contAbobora && Btn_Sim.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Nao.Focus();
                }
            }

            if (tipo == 8)
            {
                if (contPote > contChapeu && Btn_Sim.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                }

                else if (contPote <= contChapeu && Btn_Sim.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Nao.Focus();
                }
            }

            if (tipo == 9)
            {
                if (contPote > contPocao && Btn_Sim.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                }

                else if (contPote <= contPocao && Btn_Sim.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Nao.Focus();
                }
            }

            if (tipo == 10)
            {
                if (contPocao > contAbobora && Btn_Sim.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                }

                else if (contPocao <= contAbobora && Btn_Sim.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Nao.Focus();
                }
            }

            if (tipo == 11)
            {
                if (contPocao > contChapeu && Btn_Sim.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                }

                else if (contPocao <= contChapeu && Btn_Sim.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Nao.Focus();
                }
            }

            if (tipo == 12)
            {
                if (contPocao > contPote && Btn_Sim.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                }

                else if (contPocao <= contPote && Btn_Sim.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Nao.Focus();
                }
            }
           
            Randomiza();
        }
        #endregion
        #region Nao
        private void Btn_Nao_Click(object sender, EventArgs e)
        {
            contAbobora = combinacaoAbobora;
            contChapeu = combinacaoChapeu;
            contPocao = combinacaoPocao;
            contPote = combinacaoPote;
            tempo = 10;
            Lbl_Tempo.Text = Convert.ToString(tempo);

            if(tipo == 1)
            {
                if (contAbobora > contChapeu && Btn_Nao.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Sim.Focus();
                }

                else if (contAbobora <= contChapeu && Btn_Nao.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                }
            }
            if(tipo == 2)
            {
                if (contAbobora > contPote && Btn_Nao.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Sim.Focus();
                }

                else if (contAbobora <= contPote && Btn_Nao.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                }
            }

            if(tipo == 3)
            {
                if (contAbobora > contPocao && Btn_Nao.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Sim.Focus();
                }

                else if (contAbobora <= contPocao && Btn_Nao.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                }
            }

            if (tipo == 4) 
         
            {
                if (contChapeu > contAbobora && Btn_Nao.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Sim.Focus();
                }

                else if (contChapeu <= contAbobora && Btn_Nao.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                }

            }
            if (tipo == 5)
           
            {
                if (contChapeu > contPote && Btn_Nao.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Sim.Focus();
                }

                else if (contChapeu <= contPote && Btn_Nao.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                }
            }

            if (tipo == 6)
            {
                if (contChapeu > contPocao && Btn_Nao.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Sim.Focus();
                }

                else if (contChapeu <= contPocao && Btn_Nao.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                    Btn_Sim.Focus();
                }
            }

            if (tipo == 7)
            {
                if (contPote > contAbobora && Btn_Nao.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Sim.Focus();
                }

                else if (contPote <= contAbobora && Btn_Nao.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                }
            }

            if (tipo == 8)
            {
                if (contPote > contChapeu && Btn_Nao.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Sim.Focus();
                }

                else if (contPote <= contChapeu && Btn_Nao.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                }
            }

            if (tipo == 9)
            {
                if (contPote > contPocao && Btn_Nao.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Sim.Focus();
                }

                else if (contPote <= contPocao && Btn_Nao.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                }
            }

            if (tipo == 10)
            {
                if (contPocao > contAbobora && Btn_Nao.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Sim.Focus();
                }

                else if (contPocao <= contAbobora && Btn_Nao.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                }
            }

            if (tipo == 11)
            {
                if (contPocao > contChapeu && Btn_Nao.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Sim.Focus();
                }

                else if (contPocao <= contChapeu && Btn_Nao.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                }
            }

            if (tipo == 12)
            {
                if (contPocao > contPote && Btn_Nao.Enabled == true)
                {
                    erros++;
                    Lbl_Erros.Text = Convert.ToString(erros);
                    Btn_Sim.Focus();
                }

                else if (contPocao <= contPote && Btn_Nao.Enabled == true)
                {
                    acertos++;
                    Lbl_Acertos.Text = Convert.ToString(acertos);
                }
            }

            Randomiza();
        }
        #endregion
        #region Autores
        private void Btn_Autores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                  Equipe Vick Count:\n\n       Felipe Miranda    " +
                "RA: 152799\n       Gabriel Oliveira   RA: 186806" +
                "\n       Hugo Galluzzi    RA: 193573\n\nColaboradores: Tarcísio Leite e Nickolas Correa", "Informações",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        #endregion
        #region Audios
        private void Pbx_Iniciar_Click(object sender, EventArgs e)
        {
            Media_Iniciar.URL = (Directory.GetCurrentDirectory() + "\\iniciar.mp3");
        }

        private void Pbx_Reiniciar_Click(object sender, EventArgs e)
        {
            Media_Reiniciar.URL = (Directory.GetCurrentDirectory() + "\\reiniciar.mp3");
        }

        private void Pbx_Autores_Click(object sender, EventArgs e)
        {
            Media_Autores.URL = (Directory.GetCurrentDirectory() + "\\autores.mp3");
        }

        private void Pbx_Sim_Click(object sender, EventArgs e)
        {
            Media_Sim.URL = (Directory.GetCurrentDirectory() + "\\sim.mp3");
        }

        private void Pbx_Nao_Click(object sender, EventArgs e)
        {
            Media_Nao.URL = (Directory.GetCurrentDirectory() + "\\nao.mp3");
        }

        private void Media_Pergunta_ClickEvent(object sender, _WMPOCXEvents_ClickEvent e)
        {
            Media_Pergunta.URL = (Directory.GetCurrentDirectory() + "\\pergunta.mp3");
        }
        #endregion
    }
}