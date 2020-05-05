using CH1.FlyBehaviors;
using CH1.QuackBehaviors;
using System;

namespace CH1
{
    public class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuackBehavior { get; set; }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void Swim()
        {
            Console.WriteLine("Swimming...");
        }

        public virtual void Display()
        {
            throw new NotImplementedException("Must be implemented in child class");
        }
    }
}
