using NUnit.Framework;
using System;

namespace Model.Tests
{
    public class SphereTests
    {
        [Test]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(100)]
        [TestCase(1000)]
        [TestCase(100000)]
        public void TestSuccess(double r)
        {
            Assert.DoesNotThrow(() =>
            {
                new Sphere(r).CalcV();
            });
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-100)]
        [TestCase(-1000)]
        [TestCase(double.MinValue)]
        public void TestFail(double r)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                new Sphere(r).CalcV();
            });
        }
    }
}