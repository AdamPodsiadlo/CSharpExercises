using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace CSharpEx.Geometry.Tests
{
    [TestFixture]
    public class TrinagleTests
    {

        private const double Delta = 0.01;

        [Test]
        [TestCase(1,1,1)]
        [TestCase(1,2,2)]
        [TestCase(2,2,1)]
        [TestCase(200,201,199)]
        [TestCase(2.4, 2.5, 2.6)]
        public void Constructor(double a, double b, double c)
        {
            var tri = new Triangle(a,b,c);

            Assert.AreEqual(a, tri.A, Delta);
            Assert.AreEqual(b, tri.B, Delta);
            Assert.AreEqual(c, tri.C, Delta);
        }

        [Test]
        [TestCase(0, 1, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(2, 2, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        [TestCase(-1, -1, -1)]
        public void Constructor_Throws_ArgumentException(double a, double b, double c)
        {
            Triangle tri;
            Assert.Throws<ArgumentException>(()=> tri = new Triangle(a, b, c));
        }

        [Test]
        [TestCase(3, 1, 1)]
        [TestCase(1,3, 1)]
        [TestCase(3, 3, 1)]
        public void Constructor_Throws_InvalidOperationException(double a, double b, double c)
        {
            Triangle tri;
            Assert.Throws<InvalidOperationException>(() => tri = new Triangle(a, b, c));
        }

        [Test]
        [TestCase(1, 1, 1)]
        [TestCase(4, 4, 4)]
        public void IsEquilateral_True(double a, double b, double c)
        {
            var tri = new Triangle(a,b,c);

            bool isEquilateral = tri.IsEquilateral();

            Assert.IsTrue(isEquilateral);
        }

        [Test]
        [TestCase(1, 3, 3)]
        [TestCase(2, 3, 4)]
        [TestCase(0.4, 0.5, 0.6)]
        public void IsEquilateral_False(double a, double b, double c)
        {
            var tri = new Triangle(a, b, c);

            bool isEquilateral = tri.IsEquilateral();

            Assert.IsFalse(isEquilateral);
        }

        [Test]
        [TestCase(1, 1, 1)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(2, 2, 1)]
        [TestCase(0.5, 0.5, 0.6)]
        public void IsIsosceles_True(double a, double b, double c)
        {
            var tri = new Triangle(a,b,c);

            var result = tri.IsIsosceles();

            Assert.IsTrue(result);
        }

        [Test]
        [TestCase(3, 4, 5)]
        [TestCase(1.1, 1.2, 1.3)]
        public void IsIsosceles_False(double a, double b, double c)
        {
            var tri = new Triangle(a, b, c);

            var result = tri.IsIsosceles();

            Assert.IsFalse(result);
        }


        [Test]
        [TestCase(3, 4, 5)]
        [TestCase(6, 8, 10)]
        [TestCase(1, 1, 1.41)]
        [TestCase(1, 2, 1.73)]
        public void IsRight_True(double a, double b, double c)
        {
            var tri = new Triangle(a, b, c);

            var result = tri.IsRight();

            Assert.IsTrue(result);
        }

        [Test]
        [TestCase(1, 1, 1)]
        [TestCase(6, 8, 8)]
        [TestCase(1, 1, 1.3)]
        [TestCase(1, 2, 1.9)]
        public void IsRight_False(double a, double b, double c)
        {
            var tri = new Triangle(a, b, c);

            var result = tri.IsRight();

            Assert.IsFalse(result);
        }

        [Test]
        [TestCase(2, 2, 3.46)]
        [TestCase(3, 8, 10.7)]
        public void IsObtuse_True(double a, double b, double c)
        {
            var tri = new Triangle(a, b, c);

            var result = tri.IsObtuse();

            Assert.IsTrue(result);
        }

        [Test]
        [TestCase(1, 1, 1)]
        [TestCase(3, 4, 5)]
        [TestCase(4, 5, 6)]
        public void IsObtuse_False(double a, double b, double c)
        {
            var tri = new Triangle(a, b, c);

            var result = tri.IsObtuse();

            Assert.IsFalse(result);
        }

        [Test]
        [TestCase(4, 4, 4)]
        [TestCase(4, 5, 6)]
        public void IsAcute_True(double a, double b, double c)
        {
            var tri = new Triangle(a, b, c);

            var result = tri.IsAcute();

            Assert.IsTrue(result);
        }

        [Test]
        [TestCase(2, 2, 3.46)]
        [TestCase(3, 8, 10.7)]
        [TestCase(3, 4, 5)]
        public void IsAcute_False(double a, double b, double c)
        {
            var tri = new Triangle(a, b, c);

            var result = tri.IsAcute();

            Assert.IsFalse(result);
        }

        [Test]
        [TestCase(3,4,5, 6)]
        [TestCase(2,2,2, 1.73)]
        [TestCase(6,6,3, 8.71)]
        public void Area(double a, double b, double c, double area)
        {
            var tri = new Triangle(a, b, c);

            var result = tri.Area();

            Assert.AreEqual(area, result, Delta);
        }

        [Test]
        [TestCase(3, 4, 5, 1)]
        [TestCase(2, 2, 2, 0.57)]
        [TestCase(6, 6, 3, 1.16)]
        public void InCircleRadius(double a, double b, double c, double radius)
        {
            var tri = new Triangle(a, b, c);

            var result = tri.InCircleRadius();

            Assert.AreEqual(radius, result, Delta);
        }

        [Test]
        [TestCase(3, 4, 5, 2.5)]
        [TestCase(2, 2, 2, 1.73)]
        [TestCase(6, 6, 3, 1.55)]
        public void ExCircleRadius(double a, double b, double c, double radius)
        {
            var tri = new Triangle(a, b, c);

            var result = tri.ExCircleRadius();

            Assert.AreEqual(radius, result, Delta);
        }
    }
}
