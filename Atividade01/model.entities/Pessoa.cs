using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01.model.entities
    {
    internal class Pessoa {
        private string _nome;
        private int _idade;
        private double _altura;

        public string Nome {
            get { return _nome; }
            set { this._nome = value; }
        }

        public int Idade
            {
            get { return _idade; }
            set { _idade = value; }
            }
        public double Altura
            {
            get { return _altura; }
            set { _altura = value; }
            }
        public string ImprimirDados()
            {
            return ToString ();
            }
        public override string ToString ( )
            {
            return "Nome: " + _nome +
                   "\nIdade: " + _idade.ToString() +
                   "\nAltura: " + _altura.ToString ("F2") + " metros"; 
            }

        }
    }
