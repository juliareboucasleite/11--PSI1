using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Morada { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Salario { get; set; } = 1000;
        public int AnosServico { get; set; }
        public int NumeroFilhos { get; set; }
        public Funcionario(string nome, string morada, DateTime dataNascimento, int
        anosServico, int numeroFilhos)
        {
            Nome = nome;
            Morada = morada;
            DataNascimento = dataNascimento;
            AnosServico = anosServico;
            NumeroFilhos = numeroFilhos;
        }
       
        public void CalcularSalario()
        {
            // Acresce ao salário-base 50€ se tiver acima de 45 anos de idade
            if (Idade() > 45)
            {
                Salario += 50;
            }
            // Mais 10€ por cada ano de serviço
            Salario += 10 * AnosServico;
            // Mais 25€ por filho; acima de 3 filhos, receberá sempre 50€ por filho
            if (NumeroFilhos <= 3)
            {
                Salario += 25 * NumeroFilhos;
            }
            else
            {
                Salario += 50 * NumeroFilhos;
            }
        }
    }


}
