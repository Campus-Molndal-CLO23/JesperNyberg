using System;
namespace Temperaturomvandling
{
    internal class Program
    {
        private const int celsius = 25;
        static void Main(string[] args)
        {
            Temperaturomvandling();

            Console.Read();
        }

        public static void Temperaturomvandling()
        {
            PrintToConsole($"Celsius: {celsius} grader");
            PrintToConsole($"Farenheit: {celsius.ConvertToFarenheit()} grader");
            PrintToConsole($"Kelvin:  {celsius.ConvertToKelvin()} grader");
        }

        public static void PrintToConsole(string temperature)
        {
            Console.WriteLine(temperature);
        }
    }

    public static class Extension
    {
        public static double ConvertToFarenheit(this int celsius)
        {
            return celsius * 1.8 + 32;
        }

        public static double ConvertToKelvin(this int celsius)
        {
            return celsius + 273.15;
        }
    }
}
