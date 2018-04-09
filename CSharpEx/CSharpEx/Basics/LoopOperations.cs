using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

                result = result + start;
                start = start + 1;
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
            int result = 0;
            var sb = new StringBuilder();
            for (int i = 0; i < n; i++)

            {
                result = result + start;
                start = start + step;



            }

            return result;
        }

        /// <summary>
        /// Counts event numbers between start and end.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public int CountEven(int start, int end)
        {
            int result = 0;
            var sb = new StringBuilder();
            for (int i = start; i <= end; i++)

            {
                if (i % 2 == 0)
                    result = result + 1;



            }

            return result;
        }

        /// <summary>
        /// returns n!
        /// </summary>
        public int Factorial(int n)
        {
            int result = 1;

            for (int i = 2; i <= n; i++)

            {
                result = result * i;




            }

            return result;
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
            int result = 0;
            var sb = new StringBuilder();
            for (int i = 0; i < n; i++)

            {
                for (int j = 0; j < i + 1; j++)
                {
                    sb.Append("*");
                }

                sb.AppendLine();

            }

            return sb.ToString();


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
            int result = 0;
            var sb = new StringBuilder();
            for (int i = 1; i <= n; i++)

            {
                for (int j = 1; j < i + 1; j++)
                {
                    sb.Append($"{j}");
                }

                sb.AppendLine();

            }

            return sb.ToString();

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
            int result = 0;
            for (int i = 1; i <= Math.Min(a, b); i++)

            {
                if (a % i == 0 && b % i == 0)
                    result = i;
            }

            return result;


        }









        public int LeastCommonMultiple(int a, int b)

        {
            int result = 0;
            for (int i = Math.Max(a, b); i < a * b; i++)

            {
                if (i % a == 0 && i % b == 0) 
                {
                    return i;
                }
            }

            return a * b;
        }

    }
}

   





    


