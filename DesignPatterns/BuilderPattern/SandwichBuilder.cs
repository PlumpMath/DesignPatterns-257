using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    // Ensures that all properties are initialized
    public class SandwichBuilder
    {
        private Sandwich _sandwich;

        public Sandwich GetSandwich()
        {
            return _sandwich; 
        }

        public void CreateSandwich()
        {
            _sandwich = new Sandwich();
            _sandwich.CheeseType = CheeseType.Cheddar;
            _sandwich.HasKetchup = true;
            _sandwich.HasMustard = true;
            _sandwich.MeatType = MeatType.Chicken;
            _sandwich.Vegatables = new List<string> { "tomato", "onion" };
        }
    }
}
