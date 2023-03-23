using DIP.Pagamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP {
    class Program {
        static void Main(string[] args) {

            ProcessoPagamento pagamento = new ProcessoPagamento();
            pagamento.Pagar("ABC1234");

            Console.ReadLine();


        }
    }
}
