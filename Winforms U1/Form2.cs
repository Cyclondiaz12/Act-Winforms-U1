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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double c;
            double r;

            try
            {
                c = Double.Parse(txtGrados.Text);
                r = c * (Math.PI / 180);
                MessageBox.Show("En radianes, son: " + r);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce un valor válido para los grados.");
            }
        }
    }
}
