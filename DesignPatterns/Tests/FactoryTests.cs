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
            CarFactory manager = new CarFactory(); //NOTE: factory type has to be known by the caller in simple factory approach
            IAuto auto = manager.CreateInstance("audi");

            auto.TurnOn();
            auto.TurnOff(); 
        }
    }
}
