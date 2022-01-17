using System;

namespace KalkulatorKonsolowy
{
    class Program : CalculationType
    {
        static void Main(string[] args)
        {
            double x, y;
            char sign;
            Console.WriteLine("Podaj pierwszą liczbę:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj symbol: \n + : dodawanie \n - : odejmowanie \n * : mnożenie \n / : dzielenie \n % : modulo");
            sign = Convert.ToChar(Console.ReadLine());

            Calculate(ref sign, ref x, ref y);
            Console.WriteLine(result);
        }
    }
}
