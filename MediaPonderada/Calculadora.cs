using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaPonderada
{
    public class Calculadora
    {
        private double _mediaPonderada;
        private double[] _notas;
        private double[] _pesos;

        public Calculadora(double[] notas, double[] pesos)
        {
            _notas = notas;
            _pesos = pesos;
        }
        
        public double CalcularMediaPonderada()
        {
            double soma = 0;
            double somaPesos = 0;
            for (int i = 0; i < _notas.Length; i++)
            {
                soma += _notas[i] * _pesos[i];
                somaPesos += _pesos[i];
            }

            _mediaPonderada = soma / somaPesos;
            return _mediaPonderada;
        }
    }
}