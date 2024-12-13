using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Validar dados de login
        /// </summary>
       
        private void BotaoOk_Click(object sender, EventArgs e)
        {
            //Verificar que as textboxes nao estão vazias
            if (Username.Text != string.Empty && Password.Text != string.Empty)
            {
                //validar o username e a password
                if (utilizadores.Contains(new Utilizador(Username.Text, Password.Text)))
                {
                    MessageBox.Show("Os dados de login estão corretos", "Login..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Os dados de login estão incorretos. \nPor avor tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Preencha o Username e a Password", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Fechar a aplicação
        /// </summary>
      
        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Inicializar os componentes da form.
        /// </summary>
       
        private void Form1_Load(object sender, EventArgs e)
        {
            //Inicializar a lista de utilizadores
            utilizadores.Add(new Utilizador("pato", "donald"));
            utilizadores.Add(new Utilizador("eça", "queirós"));
            utilizadores.Add(new Utilizador("anon", "123"));
            utilizadores.Add(new Utilizador("julinha", "123"));
            utilizadores.Add(new Utilizador("julia", "1qaz2wsx3edc"));
            utilizadores.Add(new Utilizador("x", "y"));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Armazena dados de um Utilizador
        /// </summary>
        private struct Utilizador
        {
            public string username;
            public string password;

            public Utilizador (String _username, string _password)
            {
                username = _username;
                password = _password;
            }
        }
        /// <summary>
        /// Lista de Utilzadores
        /// </summary>
      
        private List <Utilizador> utilizadores = new List <Utilizador> ();

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
