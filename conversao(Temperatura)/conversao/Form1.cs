using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace conversao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConv_Click(object sender, EventArgs e)
        {

            double temp, r;
            int opc;
            temp = double.Parse(txtValor.Text);
            opc = cbTemp.SelectedIndex;

            switch (opc)
            {
                case 0:
                    r = (temp + 273.15);
                    MessageBox.Show("A Temperatura de Celcius para Kelvin é: " + r);
                    break;
                case 1:
                    r = (temp - 273.15);
                    MessageBox.Show("A Temperatura de Kelvin para Celcius é: " + r);
                    break;
                case 2:
                    r = (320 + ((1.8) * temp));
                    MessageBox.Show("A Temperatura de Celcius para Farenheit é: " + r);
                    break;
                case 3:
                    r = ((1.8) * (temp - 32.0));
                    MessageBox.Show("A Temperatura de Farenheit para Celcius é: " + r);
                    break;

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }
    }
}
                     
