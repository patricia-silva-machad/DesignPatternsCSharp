using Builder.Builders;
using Builder.Components;

namespace Builder.Directors {
    internal class Director {

        IBuilder builder;

        public Director(IBuilder builder) {
            this.builder = builder; 
        }
        public void ConstructSedanCarro() {
            builder.SetVeiculosType(VeiculosType.SEDAN);
            builder.SetMotor(new Motor(2000));
            builder.SetAssentos(5);
            builder.SetTransmission(Transmission.AUTOMATIC);
        }

        public void ConstructTruck() {
            builder.SetVeiculosType(VeiculosType.TRUCK);
            builder.SetMotor(new Motor(4000));
            builder.SetAssentos(2);
            builder.SetTransmission(Transmission.MANUAL);
        }

        public void ConstructSUV() {
            builder.SetVeiculosType(VeiculosType.SPORTCAR);
            builder.SetMotor(new Motor(2600));
            builder.SetAssentos(5);
            builder.SetTransmission(Transmission.AUTOMATIC_SEQUENTIAL);
            builder.SetAirBags(2);
        }
    }
}
