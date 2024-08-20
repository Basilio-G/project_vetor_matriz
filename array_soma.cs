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
    public partial class array_soma : Form
    {
        public array_soma()
        {
            InitializeComponent();
        }

        int[] vetor = new int[4];
        int indice = 0, total;

        private void btadd_Click(object sender, EventArgs e)
        {
            if (indice < vetor.Length)
            {
                vetor[indice] = int.Parse(txbnum.Text);
                total += vetor[indice];
                indice++;

                txbnum.Clear();
                txbnum.Focus();
            }
            else
            {
                btadd.Enabled = false;
            }
        }

        private void btsoma_Click(object sender, EventArgs e)
        {
            txbsoma.Text = total.ToString();
            btadd.Enabled = true;
        }
    }
}
