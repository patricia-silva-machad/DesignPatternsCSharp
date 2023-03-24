using Builder.Builders;
using Builder.Directors;
using Builder.Products;
using System;

namespace Builder {
    internal class Program {
        static void Main(string[] args) {

            VeiculosBuilder builder = new VeiculosBuilder();
            Director director = new Director(builder);

            director.ConstructSedanCarro();
            Veiculos sedan = builder.GetVeiculos();

            Console.WriteLine($"Criado um veiculo do tipo {sedan.VeiculosType}");

            director.ConstructTruck();
            Veiculos truck = builder.GetVeiculos();

            Console.WriteLine($"Criado um veiculo do tipo {truck.VeiculosType}");

            director.ConstructSUV();
            Veiculos suv = builder.GetVeiculos();

            Console.WriteLine($"Criando um veiculo do tipo {suv.VeiculosType}");

            Console.ReadLine();
        }
    }
}
