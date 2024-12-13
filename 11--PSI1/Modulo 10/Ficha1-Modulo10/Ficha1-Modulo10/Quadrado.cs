using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static Ficha1_Modulo10.Forma;

namespace Ficha1_Modulo10
{
    internal class Quadrado : Ponto
    {
            private int tamanho;
            public int Tamanho
            {
                get { return tamanho; }
                set { tamanho = (value < 2) ? 2 : value; }
            }
            public Quadrado(int x, int y, int tamanho, ConsoleColor cor) : base(x, y, cor)
            {
                Tamanho = tamanho;
            }
            public new void Desenhar()
            {
                Console.ForegroundColor = Cor;
                Console.SetCursorPosition(X, Y);
                for (int x = X; x <= X + Tamanho - 1; ++x)
                {
                    Console.Write("*");
                }
                for (int y = Y + 1; y <= Y + Tamanho - 2; ++y)
                {
                    Console.SetCursorPosition(X, y);
                    Console.Write("*");
                    Console.SetCursorPosition(X + Tamanho - 1, y);
                    Console.Write("*");
                }
                Console.SetCursorPosition(X, Y + Tamanho - 1);
                for (int x = X; x <= X + tamanho - 1; ++x)
                {
                    Console.Write("*");
                }
            }
        }
    }
