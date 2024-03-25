using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade06.mode.entities
    {
    internal class Aluno
        {
        private string _nome;
        private List<double> _notas = new();
        public string Nome { 
            get { return _nome;} 
            set { _nome = value; } 
            }
        public List<double> Notas { 
            get { return _notas; } 
            }
        public void addNota (double nota) {
            _notas.Add(nota);
            }
        public void removeNota (double nota)
            {
            _notas.Remove(nota);
            }
        public double CalculaMedia()
            {
            double somaDasNotas = _notas.Sum();
            int quantidadeDeMaterias = _notas.Count();
            double media = somaDasNotas/quantidadeDeMaterias;
            return media;
            }
        }
    }
