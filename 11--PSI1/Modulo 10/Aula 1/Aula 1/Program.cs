using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1
{
    class Veiculo
    {
        
        public string marca { get; set; }
        public string modelo { get; set; }

        public Veiculo(string marca)
        {
            this.marca = marca;
        }

        public virtual void Mover()
        {
            Console.WriteLine("O veículo está se movendo.");
        }
    }



    public sealed class Trotinete : Veiculo
    {
        public string cor { get; set}
    }

    class Carro : Veiculo
    {
        public Carro(string marca) : base(marca) { Console.WriteLine("Construtor carro"); }
        public override void Mover()
        { Console.WriteLine($"O carro {marca} esta a acelerar na estrada.");
        }

    }
    class Bicicleta : Veiculo
    {
        public Bicicleta(string marca) : base(marca) { Console.WriteLine($"Construtor bike"); }
        public override void Mover()
        {
            Console.WriteLine($"A bicicleta {marca} esta a andar na ciclovia");
        }
    }
}