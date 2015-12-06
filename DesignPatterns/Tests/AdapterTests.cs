using DesignPatterns.AdapterPattern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class AdapterTests
    {
        [Test]
        public void Test_ListingObjects_UsingAdapter()
        {
            DataRendererAdapter adapter = new DataRendererAdapter(); // not the best usage example 
            PatternRendererClient client = new PatternRendererClient(adapter);

            List<Pattern> patterns = new List<Pattern>();
            patterns.Add(new Pattern
            {
                Id = 1,
                Name = "first"
            });

            patterns.Add(new Pattern
            {
                Id = 2,
                Name = "second"
            });

            string result = client.ListPatterns(patterns); // We want to list patterns and we use legacy adapter passed to new client

            Assert.IsNotNullOrEmpty(result); 
            Console.WriteLine(result);
        }
    }
}
