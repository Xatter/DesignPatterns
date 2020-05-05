using CH1.FlyBehaviors;
using CH1.QuackBehaviors;
using System;

namespace CH1.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWingsBehavior();
            QuackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I am a Mallard Duck");
        }
    }
}
