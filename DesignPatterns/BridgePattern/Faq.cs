using System;
using System.Collections.Generic;

namespace DesignPatterns.BridgePattern
{
    class Faq : Manuscript
    {
        public Faq(ICustomFormatter formatter) : base(formatter) {}

        public string SectionTitle { get; set; }
        public List<string> Questions { get; set; }

        public override void Print()
        {
            Console.WriteLine(_formatter.Format("SectionTitle", SectionTitle));
            Questions.ForEach(s => Console.WriteLine(s));
        }
    }
}
