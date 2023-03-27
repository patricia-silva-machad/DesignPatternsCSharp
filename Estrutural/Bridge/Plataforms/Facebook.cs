using System;

namespace Bridge.Plataforms {
    internal class Facebook : IPlataform {

        public Facebook() {
            ConfigureRMTP();
            Console.WriteLine("Facebook: Transmissao Iniciada");
        }
        public void AuthToken() {
            Console.WriteLine("Facebook: Autorizando aplicacao");
        }

        public void ConfigureRMTP() {

            AuthToken();
            Console.WriteLine("Facebook: Configurando servidor RTMP");
        }
    }
}
