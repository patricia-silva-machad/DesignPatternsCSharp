﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod.VeiculosTerrestres {
    internal class Carro : IVeiculosTerrestres {
        public void GetCargo() {
            Console.WriteLine("Pegamos os passageiros");
        }

        public void StartRoute() {
            GetCargo();
            Console.WriteLine("Iniciando o trajeto");
        }
    }
}
