using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_5_Modulo10
{
    
        public class Veiculo
        {
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int Ano { get; set; }

            public Veiculo(string marca, string modelo, int ano)
            {
                Marca = marca;
                Modelo = modelo;
                Ano = ano;
            }

            public virtual void MostrarDetalhes()
            {
                Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
            }
        }
 }
