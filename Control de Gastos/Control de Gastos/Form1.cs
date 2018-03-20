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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            Form iron = new Form2();
            iron.Show();
        }

        private void comboBIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBIdioma.SelectedIndex == 0)
            {
                lblTitulo.Visible = true;
                lblTitle.Visible = false;
                btnComenzar.Visible = true;
                btnStart.Visible = false;
            }
            if(comboBIdioma.SelectedIndex == 1)
            {
                lblTitulo.Visible = false;
                lblTitle.Visible = true;
                btnStart.Visible = true;
                btnComenzar.Visible = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form iron = new Form2();
            iron.Show();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
