namespace VolumeEsfera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio = 10;
            Calculadora calculadora = new Calculadora(raio);
            Console.WriteLine("Volume: " + calculadora.CalcularVolume() + " m³s");
        }
    }
}