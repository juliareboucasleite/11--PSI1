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
            ListaPizza.Items.Add("(selecione pizza)");
            ListaPizza.Items.Add("Pizza Margherita: €5,00");
            ListaPizza.Items.Add("Pizza Camponesa: €7,00");
            ListaPizza.Items.Add("Pizza Vegetariana: €6,80");
            // Selecionar o 1o elemento da lista
            ListaPizza.SelectedIndex = 0;
            ImagemPizza.BorderStyle = BorderStyle.FixedSingle;
            ImagemPizza.SizeMode = PictureBoxSizeMode.StretchImage;
            // Pré-selecionar entrega take away
            EntregaTakeAway.Checked = true;
        }
        /// <summary>
        /// Calcular e atualizar os totais com base na informação do formulário.
        /// </summary>
        private void AtualizarTotais()
        {
            encomendaCliente.CalcularTotais();
            LabelTotalSemIva.Text = $"{encomendaCliente.TotalSemIva.ToString("C")}";
            LabelTotalComIva.Text = $"{encomendaCliente.TotalComIva.ToString("C")}";
        }
        
       
        /// <summary>
        /// Mudança na quantidade de entradas selecionadas.
        /// </summary>
        private void QuantidadeEntrada_ValueChanged(object sender, EventArgs e)
        {
            encomendaCliente.QuantidadeEntrada = (int)QuantidadeEntrada.Value;
            AtualizarTotais();
        }

        private void Entradas_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (Entradas.SelectedItem.ToString())
            {
                case "":
                    QuantidadeEntrada.Value = 0;
                    QuantidadeEntrada.Enabled = false;
                    break;
                case "Pão de alho (2 unidades): €2,50":
                    encomendaCliente.Entrada = TipoEntrada.PaoAlho;
                    encomendaCliente.QuantidadeEntrada = 1;
                    QuantidadeEntrada.Value = 1;
                    QuantidadeEntrada.Enabled = true;
                    break;
                case "Pão de alho supremo (2 unidades): €3,50":
                    encomendaCliente.Entrada = TipoEntrada.PaoAlhoSupremo;
                    encomendaCliente.QuantidadeEntrada = 1;
                    QuantidadeEntrada.Value = 1;
                    QuantidadeEntrada.Enabled = true;
                    break;
            }
            AtualizarTotais();
        }

        private void ListaPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ListaPizza.SelectedItem)
            {
                case "(selecione pizza)":
                    encomendaCliente.Pizza = TipoPizza.Nulo;
                    ImagemPizza.Image = null;
                    break;
                case "Pizza Margherita: €5,00":
                    encomendaCliente.Pizza = TipoPizza.Margherita;
                    ImagemPizza.Image = Pizza.Properties.Resources.margherita;
                    break;
                case "Pizza Camponesa: €7,00":
                    encomendaCliente.Pizza = TipoPizza.Camponesa;
                    ImagemPizza.Image = Pizza.Properties.Resources.camponesa;
                    break;
                case "Pizza Vegetariana: €6,80":
                    encomendaCliente.Pizza = TipoPizza.Vegetariana;
                    ImagemPizza.Image = Pizza.Properties.Resources.vegetariana;
                    break;
            }
            AtualizarTotais();
        }
        /// <summary>
        /// Selecionar (ou não) água.
        /// </summary>
        private void BebidaAgua_CheckedChanged(object sender, EventArgs e)
        {
            encomendaCliente.BebidaAgua = BebidaAgua.Checked;
            AtualizarTotais();
        }
        /// <summary>
        /// Selecionar (ou não) Coca-Cola.
        /// </summary>
        private void BebidaCocaCola_CheckedChanged(object sender, EventArgs e)
        {
            encomendaCliente.BebidaCocaCola = BebidaCocaCola.Checked;
            AtualizarTotais();
        }
        
       
        /// <summary>
        /// Validar a encomenda.
        /// </summary>
        private void BotaoValidar_Click(object sender, EventArgs e)
        {
            bool encomendaValida = true;

            // Verificar se os campos pessoais estão preenchidos
            if (Nome.Text == "" || Morada.Text == "" || Contacto.Text == "")
            {
                MessageBox.Show("Dados de cliente em falta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                encomendaValida = false;
            }

            // Verificar se uma pizza foi selecionada
            if (ListaPizza.SelectedIndex == 0)
            {
                MessageBox.Show("Escolha a pizza", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                encomendaValida = false;
            }

            // Se a encomenda for válida
            if (encomendaValida)
            {
                // Mostrar mensagem de sucesso com ícone de informação
                MessageBox.Show("Encomenda validada e confirmada.\nObrigado.", "Encomenda validada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Efetuar reset ao formulário: iniciar nova encomenda
                LimparCampos();
            }

        }
        /// <summary>
        /// Limpar os dados do formulário.
        /// </summary>
        private void LimparCampos()
        {
            // Dados do cliente
            Nome.Text = "";
            Morada.Text = "";
            Contacto.Text = "";

            // Entradas
            Entradas.SelectedIndex = -1;
            QuantidadeEntrada.Value = 0;

            // Pizza
            ListaPizza.SelectedIndex = 0;

            // Bebidas
            BebidaAgua.Checked = false;
            BebidaCocaCola.Checked = false;
            BebidaSumoSemGas.Checked = false;
            BebidaSumoComGas.Checked = false;

            // Tipo de entrega
            EntregaTakeAway.Checked = false;
        }
        /// <summary>
        /// Anular a encomenda.
        /// </summary>

        private void BotaoAnular_Click(object sender, EventArgs e)
        {
            // Exibe a caixa de diálogo de confirmação
            DialogResult resultado = MessageBox.Show("Confirma a anulação da encomenda?", "Anular Encomenda",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            // Verifica se o usuário clicou em "Sim"
            if (resultado == DialogResult.Yes)
            {
                // Código para anular a encomenda (limpar os campos)
                LimparCampos();
                MessageBox.Show("Encomenda anulada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Se o usuário clicou em "Não", apenas fecha a caixa de diálogo e não faz nada
                MessageBox.Show("A encomenda não foi anulada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fechar a aplicação.
        /// </summary>
        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void BebidaSumoSemGas_CheckedChanged_1(object sender, EventArgs e)
        {
            encomendaCliente.BebidaSumoSemGas = BebidaSumoSemGas.Checked;
            AtualizarTotais();
        }

        private void BebidaSumoComGas_CheckedChanged_1(object sender, EventArgs e)
        {
            encomendaCliente.BebidaSumoComGas = BebidaSumoComGas.Checked;
            AtualizarTotais();
        }

        private void EntregaTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            if (EntregaTakeAway.Checked)
            {
                encomendaCliente.Entrega = MetodoEntrega.TakeAway;
                AtualizarTotais();
            }
        }

        private void EntregaCasa_CheckedChanged(object sender, EventArgs e)
        {
            if (EntregaCasa.Checked)
            {
                encomendaCliente.Entrega = MetodoEntrega.Casa;
                AtualizarTotais();
            }
        }
    }
}
