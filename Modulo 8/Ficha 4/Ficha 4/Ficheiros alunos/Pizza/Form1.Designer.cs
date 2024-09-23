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
            this.ListaPizza = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BebidaSumoComGas = new System.Windows.Forms.CheckBox();
            this.BebidaSumoSemGas = new System.Windows.Forms.CheckBox();
            this.BebidaCocaCola = new System.Windows.Forms.CheckBox();
            this.BebidaAgua = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EntregaCasa = new System.Windows.Forms.RadioButton();
            this.EntregaTakeAway = new System.Windows.Forms.RadioButton();
            this.Entradas = new System.Windows.Forms.ComboBox();
            this.QuantidadeEntrada = new System.Windows.Forms.NumericUpDown();
            this.ImagemPizza = new System.Windows.Forms.PictureBox();
            this.LabelTotalComIva = new System.Windows.Forms.Label();
            this.LabelTotalSemIva = new System.Windows.Forms.Label();
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
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Morada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contacto:";
            // 
            // Nome
            // 
            this.Nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nome.Location = new System.Drawing.Point(96, 78);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(254, 20);
            this.Nome.TabIndex = 4;
            // 
            // Morada
            // 
            this.Morada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Morada.Location = new System.Drawing.Point(96, 110);
            this.Morada.Name = "Morada";
            this.Morada.Size = new System.Drawing.Size(254, 20);
            this.Morada.TabIndex = 6;
            // 
            // Contacto
            // 
            this.Contacto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contacto.Location = new System.Drawing.Point(96, 139);
            this.Contacto.Name = "Contacto";
            this.Contacto.Size = new System.Drawing.Size(147, 20);
            this.Contacto.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Entrada:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total (com IVA)";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(528, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total (sem IVA):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Pizza:";
            // 
            // ListaPizza
            // 
            this.ListaPizza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaPizza.FormattingEnabled = true;
            this.ListaPizza.Location = new System.Drawing.Point(20, 279);
            this.ListaPizza.Name = "ListaPizza";
            this.ListaPizza.Size = new System.Drawing.Size(196, 82);
            this.ListaPizza.TabIndex = 14;
            this.ListaPizza.SelectedIndexChanged += new System.EventHandler(this.ListaPizza_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BebidaSumoComGas);
            this.groupBox1.Controls.Add(this.BebidaSumoSemGas);
            this.groupBox1.Controls.Add(this.BebidaCocaCola);
            this.groupBox1.Controls.Add(this.BebidaAgua);
            this.groupBox1.Location = new System.Drawing.Point(31, 393);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 56);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bebidas:";
            // 
            // BebidaSumoComGas
            // 
            this.BebidaSumoComGas.AutoSize = true;
            this.BebidaSumoComGas.Location = new System.Drawing.Point(390, 19);
            this.BebidaSumoComGas.Name = "BebidaSumoComGas";
            this.BebidaSumoComGas.Size = new System.Drawing.Size(180, 17);
            this.BebidaSumoComGas.TabIndex = 20;
            this.BebidaSumoComGas.Text = "Sumo de maçã (Com gás): €1,50";
            this.BebidaSumoComGas.UseVisualStyleBackColor = true;
            this.BebidaSumoComGas.CheckedChanged += new System.EventHandler(this.BebidaSumoComGas_CheckedChanged_1);
            // 
            // BebidaSumoSemGas
            // 
            this.BebidaSumoSemGas.AutoSize = true;
            this.BebidaSumoSemGas.Location = new System.Drawing.Point(204, 19);
            this.BebidaSumoSemGas.Name = "BebidaSumoSemGas";
            this.BebidaSumoSemGas.Size = new System.Drawing.Size(180, 17);
            this.BebidaSumoSemGas.TabIndex = 20;
            this.BebidaSumoSemGas.Text = "Sumo de maçã (Sem gás): €1,50";
            this.BebidaSumoSemGas.UseVisualStyleBackColor = true;
            this.BebidaSumoSemGas.CheckedChanged += new System.EventHandler(this.BebidaSumoSemGas_CheckedChanged_1);
            // 
            // BebidaCocaCola
            // 
            this.BebidaCocaCola.AutoSize = true;
            this.BebidaCocaCola.Location = new System.Drawing.Point(90, 19);
            this.BebidaCocaCola.Name = "BebidaCocaCola";
            this.BebidaCocaCola.Size = new System.Drawing.Size(108, 17);
            this.BebidaCocaCola.TabIndex = 20;
            this.BebidaCocaCola.Text = "Coca-Cola: €1,90";
            this.BebidaCocaCola.UseVisualStyleBackColor = true;
            this.BebidaCocaCola.CheckedChanged += new System.EventHandler(this.BebidaCocaCola_CheckedChanged);
            // 
            // BebidaAgua
            // 
            this.BebidaAgua.AutoSize = true;
            this.BebidaAgua.Location = new System.Drawing.Point(15, 19);
            this.BebidaAgua.Name = "BebidaAgua";
            this.BebidaAgua.Size = new System.Drawing.Size(69, 17);
            this.BebidaAgua.TabIndex = 0;
            this.BebidaAgua.Text = "Água: €1";
            this.BebidaAgua.UseVisualStyleBackColor = true;
            this.BebidaAgua.CheckedChanged += new System.EventHandler(this.BebidaAgua_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.EntregaCasa);
            this.groupBox2.Controls.Add(this.EntregaTakeAway);
            this.groupBox2.Location = new System.Drawing.Point(31, 482);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 48);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Método de Entrega:";
            // 
            // EntregaCasa
            // 
            this.EntregaCasa.AutoSize = true;
            this.EntregaCasa.Location = new System.Drawing.Point(116, 19);
            this.EntregaCasa.Name = "EntregaCasa";
            this.EntregaCasa.Size = new System.Drawing.Size(107, 17);
            this.EntregaCasa.TabIndex = 21;
            this.EntregaCasa.TabStop = true;
            this.EntregaCasa.Text = "Entrega Casa: €1";
            this.EntregaCasa.UseVisualStyleBackColor = true;
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
            this.EntregaTakeAway.CheckedChanged += new System.EventHandler(this.EntregaTakeAway_CheckedChanged);
            // 
            // Entradas
            // 
            this.Entradas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Entradas.FormattingEnabled = true;
            this.Entradas.Location = new System.Drawing.Point(96, 196);
            this.Entradas.Name = "Entradas";
            this.Entradas.Size = new System.Drawing.Size(254, 21);
            this.Entradas.TabIndex = 10;
            this.Entradas.SelectedIndexChanged += new System.EventHandler(this.Entradas_SelectedValueChanged);
            // 
            // QuantidadeEntrada
            // 
            this.QuantidadeEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuantidadeEntrada.Location = new System.Drawing.Point(96, 224);
            this.QuantidadeEntrada.Name = "QuantidadeEntrada";
            this.QuantidadeEntrada.Size = new System.Drawing.Size(56, 20);
            this.QuantidadeEntrada.TabIndex = 12;
            this.QuantidadeEntrada.ValueChanged += new System.EventHandler(this.QuantidadeEntrada_ValueChanged);
            // 
            // ImagemPizza
            // 
            this.ImagemPizza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagemPizza.Location = new System.Drawing.Point(250, 279);
            this.ImagemPizza.Name = "ImagemPizza";
            this.ImagemPizza.Size = new System.Drawing.Size(100, 92);
            this.ImagemPizza.TabIndex = 19;
            this.ImagemPizza.TabStop = false;
            // 
            // LabelTotalComIva
            // 
            this.LabelTotalComIva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTotalComIva.AutoSize = true;
            this.LabelTotalComIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalComIva.ForeColor = System.Drawing.Color.Maroon;
            this.LabelTotalComIva.Location = new System.Drawing.Point(542, 174);
            this.LabelTotalComIva.Name = "LabelTotalComIva";
            this.LabelTotalComIva.Size = new System.Drawing.Size(55, 16);
            this.LabelTotalComIva.TabIndex = 20;
            this.LabelTotalComIva.Text = "Total €";
            // 
            // LabelTotalSemIva
            // 
            this.LabelTotalSemIva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTotalSemIva.AutoSize = true;
            this.LabelTotalSemIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalSemIva.ForeColor = System.Drawing.Color.Green;
            this.LabelTotalSemIva.Location = new System.Drawing.Point(542, 98);
            this.LabelTotalSemIva.Name = "LabelTotalSemIva";
            this.LabelTotalSemIva.Size = new System.Drawing.Size(55, 16);
            this.LabelTotalSemIva.TabIndex = 18;
            this.LabelTotalSemIva.Text = "Total €";
            // 
            // BotaoValidar
            // 
            this.BotaoValidar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoValidar.Location = new System.Drawing.Point(412, 563);
            this.BotaoValidar.Name = "BotaoValidar";
            this.BotaoValidar.Size = new System.Drawing.Size(75, 23);
            this.BotaoValidar.TabIndex = 21;
            this.BotaoValidar.Text = "Validar";
            this.BotaoValidar.UseVisualStyleBackColor = true;
            this.BotaoValidar.Click += new System.EventHandler(this.BotaoValidar_Click);
            // 
            // BotaoAnular
            // 
            this.BotaoAnular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoAnular.Location = new System.Drawing.Point(508, 563);
            this.BotaoAnular.Name = "BotaoAnular";
            this.BotaoAnular.Size = new System.Drawing.Size(75, 23);
            this.BotaoAnular.TabIndex = 22;
            this.BotaoAnular.Text = "Anular";
            this.BotaoAnular.UseVisualStyleBackColor = true;
            this.BotaoAnular.Click += new System.EventHandler(this.BotaoAnular_Click);
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BotaoFechar.Location = new System.Drawing.Point(606, 563);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(75, 23);
            this.BotaoFechar.TabIndex = 23;
            this.BotaoFechar.Text = "Fechar";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(307, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Registo de Encomendas";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Brush Script MT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(13, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 46);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pizzaria";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Brush Script MT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(139, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 46);
            this.label13.TabIndex = 1;
            this.label13.Text = "Luigi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BotaoFechar;
            this.ClientSize = new System.Drawing.Size(712, 596);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BotaoFechar);
            this.Controls.Add(this.BotaoAnular);
            this.Controls.Add(this.BotaoValidar);
            this.Controls.Add(this.LabelTotalSemIva);
            this.Controls.Add(this.LabelTotalComIva);
            this.Controls.Add(this.ImagemPizza);
            this.Controls.Add(this.QuantidadeEntrada);
            this.Controls.Add(this.Entradas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListaPizza);
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
        private System.Windows.Forms.ListBox ListaPizza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Entradas;
        private System.Windows.Forms.NumericUpDown QuantidadeEntrada;
        private System.Windows.Forms.PictureBox ImagemPizza;
        private System.Windows.Forms.CheckBox BebidaSumoComGas;
        private System.Windows.Forms.CheckBox BebidaSumoSemGas;
        private System.Windows.Forms.CheckBox BebidaCocaCola;
        private System.Windows.Forms.CheckBox BebidaAgua;
        private System.Windows.Forms.RadioButton EntregaCasa;
        private System.Windows.Forms.RadioButton EntregaTakeAway;
        private System.Windows.Forms.Label LabelTotalComIva;
        private System.Windows.Forms.Label LabelTotalSemIva;
        private System.Windows.Forms.Button BotaoValidar;
        private System.Windows.Forms.Button BotaoAnular;
        private System.Windows.Forms.Button BotaoFechar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
    }
}

