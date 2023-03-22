using System;

namespace OCP.Veiculos {
    class Carro : Veiculos {

        private int assentos;
        private int portas;



        public Carro(string cor, int ano, double motor, int assentos, int portas): base(cor, ano, motor) {
            this.assentos = assentos;
            this.portas = portas;

            ConfiguraCarro();
        }
        public void ConfiguraCarro() {

            Console.WriteLine($"Criando um carro {cor}, {ano}, {motor}, {portas} portas e {assentos} assentos.");
            StartVeiculo();

        }
    }
}
