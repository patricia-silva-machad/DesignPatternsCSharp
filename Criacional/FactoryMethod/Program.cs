using FactoryMethod.Factories;
using System;

namespace FactoryMethod {
    class Program {
        static void Main(string[] args) {

            Transporte transporte = null;

            if (args.Length > 0 && args[0] == "--uber") {

                transporte = new CarroTransporte();

            }
            else if (args.Length > 0 && args[0] == "--log") {

                transporte = new MotoTransporte();
            }  
            else if (args.Length > 0 && args[0] == "--eats") {

                transporte = new BicicletaTransporte();
            }
            else {
                Console.WriteLine("Selecione o tipo de serviço.");
            }

            if (transporte != null) {

                transporte.StartTransporte();
            }
            Console.ReadLine();
        }
    }
}
