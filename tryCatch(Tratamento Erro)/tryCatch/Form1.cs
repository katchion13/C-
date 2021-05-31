using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tryCatch
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
                double var01 = double.Parse(textBox1.Text);
                double var02 = double.Parse(textBox2.Text);
                double resp = var01 * var02;
                txtResp.Text = resp.ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                MessageBox.Show("Finalizando o sistema", "Mensagem");

            }
        }
    }
}