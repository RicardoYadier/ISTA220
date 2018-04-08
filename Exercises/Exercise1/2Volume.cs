using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeofaHemisphere
{
    class Program
    {
        static void Main(string[] args)
        {
            double vol;
            double pi = 3.14159F;
            Console.WriteLine("Enter a radius value");
            double r = double.Parse(Console.ReadLine());
            vol = ((4 / 3) * pi * (r * r * r)) / 2;
            Console.WriteLine($"The volume of the circle is {vol}");
        }
    }
}
