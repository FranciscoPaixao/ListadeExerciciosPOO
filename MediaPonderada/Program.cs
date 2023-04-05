namespace MediaPonderada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = { 8, 7};
            double[] pesos = { 2, 3};
            var calculadora = new Calculadora(notas, pesos);
            Console.WriteLine("Média Ponderada: " + calculadora.CalcularMediaPonderada());
        }
    }
}