using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Veiculos {
    internal class Bicicleta : IVeiculos {


        public void GetCarga() {

            Console.WriteLine("Pegamos o pedido!");
        }

        public void StartRota() {

            Console.WriteLine("Iniciamos o trajeto.");
        }
    }
}
