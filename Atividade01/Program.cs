using Atividade01.model.entities;
using Biblioteca;

namespace Atividade01
    {
    internal class Program
        {
        static void Main ( string[] args )
            {
            string nome;
            int idade;
            double altura;
            do {
                Console.Write ("Digite o nome: ");
                nome = Console.ReadLine ()!;
                if (string.IsNullOrEmpty (nome))
                    Console.WriteLine ("O nome nao pode ser nulo, Digite novamente.");
                } while (string.IsNullOrEmpty (nome));

            do {
                idade = Leitura.LerIntComMsg ("Digite a idade: ");
                altura = Leitura.LerDoubleComMsg ("digite a altura: ");

                if (idade <= 0 || altura <= 0) {
                    Console.WriteLine ("algum dos campos é menor que 0");
                    }
                } while (idade <= 0 || altura <= 0); 

        Pessoa pessoa = new Pessoa();
            pessoa.Altura = altura;
            pessoa.Nome = nome;
            pessoa.Idade = idade;
            Console.WriteLine( pessoa.ImprimirDados() );
            }
        }
    }
