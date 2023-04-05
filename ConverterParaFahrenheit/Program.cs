namespace ConverterParaFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperaturaEmCelsius = 10;
            Conversor celsius = new Conversor(temperaturaEmCelsius);

            Console.WriteLine("Resultado: " + celsius.ConverterParaFahrenheit() + "°F");
        }
    }
}