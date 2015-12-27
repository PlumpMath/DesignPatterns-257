using System;

namespace DesignPatterns.BridgePattern
{
    class Book : Manuscript
    {
        public Book(ICustomFormatter formatter) : base(formatter) {}

        public string Title { get; set; }
        public string Author { get; set; }

        public override void Print()
        {
            Console.WriteLine($"{_formatter.Format("Title", Title)} and {Author}");
        }
    }
}
