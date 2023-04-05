namespace ConverterParaCelsius
{
    internal class Conversor
    {
        private double _fahrenheit;
        private double _celsius;

        public Conversor(double fahrenheit)
        {
            _fahrenheit = fahrenheit;
        }

        public double ConverterParaCelsius()
        {
            _celsius = (_fahrenheit - 32)/1.8;
            return _celsius;
        }
    }
}