using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEx.Basics
{
    public class SimpleOperations
    {
        #region Properties
        public int A { get; set; }
        public int B { get; set; }

        #endregion

        #region Constructors
        public SimpleOperations(int a, int b)
        {
            A = a;
            B = b;

        } 
        #endregion
        #region Methods

        public int Add()
        {
            int result = A + B;
            return result;
        }

        public int Subtract()

        {
            int result = A - B;
            return result;
        }

        public int Multiply()
        {
            int result = A * B;
            return result;
        }

        public int Divide()
        {
            int result = A / B;
            return result;
        }

        /// <summary>
        /// Returns mean value of A and B
        /// </summary>
        /// <returns></returns>
        public int Mean()
        {
            int result = (A + B) / 2;
            return result;
        }

        public int Min()
        {
            if (A<B)
            {
                return A;

            }
            else
            {
                return B;
            }
         
        }

        public int Max()
        {
            if (A>B)
            {
                return A;
            }
            else
            {
                return B;
            }
       
        }
        #endregion


    }
}
