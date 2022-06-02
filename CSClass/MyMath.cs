using System;

namespace CSClass
{
    public class MyMath
    {
        public static int Abs(int v)
        {
            return (v < 0) ? -1 * v : v;
        }

        public static double Abs(double v)
        {
            return (v < 0) ? -1 * v : v;
        }
        public static long Abs(long v)
        {
            return (v < 0) ? -1 * v : v;
        }
    }
}