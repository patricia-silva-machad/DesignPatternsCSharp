using System;

namespace ISP.Veiculos {
    class Carro : IVeiculosCarro {

        private string cor;
        private int ano;
        private double motor;
        private int assentos;
        private int portas;

        public Carro(string cor, int ano, double motor, int assentos, int portas) {
            ConfiguraCarro(cor, ano, motor, assentos, portas);
        }
        public void ConfiguraCarro(string cor, int ano, double motor, int assentos, int portas) {
            this.cor = cor;
            this.ano = ano; 
            this.motor = motor;
            this.assentos = assentos; 
            this.portas = portas;

            Console.WriteLine($"Criando carro ano {ano}, motor {motor} da cor {cor}.");
            StartVeiculo();
        }

        public void StartVeiculo() {
            Console.WriteLine("Ligando os motores");
        }
    }
}
