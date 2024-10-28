using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Automóvel";
            Console.WindowWidth = 100;
            Console.CursorVisible = false;
            Automovel automovel1 = new Automovel(0, 8, 15700, "NA-17-66", ConsoleColor.Red);
            Automovel automovel2 = new Automovel(0, 12, 5000, "AA-11-02", ConsoleColor.Green);
            // Movimentar os automóveis
            while (!Console.KeyAvailable)
            {
                automovel1.Movimentar();
                automovel2.Movimentar();
                System.Threading.Thread.Sleep(80);
            }
            Console.ReadKey();
        
        }
    }
}
