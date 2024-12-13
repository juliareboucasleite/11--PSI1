using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Fechar a aplicação.
        /// </summary>

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
             this.Close(); 

        }
        /// <summary>
        /// Acrescentar texto ao labelMensagem
        /// </summary>
        private void BotaoTexto_Click(object sender, EventArgs e)
        {
            LabelMensagem.Text += " É legal";
        }
    }
}
