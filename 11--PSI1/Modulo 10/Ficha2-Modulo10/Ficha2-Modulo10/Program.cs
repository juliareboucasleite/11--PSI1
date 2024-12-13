using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2_Modulo10
{
    /// <summary>
    /// Enumeração do Movimento
    /// </summary>
    public enum DirecaoMovimento
    {
        Indefinido,
        Esquerda,
        Direita
    }

    /// <summary>
    /// Classe abstrata Veiculo
    /// </summary>
    public abstract class Veiculo
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public ConsoleColor Cor { get; set; }
        public DirecaoMovimento Direcao { get; set; }

        protected Veiculo(int x, int y, string marca, string modelo, ConsoleColor cor)
        {
            X = x;
            Y = y;
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Direcao = DirecaoMovimento.Indefinido;
        }

        public abstract void Desenhar();
    }

    /// <summary>
    /// Classe Bicicleta
    /// </summary>
    // Classe Bicicleta
    public class Bicicleta : Veiculo
    {
        public Bicicleta(int x, int y, string marca, string modelo, ConsoleColor cor)
            : base(x, y, marca, modelo, cor) { }

        public override void Desenhar()
        {
            Console.ForegroundColor = Cor;
            Console.SetCursorPosition(X, Y);
            Console.Write("    __o");
            Console.SetCursorPosition(X, Y + 1);
            Console.Write(" _ `\\<,_");
            Console.SetCursorPosition(X, Y + 2);
            Console.Write("(*) / (*)");
            Console.ResetColor();
        }
    }


    /// <summary>
    /// Classe Automovel
    /// </summary>
    public class Automovel : Veiculo
    {
        public string Matricula { get; set; }

        public Automovel(int x, int y, string marca, string modelo, string matricula, ConsoleColor cor)
            : base(x, y, marca, modelo, cor)
        {
            Matricula = matricula;
        }

        public override void Desenhar()
        {
            Console.ForegroundColor = Cor;
            Console.SetCursorPosition(X, Y);
            
            Console.Write(" ██████ ");
            Console.SetCursorPosition(X, Y + 1);
            Console.Write(" O    O ");
            Console.ResetColor();
        }
    }

    /// <summary>
    /// Classe Camiao
    /// </summary>
    public class Camiao : Veiculo
    {
        public string Matricula { get; set; }

        public Camiao(int x, int y, string marca, string modelo, string matricula, ConsoleColor cor) : base(x, y, marca, modelo, cor)
        {
            Matricula = matricula;
            Desenhar();
        }

        public override void Desenhar()
        {
            Console.ForegroundColor = Cor;
            Console.SetCursorPosition(X, Y);
            Console.Write(" ███████ ");
            Console.SetCursorPosition(X, Y + 1);
            Console.Write(" O     O ");
            Console.ResetColor();
        }
    }

    /// <summary>
    /// Programa Principal
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            Veiculo automovel1 = new Automovel(10, 7, "Toyota", "Corolla", "AA-00-11", ConsoleColor.Yellow);
            Veiculo camiao1 = new Camiao(10, 14, "Toyota", "Hiace", "BB-11-22", ConsoleColor.Red);
            Veiculo bicicleta1 = new Bicicleta(10, 20, "Specialized", "S-Works Epic", ConsoleColor.White);

            
            automovel1.Desenhar();
            camiao1.Desenhar();
            bicicleta1.Desenhar();
            Console.ReadKey();
        }
    }
}
