using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Faz com que o formulário inicie centralizado na tela
            this.MaximizeBox = false; // Impede que o botão de maximizar seja habilitado
        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        /// <summary>
        /// Ver o sistema de ficheiros do computador e selecionar uma localização para criar a pasta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotaoBrowse_Click(object sender, EventArgs e)
        {
            DialogResult resultado = folderBrowserDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                LocalizacaoPasta.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "FolderNew"; // Define o texto na barra de título
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Impede redimensionamento do formulário
            Resultado.ScrollBars = ScrollBars.Vertical; // Adiciona barras de rolagem verticais
            LocalizacaoPasta.ReadOnly = true; // Impede edição na caixa de texto "LocalizacaoPasta"
        }

        private void BotaoCriarPasta_Click(object sender, EventArgs e)
        {
            if (LocalizacaoPasta.Text == String.Empty || NomePasta.Text == String.Empty)
            {
                MessageBox.Show("Especifique a localização e o nome da pasta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string pasta = Path.Combine(@LocalizacaoPasta.Text, NomePasta.Text);
            try
            {
                Directory.CreateDirectory(pasta);
            }
            catch (UnauthorizedAccessException)
            {
                Resultado.Text += $"Erro ao tentar criar a pasta {pasta}: o utilizador não possui permissões para executar a operação\n";
                return;
            }
            catch (PathTooLongException)
            {
                Resultado.Text += $"Erro ao tentar criar a pasta {pasta}: path muito longa\n";
                return;
            }
            catch (IOException)
            {
                Resultado.Text += $"Erro ao tentar criar a pasta {pasta}: erro no sistema de ficheiros\n";
                return;
            }
            catch (Exception excecao)
            {
                Resultado.Text += $"Erro ao tentar criar a pasta {pasta}: {excecao.Message}\n";
                return;
            }
            Resultado.Text += $"Pasta {pasta} criada com sucesso!\n";
        }
    }
}
