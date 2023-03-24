using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod.Aeronaves {
    internal class Helicoptero : IAeronaves {
        public void CheckWind() {
            Console.WriteLine("Verificando vento, vento sudeste, Ok");
        }

        public void GetCargo() {
            Console.WriteLine("Passageiros ok. Ligando helices.");
        }

        public void StartRoute() {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem");
        }
    }
}
