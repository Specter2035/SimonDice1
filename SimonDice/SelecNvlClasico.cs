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
    public partial class SelecNvlClasico : Form
    {
        public SelecNvlClasico()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            SimonDiceClasico n1 = new SimonDiceClasico();
            n1.Show();
            this.Hide();
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            SmnDiceClasicoN2 n2 = new SmnDiceClasicoN2();
            n2.Show();
            this.Hide();
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            SmnDiceClasicoN3 n3 = new SmnDiceClasicoN3();
            n3.Show();
            this.Hide();
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            SmnDiceClasicoN4 n4 = new SmnDiceClasicoN4();
            n4.Show();
            this.Hide();
        }
    }
}
