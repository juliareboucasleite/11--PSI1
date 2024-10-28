using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha3
{
    internal class Automovel
    {
        private int X;
        private int Y;
        /// <summary>
        /// Valores possíveis do movimento: 1 = direita, 2 = esquerda
        /// </summary>
        private int Direcao = 1;
        public int Quilometragem { get; private set; }
        public int Velocidade { get; set; } = 0;
        public string Matricula { get; private set; }
        public ConsoleColor Cor { get; set; }
        public Automovel(int x, int y, int quilometragem, string matricula, ConsoleColor
        cor)
        {
            X = x;
            Y = y;
            Quilometragem = quilometragem;
            Matricula = matricula;
            Cor = cor;
        }

        public void Desenhar(bool apagar = false)
        {
            ConsoleColor corAntiga = Console.BackgroundColor;
            if (!apagar)
            {
                Console.BackgroundColor = Cor;
            }
            Console.SetCursorPosition(X + 2, Y);
            Console.Write(" ");
            Console.SetCursorPosition(X, Y + 1);
            Console.Write(" ");
            Console.BackgroundColor = corAntiga;
            Console.SetCursorPosition(X, Y + 2);
            Console.Write(" O O ");
        }

        public void Movimentar()
        {
            // Verificar que não atingiu o limite horizontal do ecrã
            if ((Direcao == 1) && (X >= Console.WindowWidth - 8))
            {
                Direcao = 2;
            }
            else if ((Direcao == 2) && (X == 0))
            {
                Direcao = 1;
            }
            // Apagar o automóvel
            Desenhar(true);
            if (Direcao == 1)
            {
                ++X;
            }
             else
            {
                --X;
            }
            // Desenhar o automóvel
            Desenhar();

        }
    }
}
