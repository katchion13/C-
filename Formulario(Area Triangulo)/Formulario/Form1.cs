using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
    
        private void button1_Click(object sender, EventArgs e)
        {

            double bmenor, bmaior, altura, area;
            bmenor = double.Parse(txtMenor.Text);
            bmaior = double.Parse(txtMaior.Text);
            altura = double.Parse(txtAltura.Text);

             area = ((bmaior + bmenor) * altura) / 2;
            MessageBox.Show("A área é: " + area);

        }
                private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
