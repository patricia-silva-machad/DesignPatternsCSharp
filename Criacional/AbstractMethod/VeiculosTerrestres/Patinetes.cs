using System;

namespace AbstractMethod.VeiculosTerrestres {
    internal class Patinetes : IVeiculosTerrestres {
        public void GetCargo() {
            Console.WriteLine("Pegamos a encomenda");
        }

        public void StartRoute() {
            GetCargo();
            Console.WriteLine("Iniciando o trajeto");
        }
    }
}
