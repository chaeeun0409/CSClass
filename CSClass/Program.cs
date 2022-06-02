using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();


            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 10);


            /*l    List<int> list = new List<int>();
             * ist.Add(90);
            list.Add(24);
            list.Add(21);
            list.Add(40);*/
            List<int> list = new List<int>() { 52, 273, 32, 24 };
            list.Remove(52);
            foreach (var item in list)
            {
                Console.WriteLine("Count:" + list.Count + "\titem : " + item);

            }

            //  Math 클래스  수학과 관련된 클래스
            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));
            Console.WriteLine(Math.PI);

            Hamburger nyam = new Hamburger();

            Product productA = new Product();
            productA.name = "포켓몬빵";
            productA.price = 1500;
            //인스턴스 변수를 생성과 동시에 초기화(C# 고유 문법)
            Product productB = new Product() { name="소금빵", price=2000};
            Product productC = new Product() { price=5000, name = "당근케이크"};
            Product productD = new Product() { price=6000 };

            List<Student> students = new List<Student>()
            {
                 new Student() { name = "이채은", grade = 1 },
                 new Student() { name = "윤서연", grade = 3 },
                 new Student() { name = "김지호", grade = 2 },
                 new Student() { name = "이자두", grade = 3 },

            };

            /*   foreach (var item in students)
               {
                   if(item.grade > 2)
                   {
                       students.Remove(item);
                   }`

          *//*     }*//*
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].grade > 2)
                {
                    students.RemoveAt(i);
                    //students.Remove(students[i]);
                    i--;
                }
            }*/
            for (int i = students.Count-1; i >=0; i--)
            {
                if (students[i].grade > 2)
                {
                    students.RemoveAt(i);
                }
             
            }
            foreach (var item in students)
            {
                Console.WriteLine(item);

            }
            Method method = new Method();
            Console.WriteLine(method.Multi(52, 273));
            Console.WriteLine(method.Sum(1, 100));
            Console.WriteLine(method.Multiply(1, 10));
            Console.WriteLine(Method.Abs(-100));
            Console.WriteLine(Method.Abs(100));
           // Console.WriteLine(method.Abs(-100)); //java는 가능, c#은 불가능



        }
    }
}
