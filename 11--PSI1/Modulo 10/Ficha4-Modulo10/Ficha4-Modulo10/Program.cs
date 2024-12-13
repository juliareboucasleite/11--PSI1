using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha4_Modulo10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Configurador de Computadores!");

            Console.WriteLine("\nEscolha o processador:");
            Console.WriteLine("1. Intel Core i5 (2.5 GHz)");
            Console.WriteLine("2. Intel Core i7 (3.8 GHz)");
            Console.WriteLine("3. AMD Ryzen 5 (3.6 GHz)");
            Console.Write("Opção: ");
            int opcaoProcessador = int.Parse(Console.ReadLine());

            Processador processador;
            switch (opcaoProcessador)
            {
                case 1:
                    processador = new Processador("Intel Core i5", 2.5);
                    break;
                case 2:
                    processador = new Processador("Intel Core i7", 3.8);
                    break;
                case 3:
                    processador = new Processador("AMD Ryzen 5", 3.6);
                    break;
                default:
                    throw new Exception("Opção inválida!");
            }

            Console.WriteLine("\nEscolha a quantidade de memória RAM (em GB):");
            Console.WriteLine("1. 8 GB");
            Console.WriteLine("2. 16 GB");
            Console.WriteLine("3. 32 GB");
            Console.Write("Opção: ");
            int opcaoMemoria = int.Parse(Console.ReadLine());

            MemoriaRAM memoria;
            switch (opcaoMemoria)
            {
                case 1:
                    memoria = new MemoriaRAM(8);
                    break;
                case 2:
                    memoria = new MemoriaRAM(16);
                    break;
                case 3:
                    memoria = new MemoriaRAM(32);
                    break;
                default:
                    throw new Exception("Opção inválida!");
            }

            Console.WriteLine("\nEscolha o disco rígido:");
            Console.WriteLine("1. 512 GB SSD");
            Console.WriteLine("2. 1 TB HDD");
            Console.WriteLine("3. 1 TB SSD");
            Console.Write("Opção: ");
            int opcaoDisco = int.Parse(Console.ReadLine());

            DiscoRigido disco;
            switch (opcaoDisco)
            {
                case 1:
                    disco = new DiscoRigido(512, "SSD");
                    break;
                case 2:
                    disco = new DiscoRigido(1024, "HDD");
                    break;
                case 3:
                    disco = new DiscoRigido(1024, "SSD");
                    break;
                default:
                    throw new Exception("Opção inválida!");
            }

            Computador computador = new Computador(processador, memoria, disco);
            computador.ExibirEspecificacoes();

            computador = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            
            
            
        }
    }
}