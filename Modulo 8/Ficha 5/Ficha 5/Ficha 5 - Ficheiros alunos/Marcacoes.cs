using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ficha5
{
    /// <summary>
    /// Dados de todas as marcações de consultas médicas.
    /// </summary>
    public class Marcacoes
    {
        private List<Marcacao> marcacoes = new List<Marcacao>();

        public Marcacoes()
        {
            marcacoes.Add(new Marcacao("João Vilar", "Dra. Carla Afonso", new DateTime(2020, 12, 3, 17, 00, 00), "SAMS"));
            marcacoes.Add(new Marcacao("Carlos Pardal", "Dr. Carlos Passarinho", new DateTime(2021, 4, 21, 09, 25, 00), "ADSE"));
            marcacoes.Add(new Marcacao("Patrícia Afonso", "Dr. Carlos Passarinho", new DateTime(2021, 4, 21, 14, 00, 00), "SNS"));
        }

        /// <summary>
        /// Criar uma nova marcação de consulta médica.
        /// </summary>
        /// <param name="marcacao">Os dados da nova marcação.</param>
        public void CriarMarcacao(Marcacao marcacao)
        {
            marcacoes.Add(marcacao);
        }

        /// <summary>
        /// Retorna o número de marcacoes existentes.
        /// </summary>
        /// <returns>Um número inteiro.</returns>
        public int NumeroMarcacoes()
        {
            return marcacoes.Count;
        }

        /// <summary>
        /// Retorna os dados de uma marcação.
        /// </summary>
        /// <param name="indice">O índice da marcação para a qual se pretendem obter dados.</param>
        /// <returns>Os dados da marcação.</returns>
        public Marcacao DadosMarcacao(int indice)
        {
            return marcacoes[indice];
        }

        /// <summary>
        /// Retorna os dados da última marcação.
        /// </summary>
        /// <returns>Os dados da marcação.</returns>
        public Marcacao DadosUltimaMarcacao()
        {
            return marcacoes[marcacoes.Count - 1];
        }
    }
}
