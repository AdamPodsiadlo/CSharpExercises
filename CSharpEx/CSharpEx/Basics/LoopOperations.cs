using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEx.Basics
{
    public class LoopOperations
    {
        /// <summary>
        /// Sums numbers from 1 to n
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Sum(int n)
        {
            int result = 0;
            var sb = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                sb.AppendLine("=====");
                sb.AppendLine($"r {result} i {i}");
                result = result + i;
                sb.AppendLine($"r {result} i {i}");
            }

            var str = sb.ToString();
            return result;
        }

        /// <summary>
        /// Sums n numbers from <param name="start"></param>
        /// </summary>
        /// <param name="start"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Sum(int n, int start)
        {
            int result = 0;
            var sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                int nextNumber = start + i;
                result = result + nextNumber;
                Console.WriteLine(i);
            }

                var str = sb.ToString();
            return result;
        }


        /// <summary>
        /// Sums n numbers from start with step
        /// </summary>
        /// <param name="n"></param>
        /// <param name="start"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public int Sum(int n, int start, int step)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Counts event numbers between start and end.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public int CountEven(int start, int end)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// returns n!
        /// </summary>
        public int Factorial(int n)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Displays star pattern. N lines. E.g (n=3)
        /// *
        /// **
        /// ***
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string StarPattern(int n)
        {
            var sb = new StringBuilder();
            throw new NotImplementedException();
        }

        /// <summary>
        /// Displays numbers pattern. N lines. E.g (n=3)
        /// 1
        /// 12
        /// 123
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string NumberPattern(int n)
        {
            var sb = new StringBuilder();
            throw new NotImplementedException();
        }

        /// <summary>
        /// Displays star pyramid. N lines. E.g (n=3)
        ///   *
        ///  ***
        /// *****
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string StarPyramid(int n)
        {
            var sb = new StringBuilder();
            throw new NotImplementedException();
        }

        public int HighestCommonFactor(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int LeastCommonMultiple(int a, int b)
        {
            throw new NotImplementedException();
        }

    }
}
