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
        /// Caixa do Primeiro Nome
        /// </summary>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Caixa do Apelido
        /// </summary>
       
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Caixa do nome Completo
        /// </summary>
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Botao concatenar
        /// </summary>
        private void Concatenar_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Botao Limpar
        /// </summary>
         private void Limpar_Click(object sender, EventArgs e)
        {
            // Limpando os TextBox
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            

        }
        /// <summary>
        /// Botao fechar
        /// </summary>
        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
