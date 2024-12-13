namespace Ficha_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.LabelMensagem = new System.Windows.Forms.Label();
            this.BotaoTexto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Location = new System.Drawing.Point(196, 153);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(75, 23);
            this.BotaoFechar.TabIndex = 0;
            this.BotaoFechar.Text = "Fechar";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // LabelMensagem
            // 
            this.LabelMensagem.Location = new System.Drawing.Point(29, 29);
            this.LabelMensagem.Name = "LabelMensagem";
            this.LabelMensagem.Size = new System.Drawing.Size(327, 105);
            this.LabelMensagem.TabIndex = 1;
            this.LabelMensagem.Text = "Programação e Sistema de Informação";
            // 
            // BotaoTexto
            // 
            this.BotaoTexto.Location = new System.Drawing.Point(82, 153);
            this.BotaoTexto.Name = "BotaoTexto";
            this.BotaoTexto.Size = new System.Drawing.Size(91, 23);
            this.BotaoTexto.TabIndex = 2;
            this.BotaoTexto.Text = "MudarTexto";
            this.BotaoTexto.UseVisualStyleBackColor = true;
            this.BotaoTexto.Click += new System.EventHandler(this.BotaoTexto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.BotaoTexto);
            this.Controls.Add(this.LabelMensagem);
            this.Controls.Add(this.BotaoFechar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotaoFechar;
        private System.Windows.Forms.Label LabelMensagem;
        private System.Windows.Forms.Button BotaoTexto;
    }
}

