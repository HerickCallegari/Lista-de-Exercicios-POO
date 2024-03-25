namespace Atividade05;

using Atividade05.model.entities;
using Biblioteca;
using System.Runtime.Intrinsics.Arm;

internal class Program
    {
    static void Main ( string[] args )
        {
        string nome = Leitura.LerStringComMsg ("Nome: ");
        int idade;
        do {
            idade = Leitura.LerIntComMsg ("Idade: ");

            if (idade <= 0) {
                Console.WriteLine ("A idade deve ser maior que 0.");
                }

            } while (idade <= 0);

        Pessoa pessoa = new Pessoa ();
        pessoa.Idade = idade;
        pessoa.Nome = nome;

        Console.WriteLine (pessoa.EhMaiorDeIdade () ? "É maior de idade" : "Não é maior de idade");

        }
    }

