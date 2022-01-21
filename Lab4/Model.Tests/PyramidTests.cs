using NUnit.Framework;
using System;

namespace Model.Tests
{
    public class PyramidTests
    {
        [Test]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(100)]
        [TestCase(1000)]
        [TestCase(100000)]
        public void TestSuccess(double parametr)
        {
            Assert.DoesNotThrow(() =>
            {
                new Pyramid(parametr, parametr).CalcV();
            });
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-100)]
        [TestCase(-1000)]
        [TestCase(double.MinValue)]
        public void TestFail(double parametr)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                new Pyramid(parametr, parametr).CalcV();
            });
        }
    }
}
