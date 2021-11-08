using NUnit.Framework;

namespace UnitTest
{
    using GitHubActionsTest.Models;
    public class UnitTest1
    {
        Calculator calculator;
        [SetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }

        [TestCase(0, 0, 0)]
        [TestCase(1, 3, 4)]
        [TestCase(3, 43, 46)]
        [TestCase(53, 4, 57)]
        [TestCase(6432, 322, 6754)]
        [TestCase(32, 5454, 5486)]
        [TestCase(95, 930, 1025)]
        public void AddTest(int a, int b, int res)
        {
            int val = calculator.Add(a, b);
            Assert.AreEqual(res, val);
        }
    }
}
