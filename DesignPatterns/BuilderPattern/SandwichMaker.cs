using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class SandwichMaker
    {
        private readonly SandwichBuilder _sandwichBuilder; 

        public SandwichMaker(SandwichBuilder sandwichBuilder)
        {
            _sandwichBuilder = sandwichBuilder; 
        }

        public void BuildSandwich()
        {
            _sandwichBuilder.CreateSandwich(); 
            _sandwichBuilder.ApplyCheeseAndMeat();
            _sandwichBuilder.ApplyVegatables();
            _sandwichBuilder.ApplyCondiments(); 
        }

        public Sandwich GetSandwich()
        {
            return _sandwichBuilder.GetSandwich(); 
        }
    }
}
