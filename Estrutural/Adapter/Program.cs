using System;

namespace Adapter {
    internal class Program {
        static void Main(string[] args) {

            //PayPal payment = new PayPal();
            //Payonner payment = new Payonner();
            //IPayPalPayment payment = new PayonnerAdapter(new Payonner());
            //payment.PayPalPayment();
            //payment.PayPalReceive();

            IPayPalPayment payment = new MercadoPagoAdpter(new MercadoPago());
            payment.PayPalPayment();
            payment.PayPalReceive();

            //payment.SendPayment();
            //payment.ReceivePayment();

            Console.ReadLine();
        }
    }
}
