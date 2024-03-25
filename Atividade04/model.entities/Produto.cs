using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04.model.entities
    {
    internal class Produto{
        private string _nome;
        private double _valor;
        private int _quantidade;
        public string Nome { 
            get { return _nome; }
            set { _nome = value; } 
            }
        public double Valor
            {
            get { return _valor; }
            set { _valor = value; }
            }

        public int Quantidade{
            get { return _quantidade; }
            set {_quantidade = value; }
            }

        public double CalcularTotal ( )
            {
            return _quantidade * _valor;
            }

        }
    }
