using System;

namespace FactoryMethod.Veiculos {
    class Moto : IVeiculos {
        public void GetCarga() {

            Console.WriteLine("Pegamos a encomenda");
        }

        public void StartRota() {
            GetCarga();
            Console.WriteLine("Iniciamos a entrega.");
        }
    }
}
