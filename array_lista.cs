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
    public partial class array_lista : Form
    {
        public array_lista()
        {
            InitializeComponent();
        }

        int[] vetor = new int[4];
        int index = 0;
        
        private void BTadd_Click(object sender, EventArgs e)
        {
            if (index < vetor.Length)
            { 
                vetor[index] = int.Parse(TXBnum.Text);
                index++;
                TXBnum.Clear();
                TXBnum.Focus();

            }
            else
            {
                BTadd.Enabled = false;
            }
        }

        private void BTlistar_Click(object sender, EventArgs e)
        {
            LBnum.Items.Clear();

            for (index = 0; index < vetor.Length; index++)
            {
                LBnum.Items.Add(vetor[index]);
                
            }
            index = 0;

            BTadd.Enabled = true;

        }
    }
}
