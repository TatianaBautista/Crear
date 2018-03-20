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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form iron = new Form2();
            iron.Show();
        }

        private void comboBIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBIdioma.SelectedIndex == 0)
            {
                lblRegistro.Visible = true;
                lblNombreArticulo.Visible = true;
                lblPrecio.Visible = true;
                lblCantidad.Visible = true;
                lblFecha.Visible = true;
                btnRegresar.Visible = true;
                btnSalir.Visible = true;
                btnRegistrarProd.Visible = true;

                lblTitleProduct.Visible = false;
                lblNameArti.Visible = false;
                lblPrice.Visible = false;
                lblAmount.Visible = false;
                lblDate.Visible = false;
                btnReturn.Visible = false;
                btnExit.Visible = false;
                btnRegister.Visible = false;

            }
            if (comboBIdioma.SelectedIndex == 1)
            {
                lblTitleProduct.Visible = true;
                lblNameArti.Visible = true;
                lblPrice.Visible = true;
                lblAmount.Visible = true;
                lblDate.Visible = true;
                btnReturn.Visible = true;
                btnExit.Visible = true;
                btnRegister.Visible = true;

                lblRegistro.Visible = false;
                lblNombreArticulo.Visible = false;
                lblPrecio.Visible = false;
                lblCantidad.Visible = false;
                lblFecha.Visible = false;
                btnRegresar.Visible = false;
                btnSalir.Visible = false;
                btnRegistrarProd.Visible = false;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form iron = new Form2();
            iron.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form iron = new Form5();
            iron.Show();
            MessageBox.Show("The record was saved correctly");
            Form5 s = new Form5();
            s.lbl1.Text = txtArticulo.Text;
            s.lbl2.Text = txtPrecio.Text;
            s.lbl3.Text = txtBCantidad.Text;
            s.lbl4.Text = txtFecha.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrarProd_Click(object sender, EventArgs e)
        {
            Form iron = new Form5();
            iron.Show();
            MessageBox.Show("Se Guardó el Registro Correctamente ");
            Form5 s = new Form5();
            s.lbl1.Text = txtArticulo.Text;
            s.lbl2.Text = txtPrecio.Text;
            s.lbl3.Text = txtBCantidad.Text;
            s.lbl4.Text = txtFecha.Text;
            s.Show();
        }
    }
}
