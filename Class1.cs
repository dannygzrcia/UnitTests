using System;

namespace MinimumLibrary
{
    public class MinimumCalculator
    {
        public static int Min(int a, int b)
        {
            return Math.Min(a, b);
        }

        public static int Min(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }

        public static double Min(double a, double b, double c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
    }
}
