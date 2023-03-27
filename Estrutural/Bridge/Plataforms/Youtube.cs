using System;

namespace Bridge.Plataforms {
    internal class Youtube : IPlataform {

        public Youtube() {
            ConfigureRMTP();
            Console.WriteLine("Youtube: Transmissao Iniciada");
        }
        public void AuthToken() {
            Console.WriteLine("Youtube: Autorizando aplicacao");
        }

        public void ConfigureRMTP() {

            AuthToken();
            Console.WriteLine("Youtube: Configurando servidor RTMP");
        }
    }
}
