using Atividade10.model.utils;
using Biblioteca;
namespace Atividade10
    {
    internal class Program
        {
        static void Main ( string[] args )
            {
                double valor = Leitura.LerDoubleComMsg ("Dinheiro que voce tem: ");
                double cambio;
            do {
                cambio = Leitura.LerDoubleComMsg ("Cambio para a nova moeda: ");
                } while (cambio <= 0);

            Console.WriteLine("Quantidade de dinheiro na nova moeda: " + Conversores.ConversorDeMoedas(valor, cambio));
        }
        }
    }
