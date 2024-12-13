using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ficha_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Botao Limpar
        /// </summary>
         private void Limpar_Click(object sender, EventArgs e)
        {
            // Limpando os TextBox
            PrimeiroNome.Text = "";
            Apelido.Text = "";
            NomeCompleto.Text = "";

            

        }
        /// <summary>
        /// Botao fechar
        /// </summary>
        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotaoConcatenar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(NomeCompleto.Text = PrimeiroNome.Text + " " + Apelido.Text, "Nome Completto");
        }
    }
}
