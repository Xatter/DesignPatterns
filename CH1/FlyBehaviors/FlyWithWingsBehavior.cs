using System;

namespace CH1.FlyBehaviors
{
    public class FlyWithWingsBehavior : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I spread my wings and soar above the clouds");
        }
    }
}
