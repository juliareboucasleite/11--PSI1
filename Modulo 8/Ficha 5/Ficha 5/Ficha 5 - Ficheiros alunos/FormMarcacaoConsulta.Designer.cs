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
            this.Paciente = new System.Windows.Forms.ComboBox();
            this.Medico = new System.Windows.Forms.ComboBox();
            this.DataConsulta = new System.Windows.Forms.DateTimePicker();
            this.HoraConsulta = new System.Windows.Forms.DateTimePicker();
            this.MotivosConsulta = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SubsistemaSns = new System.Windows.Forms.RadioButton();
            this.SubsistemaAdse = new System.Windows.Forms.RadioButton();
            this.SubsistemaSams = new System.Windows.Forms.RadioButton();
            this.SubsistemaMedis = new System.Windows.Forms.RadioButton();
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
            this.Paciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Paciente.Location = new System.Drawing.Point(78, 75);
            this.Paciente.Name = "Paciente";
            this.Paciente.Size = new System.Drawing.Size(289, 21);
            this.Paciente.TabIndex = 1;
            // 
            // Medico
            // 
            this.Medico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Medico.Location = new System.Drawing.Point(78, 102);
            this.Medico.Name = "Medico";
            this.Medico.Size = new System.Drawing.Size(289, 21);
            this.Medico.TabIndex = 3;
            // 
            // DataConsulta
            // 
            this.DataConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataConsulta.Location = new System.Drawing.Point(78, 129);
            this.DataConsulta.Name = "DataConsulta";
            this.DataConsulta.Size = new System.Drawing.Size(200, 20);
            this.DataConsulta.TabIndex = 5;
            // 
            // HoraConsulta
            // 
            this.HoraConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HoraConsulta.Location = new System.Drawing.Point(78, 155);
            this.HoraConsulta.Name = "HoraConsulta";
            this.HoraConsulta.Size = new System.Drawing.Size(94, 20);
            this.HoraConsulta.TabIndex = 7;
            this.HoraConsulta.Value = new System.DateTime(2024, 9, 25, 16, 20, 0, 0);
            // 
            // MotivosConsulta
            // 
            this.MotivosConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MotivosConsulta.FormattingEnabled = true;
            this.MotivosConsulta.Location = new System.Drawing.Point(20, 214);
            this.MotivosConsulta.Name = "MotivosConsulta";
            this.MotivosConsulta.Size = new System.Drawing.Size(422, 109);
            this.MotivosConsulta.TabIndex = 9;
            this.MotivosConsulta.Tag = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SubsistemaMedis);
            this.groupBox1.Controls.Add(this.SubsistemaAdse);
            this.groupBox1.Controls.Add(this.SubsistemaSams);
            this.groupBox1.Controls.Add(this.SubsistemaSns);
            this.groupBox1.Location = new System.Drawing.Point(20, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 48);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Subsistema de Saúde";
            // 
            // SubsistemaSns
            // 
            this.SubsistemaSns.AutoSize = true;
            this.SubsistemaSns.Location = new System.Drawing.Point(7, 20);
            this.SubsistemaSns.Name = "SubsistemaSns";
            this.SubsistemaSns.Size = new System.Drawing.Size(47, 17);
            this.SubsistemaSns.TabIndex = 0;
            this.SubsistemaSns.TabStop = true;
            this.SubsistemaSns.Text = "SNS";
            this.SubsistemaSns.UseVisualStyleBackColor = true;
            // 
            // SubsistemaAdse
            // 
            this.SubsistemaAdse.AutoSize = true;
            this.SubsistemaAdse.Location = new System.Drawing.Point(98, 20);
            this.SubsistemaAdse.Name = "SubsistemaAdse";
            this.SubsistemaAdse.Size = new System.Drawing.Size(54, 17);
            this.SubsistemaAdse.TabIndex = 1;
            this.SubsistemaAdse.TabStop = true;
            this.SubsistemaAdse.Text = "ADSE";
            this.SubsistemaAdse.UseVisualStyleBackColor = true;
            // 
            // SubsistemaSams
            // 
            this.SubsistemaSams.AutoSize = true;
            this.SubsistemaSams.Location = new System.Drawing.Point(189, 19);
            this.SubsistemaSams.Name = "SubsistemaSams";
            this.SubsistemaSams.Size = new System.Drawing.Size(55, 17);
            this.SubsistemaSams.TabIndex = 2;
            this.SubsistemaSams.TabStop = true;
            this.SubsistemaSams.Text = "SAMS";
            this.SubsistemaSams.UseVisualStyleBackColor = true;
            // 
            // SubsistemaMedis
            // 
            this.SubsistemaMedis.AutoSize = true;
            this.SubsistemaMedis.Location = new System.Drawing.Point(280, 20);
            this.SubsistemaMedis.Name = "SubsistemaMedis";
            this.SubsistemaMedis.Size = new System.Drawing.Size(53, 17);
            this.SubsistemaMedis.TabIndex = 3;
            this.SubsistemaMedis.TabStop = true;
            this.SubsistemaMedis.Text = "Médis";
            this.SubsistemaMedis.UseVisualStyleBackColor = true;
            // 
            // BotaoMarcar
            // 
            this.BotaoMarcar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoMarcar.Location = new System.Drawing.Point(254, 415);
            this.BotaoMarcar.Name = "BotaoMarcar";
            this.BotaoMarcar.Size = new System.Drawing.Size(75, 23);
            this.BotaoMarcar.TabIndex = 11;
            this.BotaoMarcar.Text = "&Marcar";
            this.BotaoMarcar.UseVisualStyleBackColor = true;
            this.BotaoMarcar.Click += new System.EventHandler(this.BotaoMarcar_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoCancelar.Location = new System.Drawing.Point(346, 415);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancelar.TabIndex = 12;
            this.BotaoCancelar.Text = "&Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Paciente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Medico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "&Hora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Motivos da Consulta:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(15, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Clínica de Coimbra";
            // 
            // FormMarcacaoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(466, 450);
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
            this.Controls.Add(this.HoraConsulta);
            this.Controls.Add(this.DataConsulta);
            this.Controls.Add(this.Medico);
            this.Controls.Add(this.Paciente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMarcacaoConsulta";
            this.Text = "Marcação de Consulta";
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