using System;

namespace OCP.Veiculos {
    internal class Moto : Veiculos {

        public Moto(string cor, int ano, double motor) : base(cor, ano, motor) {
            ConfiguraMoto();

        }
        public void ConfiguraMoto() {
            Console.WriteLine($"Criando uma moto {cor}, {ano}, {motor} cilindrada.");
            StartVeiculo();

        }
    }
}
