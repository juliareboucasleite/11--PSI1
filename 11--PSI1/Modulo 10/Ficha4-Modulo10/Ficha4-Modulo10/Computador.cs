using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha4_Modulo10
{
    class Computador
    {
        private Processador Processador { get; set; }
        private MemoriaRAM Memoria { get; set; }
        private DiscoRigido Disco { get; set; }

        public Computador(Processador processador, MemoriaRAM memoria, DiscoRigido disco)
        {
            Processador = processador;
            Memoria = memoria;
            Disco = disco;
        }

        ~Computador() 
        {
            Console.WriteLine("Computador destruido.");
        }

        public void ExibirEspecificacoes()
        {
            Console.WriteLine($"\nProcessador {Processador.Modelo} criado.");
            Console.WriteLine($"Memoria RAM de {Memoria.Capacidade} GB criada.");
            Console.WriteLine($"Disco Rigido de {Disco.Capacidade} GB ({Disco.Tipo}) criado.");
            Console.WriteLine("Computador Criado.");

            Console.WriteLine("\nEspecificações do Computador:");
            Console.WriteLine($"Processador: {Processador.Modelo}, {Processador.Frequencia} GHz");
            Console.WriteLine($"Memória RAM: {Memoria.Capacidade} GB");
            Console.WriteLine($"Disco Rígido: {Disco.Capacidade} GB, Tipo: {Disco.Tipo}");

            Console.ReadKey();
        }
    }
}
