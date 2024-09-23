namespace Pizza
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Morada = new System.Windows.Forms.TextBox();
            this.Contacto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ListasPizzas = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.EntregaTakeAway = new System.Windows.Forms.RadioButton();
            this.Entradas = new System.Windows.Forms.ComboBox();
            this.QuantidadeEntrada = new System.Windows.Forms.NumericUpDown();
            this.ImagemPizza = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BotaoValidar = new System.Windows.Forms.Button();
            this.BotaoAnular = new System.Windows.Forms.Button();
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantidadeEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Morada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contacto:";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(96, 78);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(254, 20);
            this.Nome.TabIndex = 4;
            // 
            // Morada
            // 
            this.Morada.Location = new System.Drawing.Point(96, 110);
            this.Morada.Name = "Morada";
            this.Morada.Size = new System.Drawing.Size(254, 20);
            this.Morada.TabIndex = 5;
            this.Morada.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Contacto
            // 
            this.Contacto.Location = new System.Drawing.Point(96, 139);
            this.Contacto.Name = "Contacto";
            this.Contacto.Size = new System.Drawing.Size(147, 20);
            this.Contacto.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Entrada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total (com IVA)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(528, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total (sem IVA):";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Pizza:";
            // 
            // ListasPizzas
            // 
            this.ListasPizzas.FormattingEnabled = true;
            this.ListasPizzas.Location = new System.Drawing.Point(20, 279);
            this.ListasPizzas.Name = "ListasPizzas";
            this.ListasPizzas.Size = new System.Drawing.Size(196, 82);
            this.ListasPizzas.TabIndex = 14;
            this.ListasPizzas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(31, 393);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 56);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bebidas:";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(390, 19);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(180, 17);
            this.checkBox4.TabIndex = 20;
            this.checkBox4.Text = "Sumo de maçã (Com gás): €1,50";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(204, 19);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(180, 17);
            this.checkBox3.TabIndex = 20;
            this.checkBox3.Text = "Sumo de maçã (Sem gás): €1,50";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(90, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(108, 17);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "Coca-Cola: €1,90";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Água: €1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.EntregaTakeAway);
            this.groupBox2.Location = new System.Drawing.Point(31, 482);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 48);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Método de Entrega:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(116, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 17);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Entrega Casa: €1";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // EntregaTakeAway
            // 
            this.EntregaTakeAway.AutoSize = true;
            this.EntregaTakeAway.Location = new System.Drawing.Point(15, 19);
            this.EntregaTakeAway.Name = "EntregaTakeAway";
            this.EntregaTakeAway.Size = new System.Drawing.Size(97, 17);
            this.EntregaTakeAway.TabIndex = 20;
            this.EntregaTakeAway.TabStop = true;
            this.EntregaTakeAway.Text = "Take Away: €0";
            this.EntregaTakeAway.UseVisualStyleBackColor = true;
            // 
            // Entradas
            // 
            this.Entradas.FormattingEnabled = true;
            this.Entradas.Location = new System.Drawing.Point(96, 196);
            this.Entradas.Name = "Entradas";
            this.Entradas.Size = new System.Drawing.Size(254, 21);
            this.Entradas.TabIndex = 17;
            // 
            // QuantidadeEntrada
            // 
            this.QuantidadeEntrada.Location = new System.Drawing.Point(96, 224);
            this.QuantidadeEntrada.Name = "QuantidadeEntrada";
            this.QuantidadeEntrada.Size = new System.Drawing.Size(56, 20);
            this.QuantidadeEntrada.TabIndex = 18;
            // 
            // ImagemPizza
            // 
            this.ImagemPizza.Location = new System.Drawing.Point(250, 279);
            this.ImagemPizza.Name = "ImagemPizza";
            this.ImagemPizza.Size = new System.Drawing.Size(100, 92);
            this.ImagemPizza.TabIndex = 19;
            this.ImagemPizza.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(542, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(542, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "label12";
            // 
            // BotaoValidar
            // 
            this.BotaoValidar.Location = new System.Drawing.Point(412, 563);
            this.BotaoValidar.Name = "BotaoValidar";
            this.BotaoValidar.Size = new System.Drawing.Size(75, 23);
            this.BotaoValidar.TabIndex = 22;
            this.BotaoValidar.Text = "Validar";
            this.BotaoValidar.UseVisualStyleBackColor = true;
            // 
            // BotaoAnular
            // 
            this.BotaoAnular.Location = new System.Drawing.Point(508, 563);
            this.BotaoAnular.Name = "BotaoAnular";
            this.BotaoAnular.Size = new System.Drawing.Size(75, 23);
            this.BotaoAnular.TabIndex = 23;
            this.BotaoAnular.Text = "Anular";
            this.BotaoAnular.UseVisualStyleBackColor = true;
            this.BotaoAnular.Click += new System.EventHandler(this.button2_Click);
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Location = new System.Drawing.Point(606, 563);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(75, 23);
            this.BotaoFechar.TabIndex = 24;
            this.BotaoFechar.Text = "Fechar";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(307, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Registo de Encomendas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Brush Script MT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(13, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 46);
            this.label10.TabIndex = 26;
            this.label10.Text = "Pizzaria";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Brush Script MT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(139, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 46);
            this.label13.TabIndex = 27;
            this.label13.Text = "Luigi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 596);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BotaoFechar);
            this.Controls.Add(this.BotaoAnular);
            this.Controls.Add(this.BotaoValidar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ImagemPizza);
            this.Controls.Add(this.QuantidadeEntrada);
            this.Controls.Add(this.Entradas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListasPizzas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Contacto);
            this.Controls.Add(this.Morada);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dados de Encomenda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantidadeEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemPizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Morada;
        private System.Windows.Forms.TextBox Contacto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox ListasPizzas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Entradas;
        private System.Windows.Forms.NumericUpDown QuantidadeEntrada;
        private System.Windows.Forms.PictureBox ImagemPizza;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton EntregaTakeAway;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BotaoValidar;
        private System.Windows.Forms.Button BotaoAnular;
        private System.Windows.Forms.Button BotaoFechar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
    }
}

