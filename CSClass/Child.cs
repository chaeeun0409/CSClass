using System;

namespace CSClass
{
    public class Child : Parent
    {
        public Child() : base(10)
        {
            Console.WriteLine("Child() : base(10)");
        }
        public Child(String input) : base(input)
        {
            Console.WriteLine("Child(String input):base(input");
        }
        public void CountChild()
        {
            Child.counter++;
        }
      
    }
}