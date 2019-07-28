using System;
using CustomTestingFramework.Asserts;
using CustomTestingFramework.Attributes;
using CustomTestingFramework.Exceptions;

namespace CustomTestingFramework.Tests
{
    [TestClass]
    public class MyTestClass
    {
        [TestMethod]
        public void ShouldSumValues()
        {
            int a = 2;
            int b = 3;

            int actualSum = a + b;
            int expectedSum = 3;

            Assert.AreEqual(actualSum, expectedSum);
        }

        [TestMethod]
        public void ShouldSumValues2()
        {
            int a = 2;
            int b = 3;

            int actualSum = a + b;
            int expectedSum = 5;

            Assert.AreNotEqual(actualSum, expectedSum);
        }

        [TestMethod]
        public void SholdThrowOutOfRangeExc()
        {
            int[] numbers = new int[5];

            Assert.Throws<IndexOutOfRangeException>(() => numbers[3] == 0);
        }
    }
}
