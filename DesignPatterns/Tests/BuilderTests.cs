using DesignPatterns.BuilderPattern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class BuilderTests
    {
        [Test]
        public void Test_UseBuilderPatternExample()
        {
            SandwichBuilder builder = new MyFavoriteSandwichBuilder();
            SandwichMaker maker = new SandwichMaker(builder);

            maker.BuildSandwich();
            var sandwich = maker.GetSandwich();

            Assert.IsNotNull(sandwich);
            Assert.IsNotEmpty(sandwich.Vegatables); // MyFavoriteSandwichBuilder has two vegetables added
            Assert.AreEqual(2, sandwich.Vegatables.Count);
        }
    }
}
