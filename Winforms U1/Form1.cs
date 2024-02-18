using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double l;
            double p;
            double s;

            try
            {
                l = double.Parse(txtLados.Text);
                s = double.Parse(txtLargo.Text);
                p = s * l;
                MessageBox.Show("Su perímetro es: " + p.ToString() + " metros");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduzca valores válidos para los lados y el largo.");
            }
        }
    }
}
