using FactoryMethod.Veiculos;

namespace FactoryMethod.Factories {
    
    abstract class Transporte {

        public void StartTransporte() {

            IVeiculos veiculos = CreateTransporte();
            veiculos.StartRota();
        }

        protected abstract IVeiculos CreateTransporte();
    }
}
