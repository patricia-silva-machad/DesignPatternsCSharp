using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {
    internal interface IMercadoPagoPayment {

        Token AuthToken();
        void MercadoPayment();
        void MercadoReceive();
    }
}
