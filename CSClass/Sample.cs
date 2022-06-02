using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    class Sample
    {
        public static int value = 42;

        static Sample()
        {
            value = 99;
            Console.WriteLine("Sample() 정적 생성자 호출!!");
        }

        /*static Sample()
        {
            value = 99;
            Console.WriteLine("Sample() 정적 생성자 호출!!");
        }*/
    }
}
