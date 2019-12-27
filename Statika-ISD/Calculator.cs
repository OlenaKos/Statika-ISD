using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statika_ISD
{
    static class Calculator
    {
        public static double Plus(double a, double b)
        {
            return a + b;
        }
        public static double Minus(double a, double b)
        {
            return Plus(a, -b);
        }

        public static double Mult(double a, double b)
        {
            return a * b;
        }

        public static double Division(double a, double b)
        {
            if (b == 0)
            {
                return Double.NaN;
            }
            else
            { return a / b; }

        }
    }
}
