using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double valorDelta;
        double valorRaiz1;
        double valorRaiz2;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            valorDelta = (Convert.ToDouble(txtB.Text) * Convert.ToDouble(txtB.Text)) - 4 * (Convert.ToDouble(txtA.Text) * Convert.ToDouble(txtC.Text));
            lblDelta.Text = valorDelta.ToString();

            valorRaiz1 = -((Convert.ToDouble(txtB.Text) + Math.Sqrt(valorDelta)) / (2 * Convert.ToDouble(txtA.Text)));
            lblRaiz1.Text = Math.Round(valorRaiz1,4).ToString();
            valorRaiz2 = -((Convert.ToDouble(txtB.Text) - Math.Sqrt(valorDelta))/ (2 * Convert.ToDouble(txtA.Text)));
            lblRaiz2.Text = Math.Round(valorRaiz2,4).ToString();

        }
    }
}
