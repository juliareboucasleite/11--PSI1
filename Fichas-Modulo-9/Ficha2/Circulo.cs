using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2
{
    internal class Circulo
    {
        public double Raio { get; set; }
        public ConsoleColor Cor { get; set; } = ConsoleColor.Red;
        public Circulo() { }
        public Circulo(double raio)
        {
            Raio = raio;
        }
        public Circulo(double raio, ConsoleColor cor)
        {
            Raio = raio;
            Cor = cor;
        }
        public void Desenhar() { }
        public override string ToString()
        {
            return $"Dados do Círculo: Raio = {Raio}, Cor = {Cor}";
        }
    }
}
