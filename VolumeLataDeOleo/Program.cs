namespace VolumeLataDeOleo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tipo = "cilindro";
            double raio = 2;
            double altura = 3;
            double largura = 4;
            double comprimento = 5;

            if (tipo.Equals("cilindro"))
            {
                Calculadora calculadora = new Calculadora(raio, altura);
                double volume = calculadora.CalcularVolumeCilindro();
                System.Console.WriteLine(volume);
            }
            else if (tipo.Equals("retangulo"))
            {
                Calculadora calculadora = new Calculadora(largura, altura, comprimento);
                double volume = calculadora.CalcularVolumeRetangulo();
                System.Console.WriteLine(volume);
            }
            else
                System.Console.WriteLine("Tipo inválido");
        }
    }
}