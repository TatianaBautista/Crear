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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form iron = new Form2();
            iron.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Form iron = new Form2();
            iron.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBIdioma.SelectedIndex == 0)
            {
                lblNuevaCuenta.Visible = true;
                lblNombreUsuario.Visible = true;
                lblCorreo.Visible = true;
                lblContraseña.Visible = true;
                lblConfirmarContraseña.Visible = true;
                lblSexo.Visible = true;
                btnAceptar.Visible = true;
                btnSalir.Visible = true;
                btnRegresar.Visible = true;
                comboBSexo.Visible = true;

                lblTitleCount.Visible = false;
                lblNameUser.Visible = false;
                lblEmail.Visible = false;
                lblPass.Visible = false;
                lblConfirmPass.Visible = false;
                lblSex.Visible = false;
                btnLogIn.Visible = false;
                btnExit.Visible = false;
                btnReturn.Visible = false;
                comboBSex.Visible = false;

            }
            if (comboBIdioma.SelectedIndex == 1)
            {
                lblNuevaCuenta.Visible = false;
                lblNombreUsuario.Visible = false;
                lblCorreo.Visible = false;
                lblContraseña.Visible = false;
                lblConfirmarContraseña.Visible = false;
                lblSexo.Visible = false;
                btnAceptar.Visible =false;
                btnSalir.Visible = false;
                btnRegresar.Visible = false;
                comboBSexo.Visible = false;

                lblTitleCount.Visible = true;
                lblNameUser.Visible = true;
                lblEmail.Visible = true;
                lblPass.Visible = true;
                lblConfirmPass.Visible = true;
                lblSex.Visible = true;
                btnLogIn.Visible = true;
                btnExit.Visible = true;
                btnReturn.Visible =true;
                comboBSex.Visible = true;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form iron = new Form2();
            iron.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Form iron = new Form2();
            iron.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTitleCount_Click(object sender, EventArgs e)
        {

        }

        private void lblNuevaCuenta_Click(object sender, EventArgs e)
        {

        }

        private void lblNameUser_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }
    }
}
