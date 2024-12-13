using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha4_Modulo10
{
    class MemoriaRAM
    {
        public int Capacidade { get; private set; }

        public MemoriaRAM(int capacidade)
        {
            Capacidade = capacidade;
        }
        ~MemoriaRAM()
        {
            Console.WriteLine("Memoria RAM destruida.");
        }
    }
}
