using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Pagamentos {
     class ItauMilhas : IPagmentosInstruments {
        public void ColetarPagamento() {
            Console.WriteLine("Pagamento realizado com sucesso");
            Console.WriteLine("Pontuação Creditada!");
        }
        
        public void Validacao() {
            Console.WriteLine("Limite OK, Pontos OK");
        }
    }
}
