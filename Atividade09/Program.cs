using Atividade09.model.entities;
using Biblioteca;
namespace Atividade09
    {
    internal class Program
        {
        static void Main ( string[] args )
            {
            string modelo = Leitura.LerStringComMsg ("Modelo: ");
            int ano = Leitura.LerIntComMsg ("Ano do carro (apenas os 4 digitos do ano): ");

            double preco;
            do {
                preco = Leitura.LerDoubleComMsg ("Preco: ");
                if (preco < 0) {
                    Console.WriteLine ("O preco deve ser maior que 0.");
                    }
                } while (preco < 0);

            Carro carro = new Carro ();
            carro.Ano = ano;
            carro.Modelo = modelo;
            carro.Preco = preco;

            Console.WriteLine ("Valor com desconto: " + carro.CalcularDesconto ());
            }
        }
    }
