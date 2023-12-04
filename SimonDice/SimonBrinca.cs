using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonDice
{
    public partial class SimonBrinca : Form
    {
        int blocksX = 80;
        int blocksY = 80;
        int puntaje = 0;

        List<PictureBox> pictureBoxes = new List<PictureBox>();
        List<PictureBox> BoxesSeleccionados = new List<PictureBox>();
        List<Color> colores = new List<Color> { Color.Red, Color.Yellow, Color.Blue, Color.Green };
        Random rnd = new Random();

        Color temp;

        int index = 0;
        int intentos = 0;
        int Level = 4;


        int LimiteTiempo = 0;
        bool SeleccionandoColores = false;

        string OrdenCorrecto = String.Empty;
        string OrdenSeleccionado = String.Empty;
        public SimonBrinca()
        {
            InitializeComponent();
            AcomodarBlocks();
        }

        private void EventoTimer(object sender, EventArgs e)
        {
            if (SeleccionandoColores)
            {
                LimiteTiempo++;
                switch (LimiteTiempo)
                {
                    case 10:
                        temp = BoxesSeleccionados[index].BackColor;
                        BoxesSeleccionados[index].BackColor = Color.White;

                        break;
                    case 20:
                        BoxesSeleccionados[index].BackColor = temp;

                        break;


                    case 30:

                        if (index < BoxesSeleccionados.Count - 1)
                        {
                            index++;
                            LimiteTiempo = 0;
                        }
                        else
                        {
                            SeleccionandoColores = false;
                        }
                        break;
                }
            }
            if (intentos >= Level)
            {
                if (OrdenCorrecto == OrdenSeleccionado)
                {
                    intentos = 0;
                    TimerJuego.Stop();
                    MessageBox.Show("Acertaste");
                    puntaje++;
                }
                else
                {
                    intentos = 0;
                    TimerJuego.Stop();
                    MessageBox.Show("intentalo nuevamente");
                }
            }
        }

        private void btnEventoClick(object sender, EventArgs e)
        {
            


        }


        private void AcomodarBlocks()
        {
            for (int i = 1; i < 5; i++)
            {
                PictureBox NuevoPB = new PictureBox();
                NuevoPB.Name = "pic_" + i;
                NuevoPB.Height = 63;
                NuevoPB.Width = 63;
                //NuevoPB.BackColor = Color.Black;
                NuevoPB.Left = blocksX;
                NuevoPB.Top = blocksY;
                NuevoPB.Click += ClickOnPictureBox;

                if (i == 2 || i == 4)
                {
                    blocksY += 65;
                    blocksX = 80;
                }
                else
                {
                    blocksX += 65;
                }

                this.Controls.Add(NuevoPB);
                pictureBoxes.Add(NuevoPB);
            }


            pictureBoxes[0].BackColor = Color.Red;
            pictureBoxes[1].BackColor = Color.Yellow;
            pictureBoxes[2].BackColor = Color.Blue;
            pictureBoxes[3].BackColor = Color.Green;


        }

        private void ClickOnPictureBox(object sender, EventArgs e)
        {
            if (!SeleccionandoColores && BoxesSeleccionados.Count > 1)
            {
                PictureBox temp = sender as PictureBox;
                temp.BackColor = Color.Black;
                OrdenSeleccionado += temp.Name + " ";
                Debug.WriteLine(OrdenSeleccionado);
                intentos++;
            }
            else return;


        }

        private void CambiarColores()
        {
            // Cambiar de orden los colores disponibles
            colores = colores.OrderBy(c => rnd.Next()).ToList();

            // Aplicar colores a los pictureboxes
            for (int i = 0; i < pictureBoxes.Count; i++)
            {
                pictureBoxes[i].BackColor = colores[i];
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (puntaje == 3 && Level < 7)
            {
                Level++;
                puntaje = 0;
            }
            OrdenCorrecto = string.Empty;
            OrdenSeleccionado = string.Empty;
            BoxesSeleccionados.Clear();
            BoxesSeleccionados = pictureBoxes.OrderBy(x => rnd.Next()).ToList();

            for (int i = 0; i < BoxesSeleccionados.Count; i++)
            {
                OrdenCorrecto += BoxesSeleccionados[i].Name + " ";
            }
            Debug.WriteLine(OrdenCorrecto);
            index = 0;
            LimiteTiempo = 0;
            SeleccionandoColores = true;
            TimerJuego.Start();
            CambiarColores();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
