using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha5
{
    public partial class FormMarcacaoConsulta : Form
    {
        public FormMarcacaoConsulta()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormMarcacaoConsulta_Load(object sender, EventArgs e)
        {
            // Inicialização da form
            this.Text = "Marcação de Consulta";
            this.ShowIcon = false;
            // Inicializar os pacientes
            Paciente.DataSource = Program.pacientesClinica.DadosPacientes();

            // Inicializar os médicos
            Medico.DataSource = Program.medicosClinica.DadosMedicos();
            // Inicializar a hora de consulta

            // HoraConsulta.Format = DateTimePickerFormat.Time;
            HoraConsulta.ShowUpDown = true;

            // Inicializar a lista de motivos para consulta
            MotivosConsulta.CheckOnClick = true;
            MotivosConsulta.Items.Add("Primeira consulta");
            MotivosConsulta.Items.Add("Continuar tratamento");
            MotivosConsulta.Items.Add("Mostrar exames");
            MotivosConsulta.Items.Add("Outro");

            // Inicialmente é selecionado subsistema SNS (Serviço Nacional de Saúde)
            SubsistemaSns.Checked = true;
        }

        private void BotaoMarcar_Click(object sender, EventArgs e)
        {
            string subsistema = string.Empty;

            // Verificar qual o subsistema de saúde selecionado
            if (SubsistemaSns.Checked)
            {
                subsistema = "SNS";
            }
            else if (SubsistemaAdse.Checked)
            {
                subsistema = "ADSE";
            }
            else if (SubsistemaSams.Checked)
            {
                subsistema = "SAMS";
            }
            else if (SubsistemaMedis.Checked)
            {
                subsistema = "Médis";
            }
            // Obter a data e a hora da consulta
           
            DateTime dataHora = new DateTime(DataConsulta.Value.Year,
            DataConsulta.Value.Month, DataConsulta.Value.Day, HoraConsulta.Value.Hour,
            HoraConsulta.Value.Minute, HoraConsulta.Value.Second);

            // Criar uma nova marcação, com os dados introduzidos pelo utilizador
            Program.marcacoesConsultas.CriarMarcacao(new Marcacao(Paciente.Text,
            Medico.Text, dataHora, subsistema));

            // Sinalizar que o utilizador efetuou a marcação da consulta
            this.DialogResult = DialogResult.OK;

            // Fechar a janela
            this.Close();
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            // Sinalizar que o utilizador cancelou a marcação da consulta
            this.DialogResult = DialogResult.Cancel;
            // Fechar a janela
            this.Close();
        }
    }
}
