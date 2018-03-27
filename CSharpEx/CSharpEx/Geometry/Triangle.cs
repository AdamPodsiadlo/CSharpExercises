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
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException();
            }

            if ((a + b) <= c || (b + c) <= a || (a + c) <= b)
            {
                throw new InvalidOperationException();
            }
        

            A = a;
            B = b;
            C = c;
        }

        public bool IsEquilateral()
        {
            if (A == B && B == C)
            {
                return true;
            }
            else
            {
                return false;

            }

        }


        public bool IsIsosceles()
        {
            if (A == B || B == C || A == C)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsRight()
        {
            double longest;
            double short1;
            double short2;

            if (C >= B && C >= A)
            {
                longest = C;
                short1 = A;
                short2 = B;
            }
            else if (A >= B && A >= C)
            {
                longest = A;
                short1 = C;
                short2 = B;

            }
            else
            {
                longest = B;
                short1 = A;
                short2 = C;
            }
       
        
          
            if (Math.Abs(longest * longest - (short1 * short1 + short2 * short2)) < 0.02)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsObtuse()
        {
            if (C * C > B * B + A * A)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsAcute()
        {
            if (C * C < B * B + A * A)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public double Area()
        {
            var P = halfPerimeter();
            double area = P * (P - A) * (P - B) * (P - C);
            area = Math.Sqrt(area);
            return area;
        }

        private double halfPerimeter()
        {
            double P = A + B + C;
            P = P / 2;
            return P;
        }

        public double InCircleRadius()
        {
            double P = halfPerimeter();
            double radius = (P - A) * (P - B) * (P - C);
            radius = radius / P;
            radius = Math.Sqrt(radius);
            return radius;
        }

        public double ExCircleRadius()
        {
            double P = halfPerimeter();
            double R = A * B * C;
            double radius = InCircleRadius();
        
            double D = radius * P;
            D = 4 * D;
            R = R / D;
        
            return R;
        }
    }
}
