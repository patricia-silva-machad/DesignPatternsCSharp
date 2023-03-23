using FactoryMethod.Veiculos;

namespace FactoryMethod.Factories {
    class MotoTransporte : Transporte {
        protected override IVeiculos CreateTransporte() {

            return new Moto();
        }
    }
}
