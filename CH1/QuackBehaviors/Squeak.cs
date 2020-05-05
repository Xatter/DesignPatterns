using System;
using System.Collections.Generic;
using System.Text;

namespace CH1.QuackBehaviors
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
