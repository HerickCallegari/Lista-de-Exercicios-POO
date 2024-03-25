using Atividade06.mode.entities;
using Biblioteca;
namespace Atividade06;
internal class Program
    {
    static void Main ( string[] args )
        {
        string nome = Leitura.LerStringComMsg ("Nome do Aluno: ");

        Aluno aluno = new Aluno ();
        aluno.Nome = nome;

        int quantidadeDeMaterias;
        do {
            quantidadeDeMaterias = Leitura.LerIntComMsg ("Quantidade de materias: ");
            if (quantidadeDeMaterias <= 0) {
                Console.WriteLine ("A quantidade de materias tem que ser maior que 0.");
                }
        } while (quantidadeDeMaterias <= 0);

        for (int i = 0; i < quantidadeDeMaterias; i++) {
            double nota;
            do {
                nota = Leitura.LerDoubleComMsg ("Nota " + (i + 1) + ": ");

                if ( nota < 0 ) {
                    Console.WriteLine("A Nota tem que ser maior ou igual que 0.");
                    }
            }while ( nota < 0);

            aluno.addNota (nota);
            }

        Console.WriteLine("Media Final: " + aluno.CalculaMedia());
    }
    }

