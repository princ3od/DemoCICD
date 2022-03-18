using NUnit.Framework;

namespace DemoCICD.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase]
        public void Test1()
        {
            Assert.Pass();
        }

        [TestCase]
        public void Test2()
        {

            Assert.Pass();
        }
    }
}