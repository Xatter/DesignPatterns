using System;
using System.Collections.Generic;
using System.Text;

namespace CH1.QuackBehaviors
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
