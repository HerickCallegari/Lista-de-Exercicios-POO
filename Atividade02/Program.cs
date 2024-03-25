using Atividade02.model.utils;
using Biblioteca;

namespace Atividade02
    {
    internal class Program
        {
        static void Main ( string[] args )
            {
            string entrada;
            char operador;

            do {
                Console.Write ("Qual operação você deseja executar? \nescolha entre( + , - , / ou  * ):");
                entrada = Console.ReadLine ()!;

                //verifica se a entrada não é nula
                if (string.IsNullOrEmpty (entrada)) {
                    Console.WriteLine("Valor invalido. Digite novamente.");
                }
                operador = entrada.FirstOrDefault<char> ();

                //verificar se o operador é algum dos digitos validos
                if (operador != '+' ||
                operador != '-' ||
                operador != '/' ||
                operador != '*') {
                    Console.WriteLine("Digite um operador valido");
                }

                } while (string.IsNullOrEmpty (entrada) ||
                operador != '+' &
                operador != '-' &&
                operador != '/' &&
                operador != '*');

            Console.WriteLine ();

            double numero1;
            double numero2;

                numero1 = Leitura.LerDoubleComMsg ("Primeiro numero: ");
                numero2 = Leitura.LerDoubleComMsg ("segundo numero: ");

            double resultado = 0.0;
            switch (operador) {
                case '+':
                    resultado = Calculadora.Soma (numero1, numero2);
                    break;
                case '-':
                    resultado = Calculadora.Subtracao (numero1, numero2);
                    break;
                case '/':
                    resultado = Calculadora.Divisao (numero1, numero2);
                    break;
                case '*':
                    resultado = Calculadora.Multiplicacao (numero1, numero2);
                    break;
                default:
                    Console.WriteLine ("Erro!!");
                    break;
                }

            Console.WriteLine("Resultado: " + resultado);

        }
        }
    }
