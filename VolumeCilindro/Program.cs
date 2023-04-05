namespace VolumeCilindro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio = 4;
            double altura = 5;
            Calculadora calculadora = new Calculadora(raio, altura);
            Console.WriteLine("Resultado: " + calculadora.CalcularVolume() + " cm³");
        }
    }
}