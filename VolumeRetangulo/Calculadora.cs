using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercícios_POO.ConsoleApp
{
    internal class Calculadora
    {
        private double _altura;
        private double _largura;
        private double _comprimento;

        public Calculadora(double altura, double largura, double comprimento)
        {
            _altura = altura;
            _largura = largura;
            _comprimento = comprimento;
        }

        public double CalcularVolume()
        {
            return _altura*_largura*_comprimento;
        }
    }
}
