using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharpEx.Basics.Tests
{
    [TestFixture]
    public class SimpleOperationsTests
    {
        [Test]
        [TestCase(1, 2)]
        [TestCase(2, 1)]
        [TestCase(3, 4)]
        [TestCase(10, 20)]
        public void Constructor(int a, int b)
        {
            var so = new SimpleOperations(a,b);
            Assert.AreEqual(a, so.A);
            Assert.AreEqual(b, so.B);
        }

        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(100, 2, 102)]
        [TestCase(0, 20, 20)]
        [TestCase(5, 5, 10)]
        public void Add(int a, int b, int expectedResult)
        {
            var so = new SimpleOperations(a,b);

            var result = so.Add();

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(100, 2, 200)]
        [TestCase(0, 20, 0)]
        [TestCase(5, 5, 25)]
        public void Multiply(int a, int b, int expectedResult)
        {
            var so = new SimpleOperations(a, b);

            var result = so.Multiply();

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(1, 2, -1)]
        [TestCase(100, 2, 98)]
        [TestCase(0, 20, -20)]
        [TestCase(5, 5, 0)]
        public void Subtract(int a, int b, int expectedResult)
        {
            var so = new SimpleOperations(a, b);

            var result = so.Subtract();

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(1, 2, 0)]
        [TestCase(100, 2, 50)]
        [TestCase(0, 20, 0)]
        [TestCase(5, 5, 1)]
        [TestCase(30, 3, 10)]
        [TestCase(18, 5, 3)]
        public void Divide(int a, int b, int expectedResult)
        {
            var so = new SimpleOperations(a, b);

            var result = so.Divide();

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(1, 2, 1)]
        [TestCase(100, 2, 51)]
        [TestCase(0, 20, 10)]
        [TestCase(5, 5, 5)]
        [TestCase(30, 3, 16)]
        [TestCase(18, 5, 11)]
        public void Mean(int a, int b, int expectedResult)
        {
            var so = new SimpleOperations(a, b);

            var result = so.Mean();

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(1, 2, 1)]
        [TestCase(2, 1, 1)]
        [TestCase(3, 3, 3)]
        [TestCase(100, 2, 2)]
        [TestCase(100, 200, 100)]
        [TestCase(-1, 0, -1)]
        [TestCase(-100, -200, -200)]
        public void Min(int a, int b, int expectedResult)
        {
            var so = new SimpleOperations(a, b);

            var result = so.Min();

            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(3, 3, 3)]
        [TestCase(100, 2, 100)]
        [TestCase(100, 200, 200)]
        [TestCase(-1, 0, 0)]
        [TestCase(-100, -200, -100)]
        public void Max(int a, int b, int expectedResult)
        {
            var so = new SimpleOperations(a, b);

            var result = so.Max();

            Assert.AreEqual(expectedResult, result);
        }
    }
}
