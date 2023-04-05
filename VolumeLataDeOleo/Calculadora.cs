using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolumeLataDeOleo
{
    public class Calculadora
    {
        private double _raio;
        private double _altura;
        private double _largura;
        private double _comprimento;
        public Calculadora(double raio, double altura)
        {
            _raio = raio;
            _altura = altura;
        }
        public Calculadora(double altura, double largura, double comprimento)
        {
            _altura = altura;
            _largura = largura;
            _comprimento = comprimento;
        }
        public double CalcularVolumeCilindro()
        {
            return Math.PI * Math.Pow(_raio, 2) * _altura;
        }
        public double CalcularVolumeRetangulo()
        {
            return _altura * _largura * _comprimento;
        }
    }
}