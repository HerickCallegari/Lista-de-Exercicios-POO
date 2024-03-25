using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade05.model.entities{
    internal class Pessoa{
        private string _nome;
        private int _idade;
        public string Nome { 
            get { return _nome; } 
            set { _nome = value; }
            }
        public int Idade {  
            get { return _idade; } 
            set {  _idade = value; } 
            }

        public Boolean EhMaiorDeIdade()
            {
            return _idade >= 18;
            }
        }
    }
