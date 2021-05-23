using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculoConsumo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                               
                double anterior = double.Parse(txtEletricaAnt.Text);
                double atual = double.Parse(txtEletricaAtu.Text);
                double constante = double.Parse(txtEletricaCons.Text);
                double consumo;       
                consumo = (atual - anterior) * constante;
                
                MessageBox.Show("Consumo Total de Energia é: " + consumo);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   try
            {
                       double anterior2 = double.Parse(txtAguaAnti.Text);
                    double  atual2 = double.Parse(txtAgueAtua.Text);
                    double consumo2;     
       consumo2 = (atual2 - anterior2) * 1000;
                     
                MessageBox.Show("Consumo Total de Água é: " + consumo2);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtEletricaCons_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEletricaAtu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEletricaAnt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAguaAnti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtAgueAtua_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
   }
 }
