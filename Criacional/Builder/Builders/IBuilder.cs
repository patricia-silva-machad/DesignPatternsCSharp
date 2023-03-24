using Builder.Components;
using Builder.Products;

namespace Builder.Builders {
    internal interface IBuilder {

        void Reset();
        Veiculos GetVeiculos();
        void SetAssentos(int assentos);
        void SetMotor(Motor motor);
        void SetTransmission (Transmission transmission);
        void SetVeiculosType (VeiculosType veiculosType);
        void SetAirBags(int airBags);
    }
}
