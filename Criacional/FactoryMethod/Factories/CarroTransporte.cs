using FactoryMethod.Veiculos;


namespace FactoryMethod.Factories {
    class CarroTransporte : Transporte {
        protected override IVeiculos CreateTransporte() {

            return new Carro();
        }
    }
}
