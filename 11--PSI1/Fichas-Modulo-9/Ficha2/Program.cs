using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa1 = new Pessoa("Catarina Almeida", "Rua Vicente Vaz das Vacas, no 67,1o Esquerdo, 8500 - 611, Portimão", 123456789, "123456789 0UX 1", new DateTime(1999,12, 31));
            Pessoa pessoa2 = new Pessoa("Miguel Afonso", "Rua Dom Manuel I, no 300, 3030-320,Coimbra", 123456789, "123456789 0UX 1", new DateTime(1960, 08, 01));

            Animal animal1 = new Animal("Rex", Animal.TipoAnimal.Cao, 12.28D);
            Animal animal2 = new Animal("Atum", Animal.TipoAnimal.Gato, 6D);
            Animal animal3 = new Animal("Nemo", Animal.TipoAnimal.Peixe, 0.90D);

            Circulo circulo1 = new Circulo(4, ConsoleColor.Blue);

            Console.WriteLine(circulo1.ToString());

            Funcionario funcionario1 = new Funcionario("Catarina Almeida", "Rua Vicente Vaz dasVacas, no 67, 1o Esquerdo, 8500 - 611, Portimão", new DateTime(1995, 12, 31), 4, 0);
            Funcionario funcionario2 = new Funcionario("Miguel Afonso", "Rua Dom Manuel I, no300, 3030 - 320, Coimbra", new DateTime(1960, 08, 01), 32, 4);
            Funcionario funcionario3 = new Funcionario("Mónica Tavares", "Rua Miguel Torga, no17, 9o C, 3030 - 320, Coimbra", new DateTime(1986, 02, 17), 12, 2);

            Console.WriteLine($"{funcionario1.Nome}\nSalário: {funcionario1.Salario:C}\n");
            Console.WriteLine($"{funcionario2.Nome}\nSalário: {funcionario2.Salario:C}\n");
            Console.WriteLine($"{funcionario3.Nome}\nSalário: {funcionario3.Salario:C}\n");


            Console.ReadKey();
        }

        

    }
}
