namespace MediaHarmonica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var calculadora = new Calculadora(notas);
            Console.WriteLine("Média Harmônica: " + calculadora.CalcularMediaHarmonica());
        }
    }
}