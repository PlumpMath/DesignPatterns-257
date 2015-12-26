using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public class AudiFactory : IAutoFactory
    {
        // This is implementation of factory method. Class can have multiple such methods, which allows e.g. to customize created car (luxury audi car, sports audi car etc.) 
        public IAuto CreateAuto()
        {
            return new AudiCar(); 
        }
    }
}
