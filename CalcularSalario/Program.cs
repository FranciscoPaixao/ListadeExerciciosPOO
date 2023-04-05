namespace CalcularSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioBase = 1000;
            double bonusPorVenda = 5;
            double totalVendas = 10000;
            Calculadora calculadora = new Calculadora(salarioBase, bonusPorVenda, totalVendas);
            Console.WriteLine("Salário: " + calculadora.CalcularSalario());
        }
    }
}