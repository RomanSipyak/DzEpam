using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1
{
    public static class MyMath
    {
        public static double GetRoot(double number)
        {
            if (number > 0)
            {
                double root = number / 3;
                for (int i = 0; i < 32; i++)
                {
                    root = (root + (number / root)) / 2;
                }

                return root;
            }
            else
            {
                return double.NaN;
            }
        }

        public static double GetPow(double number, int pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}