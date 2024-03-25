using System.ComponentModel.DataAnnotations;
using Atividade08.model.entities;
using Biblioteca;
namespace Atividade08;

internal class Program
    {
    static void Main ( string[] args )
        {
        string nome = Leitura.LerStringComMsg ("Nome: ");
        int horasTrabalhadas;
        double salario;
        do {
            horasTrabalhadas = Leitura.LerIntComMsg ("Horas trabalhadas: ");
            salario = Leitura.LerDoubleComMsg ("Salario: ");
            if (horasTrabalhadas <= 0 || salario <= 0) {
                Console.WriteLine ("Algum dos campos é menor que 0.");
                }
            } while (horasTrabalhadas <= 0 || salario <= 0);
        Funcionario funcionario = new Funcionario ();
        funcionario.Salario = salario;
        funcionario.Nome = nome;
        funcionario.HorasTrabalhadas = horasTrabalhadas;
        
        Console.WriteLine ("Salario total: " +  funcionario.CalcularSalarioTotal());
        }
    }

