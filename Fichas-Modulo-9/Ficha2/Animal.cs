using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2
{
    internal class Animal
    {
        public string Nome { get; set; }
        public TipoAnimal Tipo { get; set; }
        public double Peso { get; set; }
        public Animal(string nome, TipoAnimal tipo, double peso)
        {
            Nome = nome;
            Tipo = tipo;
            Peso = peso;
        }
        public enum TipoAnimal
        {
            Nulo,
            Cao,
            Gato,
            Passaro,
            Peixe
        }
    }
}
