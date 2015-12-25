using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.BuilderPattern
{
    public class Sandwich
    {
        private CheeseType _cheeseType;
        private bool _hasKetchup;
        private bool _hasMustard;
        private MeatType _meatType;
        private List<string> _vegatables;

        // This constructor has a problem - too many parameters
        public Sandwich(CheeseType cheeseType, MeatType meatType, bool hasKetchup, bool hasMustard, IEnumerable<string> vegetables)
        {
            _cheeseType = cheeseType;
            _meatType = meatType;
            _hasKetchup = hasKetchup;
            _hasMustard = hasMustard;
            _vegatables = vegetables.ToList(); 
        }
    }

    public enum CheeseType
    {
        Cheddar, 
        Gouda, 
        Emmentaler
    }

    public enum MeatType
    {
        Sausage, 
        Pork, 
        Chicken
    }
}
