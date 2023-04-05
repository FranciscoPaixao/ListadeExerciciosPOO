using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterParaFahrenheit
{
    internal class Conversor
    {
        private double _valorCelsius;

        public Conversor(double valorCelsius)
        {
            _valorCelsius = valorCelsius;
        }
        public double ConverterParaFahrenheit()
        {
            return _valorCelsius*1.8 + 32.0;
        }
    }
}
