using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Pagamentos {

        interface IPagmentosInstruments {
        void Validacao();
        void ColetarPagamento();
    }
}
