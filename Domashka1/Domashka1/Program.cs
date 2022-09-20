using System;
using System.Globalization;

namespace Domashka1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x1:");
            double x1 = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);
            Console.Write("Введите y1:");
            double y1 = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);
            Console.Write("Введите x2:");
            double x2 = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);
            Console.Write("Введите y2:");
            double y2 = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);
            double a = y2-y1;
            double b = x2-x1;
            double P = 2*a+2*b;
            double S = a * b;
            Console.WriteLine("Периметр и Площадь равны:");
            Console.WriteLine($"P={P}");
            Console.WriteLine($"S={S}");
        }
    }
}
