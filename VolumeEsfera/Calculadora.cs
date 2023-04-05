using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeEsfera
{
    internal class Calculadora
    {
        private double _raio;
        private double _volume;

        public Calculadora(double raio)
        {
            _raio = raio;
        }

        public double CalcularVolume()
        {
            _volume = (4 * Math.PI * Math.Pow(_raio, 3)) / 3;
            return _volume;
        }
    }
}
