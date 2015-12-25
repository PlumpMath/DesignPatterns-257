using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.BuilderPattern
{
    public class Sandwich
    {
        public CheeseType CheeseType {get; set;}
        public bool HasKetchup { get; set; }
        public bool HasMustard { get; set; }
        public MeatType MeatType { get; set; }
        public List<string> Vegatables { get; set; }

        public void Display()
        {
            System.Console.WriteLine("This is sample sandwich"); //only partial implementation for test purposes
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
