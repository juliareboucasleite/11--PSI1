using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_5_Modulo10
{
    public class Motor
    {
        public string Tipo { get; set; }
        public int Potencia { get; set; }

        public Motor(string tipo, int potencia)
        {
            Tipo = tipo;
            Potencia = potencia;
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"Tipo do Motor: {Tipo}, Potência: {Potencia} CV");
        }
    }
}
