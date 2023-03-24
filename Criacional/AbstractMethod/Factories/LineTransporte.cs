using AbstractMethod.Aeronaves;
using AbstractMethod.VeiculosTerrestres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod.Factories {
    internal class LineTransporte : ITransporteFactory {
        public IAeronaves CreateTransportAircraft() {
            return new Drone();
        }

        public IVeiculosTerrestres CreateVeiculosTerrestres() {
            return new Patinetes();
        }
    }
}
