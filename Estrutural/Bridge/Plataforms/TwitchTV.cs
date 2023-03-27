using System;

namespace Bridge.Plataforms {
    internal class TwitchTV : IPlataform {

        public TwitchTV() {
            ConfigureRMTP();
            Console.WriteLine("TwitchTV: Transmissao Iniciada");
        }
        public void AuthToken() {
            Console.WriteLine("TwitchTV: Autorizando aplicacao");
        }

        public void ConfigureRMTP() {

            AuthToken();
            Console.WriteLine("TwitchTV: Configurando servidor RTMP");
        }
    }
}
