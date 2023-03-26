using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {
    internal class PayonnerAdapter : IPayPalPayment {

        private Payonner payonner;
        public PayonnerAdapter(Payonner payonner) {
            this.payonner = payonner;
            Console.WriteLine("Realizando adaptacao de Payonner para os metodos do Paypal");
        }
        public Token AuthToken() {
            return this.payonner.AuthToken();
        }

        public void PayPalPayment() {
            this.payonner.SendPayment();
        }

        public void PayPalReceive() {
            this.payonner.ReceivePayment();
        }
    }
}
