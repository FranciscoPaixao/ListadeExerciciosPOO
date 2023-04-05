using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeCilindro
{
    internal class Calculadora
    {
        private double _raio;
        private double _altura;

        public Calculadora(double raio, double altura)
        {
            _raio = raio;
            _altura = altura;
        }
        public double CalcularVolume()
        {
            return Math.PI * Math.Pow(_raio, 2) * _altura;
        }
    }
}
