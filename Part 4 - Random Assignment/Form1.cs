using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4___Random_Assignment
{
    public partial class RandomNumbers : Form
    {
        Random generator = new Random();
        int intOutput;
        int Minimum;
        int Maximum;
        double randomDecimal;
        double doubleOutput;
        int decimalPlaces;
        public RandomNumbers()

        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInteger_Click(object sender, EventArgs e)
        {
            Minimum = Convert.ToInt32(txtMin.Text);
            Maximum = Convert.ToInt32(txtMax.Text);
            Maximum = Maximum + 1;
            intOutput = generator.Next(Minimum, Maximum);
            lblOutput.Text = ($"{intOutput}");
        }
        private void txtOutput_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            Minimum = Convert.ToInt32(txtMin.Text);
            Maximum = Convert.ToInt32(txtMax.Text);
            decimalPlaces = Convert.ToInt32(txtDecimalPlaces.Text);
            Maximum = Maximum - 1;
            intOutput = generator.Next(Minimum, Maximum);
            randomDecimal = generator.NextDouble();
            doubleOutput = intOutput + randomDecimal;
            doubleOutput = Math.Round(doubleOutput, decimalPlaces);
            lblOutput.Text = ($"{doubleOutput}");

        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
