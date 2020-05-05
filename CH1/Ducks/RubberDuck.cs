using CH1.FlyBehaviors;
using CH1.QuackBehaviors;
using System;

namespace CH1.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehavior = new NoFlyBehavior();
            QuackBehavior = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("I am a Rubber Duckie");
        }
    }
}
