using DesignPatterns.BridgePattern;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class BridgeTests
    {
        [Test]
        public void Test_PrintAllManuscripts()
        {
            // Entities always derive from Manuscript class - this does not change
            // But formatting implementation can be changed and it doesn't require changing base class 
            List<Manuscript> manuscripts = new List<Manuscript>(); 
            BridgePattern.ICustomFormatter standardFormatter = new StandardFormatter(); 

            Book book = new Book(standardFormatter);
            book.Title = "Book title";
            book.Author = "Anonymous";
            manuscripts.Add(book);

            Faq faq = new Faq(standardFormatter);
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
