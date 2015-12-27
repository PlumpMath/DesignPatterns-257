using System;
using System.Collections.Generic;

namespace DesignPatterns.BridgePattern
{
    class Faq : IManuscript
    {
        public string SectionTitle { get; set; }
        public List<string> Questions { get; set; }

        public void Print()
        {
            Console.WriteLine(SectionTitle);
            Questions.ForEach(s => Console.WriteLine(s));
        }
    }
}
