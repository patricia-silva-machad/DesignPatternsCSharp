using Builder.Components;

namespace Builder.Products {
    internal class Veiculos {

        private VeiculosType veiculosType;
        private int assentos;
        private Motor motor;
        private Transmission transmission;
        private int airBags;

        public VeiculosType VeiculosType {
            get => veiculosType;
            set => veiculosType = value;
        }

        public int Assentos {
            get => assentos;
            set => assentos = value;
        }

        public Motor Motor {
            get => motor;
            set => motor = value;
        }

        public Transmission Transmission {
            get => transmission;
            set => transmission = value;
        }

        public int AirBags {
            get => airBags;
            set => airBags = value;
        }

    }
}
