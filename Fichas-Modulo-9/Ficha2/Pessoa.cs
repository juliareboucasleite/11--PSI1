using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Morada { get; set; }
        public int Nif { get; set; }
        public string CartaoCidadao { get; set; }
        public DateTime DataNascimento { get; set; }
        public Pessoa(string nome, string morada, int nif, string cartaoCidadao,
        DateTime dataNascimento)
        {
            Nome = nome;
            Morada = morada;
            Nif = nif;
            CartaoCidadao = cartaoCidadao;
            DataNascimento = dataNascimento;
        }
        /// <summary>
        /// Refere a idade
        /// </summary>
       
        public int Idade()
        {
            int anos = DateTime.Now.Year - DataNascimento.Year;
            int meses = DateTime.Now.Month - DataNascimento.Month;
            int dias = DateTime.Now.Day - DataNascimento.Day;
            if (meses == 0)
            {
                if (dias < 0)
                {
                    --anos;
                }
            }
            else if (meses < 0)
            {
                --anos;
            }
            return anos;
        }

    }
}
