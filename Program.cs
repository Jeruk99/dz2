using System;

namespace dz2
{
    
    class ConsoleConversion
    {
        public static string Per(int i, int n)
        {
            if (i > 0)
               return Per(i / n,n) + i % n;
            return "";
        }
        static void Main()
        {
            int num;
            Console.Write("Введите число: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите систему счисления: ");
            int bas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше число в {0}-ной системе счисления: {1}",bas, Per(num,bas));
            Console.ReadKey();
        }
    }
}
