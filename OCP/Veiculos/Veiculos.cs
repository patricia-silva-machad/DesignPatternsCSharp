using System;

namespace OCP.Veiculos {
     class Veiculos {

        protected string cor;
        protected int ano;
        protected double motor;

        public Veiculos(string cor, int ano, double motor) {

            this.cor = cor;
            this.ano = ano;
            this.motor = motor;
        }

        public void StartVeiculo() {
            Console.WriteLine("Ligando os motores");
        }
    }
}
