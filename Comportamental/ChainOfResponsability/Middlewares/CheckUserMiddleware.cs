using System;
using ChainOfResponsability.Servers;

namespace ChainOfResponsability.Middlewares {
    internal class CheckUserMiddleware : Middleware {

        private Server server;

        public CheckUserMiddleware(Server server) {
            this.server = server;
        }

        public override bool Check(string email, string password) {
            if(!server.HasEmail(email)) {
                Console.WriteLine("E-mail invalido!");
                return false;
            }
            if(!server.IsValidPassword(email, password)) {
                Console.WriteLine("E-mail e/ou senha invalida!");
                return false;
            }

            return CheckNext(email, password);
        }
    }
}
