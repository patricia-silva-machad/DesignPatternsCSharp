using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Pagamentos {
     class CartaoDeCredito : ItauCard {

        public override void Validacao() {
            Console.WriteLine("Validando limite do cartao");
            Console.WriteLine("Limite ok");
        }


    }
}
