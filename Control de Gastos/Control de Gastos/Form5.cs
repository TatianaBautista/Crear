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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form iron = new Form4();
            iron.Show();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form iron = new Form4();
            iron.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblIdioma_Click(object sender, EventArgs e)
        {

        }

        private void comboBIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBIdioma.SelectedIndex == 0)
            {
                lblRegistro.Visible = true;
                btnRegresar.Visible = true;
                lblNombreAr.Visible = true;
                lblPrecio.Visible = true;
                lblCanti.Visible = true;
                lblFecha.Visible = true;


                lblTitleProduct.Visible = false;
                btnReturn.Visible = false;
                lblArticle.Visible = false;
                lblPrice.Visible = false;
                lblDate.Visible = false;
                lblQua.Visible = false;

            }
            if (comboBIdioma.SelectedIndex == 1)
            {
                lblRegistro.Visible = false;
                btnRegresar.Visible = false;
                lblNombreAr.Visible = false;
                lblPrecio.Visible = false;
                lblCanti.Visible = false;
                lblFecha.Visible = false;


                lblTitleProduct.Visible = true;
                btnReturn.Visible = true;
                lblArticle.Visible = true;
                lblPrice.Visible = true;
                lblDate.Visible = true;
                lblQua.Visible = true;
            }
        }
    }
}
