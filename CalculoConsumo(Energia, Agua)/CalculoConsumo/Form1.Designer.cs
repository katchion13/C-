namespace CalculoConsumo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAguaAnti = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtEletricaCons = new System.Windows.Forms.TextBox();
            this.txtEletricaAtu = new System.Windows.Forms.TextBox();
            this.txtEletricaAnt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtAgueAtua = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAguaAnti.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAguaAnti
            // 
            this.txtAguaAnti.Controls.Add(this.tabPage1);
            this.txtAguaAnti.Controls.Add(this.tabPage2);
            this.txtAguaAnti.Location = new System.Drawing.Point(26, 19);
            this.txtAguaAnti.Name = "txtAguaAnti";
            this.txtAguaAnti.SelectedIndex = 0;
            this.txtAguaAnti.Size = new System.Drawing.Size(364, 328);
            this.txtAguaAnti.TabIndex = 0;
            this.txtAguaAnti.SelectedIndexChanged += new System.EventHandler(this.txtAguaAnti_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.txtEletricaCons);
            this.tabPage1.Controls.Add(this.txtEletricaAtu);
            this.tabPage1.Controls.Add(this.txtEletricaAnt);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(356, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Energia elétrica";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtEletricaCons
            // 
            this.txtEletricaCons.Location = new System.Drawing.Point(130, 154);
            this.txtEletricaCons.Name = "txtEletricaCons";
            this.txtEletricaCons.Size = new System.Drawing.Size(147, 20);
            this.txtEletricaCons.TabIndex = 13;
            this.txtEletricaCons.TextChanged += new System.EventHandler(this.txtEletricaCons_TextChanged);
            // 
            // txtEletricaAtu
            // 
            this.txtEletricaAtu.Location = new System.Drawing.Point(130, 106);
            this.txtEletricaAtu.Name = "txtEletricaAtu";
            this.txtEletricaAtu.Size = new System.Drawing.Size(147, 20);
            this.txtEletricaAtu.TabIndex = 12;
            this.txtEletricaAtu.TextChanged += new System.EventHandler(this.txtEletricaAtu_TextChanged);
            // 
            // txtEletricaAnt
            // 
            this.txtEletricaAnt.Location = new System.Drawing.Point(130, 58);
            this.txtEletricaAnt.Name = "txtEletricaAnt";
            this.txtEletricaAnt.Size = new System.Drawing.Size(147, 20);
            this.txtEletricaAnt.TabIndex = 11;
            this.txtEletricaAnt.TextChanged += new System.EventHandler(this.txtEletricaAnt_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Constante";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Leitura atual";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Leitura anterior";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.txtAgueAtua);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(356, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Água";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // txtAgueAtua
            // 
            this.txtAgueAtua.Location = new System.Drawing.Point(146, 103);
            this.txtAgueAtua.Name = "txtAgueAtua";
            this.txtAgueAtua.Size = new System.Drawing.Size(147, 20);
            this.txtAgueAtua.TabIndex = 19;
            this.txtAgueAtua.TextChanged += new System.EventHandler(this.txtAgueAtua_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(146, 55);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(147, 20);
            this.textBox6.TabIndex = 18;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 27);
            this.button2.TabIndex = 17;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Leitura atual";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Leitura anterior";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 363);
            this.Controls.Add(this.txtAguaAnti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.txtAguaAnti.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl txtAguaAnti;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtEletricaCons;
        private System.Windows.Forms.TextBox txtEletricaAtu;
        private System.Windows.Forms.TextBox txtEletricaAnt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAgueAtua;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

