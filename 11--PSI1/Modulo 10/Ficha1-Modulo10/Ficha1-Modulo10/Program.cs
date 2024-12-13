using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ficha1_Modulo10.Forma;

namespace Ficha1_Modulo10
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // Não consegui fazer q nem o da imagem
            Console.WriteLine("Instância da classe Ponto");
            Ponto p1 = new Ponto(10, 4, ConsoleColor.Yellow);
            p1.Desenhar();

            Console.WriteLine("\n\nInstâncias da classe Quadrado");
            Quadrado q1 = new Quadrado(10, 9, 1, ConsoleColor.Green);  
            Quadrado q2 = new Quadrado(16, 9, 3, ConsoleColor.Red);
            Quadrado q3 = new Quadrado(25, 9, 6, ConsoleColor.Green);
            q1.Desenhar();
            q2.Desenhar();
            q3.Desenhar();

            Console.WriteLine("\n\nInstâncias da classe Retangulo");
            Retangulo r1 = new Retangulo(10, 19, 0, 0, ConsoleColor.White);
            Retangulo r2 = new Retangulo(16, 19, 10, 3, ConsoleColor.White);
            Retangulo r3 = new Retangulo(30, 19, 2, 8, ConsoleColor.White);
            r1.Desenhar();
            r2.Desenhar();
            r3.Desenhar();

            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
