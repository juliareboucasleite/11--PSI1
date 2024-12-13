namespace Ficha5
{
    partial class FormMarcacaoConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMarcacaoConsulta));
            this.Paciente = new System.Windows.Forms.ComboBox();
            this.Medico = new System.Windows.Forms.ComboBox();
            this.DataConsulta = new System.Windows.Forms.DateTimePicker();
            this.HoraConsulta = new System.Windows.Forms.DateTimePicker();
            this.MotivosConsulta = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SubsistemaMedis = new System.Windows.Forms.RadioButton();
            this.SubsistemaAdse = new System.Windows.Forms.RadioButton();
            this.SubsistemaSams = new System.Windows.Forms.RadioButton();
            this.SubsistemaSns = new System.Windows.Forms.RadioButton();
            this.BotaoMarcar = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Paciente
            // 
            resources.ApplyResources(this.Paciente, "Paciente");
            this.Paciente.Name = "Paciente";
            // 
            // Medico
            // 
            resources.ApplyResources(this.Medico, "Medico");
            this.Medico.Name = "Medico";
            // 
            // DataConsulta
            // 
            resources.ApplyResources(this.DataConsulta, "DataConsulta");
            this.DataConsulta.Name = "DataConsulta";
            // 
            // HoraConsulta
            // 
            resources.ApplyResources(this.HoraConsulta, "HoraConsulta");
            this.HoraConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraConsulta.Name = "HoraConsulta";
            this.HoraConsulta.Value = new System.DateTime(2024, 9, 25, 16, 20, 0, 0);
            // 
            // MotivosConsulta
            // 
            resources.ApplyResources(this.MotivosConsulta, "MotivosConsulta");
            this.MotivosConsulta.FormattingEnabled = true;
            this.MotivosConsulta.Name = "MotivosConsulta";
            this.MotivosConsulta.Tag = "";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.SubsistemaMedis);
            this.groupBox1.Controls.Add(this.SubsistemaAdse);
            this.groupBox1.Controls.Add(this.SubsistemaSams);
            this.groupBox1.Controls.Add(this.SubsistemaSns);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // SubsistemaMedis
            // 
            resources.ApplyResources(this.SubsistemaMedis, "SubsistemaMedis");
            this.SubsistemaMedis.Name = "SubsistemaMedis";
            this.SubsistemaMedis.TabStop = true;
            this.SubsistemaMedis.UseVisualStyleBackColor = true;
            // 
            // SubsistemaAdse
            // 
            resources.ApplyResources(this.SubsistemaAdse, "SubsistemaAdse");
            this.SubsistemaAdse.Name = "SubsistemaAdse";
            this.SubsistemaAdse.TabStop = true;
            this.SubsistemaAdse.UseVisualStyleBackColor = true;
            // 
            // SubsistemaSams
            // 
            resources.ApplyResources(this.SubsistemaSams, "SubsistemaSams");
            this.SubsistemaSams.Name = "SubsistemaSams";
            this.SubsistemaSams.TabStop = true;
            this.SubsistemaSams.UseVisualStyleBackColor = true;
            // 
            // SubsistemaSns
            // 
            resources.ApplyResources(this.SubsistemaSns, "SubsistemaSns");
            this.SubsistemaSns.Name = "SubsistemaSns";
            this.SubsistemaSns.TabStop = true;
            this.SubsistemaSns.UseVisualStyleBackColor = true;
            // 
            // BotaoMarcar
            // 
            resources.ApplyResources(this.BotaoMarcar, "BotaoMarcar");
            this.BotaoMarcar.Name = "BotaoMarcar";
            this.BotaoMarcar.UseVisualStyleBackColor = true;
            this.BotaoMarcar.Click += new System.EventHandler(this.BotaoMarcar_Click);
            // 
            // BotaoCancelar
            // 
            resources.ApplyResources(this.BotaoCancelar, "BotaoCancelar");
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Name = "label6";
            // 
            // FormMarcacaoConsulta
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.HoraConsulta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.BotaoMarcar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MotivosConsulta);
            this.Controls.Add(this.DataConsulta);
            this.Controls.Add(this.Medico);
            this.Controls.Add(this.Paciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMarcacaoConsulta";
            this.Load += new System.EventHandler(this.FormMarcacaoConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Paciente;
        private System.Windows.Forms.ComboBox Medico;
        private System.Windows.Forms.DateTimePicker DataConsulta;
        private System.Windows.Forms.DateTimePicker HoraConsulta;
        private System.Windows.Forms.CheckedListBox MotivosConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SubsistemaMedis;
        private System.Windows.Forms.RadioButton SubsistemaAdse;
        private System.Windows.Forms.RadioButton SubsistemaSams;
        private System.Windows.Forms.RadioButton SubsistemaSns;
        private System.Windows.Forms.Button BotaoMarcar;
        private System.Windows.Forms.Button BotaoCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}