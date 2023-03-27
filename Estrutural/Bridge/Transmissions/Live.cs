using Bridge.Plataforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Transmissions {
    internal class Live : ITransmission {

        protected IPlataform plataform;
        public Live(IPlataform plataform) {
            this.plataform = plataform;
        }
        public void Broadcasting() {
            Console.WriteLine($"Iniciando a transmissao na plataforma {plataform}");
        }

        public void Result() {
            Console.WriteLine("---- No ar ----");
        }

    }
}
