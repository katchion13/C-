using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JogoSimpson
{
    public partial class Form1 : Form
    {
        Simpson objSimpson = new Simpson();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new System.Drawing.Point(pictureBox1.Location.X + 5, pictureBox2.Location.Y);
            pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X + 2, pictureBox2.Location.Y);
            pictureBox3.Location = new System.Drawing.Point(pictureBox3.Location.X + 3, pictureBox2.Location.Y);
            timer1.Start();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.pictureBox2.Location = new System.Drawing.Point(05, 324);
            this.pictureBox1.Location = new System.Drawing.Point(10, 227);
            this.pictureBox3.Location = new System.Drawing.Point(100, 358);
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            objSimpson.qtdpontos = objSimpson.consultarpontos();
            MessageBox.Show("Sua Pontuação é: " + objSimpson.qtdpontos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            objSimpson.pontuacao(5);
            pictureBox1.Visible = false;

            objSimpson.qtdpontos = objSimpson.consultarpontos();
            label2.Text = Convert.ToString(objSimpson.qtdpontos);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
            objSimpson.pontuacao(5);
            pictureBox2.Visible = false;

            objSimpson.qtdpontos = objSimpson.consultarpontos();
            label2.Text = Convert.ToString(objSimpson.qtdpontos);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            objSimpson.pontuacao(5);
            pictureBox3.Visible = false;

            objSimpson.qtdpontos = objSimpson.consultarpontos();
            label2.Text = Convert.ToString(objSimpson.qtdpontos);
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
          
            objSimpson.Tempo(1);
        
            if (objSimpson.tempo == 20)
    {
            MessageBox.Show("Game Over");
    }
 
        }

        private void button3_Click(object sender, EventArgs e)
        {
              Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
      
   
}