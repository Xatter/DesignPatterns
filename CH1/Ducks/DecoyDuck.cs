using CH1.FlyBehaviors;
using CH1.QuackBehaviors;
using System;

namespace CH1.Ducks
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            FlyBehavior = new NoFlyBehavior();
            QuackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I am a decoy duck, don't trust me!");
        }
    }
}
