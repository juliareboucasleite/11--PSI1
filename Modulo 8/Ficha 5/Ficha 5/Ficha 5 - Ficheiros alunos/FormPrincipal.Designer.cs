﻿namespace Ficha5
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ficheirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDaAplicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ListaMarcacoes = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheirosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(195, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // ficheirosToolStripMenuItem
            // 
            this.ficheirosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.ficheirosToolStripMenuItem.Name = "ficheirosToolStripMenuItem";
            this.ficheirosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ficheirosToolStripMenuItem.Text = "&Ficheiros";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaConsultaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "&Consultas";
            // 
            // novaConsultaToolStripMenuItem
            // 
            this.novaConsultaToolStripMenuItem.Name = "novaConsultaToolStripMenuItem";
            this.novaConsultaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.novaConsultaToolStripMenuItem.Text = "&Nova Consulta...";
            this.novaConsultaToolStripMenuItem.Click += new System.EventHandler(this.novaConsultaToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDaAplicaçãoToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // acercaDaAplicaçãoToolStripMenuItem
            // 
            this.acercaDaAplicaçãoToolStripMenuItem.Name = "acercaDaAplicaçãoToolStripMenuItem";
            this.acercaDaAplicaçãoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.acercaDaAplicaçãoToolStripMenuItem.Text = "A&cerca da Aplicação";
            this.acercaDaAplicaçãoToolStripMenuItem.Click += new System.EventHandler(this.acercaDaAplicaçãoToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(35, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "Nova Consulta";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Nova Consulta";
            this.toolStripButton1.Click += new System.EventHandler(this.novaConsultaToolStripMenuItem_Click);
            // 
            // ListaMarcacoes
            // 
            this.ListaMarcacoes.HideSelection = false;
            this.ListaMarcacoes.Location = new System.Drawing.Point(12, 52);
            this.ListaMarcacoes.Name = "ListaMarcacoes";
            this.ListaMarcacoes.Size = new System.Drawing.Size(572, 199);
            this.ListaMarcacoes.TabIndex = 3;
            this.ListaMarcacoes.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 262);
            this.Controls.Add(this.ListaMarcacoes);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Clinica de Coimbra";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ficheirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDaAplicaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListView ListaMarcacoes;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}
