using AbstractMethod.Aeronaves;
using AbstractMethod.VeiculosTerrestres;



namespace AbstractMethod.Factories {
    internal class NineNineTransporte : ITransporteFactory {
        public IAeronaves CreateTransportAircraft() {

            return new Helicoptero();
        }

        public IVeiculosTerrestres CreateVeiculosTerrestres() {
            return new Moto();
        }
    }
}
