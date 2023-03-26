using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {
    internal class MercadoPagoAdpter : IPayPalPayment {

        private MercadoPago mercadoPago;

        public MercadoPagoAdpter(MercadoPago mercado) {
            this.mercadoPago = mercado;
            Console.WriteLine("Realizando adaptacao de Mercado Pago para os metodos do Paypal");
        }
        public Token AuthToken() {
            return this.mercadoPago.AuthToken();
        }

        public void PayPalPayment() {
            this.mercadoPago.MercadoPayment();
        }

        public void PayPalReceive() {
            this.mercadoPago.MercadoReceive();
        }
    }
}
