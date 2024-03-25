using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03.model.entities
    {
    internal class Triangulo{

        private double _base;
        private double _altura;

        public double Base
            {
            get { return _base; }
            set { _base = value; }
            }

        public double Altura
            {
            get { return _altura; }
            set { _altura = value; }
            }
        public double CalcularArea(){
            return (_altura * _base) / 2; 
            }
        }
    }
