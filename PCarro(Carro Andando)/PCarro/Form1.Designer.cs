namespace PCarro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMov = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnRe = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVelo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtMarca = new System.Windows.Forms.ComboBox();
            this.txtCombu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMov
            // 
            this.btnMov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMov.ForeColor = System.Drawing.Color.Transparent;
            this.btnMov.Location = new System.Drawing.Point(0, 288);
            this.btnMov.Name = "btnMov";
            this.btnMov.Size = new System.Drawing.Size(153, 30);
            this.btnMov.TabIndex = 2;
            this.btnMov.Text = "Movimentar";
            this.btnMov.UseVisualStyleBackColor = true;
            this.btnMov.Click += new System.EventHandler(this.btnMov_Click);
            // 
            // btnParar
            // 
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParar.ForeColor = System.Drawing.Color.Transparent;
            this.btnParar.Location = new System.Drawing.Point(152, 288);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(169, 30);
            this.btnParar.TabIndex = 3;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnRe
            // 
            this.btnRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRe.ForeColor = System.Drawing.Color.Transparent;
            this.btnRe.Location = new System.Drawing.Point(318, 288);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(163, 30);
            this.btnRe.TabIndex = 4;
            this.btnRe.Text = "Ré";
            this.btnRe.UseVisualStyleBackColor = true;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.Transparent;
            this.btnSair.Location = new System.Drawing.Point(629, 288);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(160, 30);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVelo
            // 
            this.btnVelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVelo.ForeColor = System.Drawing.Color.Transparent;
            this.btnVelo.Location = new System.Drawing.Point(477, 288);
            this.btnVelo.Name = "btnVelo";
            this.btnVelo.Size = new System.Drawing.Size(153, 30);
            this.btnVelo.TabIndex = 5;
            this.btnVelo.Text = "Consultar Velocidade";
            this.btnVelo.UseVisualStyleBackColor = true;
            this.btnVelo.Click += new System.EventHandler(this.btnVelo_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(378, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Combustivél";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 142);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 161);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(345, 129);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // txtMarca
            // 
            this.txtMarca.FormattingEnabled = true;
            this.txtMarca.Items.AddRange(new object[] {
            "Ferrari",
            "Skyline",
            "Ford",
            "Fiat",
            "Honda"});
            this.txtMarca.Location = new System.Drawing.Point(71, 3);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(229, 21);
            this.txtMarca.TabIndex = 13;
            // 
            // txtCombu
            // 
            this.txtCombu.FormattingEnabled = true;
            this.txtCombu.Items.AddRange(new object[] {
            "Combustivél",
            "Álcool"});
            this.txtCombu.Location = new System.Drawing.Point(516, 3);
            this.txtCombu.Name = "txtCombu";
            this.txtCombu.Size = new System.Drawing.Size(229, 21);
            this.txtCombu.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 317);
            this.Controls.Add(this.txtCombu);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVelo);
            this.Controls.Add(this.btnRe);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnMov);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMov;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnRe;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVelo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox txtMarca;
        private System.Windows.Forms.ComboBox txtCombu;
    }
}

