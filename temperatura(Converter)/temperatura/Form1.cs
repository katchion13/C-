using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double t, r;
            t = double.Parse(txtTemp.Text);


            if (rbCelcius.Checked)
            {
                r = 32 + (1.8 * t);
                MessageBox.Show("A Temperatura de Celcius para Farenheit é: " + r);
            }
            if (rbFarenheit.Checked)
            {
                r = (t - 32) * 1.8;
                MessageBox.Show("A Temperatura de Farenheit para  Celcius é: " + r);
            }
                }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
                   }
    }
}
