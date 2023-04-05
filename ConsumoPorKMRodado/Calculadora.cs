using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoPorKMRodado
{
    internal class Calculadora
    {
        private double _kmRodado;
        private double _consumoPorKM;
        private double _kmInicial;
        private double _kmFinal;

        public Calculadora(double kmInicial, double kmFinal, double consumoPorKM)
        {
            _kmInicial = kmInicial;
            _kmFinal = kmFinal;
            _consumoPorKM = consumoPorKM;
        }

        public double CalcularConsumo()
        {
            _kmRodado = _kmFinal - _kmInicial;
            return _consumoPorKM * _kmRodado;
        }
    }
}
