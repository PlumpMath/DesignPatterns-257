using System;

namespace DesignPatterns.BridgePattern
{
    class Book : Manuscript
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public override void Print()
        {
            Console.WriteLine($"{Title} and {Author}");
        }
    }
}
