using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ficha5
{
    /// <summary>
    /// Médicos da clínica.
    /// </summary>
    public class Medicos
    {
        private List<string> medicos = new List<string>();

        public Medicos()
        {
            // Inicializar a lista de médicos
            medicos.Add("Dra. Anabela Marques");
            medicos.Add("Dr. Carlos Passarinho");
            medicos.Add("Dra. Maria Almeida");
            medicos.Add("Dr. João Vilarinho");
            medicos.Add("Dra. Carla Afonso");
        }

        public List<string> DadosMedicos()
        {
            return medicos;
        }
    }
}
