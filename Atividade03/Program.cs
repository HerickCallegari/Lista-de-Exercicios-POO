using Atividade03.model.entities;
using Biblioteca;
namespace Atividade03
    {
    internal class Program
        {
        static void Main ( string[] args )
            {
            double alturaDoTriangulo;
            double baseDoTriangulo;
            do {
                alturaDoTriangulo = Leitura.LerDoubleComMsg ("Altura do Triangulo: ");
                baseDoTriangulo = Leitura.LerDoubleComMsg ("base do Triangulo: ");
                if (baseDoTriangulo <= 0 || alturaDoTriangulo <= 0) {
                    Console.WriteLine ("Algum dos campos é menor ou igual a 0");
                    }
                } while (baseDoTriangulo <= 0 || alturaDoTriangulo <= 0);

            Triangulo triangulo = new Triangulo();
            triangulo.Altura = alturaDoTriangulo;
            triangulo.Base = baseDoTriangulo;

            Console.WriteLine("Area do triangulo: " + triangulo.CalcularArea());

        }
        }
    }
