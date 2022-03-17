using System;

namespace dz2
{ 
 
class Conversion
    {

        public string v;
        public void Per(int i)
        {
            if (i > 0)
            {
                if (i % 2 == 1)
                    v += "1";
                else
                    v += "0";
                Per(i / 2);
            }
        }
    }
    class ConsoleConversion
    {
        static void Main()
        {
            int num;
            Conversion ob = new Conversion();
            Console.Write("Введите число: ");
            num = Convert.ToInt32(Console.ReadLine());
            ob.Per(num);
            Console.WriteLine("Ваше число в двоичной системе: {0}", ob.v);
            Console.ReadKey();
        }
    }
}
