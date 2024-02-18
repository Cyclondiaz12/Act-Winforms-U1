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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3();
            formulario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario = new Form4();
            formulario.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario = new Form5();
            formulario.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formulario = new Form6();
            formulario.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form formulario = new Form7();
            formulario.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form formulario = new Form8();
            formulario.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form formulario = new Form9();
            formulario.Show();
        }
    }
}
