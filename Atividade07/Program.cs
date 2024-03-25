using Atividade07.model.entities;
using Biblioteca;
namespace Atividade07;
internal class Program
    {
    static void Main ( string[] args )
        {
        double alturaDoRetangulo;
        double baseDoRetangulo;
        do {
            alturaDoRetangulo = Leitura.LerDoubleComMsg ("Altura do retangulo: ");
            baseDoRetangulo = Leitura.LerDoubleComMsg ("base do retangulo: ");

            if (alturaDoRetangulo <= 0 || baseDoRetangulo <= 0) {
                Console.WriteLine ("Algum dos campos é menor ou igual a 0");
                }

            } while (alturaDoRetangulo <= 0 || baseDoRetangulo <= 0);

        Retangulo retangulo = new Retangulo ();
        retangulo.Altura = alturaDoRetangulo;
        retangulo.Base = baseDoRetangulo;

        Console.WriteLine ("Perimetro: " + retangulo.CalcularPerimetro ());
        }
    }