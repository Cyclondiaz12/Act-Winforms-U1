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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double c;
            double f;

            try
            {
                c = Double.Parse(txtGrados.Text);
                f = (c * 9 / 5) + 32;
                MessageBox.Show("En Fahrenheit, son: " + f);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce un valor válido para los grados Celsius.");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
