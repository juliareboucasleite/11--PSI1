using System;
using System.Collections.Generic;

namespace Ficha_5_Modulo10
{
    public class Garagem
    {
        public string Nome { get; set; }
        public List<Veiculo> Veiculos { get; set; }

        public Garagem(string nome)
        {
            Nome = nome;
            Veiculos = new List<Veiculo>();
        }

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            Veiculos.Add(veiculo);
            Console.WriteLine($"{veiculo.GetType().Name} adicionado à garagem.");
        }

        public void ListarVeiculos()
        {
            Console.WriteLine($"Veículos na garagem {Nome}:");
            foreach (var veiculo in Veiculos)
            {
                veiculo.MostrarDetalhes();
            }
        }

        public void RetirarVeiculo(Veiculo veiculo)
        {
            if (Veiculos.Remove(veiculo))
            {
                Console.WriteLine($"{veiculo.GetType().Name} removido da garagem.");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado na garagem.");
            }
        }
    }

}
