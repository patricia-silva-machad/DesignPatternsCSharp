using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Pagamentos {

    //classe abstract nao pode ser instanciada.
    abstract class ItauCard : IPagmentosInstruments {

        public void ColetarPagamento() {
            Console.WriteLine("Pagamento realizado");
        }

        public virtual void Validacao() {

          
            
               
        }

    }
}
