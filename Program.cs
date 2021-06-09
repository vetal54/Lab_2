using System;

namespace Laba2_1
{
    class Program
    {
        delegate double Delegates(double x);

        static void Main(string[] args)
        { 
            Console.WriteLine("0 -- sqrt(abs(x))");
            Console.WriteLine("1 -- x^3 ");
            Console.WriteLine("2 -- x+3.5");
            Console.WriteLine("Згiдно цифри на початку i виводитиме результат");
            Console.WriteLine("Якщо вхiдний рядок не задовольнятиме цей формат, програма завершить свою роботу");
            Delegates[] Methods = new Delegates[] { Method0, Method1, Method2 };
            while (true)
            {
                try
                {
                    string [] a = Console.ReadLine().Split(' ');
                    double a1 = double.Parse(a[1]);
                    Console.WriteLine(Methods[Convert.ToInt32(a[0])](a1));
                }
                catch (Exception)
                { 
                    Console.WriteLine("Помилка. Input string was not in a correct format");
                    break;
                }
            }
            Console.ReadKey();
        }
        static double Method0(double x) => Math.Sqrt(Math.Abs(x));
        static double Method1(double x) => x * x * x;
        static double Method2(double x) => x + 3.5;
    }
}
