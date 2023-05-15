using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(3,4)]
        public void Test1()
        {
            int result = Add(3, 4);
            int expected = 7;
            Assert.AreEqual(expected, result);
            Assert.Pass();
        }


        private int Add (int a, int b)
        {
            return a + b;
        }

    }
}