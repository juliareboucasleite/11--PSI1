using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaAvaliacao_Modulo_9
{

    internal class Pessoa
    {
        public string Nome { get; set; }
        public SexoPessoa Sexo { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public static int TotalPessoas = 0;

        public double Imc = 0;

        public Pessoa()
        {
            TotalPessoas++;
        }

        public Pessoa(string nome, SexoPessoa sexo, int idade, double peso, double altura)
        {
            Nome = nome;
            Sexo = sexo;
            Idade = idade;
            Peso = peso;
            Altura = altura;
            TotalPessoas++;
        }
        public void CalcularImc()
        {
            Imc = Peso / (Math.Pow(Altura, 2));
        }
        public string ClassificacaoPeso()
        {
            if (Imc <= 0)
            {
                return string.Empty;
            }
            else if (Imc <= 18.6)
            {
                return "Baixo peso";
            }
            else if (Imc <= 24.9)
            {
                return "Peso normal";
            }
            else if (Imc <= 29.9)
            {
                return "Pré-obesidade";
            }
            else if (Imc <= 34.9)
            {
                return "Obesidade grau I";
            }
            else if (Imc <= 39.9)
            {
                return "Obsidade grau II";
            }
            else 
            {
                return "Obesidade grau III";
            }
        }
        public string DadosPessoas()
        {
            return $"Nome: {Nome} - IMC {Imc} ({ClassificacaoPeso()})";
        }

        public static string ExibirTotalPessoas()
        {
            return $"Total de pessoas: {TotalPessoas}";
        }

    }
}
