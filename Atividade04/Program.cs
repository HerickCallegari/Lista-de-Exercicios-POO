using Atividade04.model.entities;
using Biblioteca;
namespace Atividade04
    {
    internal class Program
        {
        static void Main ( string[] args )
            {

            string nome = Leitura.LerStringComMsg ("Nome do Produto: ");

            double valor;
            int quantidade;
            do {
                valor = Leitura.LerDoubleComMsg ("Valor do produto: ");
                quantidade = Leitura.LerIntComMsg ("Quantidade de produtos: ");

                if (valor <= 0 || quantidade <= 0) {
                    Console.WriteLine ("Algum dos campos é menor ou igual a 0");
                    }
                } while (valor <= 0 || quantidade <= 0);

            Produto produto = new Produto();
            produto.Nome = nome;
            produto.Valor = valor;
            produto.Quantidade = quantidade;
            
            Console.WriteLine ("Valor total: " + produto.CalcularTotal ());
            }
        }
    }
