using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAtribuir_Click(object sender, EventArgs e)
        {
            String[] cor = new String [4];
            cor[0]=txt1.Text;
            cor[1]=txt2.Text;
            cor[2]=txt3.Text;
            cor[3] = txt4.Text;

            for(int cont = 0; cont<cor.Length;cont++)
            {
            listBox1.Items.Add(cor[cont]);
            }
        }

        private void btnMudar_Click(object sender, EventArgs e)
        {

            string selecionado;
            selecionado = Convert.ToString(listBox1.SelectedItem);
            if (selecionado == "Azul")
            {
                BackColor = System.Drawing.Color.Blue;
            }
            if (selecionado == "Vermelho")
                BackColor = System.Drawing.Color.Red;
            {
                if (selecionado == "Rosa")
                    BackColor = System.Drawing.Color.Pink;
            }
            {
                if (selecionado == "Verde")
                    BackColor = System.Drawing.Color.Green;
            }
            {
                if (selecionado == "Amarelo")
                    BackColor = System.Drawing.Color.Yellow;
            }
            {
                if (selecionado == "Verde Claro")
                    BackColor = System.Drawing.Color.YellowGreen;
            }
            {
                if (selecionado == "Branco")
                    BackColor = System.Drawing.Color.White;
            }
            {
                if (selecionado == "Laranja")
                    BackColor = System.Drawing.Color.Orange;
            }
            {
                if (selecionado == "Prata")
                    BackColor = System.Drawing.Color.Silver;
            }
            {
                if (selecionado == "Azul Claro")
                    BackColor = System.Drawing.Color.SkyBlue;
            }
            {
                if (selecionado == "Dourado")
                    BackColor = System.Drawing.Color.Gold;
            }
            {
                if (selecionado == "Cinza")
                    BackColor = System.Drawing.Color.Gray;
            }
            {
                if (selecionado == "Pink")
                    BackColor = System.Drawing.Color.HotPink;
            }
            {
                if (selecionado == "Honeydew")
                    BackColor = System.Drawing.Color.Honeydew;
            }
         }
    }
}
