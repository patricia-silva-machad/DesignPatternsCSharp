using Bridge.Plataforms;
using System;

namespace Bridge.Transmissions {
    internal class AdvancedLive : Live {

        public AdvancedLive(IPlataform plataform) : base(plataform) {

        }
        public void Subtitle() {
            Console.WriteLine("Legendas ativadas");
        }
        public void Comments() {
            Console.WriteLine("Comentarios liberados na live.");
        }

        public void Record() {
            Console.WriteLine("Iniciamos a gravação.");
        }
    }
}
