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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private void btnMostrarDia_Click(object sender, EventArgs e)
        {
            int i;

            try
            {
                i = int.Parse(txtNumeroDia.Text);

                switch (i)
                {
                    case 1:
                        txtResultado.Text = "El día es: Lunes";
                        break;
                    case 2:
                        txtResultado.Text = "El día es: Martes";
                        break;
                    case 3:
                        txtResultado.Text = "El día es: Miércoles";
                        break;
                    case 4:
                        txtResultado.Text = "El día es: Jueves";
                        break;
                    case 5:
                        txtResultado.Text = "El día es: Viernes";
                        break;
                    case 6:
                        txtResultado.Text = "El día es: Sábado";
                        break;
                    case 7:
                        txtResultado.Text = "El día es: Domingo";
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
