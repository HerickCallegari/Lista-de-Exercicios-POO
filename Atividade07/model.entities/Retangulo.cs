using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade07.model.entities
    {
    internal class Retangulo
        {
        private double _altura;
        private double _base;
        public double Altura { get { return _altura; } set { _altura = value; } }
        public double Base { get { return _base; } set { _base = value; } }
        
        public double CalcularPerimetro()
            {
            return (_altura + _base) * 2;
            }
        }
    }
