using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matriz1
{
    public partial class frmMatriz : Form
    {
        int[,] matriz =
        {
            {1, 5, -2 },
            {8, 3, 0 },
            {4, -1, 2 }
        };

        public frmMatriz()
        {
            InitializeComponent();
            PreencherDataGridView();
        }
        private void PreencherDataGridView()
        {
            dataGridView1.ColumnCount = matriz.GetLength(1);

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                string[] linha = new string[matriz.GetLength(1)];
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    linha[j] = matriz[i, j].ToString();
                }
                dataGridView1.Rows.Add(linha);
            }
        }
        private void btnExibir_Click(object sender, EventArgs e)
        {
            int maior = matriz[0, 0];
            foreach (int numero in matriz)
            {
                if (numero > maior)
                    maior = numero;
            }
            txtMatriz.Text = maior.ToString();
        }
    }
}
