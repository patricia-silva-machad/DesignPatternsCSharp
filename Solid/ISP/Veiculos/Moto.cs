using System;

namespace ISP.Veiculos {
    class Moto : IVeiculosMoto {
        private string cor;
        private int ano;
        private double motor;

        public Moto(string cor, int ano, double motor) {
            ConfiguraMoto(cor, ano, motor);
        }

        public void ConfiguraMoto(string cor, int ano, double motor) {
            this.cor = cor;
            this.ano = ano;
            this.motor = motor;

            Console.WriteLine($"Criando moto ano {ano}, {motor} cilindradas da cor {cor}.");
            StartVeiculo();
        }

        public void StartVeiculo() {
            Console.WriteLine("Ligando os motores");
        }
    }
}

