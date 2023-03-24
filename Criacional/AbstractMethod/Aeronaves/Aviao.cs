using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod.Aeronaves {
    internal class Aviao : IAeronaves {
        public void CheckWind() {
            Console.WriteLine("Verificando os ventos, ventos 25km. OK");
        }

        public void GetCargo() {
            Console.WriteLine("Passageiros a bordo, voo autorizado");
        }

        public void StartRoute() {
           CheckWind();
           GetCargo();
           Console.WriteLine("Iniciando a decolagem");
        }
    }
}
