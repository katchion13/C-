using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Conversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
      InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal inicio, fim, cont;
            double resultado;

            inicio = numInicio.Value;
            fim = numFim.Value;
            for (cont = inicio; cont<= fim; cont++)
            {
                resultado = Convert.ToDouble(cont) * 2.54;
                listBox1.Items.Add(cont + " cm = " + (Convert.ToString(resultado) + " polegadas"));
           }
        }           
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
     }
}
