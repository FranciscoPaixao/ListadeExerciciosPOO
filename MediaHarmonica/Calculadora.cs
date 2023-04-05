using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaHarmonica
{
    public class Calculadora
    {
        private double _mediaHarmonica;
        private double[] _notas;

        public Calculadora(double[] notas)
        {
            _notas = notas;
        }
        
        public double CalcularMediaHarmonica()
        {
            double soma = 0;
            foreach (var nota in _notas)
            {
                soma += 1 / nota;
            }

            _mediaHarmonica = _notas.Length / soma;
            return _mediaHarmonica;
        }
    }
}