using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha4_Modulo10
{
    class DiscoRigido
    {
        public int Capacidade { get; private set; }
        public string Tipo { get; private set; }

        public DiscoRigido(int capacidade, string tipo)
        {
            Capacidade = capacidade;
            Tipo = tipo;
        }

        ~DiscoRigido()
        {
            Console.WriteLine("Disco Rigido destruido.");
        }
    }   
}
