using AbstractMethod.Aeronaves;
using AbstractMethod.VeiculosTerrestres;

namespace AbstractMethod.Factories {
    internal class UberTransporte : ITransporteFactory {
        public IAeronaves CreateTransportAircraft() {

            return new Aviao();
        }

        public IVeiculosTerrestres CreateVeiculosTerrestres() {

            return new Carro();
        }
    }
}
