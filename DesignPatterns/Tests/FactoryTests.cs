using DesignPatterns.FactoryPattern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class FactoryTests
    {
        [Test]
        public void Test_CreateCar()
        {
            CarManager manager = new CarManager();
            IAuto auto = manager.GetCar("audi");

            auto.TurnOn();
            auto.TurnOff(); 
        }
    }
}
