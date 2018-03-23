using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharpEx.Basics.Tests
{
    [TestFixture]
    public class SwapperTests
    {

        [Test]
        [TestCase(1, 2)]
        [TestCase(2, 1)]
        [TestCase(5, 5)]
        [TestCase(9, 1234)]
        [TestCase(0, 0)]
        [TestCase(int.MinValue, int.MaxValue)]
        public void Constructor(int a, int b)
        {
            var swapper = new Swapper(a,b);

            Assert.AreEqual(a, swapper.A);
            Assert.AreEqual(b, swapper.B);
        }

        [Test]
        [TestCase(1,2)]
        [TestCase(2,1)]
        [TestCase(5,5)]
        [TestCase(9,1234)]
        [TestCase(0,0)]
        [TestCase(int.MinValue, int.MaxValue)]
        public void Swaps(int a, int b)
        {
            var swapper = new Swapper(a,b);

            swapper.Swap();

            Assert.AreEqual(b, swapper.A);
            Assert.AreEqual(a, swapper.B);
        }
    }
}
