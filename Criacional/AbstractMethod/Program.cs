using AbstractMethod.App;
using AbstractMethod.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod {
    internal class Program {

        static Application ConfigureApplication() {

            Application app;

            ITransporteFactory transporteFactory;
            string company = "Uber";
            if(company == "Uber") {

                transporteFactory = new UberTransporte();
            } else {
                transporteFactory = new NineNineTransporte();
            }


            app = new Application(transporteFactory);

            return app;
        }
        static void Main(string[] args) {

            Application app= ConfigureApplication();

            app.StartRoute();

            Console.ReadLine();
        }
    }
}
