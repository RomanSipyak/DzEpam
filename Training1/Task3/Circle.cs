using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1.Task3
{
    public class Circle
    {
        public const double PI = 3.14159265358979;

        public double GetArea(double radius)
        {
            if ( radius <= 0)
            {
                return double.NaN;
            }
            else
            {
                return PI * radius * radius;
            }
        }

        public double GetLength(double radius)
        {
            if (radius <= 0)
            {
                return double.NaN;
            }
            else
            {
                return 2 * PI * radius;
            }
        }
    }
}