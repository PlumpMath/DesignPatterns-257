using DesignPatterns.Classes;
using NUnit.Framework;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class SingletonTests
    {
        private Singleton _singleton; 

        [TestFixtureSetUp]
        public void SetUp()
        {
            _singleton = Singleton.Instance; 
        }

        [Test]
        public void Test_OnlyOneObjectReference_Exists()
        {
            var first = Singleton.Instance;
            var second = Singleton.Instance;

            Assert.AreSame(first, second);
        }

        [Test]
        public void Test_OnlyOneObjectReference_ExistsInAllTests_DespiteCreationMethod()
        {
            Assert.AreSame(_singleton, Singleton.Instance); 
        }

        [Test]
        public void Test_SetClassDataInSingleton_ShouldSuccess()
        {
            ConnectionData connectionData = new ConnectionData
            {
                Login = "login", 
                Password = "pass"
            };

            _singleton.ConnectionData = connectionData;

            Assert.AreEqual(connectionData, _singleton.ConnectionData);
        }

        [TestFixtureTearDown]
        public void CleanUp()
        {
            if(_singleton != null)
            {
                _singleton = null;
            }
        }
    }
}
