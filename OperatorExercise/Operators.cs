using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class Operators
    {
        public static double AreaOfACircle()
        {
            Console.WriteLine("what is the raidus of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"the area of the circle is {area}, and {radius} is the radius.");
            return area;
        }
    }
}
