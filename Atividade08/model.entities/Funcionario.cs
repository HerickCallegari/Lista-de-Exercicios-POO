using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade08.model.entities
    {
    internal class Funcionario
        {
        private string _nome;
        private double _salario;
        private int _horasTrabalhadas;
        public string Nome { get { return _nome;} set { _nome = value; } }
        public double Salario {  get { return _salario;} set {  _salario = value; } }
        public int HorasTrabalhadas { get { return _horasTrabalhadas; } set {  _horasTrabalhadas = value;} }

        public double CalcularSalarioTotal ( )
            {
            return _salario * _horasTrabalhadas;
            }
        }
    }
