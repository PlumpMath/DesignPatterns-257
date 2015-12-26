using System;
using System.Collections.Generic;
using System.Linq; 

namespace DesignPatterns.FactoryPattern
{
    public class CarFactory
    {
        private Dictionary<string, Type> autos; 

        public CarFactory()
        {
            autos = new Dictionary<string, Type>();
            autos.Add("audi", typeof(AudiCar));
            autos.Add("toyota", typeof(ToyotaCar));
        }

        // Usage of dictionary and this method implementation allows to avoid switch statement 
        public IAuto CreateInstance(string carName)
        {
            //Type typeToCreate = autos["carName"]; 
            Type typeToCreate = autos.Single(s => s.Key.ToUpper() == carName.ToUpper()).Value; 
            if(typeToCreate != null)
            {
                return Activator.CreateInstance(typeToCreate) as IAuto; 
            }

            return null; 
        }
    }
}
