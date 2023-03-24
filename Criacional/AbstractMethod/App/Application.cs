using AbstractMethod.Aeronaves;
using AbstractMethod.Factories;
using AbstractMethod.VeiculosTerrestres;

namespace AbstractMethod.App {
    internal class Application {

        private IAeronaves aeronave;

        private IVeiculosTerrestres veiculosTerrestres;

        public Application(ITransporteFactory factory) {

            aeronave = factory.CreateTransportAircraft();
            veiculosTerrestres = factory.CreateVeiculosTerrestres();
        }

        public void StartRoute() { 

            aeronave.StartRoute(); 
            veiculosTerrestres.StartRoute();
        
        }

    }
}
