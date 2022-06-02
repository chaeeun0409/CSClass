using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Method
    {
        int instanceVariable = 10;
        static int classVariable = 10;
       
        public double Multi(int v1, int v2)
        {
            return v1 * v2;
        }/// <summary>
         /// min 부터 max까지의 합
         /// </summary>
         /// <param name="min">시작 값</param>
         /// <param name="max">최대 값</param>
         /// <returns>min부터 max까지의 합계</returns>
        public int Sum(int min, int max)
        {
            int output = 0;
            for(int i = min; i<=max; i++)
            {
                output += i;
            }
            return output;
        }
        /// <summary>
        /// min 부터 max까지의 곱
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>min부터 max까지의 곱</returns>
        public int Multiply(int min, int max)
        {
            int output = 0;
            for (int i = min; i <= max; i++)
            {
                output *= i;
            }
            return output;

        }
        static public void some()
        {
            //Multiply(1,10);
            //  Console.WriteLine(this.instanceVariable);
            Console.WriteLine(classVariable);
        }
        public static int Abs(int input)
        {
            if(input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }
        }
    }
}