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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            double t = 1.17; // Impuesto
            double p;
            int i;
            double x;

            try
            {
                i = int.Parse(txtOpcion.Text);

                switch (i)
                {
                    case 1:
                        x = double.Parse(txtValor.Text);
                        p = x * t;
                        txtResultado.Text = "El precio de su producto es: " + p.ToString() + " pesos, considerando los impuestos";
                        break;
                    case 2:
                        x = double.Parse(txtValor.Text);
                        p = x;
                        txtResultado.Text = "El precio de su medicina es: " + p.ToString() + " pesos, sin impuestos";
                        break;
                    default:
                        MessageBox.Show("Opción Inválida");
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce un valor numérico válido.");
            }
        }
    }
}
