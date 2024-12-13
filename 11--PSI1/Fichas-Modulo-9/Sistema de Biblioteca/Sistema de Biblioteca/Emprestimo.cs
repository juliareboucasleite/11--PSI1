using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Sistema_de_Biblioteca.Livro; //Chamando a classe Livro

namespace Sistema_de_Biblioteca
{
    internal class Emprestimo
    {
        public Membro Membro { get; private set; }
        public List<Livro> LivrosEmprestados { get; set; }
        public DateTime DataEmprestimo { get; private set; }
        public static int TotalEmprestimos { get; private set; } = 0;

        


        public Emprestimo(Membro membro)
        {
            Membro = membro;
            LivrosEmprestados = new List<Livro>();
            DataEmprestimo = DateTime.Now;
            TotalEmprestimos++;
        }
        public event EventHandler<string> LivroEmprestado;
        /// <summary>
        /// Emprestimo via objeto Livro
        /// </summary>
        /// <param name="livro"></param>
        public void EmprestarLivro(Livro livro)
        {
            LivrosEmprestados.Add(livro);
            Console.WriteLine($"Livro '{ livro.Titulo}' Emprestado com sucesso!");
            OnLivroEmprestado(livro.Titulo);
        }

        /// <summary>
        /// Emprestimo diretamente com dados do livrox
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="autor"></param>
        /// <param name="anoPublicacao"></param>
         public void EmprestarLivro(string titulo, string autor, int anoPublicacao)
        {
            Livro livro = new Livro(titulo, autor, anoPublicacao, quantidadeDisponivel:1, GeneroLivro.Ficcao);
            LivrosEmprestados.Add((livro));
            
            Console.WriteLine($"Livro '{titulo}' emprestado com sucesso.");
            OnLivroEmprestado(livro.Titulo);
        }

        /// <summary>
        /// Exibir Emprestimo
        /// </summary>
        public void ExibirEmprestimo()
        {
            Console.WriteLine($"Empréstimo realizado por: {Membro.Nome} em {DataEmprestimo}");
            //Console.WriteLine($"Livros emprestados: {LivrosEmprestados}");
            //foreach (var livro in LivrosEmprestados) 
            //{ 
            //    Console.WriteLine($"");
            //}
            foreach (var livro in LivrosEmprestados)
            {
                livro.ExibirInfo();
            }

        }

        /// <summary>
        /// Exibir Total Emprestimo
        /// </summary>
        public static void ExibirTotalEmprestimo()
        {
            Console.WriteLine($"Total de Empréstimos: {TotalEmprestimos}");
        }
        
        protected virtual void OnLivroEmprestado(string tituloLivro)
        {
            if(LivroEmprestado != null)
            {
                LivroEmprestado(this, tituloLivro);
            }
        }
    }
}
