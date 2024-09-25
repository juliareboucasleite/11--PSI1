using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ficha5
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            // A janela deverá surgir no centro do ecrã
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // Inicialização da form
            this.Text = "Clínica de Coimbra";
            // Inicializar a lista de marcações de consultas
            ListaMarcacoes.View = View.Details;
            ListaMarcacoes.FullRowSelect = true;
            // A lista de marcações deverá ocupar todo o espaço disponível na form
            ListaMarcacoes.Dock = DockStyle.Fill;
            // Acrescentar as colunas à lista de marcações
            ListaMarcacoes.Columns.Add("Data", 70, HorizontalAlignment.Left);
            ListaMarcacoes.Columns.Add("Hora", 70, HorizontalAlignment.Left);
            ListaMarcacoes.Columns.Add("Paciente", 170, HorizontalAlignment.Left);
            ListaMarcacoes.Columns.Add("Médico", 170, HorizontalAlignment.Left);
            ListaMarcacoes.Columns.Add("Subsistema", -2, HorizontalAlignment.Left);
            // Popular a lista de marcações com dados
            PopularMarcacoes();
        }
        /// <summary>
        /// Inserir na lista de marcações, todas as marcações armazenadas no sistema.
        /// </summary>
        private void PopularMarcacoes()
        {
            for (int i = 0; i < Program.marcacoesConsultas.NumeroMarcacoes(); ++i)
            {
                Marcacao m = Program.marcacoesConsultas.DadosMarcacao(i);
                ListViewItem item = new ListViewItem(new string[] {
                m.DataHora.ToShortDateString(), m.DataHora.ToShortTimeString(), m.Paciente,
                m.Medico, m.Subsistema });
                ListaMarcacoes.Items.Add(item);
            }
        }
        /// <summary>
        /// Terminar a aplicação.
        /// </summary>
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void acercaDaAplicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAcerca frmAcerca = new FormAcerca();
            frmAcerca.ShowDialog();
            frmAcerca.Dispose();
        }

        private void novaConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarcarConsulta();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MarcarConsulta();
        }
        /// <summary>
        /// Efetuar marcação de consulta.
        /// </summary>
        private void MarcarConsulta()
        {
            FormMarcacaoConsulta frmMarcacaoConsulta = new FormMarcacaoConsulta();
            // Mostrar a janela de marcação de consulta e verificar o resultado
            if (frmMarcacaoConsulta.ShowDialog() == DialogResult.OK)
            {
                // Refrescar os dados na lista de marcações: acrescentar a última marcação efetuada
                Marcacao m = Program.marcacoesConsultas.DadosUltimaMarcacao();
                ListViewItem item = new ListViewItem(new string[] {m.DataHora.ToShortDateString(), m.DataHora.ToShortTimeString(), m.Paciente,m.Medico, m.Subsistema });
                ListaMarcacoes.Items.Add(item);
            }
            frmMarcacaoConsulta.Dispose();
        }
    }
}
