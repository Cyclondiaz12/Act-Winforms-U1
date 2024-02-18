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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double dolarAEuro = 0; // Valor de 1 dólar en euros
            double euroADolar = 0; // Valor de 1 euro en dólares
            double monto = 0;
            double resultado = 0;

            try
            {
                int opcion = int.Parse(txtOpcion.Text);

                switch (opcion)
                {
                    case 1:
                        dolarAEuro = double.Parse(txtValorConversion.Text);
                        monto = double.Parse(txtMonto.Text);
                        resultado = monto * dolarAEuro;
                        txtResultado.Text = $"{monto} dólares son {resultado} euros";
                        break;

                    case 2:
                        euroADolar = double.Parse(txtValorConversion.Text);
                        monto = double.Parse(txtMonto.Text);
                        resultado = monto * euroADolar;
                        txtResultado.Text = $"{monto} euros son {resultado} dólares";
                        break;

                    default:
                        MessageBox.Show("Opción inválida");
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
