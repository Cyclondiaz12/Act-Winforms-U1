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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double g;
            double r;

            try
            {
                int opcion = int.Parse(txtOpcion.Text);

                switch (opcion)
                {
                    case 1:
                        g = double.Parse(txtValorConversion.Text);
                        r = g * (Math.PI / 180);
                        txtResultado.Text = $"{g} grados son: {r} radianes";
                        break;
                    case 2:
                        r = double.Parse(txtValorConversion.Text);
                        g = r * (180 / Math.PI);
                        txtResultado.Text = $"{r} radianes son: {g} grados";
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
