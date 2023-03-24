namespace Builder.Components {
    internal class Motor {

        private int power;

        public int Power {
            get => power;
            set => power = value;   
        }
        public Motor(int power) {
            this.power = power;

        }
    }
}
