using System;

namespace Bridge.Plataforms {
    internal class DLive : IPlataform {

        public DLive() {
            ConfigureRMTP();
            Console.WriteLine("DLive: Transmissao Iniciada");

        }
        public void AuthToken() {
            Console.WriteLine("DLive: Autorizando aplicacao");
        }

        public void ConfigureRMTP() {
            AuthToken();
            Console.WriteLine("DLive: Configurando servidor RTMP");
        }
    }
}
