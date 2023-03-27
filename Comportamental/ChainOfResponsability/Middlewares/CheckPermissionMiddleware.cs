using ChainOfResponsability.Servers;
using System;

namespace ChainOfResponsability.Middlewares {
    internal class CheckPermissionMiddleware : Middleware {

        public override bool Check(string email, string password) {

            if(email.Equals("master@patriciamachado.com.br")) {

                Console.WriteLine("Seja bem vindo, admin!");
                return true;
            }
            Console.WriteLine("Seja bem vindo");

            return CheckNext(email, password);
        }
    }
}
