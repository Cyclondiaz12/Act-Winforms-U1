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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int i;
            double l;
            double s;
            double p;
            double a;
            double f;

            try
            {
                i = int.Parse(txtOpcion.Text);

                switch (i)
                {
                    case 1:
                        l = double.Parse(txtLados.Text);
                        s = double.Parse(txtLargo.Text);
                        p = s * l;
                        txtResultado.Text = "Su perímetro es: " + p.ToString() + " metros";
                        break;
                    case 2:
                        l = double.Parse(txtLados.Text);
                        s = double.Parse(txtLargo.Text);
                        p = s * l;
                        a = double.Parse(txtApotema.Text);
                        f = (a * p) / 2;
                        txtResultado.Text = "Su área es: " + f.ToString() + " metros";
                        break;
                    default:
                        MessageBox.Show("Opción Inválida");
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce valores numéricos válidos.");
            }
        }
    }
}
