using System;

namespace DesignPatterns.BridgePattern
{
    class Book : IManuscript
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public void Print()
        {
            Console.WriteLine($"{Title} and {Author}");
        }
    }
}
