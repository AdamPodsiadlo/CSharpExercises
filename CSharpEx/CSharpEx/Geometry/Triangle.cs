using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEx.Geometry
{
    public class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        /// <summary>
        /// Creates new triangle
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <exception cref="ArgumentException">Throws if one side is less or equal to 0.</exception>
        /// <exception cref="InvalidOperationException">Throws if edges don't form proper triangle.</exception>
        public Triangle(double a, double b, double c)
        {
            
        }

        public bool IsEquilateral()
        {
            throw new NotImplementedException();
        }

        public bool IsIsosceles()
        {
            throw new NotImplementedException();
        }

        public bool IsRight()
        {
            throw new NotImplementedException();
        }

        public bool IsObtuse()
        {
            throw new NotImplementedException();
        }

        public bool IsAcute()
        {
            throw new NotImplementedException();
        }

        public double Area()
        {
            throw new NotImplementedException();
        }

        public double InCircleRadius()
        {
            throw new NotImplementedException();
        }

        public double ExCircleRadius()
        {
            throw new NotImplementedException();
        }
    }
}
