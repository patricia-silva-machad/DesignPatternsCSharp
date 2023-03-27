using Bridge.Plataforms;
using Bridge.Transmissions;
using System;

namespace Bridge {
    internal class Program {

        static void StartLive(IPlataform plataform) {
            Console.WriteLine("Aguarde");
            Live live = new Live(plataform);
            live.Broadcasting();
            live.Result();
        }

        static void StartAdvancedLive(IPlataform plataform) {
            Console.WriteLine("Aguarde");

            AdvancedLive live = new AdvancedLive(plataform);
            live.Broadcasting();
            live.Subtitle();
            live.Comments();
            live.Result();
        }
        static void Main(string[] args) {

            StartAdvancedLive(new Youtube());
            StartLive(new Facebook());
            StartLive(new TwitchTV());

            Console.ReadLine();
        }
    }
}
