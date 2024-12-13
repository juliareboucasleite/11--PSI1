using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Biblioteca
{
    internal class Funcionario
    {

        public string Nome { get; private set; }
        public int Id { get; private set; }
        public string Cargo { get; private set; }

        public Funcionario(string nome, int id, string cargo)
        {
            Nome = nome;
            Id = id;
            Cargo = cargo;
        }
        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}, ID: {Id}, Cargo: {Cargo}");
        }

        public void RegistrarEmprestimo(Emprestimo emprestimo)
        {
            emprestimo.LivroEmprestado += NotificarLivrosEmprestados;
            Console.WriteLine($"Funcionario {Nome} resgistrou um novo emprestimo.");

        }
        public void NotificarLivrosEmprestados(object sender, string tituloLivro)
        {
            Console.WriteLine($"Notificação para o funcionario {Nome}: O livro '{tituloLivro}' foi emprestado.");
        }
    } 
}
