using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Method
    {

       
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

    }
}