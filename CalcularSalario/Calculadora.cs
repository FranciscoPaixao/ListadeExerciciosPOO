using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcularSalario
{
    public class Calculadora
    {
        private double _salarioBase;
        private double _bonusPorVenda;
        private double _valorTotalEmVendas;

        public Calculadora(double salarioBase, double bonusPorVenda, double valorTotalEmVendas)
        {
            _salarioBase = salarioBase;
            _bonusPorVenda = bonusPorVenda/100;
            _valorTotalEmVendas = valorTotalEmVendas;
        }

        public double CalcularSalario()
        {
            return _salarioBase + (_bonusPorVenda * _valorTotalEmVendas);
        }

    }
}