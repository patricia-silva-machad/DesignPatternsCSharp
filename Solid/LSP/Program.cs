using LSP.Pagamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP {
     class Program {
        static void Main(string[] args) {

            //CartaoDeCredito cartao = new CartaoDeCredito();
            //CartaoDeDebito cartao = new CartaoDeDebito();

            ItauMilhas cartao = new ItauMilhas();

            cartao.Validacao();
            cartao.ColetarPagamento();

            Console.ReadLine();

        }
    }
}
