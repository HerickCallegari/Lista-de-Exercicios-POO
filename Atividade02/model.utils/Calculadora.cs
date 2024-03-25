using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02.model.utils
    {
    internal class Calculadora{
        public static double Soma(double numero1, double numero2 ){
            return numero1 + numero2;
            }

        public static double Subtracao ( double numero1, double numero2 )
            {
            return numero1 - numero2;
            }
        public static double Multiplicacao ( double numero1, double numero2 )
            {
            return numero1 * numero2;
            }
        public static double Divisao ( double numero1, double numero2 )
            {
            return numero1 / numero2;
            }
        }
    }
