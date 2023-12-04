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
    public partial class SmnReversoN1 : Form
    {
        int ControlSecuencia = 0;
        Random NumeroAleatorio;
        List<int> SimonDice = new List<int>();
        //se crea una nueva lista para comparala con lo que simon dice para que  al momento de que el
        //jugador la repliqe de manera inversa se verifique si es correcto
        List<int> SecuenciaReversa = new List<int>();//Se crea una nueva lista para almacenar la secuancia original 
        bool Hablando = false;
        public SmnReversoN1()
        {
            InitializeComponent();
            NumeroAleatorio = new Random();
        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            
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
                        Thread.Sleep(700);
                        P_0.Image = Properties.Resources.CAzul_1;
                        break;
                    case 1:
                        P_1.Image = Properties.Resources.CVerde_01;
                        Thread.Sleep(700);
                        P_1.Image = Properties.Resources.CVerde_2;
                        break;
                    case 2:
                        P_2.Image = Properties.Resources.CRojo_2;
                        Thread.Sleep(700);
                        P_2.Image = Properties.Resources.CRojo_1;
                        break;
                    case 3:
                        P_3.Image = Properties.Resources.CAmarillo_2;
                        Thread.Sleep(700);
                        P_3.Image = Properties.Resources.CAmarillo_1;
                        break;

                }

                Thread.Sleep(500);
            }
            Hablando = false;

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
        //Metodo para generar la secuancia aleatoria de colores 
        private void GenerarSecuencia(int Cantidad)
        {
            for (int i = 0; i < Cantidad; i++)
            {
                SimonDice.Add(NumeroAleatorio.Next(0, 4));
            }
        }
        int puntos = 0;//esta es la variable para contar cada color correcto como un ounto 
        public void VerificarBotonPresionado(int ValorBoton)
        {    //si el juego esta hablando o si la lista de simon esta vacia no hace nada 
            if (Hablando || SimonDice.Count == 0) return;
            //compara el ultimo elemento de la secuancia inversa con el boton que se presiono
            //si es correcto control secuencia aumenta

            //se esta restando 1 para acceder al indice del ultimo elemento de la lista reverso
            //y se resta control secuencia para acceder a los elementos de la lista en orden inverso
            //y se verifica si es igaul al boton presionado
            if (SecuenciaReversa[SecuenciaReversa.Count - 1 - ControlSecuencia] == ValorBoton)
            {
                ControlSecuencia++;
                puntos++;//incrementan los puntos por cada acierto 
            }

            //si no es correcto el boton 
            else
            {

                MessageBox.Show("Tu puntaje final es:" + puntos);//te muestra tu puntaje final
                                                                 //las inicializa denuevo en 0
                ControlSecuencia = 0;
                puntos = 0;
                //las limpia
                SimonDice.Clear();
                SecuenciaReversa.Clear();
                //genera una nueva secuencia aleatoria de colores 
                GenerarSecuencia(5);
                SecuenciaReversa = new List<int>(SimonDice);
                new Thread(IniciarJuego).Start();
            }
            //despues de cada acierto
            if (ControlSecuencia >= SimonDice.Count)
            {
                // Se inicializa la secuancia en 0
                ControlSecuencia = 0;
                //se limpia
                SimonDice.Clear();
                //genera una nueva secuencia aleatoria de colores 
                GenerarSecuencia(5);
                //SimonDice.RemoveRange(0, SimonDice.Count - 5);
                // SimonDice.Add(NumeroAleatorio.Next(0,4));
                SecuenciaReversa = new List<int>(SimonDice);//se actualiza la secuencia Normal
                                                            // SimonDice.Reverse();
                new Thread(IniciarJuego).Start();
            }
            //  puntos++;//incrementan los puntos por cada acierto 
            lblPumtos.Text = puntos.ToString();
            //lblPumtos.Text = SimonDice.Count.ToString();
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
        private void ReproducirMusica()
        {
            // Aquí puedes incluir la lógica para reproducir la música cuando se presiona un botón si lo tienes implementado
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Se limoian
            SimonDice.Clear();
            SecuenciaReversa.Clear();
            GenerarSecuencia(5);//se genera una nueva secuancia de 5 colores siempre
            timer1.Enabled = true;//inicia el temporizador 
            SecuenciaReversa = new List<int>(SimonDice);//aqui se guarda su version inversa
            new Thread(IniciarJuego).Start();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            SelecNivelReverso sn = new SelecNivelReverso();
            sn.Show();
            this.Close();
        }
    }

    

}
