using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class frmCalculadora : Form
    {
        float v1;
        float v2;
        float soma;
        public frmCalculadora()
        {
            // Define a cultura padrão para usar ponto como separador decimal
           
                CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
                CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");
            
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblValor1.Visible = false;
            lblValor2.Visible = false;
            lblSinal.Visible = false;

        }

        private void lblCancelar_Click(object sender, EventArgs e) //Criei um evento de click para cancelar a conta
        {
            txtResultado.Text = "";
            lblValor1.Visible = false;
            lblValor2.Visible = false;
            lblSinal.Visible = false;

        }

        private void lbl1_Click(object sender, EventArgs e) //Criei um evento de click para todos os números
        {

            var resultado = txtResultado.Text;
            txtResultado.Text = resultado + 1;

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

            var resultado = txtResultado.Text;
            txtResultado.Text = resultado + 2;
        }

        private void lbl3_Click(object sender, EventArgs e)
        {

            var resultado = txtResultado.Text;
            txtResultado.Text = resultado + 3;
        }

        private void lbl0_Click(object sender, EventArgs e)
        {

            var resultado = txtResultado.Text;
            txtResultado.Text = resultado + 0;

        }

        private void lbl4_Click(object sender, EventArgs e)
        {

            var resultado = txtResultado.Text;
            txtResultado.Text = resultado + 4;
        }

        private void lbl5_Click(object sender, EventArgs e)
        {

            var resultado = txtResultado.Text;
            txtResultado.Text = resultado + 5;
        }

        private void lbl6_Click(object sender, EventArgs e)
        {

            var resultado = txtResultado.Text;
            txtResultado.Text = resultado + 6;
        }

        private void label7_Click(object sender, EventArgs e)
        {

            var resultado = txtResultado.Text;
            txtResultado.Text = resultado + 7;
        }

        private void lbl8_Click(object sender, EventArgs e)
        {

            var resultado = txtResultado.Text;
            txtResultado.Text = resultado + 8;
        }

        private void lbl9_Click(object sender, EventArgs e)
        {

            var resultado = txtResultado.Text;
            txtResultado.Text = resultado + 9;
        }

        private void lblMais_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToSingle(txtResultado.Text);
            txtResultado.Text = "";
            lblSinal.Visible = true;
            lblSinal.Text = "+";
            lblValor1.Visible = true;
            lblValor1.Text = v1.ToString();

        }

        private void lblIgual_Click(object sender, EventArgs e)
        {
            if (lblSinal.Text == "+")
            {
                v2 = Convert.ToSingle(txtResultado.Text);
                lblValor2.Visible = true;
                lblValor2.Text = v2.ToString();
                soma = v1 + v2;
                txtResultado.Text = soma.ToString();
            }
            else if (lblSinal.Text == "-")
            {
                v2 = Convert.ToSingle(txtResultado.Text);
                lblValor2.Visible = true;
                lblValor2.Text = v2.ToString();
                soma = v1 - v2;
                txtResultado.Text = soma.ToString();
            }
            else if (lblSinal.Text == "x")
            {
                v2 = Convert.ToSingle(txtResultado.Text);
                lblValor2.Visible = true;
                lblValor2.Text = v2.ToString();
                soma = v1 * v2;
                txtResultado.Text = soma.ToString();
            }
            else if (lblSinal.Text == "/")
            {
                v2 = Convert.ToSingle(txtResultado.Text);
                lblValor2.Visible = true;
                lblValor2.Text = v2.ToString();
                soma = v1 / v2;
                txtResultado.Text = soma.ToString();
            }
        }

        private void lblMenos_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToSingle(txtResultado.Text);
            txtResultado.Text = "";
            lblSinal.Visible = true;
            lblSinal.Text = "-";
            lblValor1.Visible = true;
            lblValor1.Text = v1.ToString();
        }

        private void lblMultiplicar_Click(object sender, EventArgs e)
        {
            {
                v1 = Convert.ToSingle(txtResultado.Text);
                txtResultado.Text = "";
                lblSinal.Visible = true;
                lblSinal.Text = "x";
                lblValor1.Visible = true;
                lblValor1.Text = v1.ToString();

            }
        }

        private void lblDividir_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToSingle(txtResultado.Text);
            txtResultado.Text = "";
            lblSinal.Visible = true;
            lblSinal.Text = "/";
            lblValor1.Visible = true;
            lblValor1.Text = v1.ToString();
        }

        private void lblPonto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(".")) // Verifica se NÃO contém um ponto
            {
                txtResultado.Text += "."; // Adiciona o ponto apenas se não houver um já

            }
        }

    }
}

