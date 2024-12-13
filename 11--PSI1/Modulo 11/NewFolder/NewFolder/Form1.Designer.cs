namespace NewFolder
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
            this.BotaoBrowse = new System.Windows.Forms.Button();
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.BotaoCriarPasta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LocalizacaoPasta = new System.Windows.Forms.TextBox();
            this.NomePasta = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BotaoBrowse
            // 
            this.BotaoBrowse.Location = new System.Drawing.Point(502, 152);
            this.BotaoBrowse.Name = "BotaoBrowse";
            this.BotaoBrowse.Size = new System.Drawing.Size(75, 23);
            this.BotaoBrowse.TabIndex = 0;
            this.BotaoBrowse.Text = "&Browse...";
            this.BotaoBrowse.UseVisualStyleBackColor = true;
            this.BotaoBrowse.Click += new System.EventHandler(this.BotaoBrowse_Click);
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Location = new System.Drawing.Point(502, 415);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(75, 23);
            this.BotaoFechar.TabIndex = 1;
            this.BotaoFechar.Text = "&Fechar";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // BotaoCriarPasta
            // 
            this.BotaoCriarPasta.Location = new System.Drawing.Point(109, 229);
            this.BotaoCriarPasta.Name = "BotaoCriarPasta";
            this.BotaoCriarPasta.Size = new System.Drawing.Size(75, 23);
            this.BotaoCriarPasta.TabIndex = 2;
            this.BotaoCriarPasta.Text = "&Criar Pasta";
            this.BotaoCriarPasta.UseVisualStyleBackColor = true;
            this.BotaoCriarPasta.Click += new System.EventHandler(this.BotaoCriarPasta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FolderNew";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "&Localização:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "&Nome:";
            // 
            // LocalizacaoPasta
            // 
            this.LocalizacaoPasta.Location = new System.Drawing.Point(109, 152);
            this.LocalizacaoPasta.Name = "LocalizacaoPasta";
            this.LocalizacaoPasta.Size = new System.Drawing.Size(370, 20);
            this.LocalizacaoPasta.TabIndex = 8;
            // 
            // NomePasta
            // 
            this.NomePasta.Location = new System.Drawing.Point(109, 187);
            this.NomePasta.Name = "NomePasta";
            this.NomePasta.Size = new System.Drawing.Size(306, 20);
            this.NomePasta.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "&Resultado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 87);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(39, 283);
            this.Resultado.Multiline = true;
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(538, 87);
            this.Resultado.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NomePasta);
            this.Controls.Add(this.LocalizacaoPasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotaoCriarPasta);
            this.Controls.Add(this.BotaoFechar);
            this.Controls.Add(this.BotaoBrowse);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotaoBrowse;
        private System.Windows.Forms.Button BotaoFechar;
        private System.Windows.Forms.Button BotaoCriarPasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LocalizacaoPasta;
        private System.Windows.Forms.TextBox NomePasta;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Resultado;
    }
}

