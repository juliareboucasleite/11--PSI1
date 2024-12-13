using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha4_Modulo10
{
    class Processador
    {
        public string Modelo { get; private set; }
        public double Frequencia { get; private set; }

        public Processador(string modelo, double frequencia)
        {
            Modelo = modelo;
            Frequencia = frequencia;
        }
        ~Processador()
        {
            Console.WriteLine("Processador destruido.");
        }
    }
}
