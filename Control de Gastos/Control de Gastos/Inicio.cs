using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Gastos
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prueba();   
        }
        private void prueba()
        {
            progressBar1.Increment(1);
            label1.Text = "C a r g a n d o . . . . " + progressBar1.Value.ToString() + " %";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                Form iron = new Form1();
                iron.Show();

            }
        }
    }
}
