using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matriz_2_treino
{
    public partial class frmMatriz : Form
    {
        double[,] matriz = new double[3, 3];
        int i = 0;
        int j = 0;

        public frmMatriz()
        {
            InitializeComponent();
        }

        private void txtMatriz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                matriz[i, j] = double.Parse(txtMatriz.Text);
                j++;
                if (j == 3)
                {
                    i++;
                    j = 0;
                }
                txtMatriz.Text = " ";

            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    txtValores.Text += matriz[i, j].ToString() + " ";

                }
                txtValores.Text += Environment.NewLine;
            }

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            double maior = double.MinValue;
            foreach (var v in matriz)
            {
                if (v > maior)
                {
                    maior = v;

                }
                txtExibirMaior.Text = " "  + maior.ToString();
            }
        }
    }
}
