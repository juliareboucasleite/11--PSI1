using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ProvaAvaliacao_Modulo_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa("Rosa Mota", SexoPessoa.Feminino, 52, 59.6, 1.65);
            Pessoa p3 = new Pessoa("Marco Silva", SexoPessoa.Masculino, 43, 87.0, 1.78);
            Pessoa.ExibirTotalPessoas();

            p2.CalcularImc();
            p3.CalcularImc();


            Console.Write($"{Pessoa.ExibirTotalPessoas()}\n");
            Console.Write($"{p1.DadosPessoas()}\n{p2.DadosPessoas()}\n{p3.DadosPessoas()}");
            
            Console.ReadKey();
        }
    }
}
