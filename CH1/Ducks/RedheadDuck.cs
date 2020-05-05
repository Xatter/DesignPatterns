using CH1.FlyBehaviors;
using CH1.QuackBehaviors;
using System;

namespace CH1.Ducks
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            FlyBehavior = new FlyWithWingsBehavior();
            QuackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I am a Redhead Duck");
        }
    }
}
