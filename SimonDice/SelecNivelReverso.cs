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
    public partial class SelecNivelReverso : Form
    {
        public SelecNivelReverso()
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
            SmnReversoN1 sn1 = new SmnReversoN1();
            sn1.Show();
            this.Hide();
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            SmnReversoN2 sn2 = new SmnReversoN2();
            sn2.Show();
            this.Hide();
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            SmnReversoN3 sn3 = new SmnReversoN3();
            sn3.Show();
            this.Hide();
        }
    }
}
