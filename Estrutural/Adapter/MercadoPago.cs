using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {
    internal class MercadoPago : IMercadoPagoPayment {

        private Token token;
        public Token AuthToken() {
            return new Token();
        }

        public void MercadoPayment() {
            token = AuthToken();
            Console.WriteLine("Recendo pagamento com Mercado Pago!");
        }

        public void MercadoReceive() {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com Mercado Pago!");
        }
    }
}
