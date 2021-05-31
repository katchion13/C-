using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PCarro
{
    public partial class Form1 : Form
    {
        Carro objCarro = new Carro();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMov_Click(object sender, EventArgs e)
        {
            objCarro.movimentar(15);
            pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X + 15, pictureBox2.Location.Y);
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer1.Start();
           

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X + 15, pictureBox2.Location.Y);
       }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnRe_Click(object sender, EventArgs e)
        {
            objCarro.re();
            pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X - 5, pictureBox2.Location.Y);
            pictureBox1.Visible = false;
            timer1.Stop();
            timer2.Start();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X - 5, pictureBox2.Location.Y);
           
        }
        private void btnParar_Click(object sender, EventArgs e)
        {
            objCarro.parar();
            timer1.Stop();
            timer2.Stop();
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }
        private void btnVelo_Click(object sender, EventArgs e)
        {
            int vel;
            objCarro.marca=txtMarca.Text;
            objCarro.comustivel = txtCombu.Text;
            objCarro.consultar();
            vel = objCarro.consultar();
            MessageBox.Show("O Carro de Marca " + objCarro.marca + " é Combustível " + objCarro.comustivel + " está na  Velocidade: " + vel);
        }
    }
}
