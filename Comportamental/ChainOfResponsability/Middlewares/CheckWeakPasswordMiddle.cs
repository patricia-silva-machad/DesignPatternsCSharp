using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Middlewares {
    internal class CheckWeakPasswordMiddle : Middleware {

        public override bool Check(string email, string password) {
            if(password == "123456") {
                Console.WriteLine("Sugerimos que altere sua senha para uma mais segura!");
                return true;
            }

            Console.WriteLine("Seja bem vindo");

            return CheckNext(email, password);
        }
    }
}
