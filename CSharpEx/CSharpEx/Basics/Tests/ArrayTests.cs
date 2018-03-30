using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace CSharpEx.Basics.Tests
{
    [TestFixture]
    public class ArrayTests
    {
        [Test]
        [TestCase(new[]
        {
            1, 2, 3, 4
        }, "1 2 3 4")]
        [TestCase(new[]
        {
            3, 3, 3, 3
        }, "3 3 3 3")]
        [TestCase(new[]
        {
            2, 1, 2, 1
        }, "2 1 2 1")]
        [TestCase(new[]
        {
            2, 1, 2
        }, "2 1 2")]
        public void Print(int[] array, string expected)
        {
            var ao = new ArrayOperations(array);

            string print = ao.Print();

            Assert.AreEqual(expected, print);
        }

        [Test]
        [TestCase(new[]
        {
            1, 2, 3
        }, 1)]
        [TestCase(new[]
        {
            3, 1, 2
        }, 1)]
        [TestCase(new[]
        {
            3, 2, 1
        }, 1)]
        [TestCase(new[] {1,1,2},1)]
        [TestCase(new[] { 1, 1, 1 }, 1)]
        public void Min(int[] array, int minExpected)
        {
            var ao = new ArrayOperations(array);

            int min = ao.Min();

            Assert.AreEqual(minExpected, min);
        }

        [Test]
        [TestCase(new[]
        {
            1, 2, 3
        }, 3)]
        [TestCase(new[]
        {
            3, 1, 2
        },3)]
        [TestCase(new[]
        {
            3, 2, 1
        }, 3)]
        [TestCase(new[] { 1, 1, 2 }, 2)]
        [TestCase(new[] { 1, 1, 1 }, 1)]
        public void Max(int[] array, int maxExpected)
        {
            var ao = new ArrayOperations(array);

            int min = ao.Max();

            Assert.AreEqual(maxExpected, min);
        }

        [Test]
        [TestCase(new[]
        {
            1, 2
        }, new[]
        {
            2, 1
        })]
        [TestCase(new[]
        {
            2, 2
        }, new[]
        {
            2, 2
        })]
        [TestCase(new[]
        {
            2, 1
        }, new[]
        {
            1, 2
        })]
        [TestCase(new[]
        {
            1, 2, 3
        }, new[]
        {
            3, 2, 1
        })]
        [TestCase(new[]
        {
            3, 2, 1
        }, new[]
        {
            3, 2, 1
        })]
        public void Reverse(int[] array, int[] expected)
        {
            var ao = new ArrayOperations(array);

            var reversed = ao.Reversed();

            CollectionAssert.AreEqual(expected, reversed);
        }

        [Test]
        [TestCase(new[]
        {
            1, 1
        }, 0)]
        [TestCase(new[]
        {
            1, 2
        }, 1)]
        [TestCase(new[]
        {
            2, 2
        }, 2)]
        [TestCase(new[]
        {
            1, 2, 3
        }, 1)]
        [TestCase(new[]
        {
            1, 2, 3, 4
        }, 2)]
        [TestCase(new[]
        {
            2, 4, 6
        }, 3)]
        public void CountEven(int[] array, int expected)
        {
            var ao = new ArrayOperations(array);

            var even = ao.EvenCount();

            Assert.AreEqual(expected, even);
        }

        [Test]
        [TestCase(new[]
        {
            0, 1
        }, 1, new[]
        {
            1, 2
        })]
        [TestCase(new[]
        {
            0, 1
        }, 0, new[]
        {
            0, 1
        })]
        [TestCase(new[]
        {
            2, 3
        }, 1, new[]
        {
            3, 4
        })]
        [TestCase(new[]
        {
            0, 1
        }, 5, new[]
        {
            5, 6
        })]
        [TestCase(new[]
        {
            2, 3
        }, 9, new[]
        {
            11, 12
        })]
        [TestCase(new[]
        {
            5, 10
        }, 2, new[]
        {
            7, 12
        })]
        public void Add(int[] array, int add, int[] expected)
        {
            var ao = new ArrayOperations(array);

            var result = ao.Add(add);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(new[] { 1, 1, 1}, 3)]
        [TestCase(new[] { 1, 2, 3 }, 6)]
        [TestCase(new[] { 0, 0, 0 }, 0)]
        [TestCase(new[] { 10, 5, 1 }, 16)]
        [TestCase(new[] { 0, 1, 0 }, 1)]
        public void SumAll(int[] array, int expected)
        {
            var ao = new ArrayOperations(array);

            var sum = ao.Sum();

            Assert.AreEqual(expected, sum);
        }

    }
}
