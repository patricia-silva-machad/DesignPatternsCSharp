using Builder.Components;
using Builder.Products;

namespace Builder.Builders {
    internal class VeiculosBuilder : IBuilder {

        private Veiculos veiculos = new Veiculos();
        public Veiculos GetVeiculos() {
            Veiculos result = veiculos;
            Reset();
            return result;
        }

        public void Reset() {
            veiculos = new Veiculos();
        }

        public void SetAssentos(int assentos) {
            veiculos.Assentos = assentos;
        }

        public void SetMotor(Motor motor) {
            veiculos.Motor = motor;
        }

        public void SetTransmission(Transmission transmission) {
            veiculos.Transmission = transmission;
        }

        public void SetVeiculosType(VeiculosType veiculosType) {
            veiculos.VeiculosType = veiculosType;
        }

        public void SetAirBags(int airBags) {
            veiculos.AirBags = airBags;
        }
    }
}
