using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static Sistema_de_Biblioteca.Livro;

namespace Sistema_de_Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando alguns livros
            Livro livro1 = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", 1954, 3, GeneroLivro.Fantasia);
            Livro livro2 = new Livro("1984", "George Orwell", 1949, 2, GeneroLivro.Ficcao);
            Livro livro3 = new Livro("O Pequeno Príncipe", "Antoine de Saint-Exupéry", 1943, 1, GeneroLivro.Ficcao);

            // Criando um membro
            Membro membro = new Membro("Alice Santos", 1, "alice@email.com");

            // Criando um funcionário
            Funcionario funcionario = new Funcionario("Carlos Silva", 101, "Bibliotecário");

            // Criando um novo empréstimo para o membro Alice
            Emprestimo emprestimo = new Emprestimo(membro);

            // Registrar o empréstimo no funcionário (isso inscreve o funcionário no evento LivroEmprestado)
            funcionario.RegistrarEmprestimo(emprestimo);

            // Emprestando livros (cada empréstimo vai disparar o evento e notificar o funcionário)
            emprestimo.EmprestarLivro(livro1);
            emprestimo.EmprestarLivro(livro2);

            // Exibindo informações sobre o empréstimo
            emprestimo.ExibirEmprestimo();

            // Exibindo o total de empréstimos realizados na biblioteca
            Emprestimo.ExibirTotalEmprestimo();

            Console.ReadLine();
        }
    }
}
