using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Biblioteca
{
    internal class Livro
    {
        public enum GeneroLivro
        {
            Ficcao,
            NaoFiccao,
            Suspense,
            Biografia,
            Fantasia,
            Romance,
            Ciencia
        }

        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int AnoPublicacao { get; private set; }
        public int QuantidadeDisponivel { get; private set; }
        public GeneroLivro Genero { get; private set; } //Novo Atributo


        public Livro(string titulo, string autor, int anoPublicacao, int quantidadeDisponivel, GeneroLivro genero)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            QuantidadeDisponivel = quantidadeDisponivel;
            Genero = genero;

        }
        /// <summary>
        /// Exibir O autor, o ano da publicação e a quantidade.
        /// </summary>
        public void ExibirInfo()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Ano: {AnoPublicacao}, Quantidade Disponível: {QuantidadeDisponivel}, Genero do Livro: {Genero}");
        }

    }
}
