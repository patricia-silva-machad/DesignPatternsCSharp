using System;

namespace AbstractMethod.Aeronaves {
    internal class Drone : IAeronaves {

        public void CheckWind() {
            Console.WriteLine("Verificando os ventos. OK");
        }

        public void GetCargo() {
            Console.WriteLine("Produtos prontos!");
        }

        public void StartRoute() {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem");
        }

    }
}
