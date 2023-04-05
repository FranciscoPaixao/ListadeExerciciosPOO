namespace Lista_de_Exercícios_POO.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora volume = new Calculadora(2,3,4);
            Console.WriteLine($"Volume: {volume.CalcularVolume()}");
        }
    }
}