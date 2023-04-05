namespace ConsumoPorKMRodado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kmInicial = 100;
            double kmFinal = 200;
            double consumoPorKM = 10;
            Calculadora calculadora = new Calculadora(kmInicial, kmFinal, consumoPorKM);
            Console.WriteLine("Consumo: " + calculadora.CalcularConsumo() + " litros");
        }
    }
}