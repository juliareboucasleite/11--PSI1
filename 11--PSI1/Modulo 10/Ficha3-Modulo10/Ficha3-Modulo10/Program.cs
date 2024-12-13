using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha3_Modulo10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo1 = new Circulo(5, 5, 10);
            Rectangulo retangulo1 = new Rectangulo(20, 5, 8, 12);


            circulo1.Informacoes();
            retangulo1.Informacoes();
            circulo1.Mover(10, 10);
            retangulo1.Mover(25, 10);
            circulo1.Informacoes();
            retangulo1.Informacoes();
        }
    }
}
