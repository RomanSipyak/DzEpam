using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1.Task4
{
    public static class Circle
    {
        public const double PI = 3.14159265358979;

        public static double GetArea(double radius)
        {
            return PI * radius * radius;
        }

        public static double GetLength(double radius)
        {
            return 2 * PI * radius;
        }
    }
}
