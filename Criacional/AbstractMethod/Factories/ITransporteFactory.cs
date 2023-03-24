using AbstractMethod.Aeronaves;
using AbstractMethod.VeiculosTerrestres;

namespace AbstractMethod.Factories {
    internal interface ITransporteFactory {
        //interface com dois metodos, pois a aplicacao cliente esta amarrada a esta interface.

        IAeronaves CreateTransportAircraft();

        IVeiculosTerrestres CreateVeiculosTerrestres();

    }
}
