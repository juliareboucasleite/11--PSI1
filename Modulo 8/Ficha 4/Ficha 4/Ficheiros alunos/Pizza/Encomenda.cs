using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizza
{
    public enum TipoEntrada
    {
        Nulo,
        PaoAlho,
        PaoAlhoSupremo
    }

    public enum TipoPizza
    {
        Nulo,
        Margherita,
        Camponesa,
        Vegetariana
    }

    public enum Bebida
    {
        Nulo,
        Agua,
        CocaCola,
        SumoMacaSemGas,
        SumoMacaComGas
    }

    public enum MetodoEntrega
    {
        TakeAway,
        Casa
    }

    /// <summary>
    /// Dados de uma encomenda.
    /// </summary>
    public class Encomenda
    {
        

        public decimal TotalSemIva { get; private set; }
        public decimal TotalComIva { get; private set; }

        public string NomeCliente { get; set; }
        public string MoradaCliente { get; set; }
        public string ContactoCliente { get; set; }

        public TipoEntrada Entrada { get; set; }
        public int QuantidadeEntrada { get; set; }

        public TipoPizza Pizza { get; set; }

        /// <summary>Bebida: água.</summary>
        public bool BebidaAgua { get; set; }

        /// <summary>Bebida: coca-cola.</summary>
        public bool BebidaCocaCola { get; set; }

        /// <summary>Bebida: sumo sem gás.</summary>
        public bool BebidaSumoSemGas { get; set; }

        /// <summary>Bebida: sumo com gás.</summary>
        public bool BebidaSumoComGas { get; set; }

        /// <summary>Método de entrega da pizza.</summary>
        public MetodoEntrega Entrega { get; set; }

        public Encomenda()
        {
            Pizza = TipoPizza.Nulo;
            Entrega = MetodoEntrega.TakeAway;
        }

        public void CalcularTotais()
        {
            TotalSemIva = 0.0M;

            // Entrada selecionada
            switch (Entrada)
            {
                case TipoEntrada.PaoAlho:
                    TotalSemIva += 2.50M * QuantidadeEntrada;
                    break;

                case TipoEntrada.PaoAlhoSupremo:
                    TotalSemIva += 3.50M * QuantidadeEntrada;
                    break;
            }

            // Tipo de pizza selecionada
            switch (Pizza)
            {
                case TipoPizza.Margherita:
                    TotalSemIva += 5;
                    break;

                case TipoPizza.Camponesa:
                    TotalSemIva += 7;
                    break;

                case TipoPizza.Vegetariana: 
                    TotalSemIva += 6.80M;
                    break;
            }

            // Bebidas
            TotalSemIva += (BebidaAgua) ? 1 : 0;
            TotalSemIva += (BebidaCocaCola) ? 1.90M : 0;
            TotalSemIva += (BebidaSumoSemGas) ? 1.50M : 0;
            TotalSemIva += (BebidaSumoComGas) ? 1.50M : 0;

            // Método de entrega
            if (Entrega == MetodoEntrega.Casa)
            {
                TotalSemIva += 1;
            }

            TotalComIva = TotalSemIva * 1.23M;
        }
    }
}
