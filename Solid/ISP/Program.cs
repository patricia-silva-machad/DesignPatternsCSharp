using ISP.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP {
    internal class Program {
        static void Main(string[] args) {

            Carro carro = new Carro("Azul", 2022, 4.0, 5, 2);
            Moto moto = new Moto("Branca", 2023, 600);
        }
    }
}
