using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonDice
{
    public partial class SmnDiceClasicoN2 : Form
    {
        int ControlSecuencia = 0;
        Random NumeroAleatorio;
        List<int> SimonDice = new List<int>();
        bool Hablando = false;
        public SmnDiceClasicoN2()
        {
            InitializeComponent();
            NumeroAleatorio = new Random();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            SimonDice.Add(NumeroAleatorio.Next(0, 5));
            timer1.Enabled = true;//inicia el temporizador 
            new Thread(IniciarJuego).Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;//detiene el temporizador
            MessageBox.Show("¡Te haz excedido de tiempo! :( PERDISTE :(");
            ControlSecuencia = 0;
            puntos = 0;
            SimonDice = new List<int>();
        }
        public void IniciarJuego()
        {
            Thread.Sleep(500);
            Hablando = true;
            foreach (int ParteActiva in SimonDice)
            {
                switch (ParteActiva)
                {
                    case 0:
                        P_0.Image = Properties.Resources.CAzul_2;
                        Thread.Sleep(500);
                        P_0.Image = Properties.Resources.CAzul_1;
                        break;
                    case 1:
                        P_1.Image = Properties.Resources.CVerde_01;
                        Thread.Sleep(500);
                        P_1.Image = Properties.Resources.CVerde_2;
                        break;
                    case 2:
                        P_2.Image = Properties.Resources.CRojo_2;
                        Thread.Sleep(500);
                        P_2.Image = Properties.Resources.CRojo_1;
                        break;
                    case 3:
                        P_3.Image = Properties.Resources.CAmarillo_2;
                        Thread.Sleep(500);
                        P_3.Image = Properties.Resources.CAmarillo_1;
                        break;
                    case 4:
                        P_4.Image = Properties.Resources.CNegro_2;
                        Thread.Sleep(500);
                        P_4.Image = Properties.Resources.CNegro_1;
                        break;
                }
                Thread.Sleep(500);
            }
            Hablando = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
        int puntos = 0;
        public void VerificarBotonPresionado(int ValorBoton)
        {
            if (Hablando || SimonDice.Count == 0) return;
            if (SimonDice[ControlSecuencia] == ValorBoton)
            {
                ControlSecuencia++;
                puntos++;
            }

            else
            {
                MessageBox.Show("Tu puntaje : " + (puntos * 2));
                ControlSecuencia = 0;
                puntos = 0;
                SimonDice = new List<int>();
            }
            if (ControlSecuencia >= SimonDice.Count)
            {
                ControlSecuencia = 0;
                SimonDice.Add(NumeroAleatorio.Next(0, 5));
                new Thread(IniciarJuego).Start();
            }
            lblPumtos.Text = (puntos * 2).ToString();
        }

        private void P_0_Click(object sender, EventArgs e)
        {
            string Presionado = ((PictureBox)sender).Name;
            string[] NumeroBoton = Presionado.Split('_');
            VerificarBotonPresionado(Convert.ToInt32(NumeroBoton[1]));
            timer1.Enabled = false;//Al presionar un color se reinicia el timer
            timer1.Enabled = true;//y lo vuelve a activar

        }

        private void P_0_MouseDown(object sender, MouseEventArgs e)
        {
            P_0.Image = Properties.Resources.CAzul_2;
            ReproducirMusica();
        }

        private void P_0_MouseUp(object sender, MouseEventArgs e)
        {
            P_0.Image = Properties.Resources.CAzul_1;
        }
        private void P_3_MouseDown(object sender, MouseEventArgs e)
        {
            P_3.Image = Properties.Resources.CAmarillo_2;
            ReproducirMusica();
        }
        private void P_3_MouseUp(object sender, MouseEventArgs e)
        {
            P_3.Image = Properties.Resources.CAmarillo_1;
        }

        private void P_1_MouseDown(object sender, MouseEventArgs e)
        {
            P_1.Image = Properties.Resources.CVerde_01;
            ReproducirMusica();
        }

        private void P_1_MouseUp(object sender, MouseEventArgs e)
        {
            P_1.Image = Properties.Resources.CVerde_2;
        }

        private void P_2_MouseDown(object sender, MouseEventArgs e)
        {
            P_2.Image = Properties.Resources.CRojo_2;
            ReproducirMusica();
        }

        private void P_2_MouseUp(object sender, MouseEventArgs e)
        {
            P_2.Image = Properties.Resources.CRojo_1;
        }
        private void P_4_MouseDown(object sender, MouseEventArgs e)
        {
            P_4.Image = Properties.Resources.CNegro_2;
            ReproducirMusica();
        }

        private void P_4_MouseUp(object sender, MouseEventArgs e)
        {
            P_4.Image = Properties.Resources.CNegro_1;
        }

        public void ReproducirMusica()
        {

            /*SoundPlayer sndplayr = new SoundPlayer(Properties.Resources.ponglong);
            sndplayr.Play();*/
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            SelecNvlClasico sn = new SelecNvlClasico();
            sn.Show();
            this.Close();
        }
    }
}
