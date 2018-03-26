using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CSharpEx.Basics
{
    [TestFixture]
    public class StringOperations
    {
        [Test]
        [TestCase("Word", 1)]
        [TestCase("Double Word", 2)]
        [TestCase("Double  Word ", 2)]
        [TestCase("Triple word line", 3)]
        [TestCase("  Triple       word line", 3)]
        [TestCase("123 qwerty asdf zxcv tyugd", 5)]
        public void WordCount(string input, int expected)
        {
            // User code

            var result = 0;

            // End of user code
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(2.0, "Number: 2.00")]
        [TestCase(2.42, "Number: 2.42")]
        [TestCase(2.5678, "Number: 2.57")]
        [TestCase(123.0, "Number: 123.00")]
        [TestCase(12345.23, "Number: 12345.23")]
        [TestCase(1234.4321, "Number: 1234.43")]
        public void DoubleFormating(double input, string expected)
        {
            string result = "";

            Assert.AreEqual(expected, result);
        }


    }
}
