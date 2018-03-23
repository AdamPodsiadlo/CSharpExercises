using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharpEx.Basics.Tests
{
    [TestFixture]
    public class PropertyOperationsTests
    {
        [Test]
        [TestCase(1)]
        [TestCase(2)]
        public void Constructor(int a)
        {
            var po = new PropertyOperations(a);
            Assert.AreEqual(a, po.Value);
        }

        [Test]
        [TestCase(2, 3)]
        [TestCase(10, 11)]
        [TestCase(200, 201)]
        public void Increment(int a, int expected)
        {
            var po = new PropertyOperations(a);

            po.Increment();

            Assert.AreEqual(expected, po.Value);
        }

        [Test]
        [TestCase(2, 4)]
        [TestCase(10, 12)]
        [TestCase(200, 202)]
        public void DoubleIncrement(int a, int expected)
        {
            var po = new PropertyOperations(a);

            po.Increment();
            po.Increment();

            Assert.AreEqual(expected, po.Value);
        }

        [Test]
        [TestCase(2, 5)]
        [TestCase(10, 13)]
        [TestCase(200, 203)]
        public void TripleIncrement(int a, int expected)
        {
            var po = new PropertyOperations(a);

            po.Increment();
            po.Increment();
            po.Increment();

            Assert.AreEqual(expected, po.Value);
        }

        [Test]
        [TestCase(2, 1)]
        [TestCase(10, 9)]
        [TestCase(200, 199)]
        public void Decrement(int a, int expected)
        {
            var po = new PropertyOperations(a);

            po.Decrement();

            Assert.AreEqual(expected, po.Value);
        }

        [Test]
        [TestCase(2, 0)]
        [TestCase(10, 8)]
        [TestCase(200, 198)]
        public void DoubleDecrement(int a, int expected)
        {
            var po = new PropertyOperations(a);

            po.Decrement();
            po.Decrement();

            Assert.AreEqual(expected, po.Value);
        }

        [Test]
        [TestCase(2, -1)]
        [TestCase(10, 7)]
        [TestCase(200, 197)]
        public void TripleDecrement(int a, int expected)
        {
            var po = new PropertyOperations(a);

            po.Decrement();
            po.Decrement();
            po.Decrement();

            Assert.AreEqual(expected, po.Value);
        }

        [Test]
        [TestCase(2)]
        [TestCase(10)]
        [TestCase(200)]
        public void Clear(int a)
        {
            var po = new PropertyOperations(a);

            po.Clear();

            Assert.AreEqual(0, po.Value);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 4)]
        [TestCase(3, 9)]
        public void Square(int a, int expected)
        {
            var po = new PropertyOperations(a);

            po.Square();

            Assert.AreEqual(expected, po.Value);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 16)]
        [TestCase(3, 81)]
        public void DoubleSquare(int a, int expected)
        {
            var po = new PropertyOperations(a);

            po.Square();
            po.Square();

            Assert.AreEqual(expected, po.Value);
        }
    }
}
