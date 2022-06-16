using System;
namespace CSClass
{
    public class Parent
    {
        public static int counter = 0;
        public void CountParent()
        {
            Parent.counter++;
        }
        public Parent()
        {
            Console.WriteLine("부모 생성자");
            
        }
        public Parent(int param)
        {
            Console.WriteLine("Parent(int param");

        }
        public Parent(String param)
        {
            Console.WriteLine("Parent(Stirng param");
        }
    }
}