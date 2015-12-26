using System;

namespace DesignPatterns.FactoryPattern
{
    internal class ToyotaCar : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("Toyota turned off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Toyota turned on");
        }
    }
}