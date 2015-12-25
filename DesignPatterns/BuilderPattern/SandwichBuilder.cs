using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    // Base class for all specific builders
    public abstract class SandwichBuilder
    {
        protected Sandwich _sandwich; 

        public Sandwich GetSandwich()
        {
            return _sandwich; 
        }

        public void CreateSandwich()
        {
            _sandwich = new Sandwich(); 
        }

        public abstract void ApplyCheeseAndMeat();
        public abstract void ApplyVegatables();
        public abstract void ApplyCondiments(); 
    }
}
