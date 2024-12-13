using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static Ficha1_Modulo10.Forma;

namespace Ficha1_Modulo10
{
    internal class Retangulo : Ponto
    
    {
        private int largura;
        public int Largura
        {
            get { return largura; }
            set { largura = (value < 2) ? 2 : value; }
        }
        private int altura;
        public int Altura
        {
            get { return altura; }
            set { altura = (value < 2) ? 2 : value; }
        }
        public Retangulo(int x, int y, int largura, int altura, ConsoleColor cor) : base(x,
        y, cor)
        {
            Largura = largura;
            Altura = altura;
        }
        public new void Desenhar()
        {
            Console.ForegroundColor = Cor;
            Console.SetCursorPosition(X, Y);
            for (int x = X; x <= X + Largura - 1; ++x)
            {
                Console.Write("*");
            }
            for (int y = Y + 1; y <= Y + Altura - 2; ++y)
            {
                Console.SetCursorPosition(X, y);
                Console.Write("*");
                Console.SetCursorPosition(X + Largura - 1, y);
                Console.Write("*");
            }
            Console.SetCursorPosition(X, Y + Altura - 1);
            for (int x = X; x <= X + Largura - 1; ++x)
            {
                Console.Write("*");
            }
        }
    }
    
}
