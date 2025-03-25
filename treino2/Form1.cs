using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treino2
{
    public partial class frmMaiorouMenor : Form
    {
        public frmMaiorouMenor()
        {
            InitializeComponent();
        }

        private void btnMaiorMenor_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtMaiorMenor.Text, out int maiormenor))
            {
                if (maiormenor >= 10)
                {
                    MessageBox.Show("O valor é maior ou igual 10", "Resulato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (maiormenor < 10)
                {
                    MessageBox.Show("O valor é menor 10", "Resulato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Você não digitou um número", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
