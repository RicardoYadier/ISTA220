using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the first number?");
            double num1 = double.Parse(Console.ReadLine());

            double result1 = Compare(num1);
            Console.WriteLine("What is the second number?");
            double num2 = double.Parse(Console.ReadLine());

            double result2 = Compare(num2);
            Console.WriteLine("What is the third number?");
            double num3 = double.Parse(Console.ReadLine());

            double result3 = Compare(num3);
            Console.WriteLine("What is the fourth number?");
            double num4 = double.Parse(Console.ReadLine());

            double result4 = Compare(num4);
            Console.WriteLine("What is the fifth number?");
            double num5 = double.Parse(Console.ReadLine());

            double result5 = Compare(num5);
            Console.WriteLine("What is the sixth number?");
            double num6 = double.Parse(Console.ReadLine());

            double result6 = Compare(num6);
            Console.WriteLine("What is the seventh number?");
            double num7 = double.Parse(Console.ReadLine());

            double result7 = Compare(num7);
            Console.WriteLine("What is the eighth number?");
            double num8 = double.Parse(Console.ReadLine());

            double result8 = Compare(num8);
            Console.WriteLine("What is the ninth number?");
            double num9 = double.Parse(Console.ReadLine());

            double result9 = Compare(num9);
            Console.WriteLine("What is the tenth number?");
            double num10 = double.Parse(Console.ReadLine());

            double result10 = Compare(num10);

            Console.WriteLine
                ("The sum is {0}", (result1 + result2 + result3 + result4 + result5 +
                result6 + result7 + result8 + result9 + result10));
            Console.ReadLine();
        }

        public static double Compare(double num)
        {

            if (num < 0 || num > 100)
            {
                Console.WriteLine("Please enter a number between 0-100");
                num = double.Parse(Console.ReadLine());
                return num;
            }
            else
            {
                return num;
            }
        }
    }
}
