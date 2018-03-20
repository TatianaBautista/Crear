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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Form iron = new Form4();
            iron.Show();
        }

        private void linklblCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form iron = new Form3();
            iron.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form iron = new Form1();
            iron.Show();
        }

        private void comboBIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBIdioma.SelectedIndex == 0)
            {
                lblSesion.Visible = true;
                lblUsuario.Visible = true;
                lblNuevaCuenta.Visible = true;
                lblContraseña.Visible = true;
                linklblCrearCuenta.Visible = true;
                btnIngresar.Visible = true;
                btnRegresar.Visible = true;

                lblLogIn.Visible = false;
                lblUserName.Visible = false;
                lblPass.Visible = false;
                lblnewcount.Visible = false;
                btnLogIn.Visible = false;
                btnReturn.Visible = false;
                linkLblCount.Visible = false;

            }
            if (comboBIdioma.SelectedIndex == 1)
            {
                lblSesion.Visible = false;
                lblUsuario.Visible = false;
                lblNuevaCuenta.Visible = false;
                lblContraseña.Visible = false;
                linklblCrearCuenta.Visible = false;
                btnIngresar.Visible = false;
                btnRegresar.Visible = false;

                lblLogIn.Visible = true;
                lblUserName.Visible = true;
                lblPass.Visible = true;
                lblnewcount.Visible = true;
                linkLblCount.Visible = true;
                btnReturn.Visible = true;
                btnLogIn.Visible = true;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form iron = new Form1();
            iron.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Form iron = new Form4();
            iron.Show();
        }

        private void linkLblCount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form iron = new Form3();
            iron.Show();
        }

        private void txtBUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
