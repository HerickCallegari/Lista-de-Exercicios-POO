using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1.model.entities
    {
    internal class Pessoa {
        private string _nome;
        private int _idade;
        private double _altura;

        public Pessoa ( ) { }

        public Pessoa ( string _nome, int _idade, double _altura )
            {
            this._nome = _nome;
            this._idade = _idade;
            this._altura = _altura;
            }

        public void SetNome(string _nome){ 
            this._nome = _nome; 
        }
        public string GetNome() { 
            return _nome;
        }
        public void SetIdade ( int _idade)
            {
            this._idade= _idade;
            }
        public int GetIdade(){
            return _idade;
            }
        public void SetAltura( double _altura )
            {
            this._altura = _altura;
            }
        public double GetAltura( )
            {
            return _altura;
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
