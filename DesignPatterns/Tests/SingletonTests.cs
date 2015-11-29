using DesignPatterns.Classes;
using NUnit.Framework;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class SingletonTests
    {
        [Test]
        public void Test_OnlyOneObjectReference_Exists()
        {
            var first = Singleton.Instance;
            var second = Singleton.Instance;

            Assert.AreSame(first, second);
        }
    }
}
