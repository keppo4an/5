using System;

namespace vsvode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
         int a = int.Parse(Console.ReadLine());
         int s = 0;
         for (int i = 1;i <= a;i++)
         {
             s+=i;
         }
         Console.WriteLine($"Сумма всех N чисел = : {s}");
        }
    }
}
