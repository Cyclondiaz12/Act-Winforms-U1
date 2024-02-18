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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void btnVerificarPar_Click(object sender, EventArgs e)
        {
            double numero;

            try
            {
                if (double.TryParse(txtNumero.Text, out numero))
                {
                    if (numero % 2 == 0)
                    {
                        MessageBox.Show(numero + " es par");
                    }
                    else
                    {
                        MessageBox.Show(numero + " no es par");
                    }
                }
                else
                {
                    MessageBox.Show("Opción Inválida. Por favor ingrese un número válido.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce un valor numérico válido.");
            }
        }
    }
}
