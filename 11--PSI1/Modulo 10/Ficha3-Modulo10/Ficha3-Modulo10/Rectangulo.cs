using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha3_Modulo10
{
    class Rectangulo : Forma
    {
        public int Largura { get; set; }
        public int Altura { get; set; }

        public Rectangulo(int x, int y, int largura, int altura) : base(x, y)
        {
            Largura = largura;
            Altura = altura;
        }

        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um retângulo.");
        }

        public override void Informacoes()
        {
            Console.WriteLine($"Forma localizada em ({X}, {Y}).");
        }

        public override void Mover(int novoX, int novoY)
        {
            Console.WriteLine($"Retângulo movendo-se de ({X}, {Y}) para ({novoX}, {novoY}) com suavidade.");
            base.Mover(novoX, novoY);
        }
    }
}
