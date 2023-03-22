using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Pagamentos {
    class CartaoDeDebito : ItauCard {


    public override void Validacao() {
       Console.WriteLine("Validando saldo da conta");
       Console.WriteLine("Saldo disponivel");
    }


    }
}
