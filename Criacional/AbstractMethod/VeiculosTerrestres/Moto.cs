using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod.VeiculosTerrestres {
    internal class Moto : IVeiculosTerrestres {
        public void GetCargo() {
            Console.WriteLine("Pegamos a encomenda");
        }

        public void StartRoute() {
            GetCargo();
            Console.WriteLine("Iniciando o trajeto");
        }
    }
}
