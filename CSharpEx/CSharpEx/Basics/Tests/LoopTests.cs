using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharpEx.Basics.Tests
{
    [TestFixture]
    public class LoopTests
    {
        public LoopOperations Loop { get; set; }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Loop = new LoopOperations();
        }

        [Test]
        [TestCase(1,1)]
        [TestCase(2, 3)]
        [TestCase(3, 6)]
        [TestCase(4, 10)]
        [TestCase(10, 55)]
        public void Sum_OneParam(int n, int expected)
        {
            var result = Loop.Sum(n);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(1,1,1)]
        [TestCase(2, 1, 3)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 10, 10)]
        [TestCase(2, 10, 22)]
        [TestCase(10, 10, 150)]
        public void Sum_TwoParams(int n, int start, int expected)
        {
            var result = Loop.Sum(n,start);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(1,1,1,1)]
        [TestCase(1, 2, 1, 2)]
        [TestCase(2, 1, 3, 1)]
        [TestCase(2, 2, 1, 5)]
        [TestCase(2, 5, 2, 12)]
        [TestCase(10, 10, 2, 200)]
        public void Sum_ThreeParames(int n, int start, int step, int expected)
        {
            var result = Loop.Sum(n, start, step);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(0,0,1)]
        [TestCase(0, 1, 1)]
        [TestCase(0, 2, 2)]
        [TestCase(1, 10, 5)]
        [TestCase(0, 9, 5)]
        public void CountEven(int start, int end, int expected)
        {
            var result = Loop.CountEven(start, end);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(0,1)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 6)]
        [TestCase(4, 24)]
        [TestCase(5, 120)]
        [TestCase(6, 720)]
        public void Factorial(int n, int expected)
        {
            var result = Loop.Factorial(n);

            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(0,"")]
        [TestCase(1, "*")]
        [TestCase
(2, 
@"*
**")]
        [TestCase
(4,
@"*
**
***
****")]
        [TestCase
(8,
@"*
**
***
****
*****
******
*******
********")]
        public void StarPatten(int n, string expected)
        {
            var result = Loop.StarPattern(n);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(0, "")]
        [TestCase(1, "1")]
        [TestCase
(2,
@"1
12")]
        [TestCase
(4,
@"1
12
123
1234")]
        [TestCase
(8,
@"1
12
123
1234
12345
123456
1234567
12345678")]
        public void NumberPatten(int n, string expected)
        {
            var result = Loop.StarPattern(n);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(0, "")]
        [TestCase(1, "*")]
        [TestCase
(2,
@" *
***")]
        [TestCase
(4,
@"   *
  *** 
 *****
*******")]
        [TestCase
(8,
@"       *
      ***
     *****
    *******
   *********
  ***********
 *************
***************")]
        public void StarPyramid(int n, string expected)
        {
            var result = Loop.StarPattern(n);


            var lines = result.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var sb =new StringBuilder();
            lines.Select(l => l.TrimEnd()).Select(l => sb.AppendLine(l));

            Assert.AreEqual(expected, sb.ToString());
        }

        [Test]
        [TestCase(1,1,1)]
        [TestCase(1,2,1)]
        [TestCase(2,5,1)]
        [TestCase(2,6,2)]
        [TestCase(4,6,2)]
        [TestCase(6,4,2)]
        [TestCase(2,10,2)]
        [TestCase(24,18,6)]
        [TestCase(18, 24, 6)]
        public void HCF(int a, int b, int expected)
        {
            var result = Loop.HighestCommonFactor(a, b);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(1,1,1)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(2, 5, 10)]
        [TestCase(4, 6, 12)]
        [TestCase(2, 10, 10)]
        [TestCase(12,8,24)]
        [TestCase(10,15,30)]
        public void LCM(int a, int b, int expected)
        {
            var result = Loop.LeastCommonMultiple(a, b);

            Assert.AreEqual(expected, result);
        }
    }
}
