using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade09.model.entities
    {
    internal class Carro
        {
        private string _modelo;
        private int _ano;
        private double _preco;

        public string Modelo {  get { return _modelo; } set {  _modelo = value; } }
        public int Ano { get { return _ano;} set { _ano = value; } }
        public double Preco { get { return _preco; } set { _preco = value; } }
        
        public double CalcularDesconto()
            {
            return _ano < 2010 ? _preco * 0.90 : _preco * 0.95;
            }
        }
    }
