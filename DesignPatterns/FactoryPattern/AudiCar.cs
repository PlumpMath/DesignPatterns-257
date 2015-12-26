using System;

namespace DesignPatterns.FactoryPattern
{
    public class AudiCar : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("Audi turned off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Audi turned on");
        }
    }
}
