using System;

namespace Home06_Method_out
{
    class Program
    {
        static int power(int a, int b, out double c)
        {
            int power = 1;
            
            while (b > 0)
            {
                power *= a;
                b--;
            }
            c = power / 2;

            return power;
        }
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine(power(9, 2, out a));
            Console.WriteLine(a);
        }
    }
}
