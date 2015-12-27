using DesignPatterns.BridgePattern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class BridgeTests
    {
        [Test]
        public void Test_PrintAllManuscripts()
        {
            List<IManuscript> manuscripts = new List<IManuscript>(); 

            Book book = new Book();
            book.Title = "Book title";
            book.Author = "Anonymous";
            manuscripts.Add(book);

            Faq faq = new Faq();
            faq.SectionTitle = "Important";
            faq.Questions = new List<string> { "First", "Second" };
            manuscripts.Add(faq); 

            foreach(var elem in manuscripts)
            {
                elem.Print(); 
            }
        }
    }
}
