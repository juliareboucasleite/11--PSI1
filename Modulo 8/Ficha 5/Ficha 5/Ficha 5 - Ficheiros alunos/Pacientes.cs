using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ficha5
{
    /// <summary>
    /// Pacientes da clínica.
    /// </summary>
    public class Pacientes
    {
        private List<string> pacientes = new List<string>();

        public Pacientes()
        {
            // Inicializar a lista de pacientes
            pacientes.Add("Ana Paula");
            pacientes.Add("Carlos Pardal");
            pacientes.Add("Mariana Almeida");
            pacientes.Add("João Vilar");
            pacientes.Add("Patrícia Afonso");
        }

        public List<string> DadosPacientes()
        {
            return pacientes;
        }
    }
}
