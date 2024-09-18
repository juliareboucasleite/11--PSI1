namespace Ficha_3
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
            this.PrimeiroNome = new System.Windows.Forms.Label();
            this.Apelido = new System.Windows.Forms.Label();
            this.NomeCompleto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Concatenar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrimeiroNome
            // 
            this.PrimeiroNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimeiroNome.AutoSize = true;
            this.PrimeiroNome.Location = new System.Drawing.Point(12, 21);
            this.PrimeiroNome.Name = "PrimeiroNome";
            this.PrimeiroNome.Size = new System.Drawing.Size(76, 13);
            this.PrimeiroNome.TabIndex = 0;
            this.PrimeiroNome.Text = "&Primeiro nome:";
            this.PrimeiroNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // Apelido
            // 
            this.Apelido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Apelido.AutoSize = true;
            this.Apelido.Location = new System.Drawing.Point(12, 47);
            this.Apelido.Name = "Apelido";
            this.Apelido.Size = new System.Drawing.Size(45, 13);
            this.Apelido.TabIndex = 1;
            this.Apelido.Text = "&Apelido:";
            // 
            // NomeCompleto
            // 
            this.NomeCompleto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NomeCompleto.AutoSize = true;
            this.NomeCompleto.Location = new System.Drawing.Point(12, 73);
            this.NomeCompleto.Name = "NomeCompleto";
            this.NomeCompleto.Size = new System.Drawing.Size(84, 13);
            this.NomeCompleto.TabIndex = 2;
            this.NomeCompleto.Text = "&Nome completo:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(102, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(102, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(102, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Concatenar
            // 
            this.Concatenar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Concatenar.Location = new System.Drawing.Point(84, 115);
            this.Concatenar.Name = "Concatenar";
            this.Concatenar.Size = new System.Drawing.Size(75, 23);
            this.Concatenar.TabIndex = 6;
            this.Concatenar.Text = "&Concatenar";
            this.Concatenar.UseVisualStyleBackColor = true;
            this.Concatenar.Click += new System.EventHandler(this.Concatenar_Click);
            // 
            // Limpar
            // 
            this.Limpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Limpar.Location = new System.Drawing.Point(180, 115);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(75, 23);
            this.Limpar.TabIndex = 7;
            this.Limpar.Text = "&Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Fechar
            // 
            this.Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Fechar.Location = new System.Drawing.Point(278, 114);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(75, 23);
            this.Fechar.TabIndex = 8;
            this.Fechar.Text = "&Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 150);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Concatenar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NomeCompleto);
            this.Controls.Add(this.Apelido);
            this.Controls.Add(this.PrimeiroNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(399, 189);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concatenar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrimeiroNome;
        private System.Windows.Forms.Label Apelido;
        private System.Windows.Forms.Label NomeCompleto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Concatenar;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Fechar;
    }
}

