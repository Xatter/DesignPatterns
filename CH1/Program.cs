using CH1.Ducks;
using CH1.FlyBehaviors;
using System;
using System.Collections.Generic;

namespace CH1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Pond = new List<Duck>()
            {
                new MallardDuck(),
                new RedheadDuck(),
                new RubberDuck(),
                new DecoyDuck()
            };

            foreach (var duck in Pond)
            {
                duck.Display();
                duck.Swim();
                duck.PerformQuack();
                duck.PerformFly();
            }

            // Behaviors can also change dynamically at runtime (maybe through a powerup!)
            Pond[1].FlyBehavior = new FlyRocketPowered();
            foreach (var duck in Pond)
            {
                duck.Display();
                duck.Swim();
                duck.PerformQuack();
                duck.PerformFly();
            }
        }
    }
}
