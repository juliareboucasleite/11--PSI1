using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ficha5
{
    static class Program
    {
        public static Pacientes pacientesClinica = new Pacientes();
        public static Medicos medicosClinica = new Medicos();
        public static Marcacoes marcacoesConsultas = new Marcacoes();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }
    }
}
