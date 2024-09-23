using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        private Encomenda encomendaCliente = new Encomenda();

        public Form1()
        {
            InitializeComponent();
            // A janela deverá surgir no centro do ecrã
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Dados de Encomenda";
            // Inicializar as entradas
            Entradas.Items.Add("");
            Entradas.Items.Add("Pão de alho (2 unidades): €2,50");
            Entradas.Items.Add("Pão de alho supremo (2 unidades): €3,50");
            // Impedir que o utilizador possa editar o texto da combobox
            Entradas.DropDownStyle = ComboBoxStyle.DropDownList;
            // Quantidade das entradas
            QuantidadeEntrada.Minimum = 0;
            QuantidadeEntrada.Maximum = 4;
            QuantidadeEntrada.Enabled = false;
            // Inicializar as pizzas
            ListasPizzas.Items.Add("(selecione pizza)");
            ListasPizzas.Items.Add("Pizza Margherita: €5,00");
            ListasPizzas.Items.Add("Pizza Camponesa: €7,00");
            ListasPizzas.Items.Add("Pizza Vegetariana: €6,80");
            // Selecionar o 1o elemento da lista
            ListasPizzas.SelectedIndex = 0;
            ImagemPizza.BorderStyle = BorderStyle.FixedSingle;
            ImagemPizza.SizeMode = PictureBoxSizeMode.StretchImage;
            // Pré-selecionar entrega take away
            EntregaTakeAway.Checked = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
