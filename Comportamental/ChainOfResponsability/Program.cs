using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability {
    internal class Program {

        private static Server server;
        static void Init() {
            server = new Server();

            server.RegisterUser("master@patricimachado.com.br", "1234$pati&&olp");
            server.RegisterUser("user@patricimachado.com.br", "32212kaka");

            Middleware middleware = new CheckUserMiddleware(server);
            middleware.LinkWith(new CheckPermissionMiddleware());
            server.SetMiddleware(middleware);
        }
        static void Main(string[] args) {

            Init();
            Boolean done = false;

            do {
                Console.WriteLine("Digite seu e-mail:");
                string email = Console.ReadLine();

                Console.WriteLine("Digite sua senha:");

                string password = Console.ReadLine();

                done = server.LogIn(email, password);
            } while (!done);

            Console.ReadLine();
        }
    }
}
