using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_5_Modulo10
{
    public class Carro : Veiculo
    {
        public int NumeroPortas { get; set; }

        public Carro(string marca, string modelo, int ano, int numeroPortas)
            : base(marca, modelo, ano)
        {
            NumeroPortas = numeroPortas;
        }

        public override void MostrarDetalhes()
        {
            base.MostrarDetalhes();
            Console.WriteLine($"Número de Portas: {NumeroPortas}");
        }
    }
}
