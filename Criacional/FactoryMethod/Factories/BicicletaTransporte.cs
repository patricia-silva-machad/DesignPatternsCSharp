using FactoryMethod.Veiculos;

namespace FactoryMethod.Factories {
    class BicicletaTransporte : Transporte {
        protected override IVeiculos CreateTransporte() {

            return new Bicicleta();
        }
    }
}
