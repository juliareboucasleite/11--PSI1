using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha1_Modulo10
{
    internal class Forma
    {
        public ConsoleColor Cor { get; set; }

        public Forma(ConsoleColor cor)
        {
            Cor = cor;
        }

        // Classe que representa um ponto na tela
        public class Ponto : Forma
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Ponto(int x, int y, ConsoleColor cor) : base(cor)
            {
                X = x;
                Y = y;
            }

            // Desenha o ponto na posição (X, Y) se estiver dentro dos limites da tela
            public void Desenhar()
            {
                if (X >= 0 && X < Console.BufferWidth && Y >= 0 && Y < Console.BufferHeight)
                {
                    Console.ForegroundColor = Cor;
                    Console.SetCursorPosition(X, Y);
                    Console.Write("*");
                }
                else
                {
                    Console.WriteLine("Posição fora dos limites da tela.");
                }
            }
        }
    }
}