using System;

namespace задание__2_Додекаэдр
{
    class Program
    {
        static void Main(string[] args)
        {
            double V, S;
            Console.WriteLine("Введите длину стороны правильного додекаэдра");
            var a = double.Parse(Console.ReadLine());
            S = 3 * a * a * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5)));
            V = (Math.Pow(a, 3) * (15 + 7 * Math.Sqrt(5))) / 4;
            Console.WriteLine($"Площадь поверхности додекаэдра ={S}");
            Console.WriteLine($"Объем додекаэдра ={V}");
        }
    }
}
