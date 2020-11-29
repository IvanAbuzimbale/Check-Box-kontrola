using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_box_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Posalji_btn_Click(object sender, EventArgs e)
        {

            if (Dorucak.Checked)
            {
                Popis.Text = Popis.Text + Dorucak.Text;
            }
            else if (Rucak.Checked)
            {
                Popis.Text = Popis.Text + Environment.NewLine + Rucak.Text;
            }
            else if (Vecera.Checked)
            {
                Popis.Text = Popis.Text + Environment.NewLine + Vecera.Text;
            }

        }

        private void Sakrij_narudzbu_CheckedChanged(object sender, EventArgs e)
        {
            if (Sakrij_narudzbu.Checked)
            {
                Popis.Visible = false;
            }else
            {
                Popis.Visible=true;
            }
        }

        private void Popis_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
