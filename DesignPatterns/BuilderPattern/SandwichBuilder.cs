using System.Collections.Generic;

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

            // Property initialization is refactored to use methods 
            ApplyCheeseAndMeat();
            ApplyVegatables(); 
            ApplyCondiments(); 
        }

        private void ApplyCheeseAndMeat()
        {
            _sandwich.CheeseType = CheeseType.Cheddar;
            _sandwich.MeatType = MeatType.Chicken;
        }

        private void ApplyVegatables()
        {
            _sandwich.Vegatables = new List<string> { "tomato", "onion" };
        }

        private void ApplyCondiments()
        {
            _sandwich.HasKetchup = true;
            _sandwich.HasMustard = true;
        }
    }
}
