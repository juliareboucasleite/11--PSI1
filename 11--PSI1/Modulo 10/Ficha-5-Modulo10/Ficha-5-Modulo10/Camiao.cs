using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_5_Modulo10
{
        public class Camiao : Veiculo
        {
            public Motor Motor { get; set; }

            public Camiao(string marca, string modelo, int ano, Motor motor)
                : base(marca, modelo, ano)
            {
                Motor = motor;
            }

            public override void MostrarDetalhes()
            {
                base.MostrarDetalhes();
                Motor.MostrarDetalhes();
            }
        }
    }

