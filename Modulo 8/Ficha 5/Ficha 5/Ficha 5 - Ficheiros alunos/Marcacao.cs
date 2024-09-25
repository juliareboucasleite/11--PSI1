using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ficha5
{
    /// <summary>
    /// Dados de uma marcação de consulta médica.
    /// </summary>
    public class Marcacao
    {
        public string Paciente { get; set; }
        public string Medico { get; set; }
        public DateTime DataHora { get; set; }
        public string Subsistema { get; set; }

        public Marcacao(string paciente, string medico, DateTime dataHora, string subsistema)
        {
            Paciente = paciente;
            Medico = medico;
            DataHora = dataHora;
            Subsistema = subsistema;
        }
    }
}
