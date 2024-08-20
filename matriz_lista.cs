using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_vetor_matriz
{
    public partial class matriz_lista : Form
    {
        public matriz_lista()
        {
            InitializeComponent();
        }

        int[,] matriz = new int[3, 3];
            int row = 0, col = 0;

        private void btlistar_Click(object sender, EventArgs e)
        {
            lbmatriz.Items.Clear();

            for (row = 0; row < 3; row++)
            {
                for (col = 0; col <3; col++)
                {
                    lbmatriz.Items.Add($"Matriz {row}, {col} = {matriz[row, col]}");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbmatriz.Items.Clear ();
            col = 0; row = 0;
            btadd.Enabled = true;
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            matriz[row,col] = int.Parse(txbnum.Text);
           
            if (col < 2)
            {
                col++;
            }

            else if (col >= 2  && row <2)
            {
                col = 0;
                row++;
            }

            else
            {
                btadd.Enabled = false;
            }

            txbnum.Clear();
            txbnum.Focus();
        }
    }
}