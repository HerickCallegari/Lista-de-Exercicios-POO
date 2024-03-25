using Atividade1.model.entities;

namespace Atividade1
    {
    internal class Program
        {
        static void Main ( string[] args )
            {
            Pessoa pessoa = new Pessoa("Herick", 18, 1.72);
            Console.WriteLine( pessoa.ImprimirDados() );
            }
        }
    }
