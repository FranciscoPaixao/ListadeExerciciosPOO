namespace ConverterParaCelsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = 50;
            Conversor conversor = new Conversor(fahrenheit);
            Console.WriteLine("Resultado: " + conversor.ConverterParaCelsius() + "°C");
        }
    }
}