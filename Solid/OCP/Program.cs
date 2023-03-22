using OCP.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP {
    internal class Program {
        static void Main(string[] args) {

            TipoVeiculo type = TipoVeiculo.CARRO;


            if (type == TipoVeiculo.CARRO) {

                Carro veiculo = new Carro("Azul", 2022, 2.0, 5, 4);
            }
            else { 
                Moto veiculo = new Moto("Branco", 2023, 250);
            }

            Console.ReadLine();
        }
    }
}
