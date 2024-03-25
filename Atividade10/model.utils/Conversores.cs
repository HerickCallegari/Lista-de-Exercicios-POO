using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade10.model.utils
    {
    internal class Conversores
        {
        public static double ConversorDeMoedas(double valor, double cambio) {
            return valor / cambio;
            }
        }
    }
