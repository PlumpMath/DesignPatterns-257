using System.Collections.Generic;

namespace DesignPatterns.BuilderPattern
{
    // Ensures that all properties are initialized
    // Final form of this class contains only details about how to build sandwich object
    public class MyFavoriteSandwichBuilder : SandwichBuilder
    {
        public override void ApplyCheeseAndMeat()
        {
            _sandwich.CheeseType = CheeseType.Cheddar;
            _sandwich.MeatType = MeatType.Chicken;
        }

        public override void ApplyVegatables()
        {
            _sandwich.Vegatables = new List<string> { "tomato", "onion" };
        }

        public override void ApplyCondiments()
        {
            _sandwich.HasKetchup = true;
            _sandwich.HasMustard = true;
        }
    }
}
