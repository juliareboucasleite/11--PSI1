using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Biblioteca
{
    internal class Membro
    {
        public string Nome { get; private set; }
        public int Id { get; private set; }
        public string Email { get; private set; }

        public Membro(string nome, int id, string email)
        {
            Nome = nome;
            Id = id;
            Email = email;
        }
        /// <summary>
        /// Exibir O Nome, O id, E o email dos membros
        /// </summary>
        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}, ID: {Id}, Email: {Email}");
        }
    }
}
