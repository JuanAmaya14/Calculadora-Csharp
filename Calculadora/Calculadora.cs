using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {

        decimal D1 = 0;
        decimal D2 = 0;
        decimal Result = 0;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            D1 = Convert.ToDecimal(textBox1.Text);
            D2 = Convert.ToDecimal(textBox2.Text);


            if (Sumar.Checked == true)
            {


                Result = (D1 + D2);

                label3.Text = "El resultado es: " + Result;

            }

            if (Restar.Checked == true)
            {
                //Result = Convert.ToDecimal(0.00);

                Result = (D1 - D2);
                label3.Text = "El resultado es: " + Result;

            }

            if (Multiplicar.Checked == true)
            {


                Result = (D1 * D2);
                label3.Text = "El resultado es: " + Result;

            }

            if (Dividir.Checked == true)
            {


                Result = (D1 / D2);
                label3.Text = "El resultado es: " + Result;

            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "El resultado es: ";

            Sumar.Checked = false;
            Restar.Checked = false;
            Multiplicar.Checked = false;
            Dividir.Checked = false;

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
