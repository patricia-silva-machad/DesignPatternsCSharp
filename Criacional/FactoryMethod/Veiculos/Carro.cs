using System;

namespace FactoryMethod.Veiculos {
    class Carro : IVeiculos {

       
        public void GetCarga() {

            Console.WriteLine("Pegamos os passageiros!");
        }

        public void StartRota() {

            Console.WriteLine("Iniciamos o trajeto.");
        }

    }
}
