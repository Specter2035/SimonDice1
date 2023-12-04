using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonDice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSimonClasico_Click(object sender, EventArgs e)
        {
            SelecNvlClasico snc = new SelecNvlClasico();
            snc.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Forms1_ResizeEvent(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnSimonReverso_Click(object sender, EventArgs e)
        {
            SelecNivelReverso sn = new SelecNivelReverso();
            sn.Show();
            this.Hide();
        }

        private void btnSimonBrinca_Click(object sender, EventArgs e)
        {
            SimonBrinca smnBrinca = new SimonBrinca();
            smnBrinca.Show();
            this.Hide();
        }

        private void btnSimonSorpresa_Click(object sender, EventArgs e)
        {
            SmnSorpresa smnSorpresa = new SmnSorpresa();
            smnSorpresa.Show();
            this.Hide();
        }
    }
}
